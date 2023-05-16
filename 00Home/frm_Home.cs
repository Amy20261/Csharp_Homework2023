using _012_Picture_Viewer;
using _09_NotePad;
using _09_Screen_Saver;
using _11Painter;
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
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            frmHello fh = new frmHello();
            fh.MdiParent = this;
            
            fh.Show();
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            FrmLoan fl = new FrmLoan();
            fl.MdiParent = this;
            
            fl.Show();
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            frmPOS fp = new frmPOS();
            fp.MdiParent = this;            
            fp.Show();
        }

        private void btn_Struct_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            FrmStruct fs = new FrmStruct();
            fs.MdiParent = this;
            fs.Show();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            Frm_MyCalc frm_MyCalc = new Frm_MyCalc();
            frm_MyCalc.MdiParent = this;
            frm_MyCalc.Show();
        }

        private void btnGuessNum_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            Frm_GuessNum fg = new Frm_GuessNum();
            fg.MdiParent = this;
            fg.Show();
        }

        private void btnAlarm_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            frmAlarm fa= new frmAlarm();
            fa.MdiParent = this;
            fa.Show();
        }

        private void btnScreenSaver_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            frm_ScreenSaver fs = new frm_ScreenSaver();        
            fs.Show();
        }

        private void btnPainter_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            frm_Painter fp=new frm_Painter();
            fp.MdiParent = this;
            fp.Show();
        }        
        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void frmNotePad_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            frmNotePad fn=new frmNotePad();
            fn.MdiParent = this;
            fn.Show();
        }

        private void btnPicViewer_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            frmPicViewer pv= new frmPicViewer();
            pv.MdiParent = this;
            pv.Show();
        }
    }
}
