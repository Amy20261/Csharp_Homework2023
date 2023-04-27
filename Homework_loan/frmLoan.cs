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

        public double pv;
        public double years;
        public double yearRate;
        public double r;
        public double n;
        public double rpn;
        public double result_PMT;
        public double result_FV;   
            
       

        private void bntPMT_Click(object sender, EventArgs e)
        {
        Double.TryParse(text_loan_amount.Text, out double pv);
        Double.TryParse(text_interest.Text, out double yearRate);
        Double.TryParse(text_year.Text, out double years);
        Decimal.TryParse(text_first_amount.Text, out decimal downpayment);

        r = 1 + yearRate / 100 / 12;
        n = years * 12;
        rpn = Math.Pow(r, n);

        //PMT = pv* rpn * (r - 1) / (rpn - 1);
        result_PMT = pv * rpn * (r - 1) / (rpn - 1);

        MessageBox.Show("Payment: " + Math.Round(result_PMT)+ " per month."); 

        }

        private void btnTotalPayment_Click(object sender, EventArgs e)
        {
            Double.TryParse(text_loan_amount.Text, out double pv);
            Double.TryParse(text_interest.Text, out double yearRate);
            Double.TryParse(text_year.Text, out double years);
            Decimal.TryParse(text_first_amount.Text, out decimal downpayment);

            r = 1 + yearRate/100/12;
             n = years * 12;
             rpn = Math.Pow(r, n);
            result_PMT = pv * rpn * (r - 1) / (rpn - 1);
            result_FV = result_PMT*n;

            MessageBox.Show("Total Payment: "+Math.Round(result_FV));
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            frmReport fr=new frmReport();
            fr.Show();
        }
    }
}
