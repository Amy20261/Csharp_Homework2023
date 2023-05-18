namespace Homework_loan
{
    partial class FrmLoan
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lab_loan_amout = new System.Windows.Forms.Label();
            this.lab_year = new System.Windows.Forms.Label();
            this.lan_interest = new System.Windows.Forms.Label();
            this.lab_first_amount = new System.Windows.Forms.Label();
            this.text_loan_amount = new System.Windows.Forms.TextBox();
            this.text_year = new System.Windows.Forms.TextBox();
            this.text_interest = new System.Windows.Forms.TextBox();
            this.text_first_amount = new System.Windows.Forms.TextBox();
            this.bntPMT = new System.Windows.Forms.Button();
            this.btnTotalPayment = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lab_loan_amout
            // 
            this.lab_loan_amout.AutoSize = true;
            this.lab_loan_amout.Location = new System.Drawing.Point(76, 72);
            this.lab_loan_amout.Name = "lab_loan_amout";
            this.lab_loan_amout.Size = new System.Drawing.Size(53, 12);
            this.lab_loan_amout.TabIndex = 0;
            this.lab_loan_amout.Text = "貸款金額";
            // 
            // lab_year
            // 
            this.lab_year.AutoSize = true;
            this.lab_year.Location = new System.Drawing.Point(76, 103);
            this.lab_year.Name = "lab_year";
            this.lab_year.Size = new System.Drawing.Size(49, 12);
            this.lab_year.TabIndex = 1;
            this.lab_year.Text = "期限(年)";
            // 
            // lan_interest
            // 
            this.lan_interest.AutoSize = true;
            this.lan_interest.Location = new System.Drawing.Point(76, 134);
            this.lan_interest.Name = "lan_interest";
            this.lan_interest.Size = new System.Drawing.Size(46, 12);
            this.lan_interest.TabIndex = 2;
            this.lan_interest.Text = "利率(%)";
            // 
            // lab_first_amount
            // 
            this.lab_first_amount.AutoSize = true;
            this.lab_first_amount.Location = new System.Drawing.Point(76, 167);
            this.lab_first_amount.Name = "lab_first_amount";
            this.lab_first_amount.Size = new System.Drawing.Size(41, 12);
            this.lab_first_amount.TabIndex = 3;
            this.lab_first_amount.Text = "頭期款";
            // 
            // text_loan_amount
            // 
            this.text_loan_amount.Location = new System.Drawing.Point(159, 72);
            this.text_loan_amount.Name = "text_loan_amount";
            this.text_loan_amount.Size = new System.Drawing.Size(100, 22);
            this.text_loan_amount.TabIndex = 4;
            this.text_loan_amount.Text = "100000";
            // 
            // text_year
            // 
            this.text_year.Location = new System.Drawing.Point(159, 103);
            this.text_year.Name = "text_year";
            this.text_year.Size = new System.Drawing.Size(100, 22);
            this.text_year.TabIndex = 5;
            this.text_year.Text = "2";
            // 
            // text_interest
            // 
            this.text_interest.Location = new System.Drawing.Point(159, 134);
            this.text_interest.Name = "text_interest";
            this.text_interest.Size = new System.Drawing.Size(100, 22);
            this.text_interest.TabIndex = 6;
            this.text_interest.Text = "10";
            // 
            // text_first_amount
            // 
            this.text_first_amount.Location = new System.Drawing.Point(159, 167);
            this.text_first_amount.Name = "text_first_amount";
            this.text_first_amount.Size = new System.Drawing.Size(100, 22);
            this.text_first_amount.TabIndex = 7;
            this.text_first_amount.Text = "0";
            // 
            // bntPMT
            // 
            this.bntPMT.Location = new System.Drawing.Point(54, 224);
            this.bntPMT.Name = "bntPMT";
            this.bntPMT.Size = new System.Drawing.Size(75, 23);
            this.bntPMT.TabIndex = 8;
            this.bntPMT.Text = "PMT(月付)";
            this.bntPMT.UseVisualStyleBackColor = true;
            this.bntPMT.Click += new System.EventHandler(this.bntPMT_Click);
            // 
            // btnTotalPayment
            // 
            this.btnTotalPayment.Location = new System.Drawing.Point(159, 224);
            this.btnTotalPayment.Name = "btnTotalPayment";
            this.btnTotalPayment.Size = new System.Drawing.Size(75, 23);
            this.btnTotalPayment.TabIndex = 9;
            this.btnTotalPayment.Text = "總付款";
            this.btnTotalPayment.UseVisualStyleBackColor = true;
            this.btnTotalPayment.Click += new System.EventHandler(this.btnTotalPayment_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(251, 224);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(75, 23);
            this.btnReport.TabIndex = 10;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // FrmLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 322);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnTotalPayment);
            this.Controls.Add(this.bntPMT);
            this.Controls.Add(this.text_first_amount);
            this.Controls.Add(this.text_interest);
            this.Controls.Add(this.text_year);
            this.Controls.Add(this.text_loan_amount);
            this.Controls.Add(this.lab_first_amount);
            this.Controls.Add(this.lan_interest);
            this.Controls.Add(this.lab_year);
            this.Controls.Add(this.lab_loan_amout);
            this.Name = "FrmLoan";
            this.Text = "貸款金額計算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_loan_amout;
        private System.Windows.Forms.Label lab_year;
        private System.Windows.Forms.Label lan_interest;
        private System.Windows.Forms.Label lab_first_amount;
        private System.Windows.Forms.TextBox text_loan_amount;
        private System.Windows.Forms.TextBox text_year;
        private System.Windows.Forms.TextBox text_interest;
        private System.Windows.Forms.TextBox text_first_amount;
        private System.Windows.Forms.Button bntPMT;
        private System.Windows.Forms.Button btnTotalPayment;
        private System.Windows.Forms.Button btnReport;
    }
}

