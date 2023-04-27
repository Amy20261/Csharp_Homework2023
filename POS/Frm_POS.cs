using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class frmPOS : Form
    {

        string purchaselist { get; set; }
        double payment { get; set; }
        double cash = 1;
        double credit = 0.9;
        
        public frmPOS()
        {
            InitializeComponent();
            
        }

        
        private void btnClear_Click(object sender, EventArgs e)
        {
            textPurchase.Text = string.Empty;
            labPayment.Text = string.Empty;
            purchaselist = string.Empty;
            payment = 0;
            BeerCount = 0;
            TaquilaCount = 0;
            WhiskyCount = 0;
            WineCount = 0;
        }

        double BeerCount;
        double BeerPrice=120;
        string BeerString { get; set; }
        public double BeerAmount { get; private set; }

        private void btnBeer_Click(object sender, EventArgs e)
        {
            // beer,120
            
            BeerCount+=1;
            BeerAmount = BeerPrice * BeerCount;
            BeerString = $"Beer X {BeerCount},beer total amount:{BeerAmount}";
            
            payment = BeerAmount + TaquilaAmount + WhiskyAmount + WineAmount;
            labPayment.Text = payment.ToString();

            purchaselist = BeerString + Environment.NewLine + TaquilaString + Environment.NewLine + WhiskyString + Environment.NewLine + WineString;
            textPurchase.Text = purchaselist;

        }

        double TaquilaCount;
        double TaquilaPrice = 180;        
        string TaquilaString { get; set; }
        public double TaquilaAmount { get; private set; }
        private void btnTaquila_Click(object sender, EventArgs e)
        {
            //Taquila,180
            TaquilaCount+=1;
            TaquilaAmount = TaquilaPrice * TaquilaCount;
            TaquilaString = $"Taquila X {TaquilaCount},Taquila total amount:{TaquilaAmount}";
            
            payment = BeerAmount + TaquilaAmount+ WhiskyAmount+ WineAmount; 
            labPayment.Text = payment.ToString();

            purchaselist = TaquilaString + Environment.NewLine + BeerString + Environment.NewLine + WhiskyString + Environment.NewLine + WineString;
            textPurchase.Text = purchaselist;
        }
        double WhiskyCount;
        double WhiskyPrice = 350;
        string WhiskyString { get; set; }
        public double WhiskyAmount { get; private set; }
        private void btnWhisky_Click(object sender, EventArgs e)
        {
            //Whisky,350
            WhiskyCount += 1;
            WhiskyAmount = WhiskyPrice * WhiskyCount;
            WhiskyString = $"Whisky X {WhiskyCount}, Whisky total amount:{WhiskyAmount}";

            payment = BeerAmount + TaquilaAmount + WhiskyAmount+ WineAmount;
            labPayment.Text = payment.ToString();

            purchaselist = WhiskyString + Environment.NewLine + TaquilaString + Environment.NewLine + BeerString + Environment.NewLine + WineString;
            textPurchase.Text = purchaselist;

        }
        double WineCount;
        double WinePrice = 320;
        string WineString { get; set; }
        public double WineAmount { get; private set; }


        private void btnWine_Click(object sender, EventArgs e)
        {
            //wine,320
            WineCount += 1;
            WineAmount = WinePrice * WineCount;
            WineString = $"Wine X {WineCount}, Wine total amount:{WineAmount}";

            payment = WineAmount+ BeerAmount + TaquilaAmount + WhiskyAmount;
            labPayment.Text = payment.ToString();

            purchaselist = WineString + Environment.NewLine + WhiskyString + Environment.NewLine + TaquilaString + Environment.NewLine + BeerString;
            textPurchase.Text = purchaselist;
        }

        

        private void btnCash_Click(object sender, EventArgs e)
        {
            payment = payment * cash;
            MessageBox.Show("Total payment:" + payment);
        }

        private void btnCard_Click(object sender, EventArgs e)
        {
            double disPayment = payment * credit;
            MessageBox.Show("Total payment:" + payment+"\n Discount payment:"+disPayment);
        }
    }
}
