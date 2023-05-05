using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_Painter
{
    public partial class Painter : Form
    {
        public Painter()
        {
            InitializeComponent();
        }
        Bitmap bmp;
        int oldX, oldY;
        int PenPixel;
        Color PenColor;
        
        private void Painter_Load(object sender, EventArgs e)
        {
           bmp = new Bitmap(320, 210);
            Graphics g = Graphics.FromImage(bmp);
            PenColor = Color.Black;
            PenPixel = 3;
            g.Clear(Color.White);
            pictureBox1.Image = bmp;
            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            oldX = e.X;
            oldY = e.Y;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                bmp = new Bitmap(320, 210);
                Graphics g = Graphics.FromImage(bmp);
                Pen p = new Pen(PenColor, PenPixel);
                g.DrawLine(p, oldX, oldY, e.X, e.Y);
                pictureBox1.Image= bmp;
                oldX= e.X;
                oldY= e.Y;
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.BackColor = colorDialog1.Color;
                PenColor = colorDialog1.Color;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            PenPixel = trackBar1.Value;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
