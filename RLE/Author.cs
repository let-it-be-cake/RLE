using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using RLE.Properties;

namespace Стеганография
{
    public partial class Author : Form
    {
        public Author()
        {
            InitializeComponent();
            var img = Resources.backgroundAuthor;
            this.BackgroundImage = new Bitmap(img);
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("http://f0169098.xsph.ru/");
        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel2.LinkVisited = true;
            System.Diagnostics.Process.Start("http://catstail.narod.ru/");
        }
    }
}
