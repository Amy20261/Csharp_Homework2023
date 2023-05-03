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

namespace _012_Picture_Viewer
{
    public partial class PictureViewer : Form
    {
        public PictureViewer()
        {
            InitializeComponent();
        }

        private void pic_Click(object sender, EventArgs e)
        {

        }
        Object imgLocation;
        private void PictureViewer_Load(object sender, EventArgs e)
        {
            
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            imgLocation = pictureBox1.BackgroundImageLayout;
            PicShow ps= new PicShow();
            ps.Show();
        }
    }
}
