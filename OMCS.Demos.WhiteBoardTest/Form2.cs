using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OMCS.Demos.WhiteBoardTest
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pdf2ImageConverter wi = new Pdf2ImageConverter();
            wi.ConvertToImage(@"D:\图片\2010xrss (1).pdf", @"D:\图片");
        }
    }
}
