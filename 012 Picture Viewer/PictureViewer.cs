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
        
        
       FileInfo[] files;

        private void PictureViewer_Load(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo("\\images");
            files = dir.GetFiles();
            foreach(object file in files)
            {
                filename = file.ToString();
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = new Bitmap();
                
            }
        }

        public string filename;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            filename = "C:\\C\\CHomework\\Homework\\012 Picture Viewer\\bin\\Debug\\cat.jpg";            
            PicShow ps= new PicShow();
            ps.Show();
        }
    }
}
