using System;
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
    public partial class EnterNum : Form
    {
        public EnterNum()
        {
            InitializeComponent();
        }

        public int guess,  min, max;
        

        private void EnterNum_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            guess = r.Next(1, 101);
            min = 0;
            max = 100;
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
           this.Close();
        }

        private void btnGuessNum_Click(object sender, EventArgs e)
        {
            int myguess = 0;
            if(int.TryParse(textGuessNum.Text, out myguess))
            {
                if (myguess >0 && myguess < 100)
                {
                    if (myguess == guess)
                    {
                        MessageBox.Show("Congrats. Bingo.");
                        btnGuessNum.Enabled = false;
                    }
                    else if (myguess > guess)
                    {
                        max = myguess;
                        MessageBox.Show($"Please enter a smaller number.\n Number should be from {min} to {max}.");
                        textGuessNum.Text = "";
                    }else if  (myguess < guess)
                    {
                        min = myguess;
                        MessageBox.Show($"Please enter a Bigger number.\n Number should be from {min} to {max}.");
                        textGuessNum.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a number between 0 and 100.");
                }
            }else
            {
                MessageBox.Show("please enter a digital number.");
            }

        }
    }
}
