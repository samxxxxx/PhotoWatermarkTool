using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoWatermarkTool.UserControls
{
    public partial class ucExif : UserControl
    {
        public string Caption { get; set; }
        public string Value { get; set; }
        public string FileName { get; set; }

        public ucExif()
        {
            InitializeComponent();
        }

        public ucExif(string caption, string value, string fileName) : this()
        {
            this.Caption = caption;
            this.Value = value;
            this.FileName = fileName;

            this.txtValue.Text = value;
            this.lblCaption.Text = caption;
        }
    }
}
