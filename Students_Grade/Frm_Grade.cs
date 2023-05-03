using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Students_Grade
{
    public partial class Frm_Grade : Form
    {
        public Frm_Grade()
        {
            InitializeComponent();
        }
        public class Score{
            public string SName;
            public int Chinese;
            public int English;
            public int Math;
            public int Total;
            public int Average;


        }
        List<Score> sg = new List<Score>();

        private void btnSave_Click(object sender, EventArgs e)
        {
            Score s = new Score();
            s.SName = textName.Text;
            int.TryParse(textChinese.Text.ToString(), out s.Chinese);
             int.TryParse(textEnglish.Text.ToString(), out s.English);
             int.TryParse(textMath.Text.ToString(), out s.Math);
            s.Total = s.Chinese + s.English + s.Math;
            s.Average = s.Total / 3;
            sg.Add(s);


            string result = "";
            labShow.Text = ($"Name\t Chinese\t English\t Math\t Total\t Average\t Hightest\t Lowest");
            foreach (Score item in sg)
            {                
                result+= $"{item.SName}\t{item.Chinese}\t{item.English}\t{item.Math}\t\n";
            }
            labShow.Text = ($"Name\t Chinese\t English\t Math\t Total\t Average\t Hightest\t Lowest\n");
            labShow.Text = result;

        }
    }
}
