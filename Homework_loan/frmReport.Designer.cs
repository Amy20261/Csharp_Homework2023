namespace Homework_loan
{
    partial class frmReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lab_PMT = new System.Windows.Forms.Label();
            this.text_report_rate = new System.Windows.Forms.TextBox();
            this.text_report_year = new System.Windows.Forms.TextBox();
            this.text_report_amount = new System.Windows.Forms.TextBox();
            this.lan_interest = new System.Windows.Forms.Label();
            this.lab_year = new System.Windows.Forms.Label();
            this.lab_loan_amout = new System.Windows.Forms.Label();
            this.lab_FV = new System.Windows.Forms.Label();
            this.btnMail = new System.Windows.Forms.Button();
            this.textReportFV = new System.Windows.Forms.TextBox();
            this.textReportPMT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lab_PMT
            // 
            this.lab_PMT.AutoSize = true;
            this.lab_PMT.Location = new System.Drawing.Point(74, 145);
            this.lab_PMT.Name = "lab_PMT";
            this.lab_PMT.Size = new System.Drawing.Size(41, 12);
            this.lab_PMT.TabIndex = 0;
            this.lab_PMT.Text = "月付款";
            // 
            // text_report_rate
            // 
            this.text_report_rate.Location = new System.Drawing.Point(157, 105);
            this.text_report_rate.Name = "text_report_rate";
            this.text_report_rate.ReadOnly = true;
            this.text_report_rate.Size = new System.Drawing.Size(100, 22);
            this.text_report_rate.TabIndex = 12;
            // 
            // text_report_year
            // 
            this.text_report_year.Location = new System.Drawing.Point(157, 74);
            this.text_report_year.Name = "text_report_year";
            this.text_report_year.ReadOnly = true;
            this.text_report_year.Size = new System.Drawing.Size(100, 22);
            this.text_report_year.TabIndex = 11;
            // 
            // text_report_amount
            // 
            this.text_report_amount.BackColor = System.Drawing.SystemColors.Control;
            this.text_report_amount.Location = new System.Drawing.Point(157, 43);
            this.text_report_amount.Name = "text_report_amount";
            this.text_report_amount.ReadOnly = true;
            this.text_report_amount.Size = new System.Drawing.Size(100, 22);
            this.text_report_amount.TabIndex = 10;
            // 
            // lan_interest
            // 
            this.lan_interest.AutoSize = true;
            this.lan_interest.Location = new System.Drawing.Point(74, 105);
            this.lan_interest.Name = "lan_interest";
            this.lan_interest.Size = new System.Drawing.Size(46, 12);
            this.lan_interest.TabIndex = 9;
            this.lan_interest.Text = "利率(%)";
            // 
            // lab_year
            // 
            this.lab_year.AutoSize = true;
            this.lab_year.Location = new System.Drawing.Point(74, 74);
            this.lab_year.Name = "lab_year";
            this.lab_year.Size = new System.Drawing.Size(49, 12);
            this.lab_year.TabIndex = 8;
            this.lab_year.Text = "期限(年)";
            // 
            // lab_loan_amout
            // 
            this.lab_loan_amout.AutoSize = true;
            this.lab_loan_amout.Location = new System.Drawing.Point(74, 43);
            this.lab_loan_amout.Name = "lab_loan_amout";
            this.lab_loan_amout.Size = new System.Drawing.Size(53, 12);
            this.lab_loan_amout.TabIndex = 7;
            this.lab_loan_amout.Text = "貸款金額";
            // 
            // lab_FV
            // 
            this.lab_FV.AutoSize = true;
            this.lab_FV.Location = new System.Drawing.Point(74, 179);
            this.lab_FV.Name = "lab_FV";
            this.lab_FV.Size = new System.Drawing.Size(41, 12);
            this.lab_FV.TabIndex = 13;
            this.lab_FV.Text = "總付款";
            // 
            // btnMail
            // 
            this.btnMail.Location = new System.Drawing.Point(157, 221);
            this.btnMail.Name = "btnMail";
            this.btnMail.Size = new System.Drawing.Size(75, 23);
            this.btnMail.TabIndex = 14;
            this.btnMail.Text = "Email";
            this.btnMail.UseVisualStyleBackColor = true;
            this.btnMail.Click += new System.EventHandler(this.btnMail_Click);
            // 
            // textReportFV
            // 
            this.textReportFV.Location = new System.Drawing.Point(157, 173);
            this.textReportFV.Name = "textReportFV";
            this.textReportFV.ReadOnly = true;
            this.textReportFV.Size = new System.Drawing.Size(100, 22);
            this.textReportFV.TabIndex = 16;
            // 
            // textReportPMT
            // 
            this.textReportPMT.Location = new System.Drawing.Point(157, 142);
            this.textReportPMT.Name = "textReportPMT";
            this.textReportPMT.ReadOnly = true;
            this.textReportPMT.Size = new System.Drawing.Size(100, 22);
            this.textReportPMT.TabIndex = 15;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 290);
            this.Controls.Add(this.textReportFV);
            this.Controls.Add(this.textReportPMT);
            this.Controls.Add(this.btnMail);
            this.Controls.Add(this.lab_FV);
            this.Controls.Add(this.text_report_rate);
            this.Controls.Add(this.text_report_year);
            this.Controls.Add(this.text_report_amount);
            this.Controls.Add(this.lan_interest);
            this.Controls.Add(this.lab_year);
            this.Controls.Add(this.lab_loan_amout);
            this.Controls.Add(this.lab_PMT);
            this.Enabled = false;
            this.Name = "frmReport";
            this.Text = "Loan Report ";
            this.Controls.SetChildIndex(this.lab_PMT, 0);
            this.Controls.SetChildIndex(this.lab_loan_amout, 0);
            this.Controls.SetChildIndex(this.lab_year, 0);
            this.Controls.SetChildIndex(this.lan_interest, 0);
            this.Controls.SetChildIndex(this.text_report_amount, 0);
            this.Controls.SetChildIndex(this.text_report_year, 0);
            this.Controls.SetChildIndex(this.text_report_rate, 0);
            this.Controls.SetChildIndex(this.lab_FV, 0);
            this.Controls.SetChildIndex(this.btnMail, 0);
            this.Controls.SetChildIndex(this.textReportPMT, 0);
            this.Controls.SetChildIndex(this.textReportFV, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_PMT;
        private System.Windows.Forms.TextBox text_report_rate;
        private System.Windows.Forms.TextBox text_report_year;
        private System.Windows.Forms.TextBox text_report_amount;
        private System.Windows.Forms.Label lan_interest;
        private System.Windows.Forms.Label lab_year;
        private System.Windows.Forms.Label lab_loan_amout;
        private System.Windows.Forms.Label lab_FV;
        private System.Windows.Forms.Button btnMail;
        private System.Windows.Forms.TextBox textReportFV;
        private System.Windows.Forms.TextBox textReportPMT;
    }
}