using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddMyPageLabels
{
    public class InputArguments
    {
        public string SourcePath { get; set; }

        public string OutputPdfPath { get; set; }

        public int PageStart { get; set; }

        public int MarginRight { get; set; }

        public int MarginTop { get; set; }
    }

    public class OutMessage
    {
        public string Message { get; set; }
    }
}
