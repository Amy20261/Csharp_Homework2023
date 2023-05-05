using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _012_Picture_Viewer
{
    public partial class PicShow : Form
    {
        public PicShow()
        {
            InitializeComponent();
        }

        private void PicShow_Load(object sender, EventArgs e)
        {
            //PictureBox.image = null;
            PictureViewer pv= new PictureViewer();
            //string name = pv.filename;
            picDisplay.SizeMode = PictureBoxSizeMode.AutoSize;
            string name = "images\\cat.jpg";
            picDisplay.Image = Image.FromFile(name);
            
        }

        private void picDisplay_Click(object sender, EventArgs e)
        {

        }
    }
}
