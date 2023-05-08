using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalc
{
    public partial class Frm_MyCalc : Form
    {
        double num1, num2, ans;
        public Frm_MyCalc()
        {
            InitializeComponent();
           
        }



        private void btnReset_Click(object sender, EventArgs e)
        {
            textNum1.Text = string.Empty;
            textNum2.Text = string.Empty;
            textAns.Text = string.Empty;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            try {
            num1 = double.Parse(textNum1.Text);
            num2 = double.Parse(textNum2.Text); 
            }catch(InvalidCastException ex)
            {
                MessageBox.Show(ex.Message);
            }
            ans = num1 + num2;
            textAns.Text= ans.ToString("N");
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            try{
            num1 = double.Parse(textNum1.Text);
            num2 = double.Parse(textNum2.Text);
            }
            catch (InvalidCastException ex)
            {
                MessageBox.Show(ex.Message);
            }
            ans = num1 - num2;
            textAns.Text = ans.ToString("N");
        }

        private void btnMultiple_Click(object sender, EventArgs e)
        {
            try{
            num1 = double.Parse(textNum1.Text);
            num2 = double.Parse(textNum2.Text);
            }
            catch (InvalidCastException ex)
            {
                MessageBox.Show(ex.Message);
            }
            ans = num1 * num2;
            textAns.Text = ans.ToString("N");
        }

        private void btnDevide_Click(object sender, EventArgs e)
        {
            try {
            num1 = double.Parse(textNum1.Text);
            num2 = double.Parse(textNum2.Text);
            }
            catch (InvalidCastException ex)
            {
                MessageBox.Show(ex.Message);
            }catch(DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ans = num1 / num2;
            textAns.Text = ans.ToString("N");
        }
    }
}
