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
    public partial class frmPicViewer : Form
    {
        public object PictureBox1 { get; private set; }

        public frmPicViewer()
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
          
            for (int i = 0; i < files.Length; i++)
            {
                PictureBox pictureBox_i = new PictureBox();
                pictureBox_i.Image = Image.FromFile($"images\\{files[i].Name}");
                pictureBox_i.Location = new Point(50+ 220 *( i%4), 50+170*(i/4));
                pictureBox_i.Size = new Size(200, 150);
                pictureBox_i.TabIndex = i;
                pictureBox_i.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox_i.Name = "images\\"+files[i].Name;
                this.Controls.Add(pictureBox_i);
                pictureBox_i.Click += new EventHandler(pictureBox1_Click);

            }

         }
            

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PicShow ps= new PicShow();
            PictureBox pic=(PictureBox)sender;
            ps.BackgroundImage= Image.FromFile(pic.Name);                     
            ps.Show();
        }
    }
}
