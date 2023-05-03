using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_loan
{
    public partial class FrmLoan : Form
    {
        public FrmLoan()
        {
            InitializeComponent();
            
        }

        public static double pv;
        public static double years;
        public static double yearRate;
        public static double downpayment;
        public static double r;
        public static double n;
        public static double rpn;
        public static double result_PMT;
        public static double result_FV;   
            
       

        private void bntPMT_Click(object sender, EventArgs e)
        {
        
        MessageBox.Show("Payment: " + Math.Round(result_PMT)+ " per month."); 

        }

        private void btnTotalPayment_Click(object sender, EventArgs e)
        {
          

            MessageBox.Show("Total Payment: "+Math.Round(result_FV));
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            frmReport fr=new frmReport();
            fr.Show();
        }

        private void FrmLoan_Load(object sender, EventArgs e)
        {
            pv=Double.Parse(text_loan_amount.Text);
            yearRate=Double.Parse(text_interest.Text);
            years=Double.Parse(text_year.Text);
            downpayment=Double.Parse(text_first_amount.Text);

            r = 1 + yearRate / 100 / 12;
            n = years * 12;
            rpn = Math.Pow(r, n);
            result_PMT =Math.Round( pv * rpn * (r - 1) / (rpn - 1));
            result_FV = Math.Round(result_PMT * n);
        }
    }
}
