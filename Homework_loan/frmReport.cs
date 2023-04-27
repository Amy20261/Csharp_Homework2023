﻿using System;
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

            FrmLoan fl = new FrmLoan();
            text_report_amount.Text = fl.pv.ToString();
            text_report_year.Text = fl.years.ToString();
            text_report_rate.Text = fl.yearRate.ToString();
            textReportPMT.Text = fl.result_PMT.ToString();
            textReportFV.Text = fl.result_FV.ToString();
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

    }
}
