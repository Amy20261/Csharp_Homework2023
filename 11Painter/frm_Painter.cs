using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11Painter
{
    public partial class frm_Painter : Form
    {
        public frm_Painter()
        {
            InitializeComponent();
        }
        int oldX, oldY, PenPixel;
        Color penColor;
        Graphics g;
        private void frm_Painter_Load(object sender, EventArgs e)
        {
            
            PenPixel = 3;
            penColor = Color.Black;
            g.Clear(Color.White);

        }
        private void frm_Painter_MouseDown(object sender, MouseEventArgs e)
        {
            oldX = e.X;
            oldY = e.Y;
        }
        private void frm_Painter_MouseMove(object sender, MouseEventArgs e)
        {
            

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            PenPixel = trackBar1.Value;

        }



        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog1=new ColorDialog();
            //colorDialog1.Color = pictureBox1.BackColor;
            colorDialog1.ShowDialog();
            if (colorDialog1.ShowDialog()==DialogResult.OK) {
                pictureBox1.BackColor = colorDialog1.Color;
                penColor = colorDialog1.Color;
            }
        }
    }
}
