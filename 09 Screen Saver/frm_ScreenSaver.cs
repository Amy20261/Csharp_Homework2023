﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_Screen_Saver
{
    public partial class frm_ScreenSaver : Form
    {
        public frm_ScreenSaver()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void frm_ScreenSaver_Load(object sender, EventArgs e)
        {
            timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            
            pictureBox1.Left =r.Next(this.Width-163);
            pictureBox1.Top=r.Next(this.Height-173);         
          
            
        }
    }
}
