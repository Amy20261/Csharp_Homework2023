﻿using System;
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

        public string purchaselist { get; set; }
        public double payment { get; set; }
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
            BeerString= string.Empty;
            BeerAmount=0;
            TaquilaCount = 0;
            TaquilaString = string.Empty;
            TaquilaAmount = 0;
            WhiskyCount = 0;
            WhiskyString = string.Empty;
            WhiskyAmount = 0;
            WineCount = 0;
            WineString = string.Empty;
            WineAmount = 0;
        }

        public double BeerCount;
        double BeerPrice=120;
        string BeerString { get; set; }
        public double BeerAmount { get; private set; }

        private void btnBeer_Click(object sender, EventArgs e)
        {
            // beer,120
            
            BeerCount+=1;
            BeerAmount = BeerPrice * BeerCount;
            BeerString = $"Beer X {BeerCount}, beer total amount: {BeerAmount:c0}";
            
            payment = BeerAmount + TaquilaAmount + WhiskyAmount + WineAmount;
            labPayment.Text = payment.ToString("c0");

            purchaselist = BeerString + Environment.NewLine + TaquilaString + Environment.NewLine + WhiskyString + Environment.NewLine + WineString;
            textPurchase.Text = purchaselist;

        }

        public double TaquilaCount;
        double TaquilaPrice = 180;        
        string TaquilaString { get; set; }
        public double TaquilaAmount { get; private set; }
        private void btnTaquila_Click(object sender, EventArgs e)
        {
            //Taquila,180
            TaquilaCount+=1;
            TaquilaAmount = TaquilaPrice * TaquilaCount;
            TaquilaString = $"Taquila X {TaquilaCount}, Taquila total amount: {TaquilaAmount:c0}";
            
            payment = BeerAmount + TaquilaAmount+ WhiskyAmount+ WineAmount; 
            labPayment.Text = payment.ToString("c0");

            purchaselist = TaquilaString + Environment.NewLine + BeerString + Environment.NewLine + WhiskyString + Environment.NewLine + WineString;
            textPurchase.Text = purchaselist;
        }

        public double WhiskyCount;
        double WhiskyPrice = 350;
        string WhiskyString { get; set; }
        public double WhiskyAmount { get; private set; }
        private void btnWhisky_Click(object sender, EventArgs e)
        {
            //Whisky,350
            WhiskyCount += 1;
            WhiskyAmount = WhiskyPrice * WhiskyCount;
            WhiskyString = $"Whisky X {WhiskyCount}, Whisky total amount: {WhiskyAmount:c0}";

            payment = BeerAmount + TaquilaAmount + WhiskyAmount+ WineAmount;
            labPayment.Text = payment.ToString("c0");

            purchaselist = WhiskyString + Environment.NewLine + TaquilaString + Environment.NewLine + BeerString + Environment.NewLine + WineString;
            textPurchase.Text = purchaselist;

        }

        public double WineCount;
        double WinePrice = 320;
        string WineString { get; set; }
        public double WineAmount { get; private set; }


        private void btnWine_Click(object sender, EventArgs e)
        {
            //wine,320
            WineCount += 1;
            WineAmount = WinePrice * WineCount;
            WineString = $"Wine X {WineCount}, Wine total amount: {WineAmount:c0}";

            payment = WineAmount+ BeerAmount + TaquilaAmount + WhiskyAmount;
            labPayment.Text = payment.ToString("c0");

            purchaselist = WineString + Environment.NewLine + WhiskyString + Environment.NewLine + TaquilaString + Environment.NewLine + BeerString;
            textPurchase.Text = purchaselist;
        }

        

        private void btnCash_Click(object sender, EventArgs e)
        {
            payment = payment * cash;
            if (payment == 0)
            {
                MessageBox.Show($"Please purchase a product.");
            }
            else {MessageBox.Show($"Total payment:{payment:c0}"); }
            
        }

        private void btnCard_Click(object sender, EventArgs e)
        {
            double disPayment = payment * credit;
            if (payment == 0)
            {
                MessageBox.Show($"Please purchase a product.");
            }
            else { MessageBox.Show($"Total payment:{payment:c0} \n Discount payment:{disPayment:c0}"); }
            
        }
    }
}
