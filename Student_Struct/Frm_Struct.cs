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

namespace Student_Struct
{
    public partial class FrmStruct : Form
    {
        public FrmStruct()
        {
            InitializeComponent();
        }

        public struct Student
        {
            public string Name;
            public double Chinese;
            public double English;
            public double Math;
            public Student(string name, double chinese, double english, double math)
            {
                Name = name;
                Chinese = chinese;
                English = english;
                Math = math;
            }

        }
        Student student = new Student();

        
        private void btnSave_Click(object sender, EventArgs e)
        {
            string sName;
            double sChinese, sEnglish,sMath;
            try { 
            sName = textName.Text;
            sChinese = double.Parse(textChinese.Text);
            sEnglish = double.Parse(textEnglish.Text);
            sMath = double.Parse(textMath.Text);
            }catch(InvalidCastException ex)
            {
                MessageBox.Show(ex.Message);
            }
            student.Name = name;
            student.Chinese = chinese;
            student.English = english;
            student.Math = math;            

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            
            textShow.Text =$"Name:{student.Name}, Chinese:{student.Chinese}, English:{student.English}, \nMath:{student.Math}";
        }

        private void btnSort_Click(object sender, EventArgs e)
        {

        }
    }
}
