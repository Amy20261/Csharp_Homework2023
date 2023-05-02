using _13_Guess_Number;
using Homework_Hello;
using Homework_loan;
using Method;
using MyCalc;
using POS;
using Student_Struct;
using Students_Grade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void btnOpenHelloForm_Click(object sender, EventArgs e)
        {
          frmHello fh= new frmHello();
            fh.Show();
        }

        private void btn_Loan_Click(object sender, EventArgs e)
        {
            FrmLoan fl = new FrmLoan();
            fl.Show();
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            frmPOS fPOS= new frmPOS();
            fPOS.Show();
        }

        private void btnStruct_Click(object sender, EventArgs e)
        {
            FrmStruct fs= new FrmStruct();
            fs.Show();
        }

        private void btnGrade_Click(object sender, EventArgs e)
        {
            Frm_Grade fg=new Frm_Grade();
            fg.Show();
        }

        private void btnMethod_Click(object sender, EventArgs e)
        {
            Frm_Method fg=new Frm_Method();
            fg.Show();
        }

        private void btnMyCalc_Click(object sender, EventArgs e)
        {
            Frm_MyCalc fg=new Frm_MyCalc(); 
            fg.Show();
        }

        private void btnGNum_Click(object sender, EventArgs e)
        {
            Frm_GuessNum fg = new Frm_GuessNum();
            fg.Show();
        }
    }
}
