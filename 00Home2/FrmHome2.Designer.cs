namespace _00Home2
{
    partial class FrmHome2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome2));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.OpenHelloForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoan = new System.Windows.Forms.Button();
            this.btnPOS = new System.Windows.Forms.Button();
            this.btnStruct = new System.Windows.Forms.Button();
            this.btnCal = new System.Windows.Forms.Button();
            this.btnGN = new System.Windows.Forms.Button();
            this.btnOpenAlarm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Black;
            this.splitContainer1.Panel1.Controls.Add(this.btnOpenAlarm);
            this.splitContainer1.Panel1.Controls.Add(this.btnGN);
            this.splitContainer1.Panel1.Controls.Add(this.btnCal);
            this.splitContainer1.Panel1.Controls.Add(this.btnStruct);
            this.splitContainer1.Panel1.Controls.Add(this.btnPOS);
            this.splitContainer1.Panel1.Controls.Add(this.btnLoan);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.OpenHelloForm);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.splitContainer1.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel2.BackgroundImage")));
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.splitContainer1.Size = new System.Drawing.Size(1235, 572);
            this.splitContainer1.SplitterDistance = 411;
            this.splitContainer1.TabIndex = 0;
            // 
            // OpenHelloForm
            // 
            this.OpenHelloForm.BackColor = System.Drawing.Color.Black;
            this.OpenHelloForm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.OpenHelloForm.Location = new System.Drawing.Point(21, 97);
            this.OpenHelloForm.Name = "OpenHelloForm";
            this.OpenHelloForm.Size = new System.Drawing.Size(92, 39);
            this.OpenHelloForm.TabIndex = 0;
            this.OpenHelloForm.Text = "01 Hello Form";
            this.OpenHelloForm.UseVisualStyleBackColor = false;
            this.OpenHelloForm.Click += new System.EventHandler(this.OpenHelloForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Jokerman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 70);
            this.label1.TabIndex = 9;
            this.label1.Text = "Home";
            // 
            // btnLoan
            // 
            this.btnLoan.BackColor = System.Drawing.Color.Black;
            this.btnLoan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLoan.Location = new System.Drawing.Point(21, 142);
            this.btnLoan.Name = "btnLoan";
            this.btnLoan.Size = new System.Drawing.Size(92, 39);
            this.btnLoan.TabIndex = 10;
            this.btnLoan.Text = "02 loan";
            this.btnLoan.UseVisualStyleBackColor = false;
            this.btnLoan.Click += new System.EventHandler(this.btnLoan_Click);
            // 
            // btnPOS
            // 
            this.btnPOS.BackColor = System.Drawing.Color.Black;
            this.btnPOS.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPOS.Location = new System.Drawing.Point(21, 187);
            this.btnPOS.Name = "btnPOS";
            this.btnPOS.Size = new System.Drawing.Size(92, 39);
            this.btnPOS.TabIndex = 11;
            this.btnPOS.Text = "03 POS";
            this.btnPOS.UseVisualStyleBackColor = false;
            this.btnPOS.Click += new System.EventHandler(this.btnPOS_Click);
            // 
            // btnStruct
            // 
            this.btnStruct.BackColor = System.Drawing.Color.Black;
            this.btnStruct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStruct.Location = new System.Drawing.Point(21, 232);
            this.btnStruct.Name = "btnStruct";
            this.btnStruct.Size = new System.Drawing.Size(92, 39);
            this.btnStruct.TabIndex = 12;
            this.btnStruct.Text = "04 Student_struct";
            this.btnStruct.UseVisualStyleBackColor = false;
            this.btnStruct.Click += new System.EventHandler(this.btnStruct_Click);
            // 
            // btnCal
            // 
            this.btnCal.BackColor = System.Drawing.Color.Black;
            this.btnCal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCal.Location = new System.Drawing.Point(21, 286);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(92, 39);
            this.btnCal.TabIndex = 13;
            this.btnCal.Text = "07 My Calculator";
            this.btnCal.UseVisualStyleBackColor = false;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // btnGN
            // 
            this.btnGN.BackColor = System.Drawing.Color.Black;
            this.btnGN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGN.Location = new System.Drawing.Point(21, 341);
            this.btnGN.Name = "btnGN";
            this.btnGN.Size = new System.Drawing.Size(92, 39);
            this.btnGN.TabIndex = 14;
            this.btnGN.Text = "13 Guess Number";
            this.btnGN.UseVisualStyleBackColor = false;
            this.btnGN.Click += new System.EventHandler(this.btnGN_Click);
            // 
            // btnOpenAlarm
            // 
            this.btnOpenAlarm.BackColor = System.Drawing.Color.Black;
            this.btnOpenAlarm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOpenAlarm.Location = new System.Drawing.Point(21, 386);
            this.btnOpenAlarm.Name = "btnOpenAlarm";
            this.btnOpenAlarm.Size = new System.Drawing.Size(92, 39);
            this.btnOpenAlarm.TabIndex = 15;
            this.btnOpenAlarm.Text = "14 Alarm";
            this.btnOpenAlarm.UseVisualStyleBackColor = false;
            this.btnOpenAlarm.Click += new System.EventHandler(this.btnOpenAlarm_Click);
            // 
            // FrmHome2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1235, 572);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmHome2";
            this.Text = "Home";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button OpenHelloForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoan;
        private System.Windows.Forms.Button btnPOS;
        private System.Windows.Forms.Button btnStruct;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Button btnGN;
        private System.Windows.Forms.Button btnOpenAlarm;
    }
}

