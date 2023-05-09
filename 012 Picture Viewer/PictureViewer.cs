using _012_Picture_Viewer.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
          
            
            foreach(Object file in files)
            {
                filename = file.ToString();
                for (int i=0; i<files.Length; i++) {
                PictureBox[] pictureBox = new PictureBox[files.Length];
                pictureBox[i].Image = Image.FromFile($"images\\{filename}");
                pictureBox[i].SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox[i].BackColor = Color.Red;
                pictureBox[i].Location = new Point(10 + 50*i, 45);
                pictureBox[i].Name = $"pic_{filename}";
                pictureBox[i].Size = new System.Drawing.Size(200, 150);
                pictureBox[i].TabIndex = i;
                    pictureBox.TabStop = true;
                    this.Controls.Add(pictureBox[i]);
                 }

            }

            
        }

        public string filename;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //filename = "C:\\C\\CHomework\\Homework\\012 Picture Viewer\\bin\\Debug\\cat.jpg";            
            //PicShow ps= new PicShow();
            //ps.Show();
        }
    }
}
