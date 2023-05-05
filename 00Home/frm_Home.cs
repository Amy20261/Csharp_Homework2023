using _13_Guess_Number;
using _14_Alarm_clock;
using Homework_Hello;
using Homework_loan;
using MyCalc;
using POS;
using Student_Struct;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _00Home
{
    public partial class frm_Home : Form
    {
        public frm_Home()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            
            frmHello fh = new frmHello();
            fh.MdiParent = this;
            fh.Show();
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            
            FrmLoan fl = new FrmLoan();
            fl.MdiParent = this;
            fl.Show();
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            frmPOS fh = new frmPOS();
            fh.MdiParent = this;
            fh.Show();
        }

        private void btn_Struct_Click(object sender, EventArgs e)
        {
            FrmStruct fh = new FrmStruct();
            fh.MdiParent = this;
            fh.Show();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            Frm_MyCalc frm_MyCalc = new Frm_MyCalc();
            frm_MyCalc.MdiParent = this;
            frm_MyCalc.Show();
        }

        private void btnGuessNum_Click(object sender, EventArgs e)
        {
            Frm_GuessNum fh = new Frm_GuessNum();
            fh.MdiParent = this;
            fh.Show();
        }

        private void btnAlarm_Click(object sender, EventArgs e)
        {
            frmAlarm fa= new frmAlarm();
            fa.MdiParent = this;
            fa.Show();
        }
    }
}
