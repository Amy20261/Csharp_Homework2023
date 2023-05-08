using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_loan
{
    public partial class frmReport : Form
    {
        
        public frmReport()
        {
            InitializeComponent();
                        
           
        }


        private void btnMail_Click(object sender, EventArgs e)
        {
            
            string amount = text_report_amount.Text;
            string year = text_report_year.Text;
            string rate = text_report_rate.Text;
            string PMT = textReportPMT.Text;
            string FV = textReportFV.Text;


            string email = "amy20261@gmail.com";
            string subject = "Annuity";
            string body = amount+";"+year+";"+rate+";"+PMT+";"+FV+";" ;
            string message = string.Format("maileto:" + email + "Subject:" + subject)+"Body:"+body;
            System.Diagnostics.Process.Start(message);
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            text_report_amount.Text = FrmLoan.pv.ToString("c0");
            text_report_year.Text = FrmLoan.years.ToString();
            text_report_rate.Text = FrmLoan.yearRate.ToString();
            textReportPMT.Text = FrmLoan.result_PMT.ToString("c0");
            textReportFV.Text = FrmLoan.result_FV.ToString("c0");
        }
    }
}
