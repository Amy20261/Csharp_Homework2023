﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_Guess_Number
{
    public partial class Frm_GuessNum : Form
    {
        public Frm_GuessNum()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       EnterNum fn= new EnterNum();

        private void btnShowNum_Click(object sender, EventArgs e)
        {
            int num;
            num = fn.guess;
            MessageBox.Show($"Answer : {num}");


        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
           
            
            fn.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
