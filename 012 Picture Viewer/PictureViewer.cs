using _012_Picture_Viewer.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
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
        
    

        private void PictureViewer_Load(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo("images\\");
            FileInfo[] files = dir.GetFiles();
            int num=files.Length;
           
            foreach(FileInfo file in files)
            {
                String filename=file.Name;
                //MessageBox.Show(file.Name);
                int i;
                i = 0;
                PictureBox[] pictureBox = new PictureBox[num];
                pictureBox[i] = new PictureBox();
                pictureBox[i].Image = Image.FromFile($"images\\{filename}");
                pictureBox[i].SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox[i].Location = new Point(10 + 300 * i, 45);
                pictureBox[i].Size = new System.Drawing.Size(200, 150);
                pictureBox[i].Name = filename;
                this.Controls.Add(pictureBox[i]);
                i++;

            }

         }
            

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //filename = "C:\\C\\CHomework\\Homework\\012 Picture Viewer\\bin\\Debug\\cat.jpg";            
            //PicShow ps= new PicShow();
            //ps.Show();
        }
    }
}
