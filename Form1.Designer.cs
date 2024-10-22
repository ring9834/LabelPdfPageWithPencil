namespace AddMyPageLabels
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.NumRight = new System.Windows.Forms.NumericUpDown();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.NumStart = new System.Windows.Forms.NumericUpDown();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.RdSaveCover = new System.Windows.Forms.RadioButton();
            this.RdSavePickedPath = new System.Windows.Forms.RadioButton();
            this.RdSaveDefault = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.NumTop = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RdAj = new System.Windows.Forms.RadioButton();
            this.RdJh = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumRight)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumStart)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumTop)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textEdit1
            // 
            this.textEdit1.EditValue = "";
            this.textEdit1.Location = new System.Drawing.Point(32, 34);
            this.textEdit1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textEdit1.Name = "textEdit1";
            // 
            // 
            // 
            this.textEdit1.Properties.NullValuePrompt = "点击选择存放PDF的路径";
            this.textEdit1.Properties.ReadOnly = true;
            this.textEdit1.Size = new System.Drawing.Size(670, 28);
            this.textEdit1.TabIndex = 0;
            this.textEdit1.Click += new System.EventHandler(this.textEdit1_Click);
            // 
            // textEdit2
            // 
            this.textEdit2.EditValue = "";
            this.textEdit2.Location = new System.Drawing.Point(126, 68);
            this.textEdit2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textEdit2.Name = "textEdit2";
            // 
            // 
            // 
            this.textEdit2.Properties.NullValuePrompt = "点击选择加完页码后PDF的保存路径";
            this.textEdit2.Properties.ReadOnly = true;
            this.textEdit2.Size = new System.Drawing.Size(576, 28);
            this.textEdit2.TabIndex = 1;
            this.textEdit2.Click += new System.EventHandler(this.textEdit2_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(18, 40);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(212, 22);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "距右上角(像素)：顶部距离";
            // 
            // NumRight
            // 
            this.NumRight.Location = new System.Drawing.Point(424, 36);
            this.NumRight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NumRight.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.NumRight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumRight.Name = "NumRight";
            this.NumRight.Size = new System.Drawing.Size(92, 28);
            this.NumRight.TabIndex = 6;
            this.NumRight.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(348, 39);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(72, 22);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "右边距离";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox7);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(36, 30);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(736, 712);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "设置";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.NumStart);
            this.groupBox7.Controls.Add(this.labelControl3);
            this.groupBox7.Location = new System.Drawing.Point(14, 582);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox7.Size = new System.Drawing.Size(711, 100);
            this.groupBox7.TabIndex = 17;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "5.确定从PDF第几页开始加页码";
            // 
            // NumStart
            // 
            this.NumStart.Location = new System.Drawing.Point(60, 39);
            this.NumStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NumStart.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NumStart.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumStart.Name = "NumStart";
            this.NumStart.Size = new System.Drawing.Size(92, 28);
            this.NumStart.TabIndex = 8;
            this.NumStart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(20, 44);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(228, 22);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "从第                 开始加页码";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.RdSaveCover);
            this.groupBox5.Controls.Add(this.RdSavePickedPath);
            this.groupBox5.Controls.Add(this.RdSaveDefault);
            this.groupBox5.Controls.Add(this.textEdit2);
            this.groupBox5.Location = new System.Drawing.Point(14, 303);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Size = new System.Drawing.Size(711, 153);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "3.确认保存路径";
            // 
            // RdSaveCover
            // 
            this.RdSaveCover.AutoSize = true;
            this.RdSaveCover.Checked = true;
            this.RdSaveCover.Location = new System.Drawing.Point(18, 110);
            this.RdSaveCover.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RdSaveCover.Name = "RdSaveCover";
            this.RdSaveCover.Size = new System.Drawing.Size(186, 22);
            this.RdSaveCover.TabIndex = 13;
            this.RdSaveCover.TabStop = true;
            this.RdSaveCover.Text = "覆盖原来的PDF文件";
            this.RdSaveCover.UseVisualStyleBackColor = true;
            // 
            // RdSavePickedPath
            // 
            this.RdSavePickedPath.AutoSize = true;
            this.RdSavePickedPath.Location = new System.Drawing.Point(18, 72);
            this.RdSavePickedPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RdSavePickedPath.Name = "RdSavePickedPath";
            this.RdSavePickedPath.Size = new System.Drawing.Size(105, 22);
            this.RdSavePickedPath.TabIndex = 12;
            this.RdSavePickedPath.Text = "自选路径";
            this.RdSavePickedPath.UseVisualStyleBackColor = true;
            // 
            // RdSaveDefault
            // 
            this.RdSaveDefault.AutoSize = true;
            this.RdSaveDefault.Location = new System.Drawing.Point(18, 33);
            this.RdSaveDefault.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RdSaveDefault.Name = "RdSaveDefault";
            this.RdSaveDefault.Size = new System.Drawing.Size(492, 22);
            this.RdSaveDefault.TabIndex = 11;
            this.RdSaveDefault.Text = "保存在原来PDF所在路径下“PageLabelAdded”的文件夹内";
            this.RdSaveDefault.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.NumRight);
            this.groupBox6.Controls.Add(this.labelControl1);
            this.groupBox6.Controls.Add(this.labelControl2);
            this.groupBox6.Controls.Add(this.NumTop);
            this.groupBox6.Location = new System.Drawing.Point(14, 470);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Size = new System.Drawing.Size(711, 96);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "4.确定页码位置";
            // 
            // NumTop
            // 
            this.NumTop.Location = new System.Drawing.Point(237, 36);
            this.NumTop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NumTop.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.NumTop.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumTop.Name = "NumTop";
            this.NumTop.Size = new System.Drawing.Size(92, 28);
            this.NumTop.TabIndex = 4;
            this.NumTop.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labelControl5);
            this.groupBox4.Controls.Add(this.textEdit1);
            this.groupBox4.Location = new System.Drawing.Point(14, 177);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(711, 111);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "2.选择源PDF所在路径";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(18, 66);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(468, 22);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "（注意：如果是卷内档案，请选择包含整卷档案的文件夹）";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RdAj);
            this.groupBox3.Controls.Add(this.RdJh);
            this.groupBox3.Location = new System.Drawing.Point(14, 36);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(711, 128);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "1.选择档案类型";
            // 
            // RdAj
            // 
            this.RdAj.AutoSize = true;
            this.RdAj.Location = new System.Drawing.Point(18, 76);
            this.RdAj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RdAj.Name = "RdAj";
            this.RdAj.Size = new System.Drawing.Size(393, 22);
            this.RdAj.TabIndex = 12;
            this.RdAj.Text = "案卷级（仅支持单卷，不支持多卷同时编页）";
            this.RdAj.UseVisualStyleBackColor = true;
            // 
            // RdJh
            // 
            this.RdJh.AutoSize = true;
            this.RdJh.Checked = true;
            this.RdJh.Location = new System.Drawing.Point(18, 38);
            this.RdJh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RdJh.Name = "RdJh";
            this.RdJh.Size = new System.Drawing.Size(546, 22);
            this.RdJh.TabIndex = 11;
            this.RdJh.TabStop = true;
            this.RdJh.Text = "件盒级（支持大批量编页，所选文件夹下的PDF都将从开始编页）";
            this.RdJh.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Location = new System.Drawing.Point(788, 30);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(807, 808);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "执行结果";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(22, 30);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(763, 754);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(291, 770);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(178, 46);
            this.simpleButton1.TabIndex = 9;
            this.simpleButton1.Text = "开始执行";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1622, 856);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDF页码生成 - 铅笔字样";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumRight)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumStart)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumTop)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit textEdit1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.NumericUpDown NumRight;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.NumericUpDown NumStart;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.NumericUpDown NumTop;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.RadioButton RdAj;
        private System.Windows.Forms.RadioButton RdJh;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RadioButton RdSaveDefault;
        private System.Windows.Forms.RadioButton RdSavePickedPath;
        private System.Windows.Forms.RadioButton RdSaveCover;
    }
}

