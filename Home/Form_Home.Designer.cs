namespace Home
{
    partial class frmHome
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
            this.btnOpenHelloForm = new System.Windows.Forms.Button();
            this.btn_Loan = new System.Windows.Forms.Button();
            this.btnPOS = new System.Windows.Forms.Button();
            this.btnStruct = new System.Windows.Forms.Button();
            this.btnGrade = new System.Windows.Forms.Button();
            this.btnMyCalc = new System.Windows.Forms.Button();
            this.btnMethod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenHelloForm
            // 
            this.btnOpenHelloForm.Location = new System.Drawing.Point(26, 66);
            this.btnOpenHelloForm.Name = "btnOpenHelloForm";
            this.btnOpenHelloForm.Size = new System.Drawing.Size(75, 23);
            this.btnOpenHelloForm.TabIndex = 0;
            this.btnOpenHelloForm.Text = "01 Hello";
            this.btnOpenHelloForm.UseVisualStyleBackColor = true;
            this.btnOpenHelloForm.Click += new System.EventHandler(this.btnOpenHelloForm_Click);
            // 
            // btn_Loan
            // 
            this.btn_Loan.Location = new System.Drawing.Point(26, 105);
            this.btn_Loan.Name = "btn_Loan";
            this.btn_Loan.Size = new System.Drawing.Size(75, 23);
            this.btn_Loan.TabIndex = 1;
            this.btn_Loan.Text = "02 Loan";
            this.btn_Loan.UseVisualStyleBackColor = true;
            this.btn_Loan.Click += new System.EventHandler(this.btn_Loan_Click);
            // 
            // btnPOS
            // 
            this.btnPOS.Location = new System.Drawing.Point(26, 143);
            this.btnPOS.Name = "btnPOS";
            this.btnPOS.Size = new System.Drawing.Size(75, 23);
            this.btnPOS.TabIndex = 2;
            this.btnPOS.Text = "03 POS";
            this.btnPOS.UseVisualStyleBackColor = true;
            this.btnPOS.Click += new System.EventHandler(this.btnPOS_Click);
            // 
            // btnStruct
            // 
            this.btnStruct.Location = new System.Drawing.Point(26, 181);
            this.btnStruct.Name = "btnStruct";
            this.btnStruct.Size = new System.Drawing.Size(127, 23);
            this.btnStruct.TabIndex = 3;
            this.btnStruct.Text = "04 Student_Struct";
            this.btnStruct.UseVisualStyleBackColor = true;
            this.btnStruct.Click += new System.EventHandler(this.btnStruct_Click);
            // 
            // btnGrade
            // 
            this.btnGrade.Location = new System.Drawing.Point(26, 220);
            this.btnGrade.Name = "btnGrade";
            this.btnGrade.Size = new System.Drawing.Size(127, 23);
            this.btnGrade.TabIndex = 4;
            this.btnGrade.Text = "05 Students_Grade";
            this.btnGrade.UseVisualStyleBackColor = true;
            this.btnGrade.Click += new System.EventHandler(this.btnGrade_Click);
            // 
            // btnMyCalc
            // 
            this.btnMyCalc.Location = new System.Drawing.Point(26, 300);
            this.btnMyCalc.Name = "btnMyCalc";
            this.btnMyCalc.Size = new System.Drawing.Size(127, 23);
            this.btnMyCalc.TabIndex = 5;
            this.btnMyCalc.Text = "07 My Calc";
            this.btnMyCalc.UseVisualStyleBackColor = true;
            this.btnMyCalc.Click += new System.EventHandler(this.btnMyCalc_Click);
            // 
            // btnMethod
            // 
            this.btnMethod.Location = new System.Drawing.Point(26, 259);
            this.btnMethod.Name = "btnMethod";
            this.btnMethod.Size = new System.Drawing.Size(127, 23);
            this.btnMethod.TabIndex = 6;
            this.btnMethod.Text = "06 Method";
            this.btnMethod.UseVisualStyleBackColor = true;
            this.btnMethod.Click += new System.EventHandler(this.btnMethod_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 450);
            this.Controls.Add(this.btnMethod);
            this.Controls.Add(this.btnMyCalc);
            this.Controls.Add(this.btnGrade);
            this.Controls.Add(this.btnStruct);
            this.Controls.Add(this.btnPOS);
            this.Controls.Add(this.btn_Loan);
            this.Controls.Add(this.btnOpenHelloForm);
            this.Name = "frmHome";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenHelloForm;
        private System.Windows.Forms.Button btn_Loan;
        private System.Windows.Forms.Button btnPOS;
        private System.Windows.Forms.Button btnStruct;
        private System.Windows.Forms.Button btnGrade;
        private System.Windows.Forms.Button btnMyCalc;
        private System.Windows.Forms.Button btnMethod;
    }
}

