using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_Hello
{
    public partial class frmHello : Form
    {
        public frmHello()
        {
            InitializeComponent();
        }

        private void button_say_hello_Click(object sender, EventArgs e)
        {
            string cName = text_cname.Text;
            string eName = text_ename.Text;
            string gender = text_gender.Text;
            string sign = text_sign.Text;

            MessageBox.Show("Hello, 我是" + cName + ","
                + Environment.NewLine + "英文名字是" + eName + ","
                + Environment.NewLine + "性別是" + gender + ","
                + Environment.NewLine + "星座是" + sign + ","
                + Environment.NewLine + "很高興認識您!"
                );
        }

        private void button_say_hi_Click(object sender, EventArgs e)
        {
            string cName = text_cname.Text;
            string eName = text_ename.Text;
            string gender = text_gender.Text;
            string sign = text_sign.Text;
            MessageBox.Show("Hi, 我是" + cName + ","+
                "英文名字是" + eName + "," +  
                "性別是" + gender + "," +
                "星座是" + sign + "," +
                "很高興認識您!"
                ) ;
        }
    }
}
