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
                 
       dataManager x=new dataManager();
        private void bntPMT_Click(object sender, EventArgs e)
        {
            get();
            MessageBox.Show($"Payment: {x.result_PMT:c0} per month."); 
        }

        private void btnTotalPayment_Click(object sender, EventArgs e)
        {
            get();
            MessageBox.Show($"Total Payment:{x.result_FV:c0}");
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            get();
            frmReport fr=new frmReport();
            fr.Show();
        }

        private void FrmLoan_Load(object sender, EventArgs e)
        {
            

        }

        private void get()
        {
            x.pv = Double.Parse(text_loan_amount.Text);
            x.yearRate = Double.Parse(text_interest.Text);
            x.years = Double.Parse(text_year.Text);
            x.downpayment = Double.Parse(text_first_amount.Text);
        }

    }
}
