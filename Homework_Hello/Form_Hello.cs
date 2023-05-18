using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Homework_Hello
{
    public partial class frmHello : Form
    {
        public frmHello()
        {
            InitializeComponent();
        }

        manager x=new manager();
        public void formInfo()
        {
            x.cName = text_cname.Text;
            x.eName = text_ename.Text;
            x.gender = text_gender.Text;
            x.sign = text_sign.Text;
        }

        private void button_say_hello_Click(object sender, EventArgs e)
        {
            formInfo();
            MessageBox.Show("Hello, 我是" + x.cName + ","
                + Environment.NewLine + "英文名字是" + x.eName + ","
                + Environment.NewLine + "性別是" + x.gender + ","
                + Environment.NewLine + "星座是" + x.sign + ","
                + Environment.NewLine + "很高興認識您!"
                );
        }

        private void button_say_hi_Click(object sender, EventArgs e)
        {
            formInfo();

            MessageBox.Show("Hi, 我是" + x.cName + ","+
                "英文名字是" + x.eName + "," +  
                "性別是" + x.gender + "," +
                "星座是" + x.sign + "," +
                "很高興認識您!"
                ) ;
        }

       
    }
}
