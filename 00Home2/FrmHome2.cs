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

namespace _00Home2
{
    public partial class FrmHome2 : Form
    {
        public FrmHome2()
        {
            InitializeComponent();
        }

        private void OpenHelloForm_Click(object sender, EventArgs e)
        {
            frmHello fh = new frmHello();
            fh.ShowDialog();
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            FrmLoan fl=new FrmLoan();
            fl.ShowDialog();
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            frmPOS f = new frmPOS();
            f.ShowDialog();
        }

        private void btnStruct_Click(object sender, EventArgs e)
        {
            FrmStruct fs=new FrmStruct();
            fs.ShowDialog();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            Frm_MyCalc fm=new Frm_MyCalc();
            fm.ShowDialog();
        }

        private void btnGN_Click(object sender, EventArgs e)
        {
            Frm_GuessNum fg = new Frm_GuessNum();
            fg.ShowDialog();
        }

        private void btnOpenAlarm_Click(object sender, EventArgs e)
        {
            frmAlarm fa=new frmAlarm();
            fa.ShowDialog();
        }
    }
}
