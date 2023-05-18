using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_loan
{
    public class dataManager
    {

        public double pv{get;set;}
        public double years{get;set;}
        public double yearRate{get;set;}
        public double downpayment{get;set;}

        public double r;
        public double n;
        public double rpn;
        public double result_PMT;
        public double result_FV;

        private void calculate()
        {
            r = 1 + yearRate / 100 / 12;
            n = years * 12;
            rpn = Math.Pow(r, n);

            result_PMT = Math.Round(pv * rpn * (r - 1) / (rpn - 1));
            result_FV = Math.Round(result_PMT * n);
        }

    }
}
