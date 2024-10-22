using iText.IO.Image;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas;
using iText.Kernel.Pdf.Extgstate;
using iText.Layout;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddMyPageLabels
{
    public partial class Form1 : Form
    {
        private bool isExecuting = false;
        private BackgroundWorker AddPageLabelWorker = new BackgroundWorker();
        public Form1()
        {
            InitializeComponent();
            AddPageLabelWorker.DoWork += AddPageLabelWorker_DoWork;
            AddPageLabelWorker.WorkerReportsProgress = true;
            AddPageLabelWorker.ProgressChanged += AddPageLabelWorker_ProgressChanged;
        }

        private void AddPageLabelWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            InputArguments ia = (InputArguments)e.Argument;
            WaterMarkPdfs(ia.SourcePath, ia.OutputPdfPath, ia.PageStart, ia.MarginRight, ia.MarginTop, worker);
        }

        private void AddPageLabelWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            string message = e.UserState.ToString();
            this.richTextBox1.Text += message;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.textEdit1.Text))
            {
                MessageBox.Show("请选择档案PDF文件所在路径后继续！", "确认", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            isExecuting = true;//任务执行
            string selfPath = "";
            if (this.RdSavePickedPath.Checked)
            {
                selfPath = this.textEdit2.Text;
            }
            int marginTop = int.Parse(this.NumTop.Value.ToString());
            int marginRight = int.Parse(this.NumRight.Value.ToString());
            int pageStart = int.Parse(this.NumStart.Value.ToString());
            string sourcePath = this.textEdit1.Text;

            InputArguments ia = new InputArguments();
            ia.SourcePath = sourcePath;
            ia.OutputPdfPath = selfPath;
            ia.MarginRight = marginRight;
            ia.MarginTop = marginTop;
            ia.PageStart = pageStart;
            AddPageLabelWorker.RunWorkerAsync(ia);
        }

        private void WaterMarkPdfs(string sourcePdfPath, string outputPdfPath, int startPage, int gapx, int gapy, BackgroundWorker worker)
        {
            DirectoryInfo di = new DirectoryInfo(sourcePdfPath);
            DirectoryInfo[] diA = di.GetDirectories();
            FileInfo[] files = GetFileInfoArrayByDirectory(di);//get the pdf files
            string message;

            if (this.RdAj.Checked) //卷内级
            {
                int allPageCount = 0;
                for (int j = 0; j < files.Length; j++)
                {
                    FileInfo fi = files[j];
                    string pdf = fi.FullName;

                    string tempDir = fi.DirectoryName + "\\temp";
                    string pdfTemp = tempDir + "\\" + fi.Name;
                    if (this.RdSaveCover.Checked)
                    {
                        if (!Directory.Exists(tempDir))
                            Directory.CreateDirectory(tempDir);
                    }

                    string aimedSavePath;
                    if (string.IsNullOrEmpty(outputPdfPath)) // use the picked path
                    {
                        if (this.RdSaveCover.Checked)
                            aimedSavePath = pdfTemp;//cover the original one when saving
                        else
                        {
                            string drc = fi.DirectoryName + "\\PageLabelAdded\\";
                            if (!Directory.Exists(drc))
                                Directory.CreateDirectory(drc);
                            string savedPdf = drc + fi.Name;
                            aimedSavePath = savedPdf;
                        }
                    }
                    else
                        aimedSavePath = outputPdfPath + "\\" + fi.Name;

                    message = "正在执行编页操作...针对文件" + fi.Name + "\r\n";
                    worker.ReportProgress(j, message);// transfer info to UI
                    int pages;
                    SetWatermarkForAj(pdf, aimedSavePath, startPage, gapx, gapy, allPageCount, out pages);
                    allPageCount += pages;
                    if (this.RdSaveCover.Checked)
                    {
                        File.Delete(pdf);
                        File.Move(pdfTemp, pdf);
                        Directory.Delete(tempDir);
                    }
                    message = fi.Name + "编页操作执行完毕！\r\n";
                    worker.ReportProgress(j, message);// transfer info to UI
                }
            }
            else //件盒级
            {
                for (int i = 0; i < diA.Length; i++) //recursive algorithm
                {
                    string subFolder = diA[i].FullName;
                    if (!subFolder.Contains("PageLabelAdded")) // execution can not be on the pdfs in PageLabelAdded
                    {
                        WaterMarkPdfs(diA[i].FullName, outputPdfPath, startPage, gapx, gapy, worker);
                    }
                }

                for (int j = 0; j < files.Length; j++)
                {
                    FileInfo fi = files[j];
                    string pdf = fi.FullName;

                    string tempDir = fi.DirectoryName + "\\temp";
                    string pdfTemp = tempDir + "\\" + fi.Name;
                    if (this.RdSaveCover.Checked)
                    {
                        if (!Directory.Exists(tempDir))
                            Directory.CreateDirectory(tempDir);
                    }

                    string aimedSavePath;
                    if (string.IsNullOrEmpty(outputPdfPath)) // use the picked path
                    {
                        if (this.RdSaveCover.Checked)
                            aimedSavePath = pdfTemp;//cover the original one when saving
                        else
                        {
                            string drc = fi.DirectoryName + "\\PageLabelAdded\\";
                            if (!Directory.Exists(drc))
                                Directory.CreateDirectory(drc);
                            string savedPdf = drc + fi.Name;
                            aimedSavePath = savedPdf;
                        }
                    }
                    else
                        aimedSavePath = outputPdfPath + "\\" + fi.Name;

                    message = "正在执行编页操作...针对文件" + fi.Name + "\r\n";
                    worker.ReportProgress(j, message);// transfer info to UI
                    SetWatermarkForJh(pdf, aimedSavePath, startPage, gapx, gapy);
                    if (this.RdSaveCover.Checked)
                    {
                        File.Delete(pdf);
                        File.Move(pdfTemp, pdf);
                        Directory.Delete(tempDir);
                    }
                    message += fi.Name + "编页操作执行完毕！\r\n";
                    worker.ReportProgress(j, message);// transfer info to UI
                }
            }
        }

        /// <summary>
        /// 取得某路径下所有的PDF信息
        /// </summary>
        /// <param name="di"></param>
        /// <returns></returns>
        private FileInfo[] GetFileInfoArrayByDirectory(DirectoryInfo di)
        {
            List<string> list = new List<string>();
            list.Add("*.pdf");

            List<FileInfo> fileInfoList = new List<FileInfo>();
            for (int u = 0; u < list.Count; u++)
            {
                FileInfo[] fin = di.GetFiles(list[u], SearchOption.TopDirectoryOnly);
                fileInfoList.AddRange(fin);
            }
            FileInfo[] files = fileInfoList.ToArray();
            return files;
        }

        private void SetWatermarkForAj(string sourcePdfPath, string outputPdfPath, int startPage, int gapx, int gapy, int previousPages, out int pages)
        {
            PdfDocument pdfDoc = new PdfDocument(new PdfReader(sourcePdfPath), new PdfWriter(outputPdfPath));
            PdfCanvas over;
            PdfExtGState gs1 = new PdfExtGState();
            //gs1.SetFillOpacity(0.6f);
            int n = pdfDoc.GetNumberOfPages();
            pages = n;
            iText.Kernel.Geom.Rectangle pagesize;
            float x, y;
            string basePath = Application.StartupPath;

            int forLoopStart;
            if (previousPages == 0)
                forLoopStart = startPage;
            else // the pdfs from second onwards will be added the PAGELABEL from the first page rather than the 2nd page
                forLoopStart = 1;

            for (int i = forLoopStart; i <= n; i++)
            {
                PdfPage pdfPage = pdfDoc.GetPage(i);
                pagesize = pdfDoc.GetPage(i).GetPageSize();
                pdfPage.SetIgnorePageRotationForContent(true);

                //x = (pagesize.GetLeft() + pagesize.GetRight()) / 2;
                //y = (pagesize.GetTop() + pagesize.GetBottom()) / 2;

                string waterPath = basePath + "\\PagePng\\" + (previousPages - startPage + i + 1).ToString() + ".png";
                if (!File.Exists(waterPath))
                {
                    MessageBox.Show("页码（铅笔）文件有误，请联系管理员！", "确认", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var image = Image.FromFile(waterPath);
                ImageData img = ImageDataFactory.Create(image, null);
                float w = img.GetWidth();
                float h = img.GetHeight();
                float scaleW = w / 4;
                float scaleH = h / 4;

                x = pagesize.GetRight() - gapx;
                y = pagesize.GetTop() - gapy;


                over = new PdfCanvas(pdfDoc.GetPage(i));
                over.SaveState();
                over.SetExtGState(gs1);

                //over.AddImageWithTransformationMatrix(img, w, 0, 0,h, x - (w / 2), y - (h / 2), true);
                over.AddImageWithTransformationMatrix(img, scaleW, 0, 0, scaleH, x, y, true);
                over.RestoreState();
            }
            pdfDoc.Close();
        }

        private void SetWatermarkForJh(string sourcePdfPath, string outputPdfPath, int startPage, int gapx, int gapy)
        {
            PdfDocument pdfDoc = new PdfDocument(new PdfReader(sourcePdfPath), new PdfWriter(outputPdfPath));
            PdfCanvas over;
            PdfExtGState gs1 = new PdfExtGState();
            //gs1.SetFillOpacity(0.6f);
            int n = pdfDoc.GetNumberOfPages();
            iText.Kernel.Geom.Rectangle pagesize;
            float x, y;
            string basePath = Application.StartupPath;

            for (int i = startPage; i <= n; i++)
            {
                PdfPage pdfPage = pdfDoc.GetPage(i);
                pagesize = pdfDoc.GetPage(i).GetPageSize();
                pdfPage.SetIgnorePageRotationForContent(true);

                //x = (pagesize.GetLeft() + pagesize.GetRight()) / 2;
                //y = (pagesize.GetTop() + pagesize.GetBottom()) / 2;

                string waterPath = basePath + "\\PagePng\\" + i.ToString() + ".png";
                if (!File.Exists(waterPath))
                {
                    MessageBox.Show("页码（铅笔）文件有误，请联系管理员！", "确认", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var image = Image.FromFile(waterPath);
                ImageData img = ImageDataFactory.Create(image, null);
                float w = img.GetWidth();
                float h = img.GetHeight();
                float scaleW = w / 4;
                float scaleH = h / 4;

                x = pagesize.GetRight() - gapx;
                y = pagesize.GetTop() - gapy;


                over = new PdfCanvas(pdfDoc.GetPage(i));
                over.SaveState();
                over.SetExtGState(gs1);

                //over.AddImageWithTransformationMatrix(img, w, 0, 0,h, x - (w / 2), y - (h / 2), true);
                over.AddImageWithTransformationMatrix(img, scaleW, 0, 0, scaleH, x, y, true);
                over.RestoreState();
            }
            pdfDoc.Close();
        }

        private void textEdit1_Click(object sender, EventArgs e)
        {
            if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.textEdit1.Text = this.folderBrowserDialog1.SelectedPath;
            }
        }

        private void textEdit2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定保存到自选路径吗？", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (!this.RdSavePickedPath.Checked)
                    this.RdSavePickedPath.Checked = true;
                if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    this.textEdit2.Text = this.folderBrowserDialog1.SelectedPath;
                }
                else
                {
                    this.RdSavePickedPath.Checked = false;
                }
            }
            else
            {
                this.RdSavePickedPath.Checked = false;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
