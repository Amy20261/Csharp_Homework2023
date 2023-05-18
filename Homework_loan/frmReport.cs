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
        dataManager x = new dataManager();
        private void frmReport_Load(object sender, EventArgs e)
        {
            set();
        }    
        private void set()
        {
            text_report_amount.Text = x.pv.ToString("c0");
            text_report_year.Text = x.years.ToString();
            text_report_rate.Text = x.yearRate.ToString();
            textReportPMT.Text = x.result_PMT.ToString("c0");
            textReportFV.Text = x.result_FV.ToString("c0");
        }
        private void btnMail_Click(object sender, EventArgs e)
        {
            
            string email = "amy20261@gmail.com";
            string subject = "Annuity";
            string body = x.pv.ToString("c0") + ";"+ x.years.ToString() + ";"+ x.yearRate.ToString() + ";"+ x.result_PMT.ToString("c0") + ";"+ x.result_FV.ToString("c0") + ";" ;
            string message = string.Format("maileto:" + email + "Subject:" + subject)+"Body:"+body;
            System.Diagnostics.Process.Start(message);
        }
    }
}
