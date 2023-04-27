namespace POS
{
    partial class frmPOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPOS));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnWine = new System.Windows.Forms.Button();
            this.btnWhisky = new System.Windows.Forms.Button();
            this.btnTaquila = new System.Windows.Forms.Button();
            this.btnBeer = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labPayment = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCard = new System.Windows.Forms.Button();
            this.btnCash = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.textPurchase = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnWine);
            this.groupBox1.Controls.Add(this.btnWhisky);
            this.groupBox1.Controls.Add(this.btnTaquila);
            this.groupBox1.Controls.Add(this.btnBeer);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 379);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // btnWine
            // 
            this.btnWine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWine.BackgroundImage")));
            this.btnWine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnWine.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnWine.Location = new System.Drawing.Point(189, 196);
            this.btnWine.Name = "btnWine";
            this.btnWine.Size = new System.Drawing.Size(157, 161);
            this.btnWine.TabIndex = 5;
            this.btnWine.Text = "wine NT 320";
            this.btnWine.UseVisualStyleBackColor = true;
            this.btnWine.Click += new System.EventHandler(this.btnWine_Click);
            // 
            // btnWhisky
            // 
            this.btnWhisky.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWhisky.BackgroundImage")));
            this.btnWhisky.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnWhisky.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnWhisky.Location = new System.Drawing.Point(16, 196);
            this.btnWhisky.Name = "btnWhisky";
            this.btnWhisky.Size = new System.Drawing.Size(157, 161);
            this.btnWhisky.TabIndex = 4;
            this.btnWhisky.Text = "Whisky NT350";
            this.btnWhisky.UseVisualStyleBackColor = true;
            this.btnWhisky.Click += new System.EventHandler(this.btnWhisky_Click);
            // 
            // btnTaquila
            // 
            this.btnTaquila.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTaquila.BackgroundImage")));
            this.btnTaquila.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTaquila.Location = new System.Drawing.Point(189, 29);
            this.btnTaquila.Name = "btnTaquila";
            this.btnTaquila.Size = new System.Drawing.Size(157, 161);
            this.btnTaquila.TabIndex = 3;
            this.btnTaquila.Text = "Taquila NT180";
            this.btnTaquila.UseVisualStyleBackColor = true;
            this.btnTaquila.Click += new System.EventHandler(this.btnTaquila_Click);
            // 
            // btnBeer
            // 
            this.btnBeer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBeer.BackgroundImage")));
            this.btnBeer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBeer.Location = new System.Drawing.Point(16, 29);
            this.btnBeer.Name = "btnBeer";
            this.btnBeer.Size = new System.Drawing.Size(157, 161);
            this.btnBeer.TabIndex = 2;
            this.btnBeer.Text = "Beer NT120";
            this.btnBeer.UseVisualStyleBackColor = true;
            this.btnBeer.Click += new System.EventHandler(this.btnBeer_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labPayment);
            this.groupBox2.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(388, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payment";
            // 
            // labPayment
            // 
            this.labPayment.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labPayment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labPayment.Location = new System.Drawing.Point(15, 38);
            this.labPayment.Name = "labPayment";
            this.labPayment.Size = new System.Drawing.Size(169, 42);
            this.labPayment.TabIndex = 0;
            this.labPayment.Text = "NT 0";
            this.labPayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btnCard);
            this.groupBox3.Controls.Add(this.btnCash);
            this.groupBox3.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox3.Location = new System.Drawing.Point(388, 208);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(196, 109);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Payment term";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "10% off by card.";
            // 
            // btnCard
            // 
            this.btnCard.Location = new System.Drawing.Point(96, 29);
            this.btnCard.Name = "btnCard";
            this.btnCard.Size = new System.Drawing.Size(75, 36);
            this.btnCard.TabIndex = 1;
            this.btnCard.Text = "Card";
            this.btnCard.UseVisualStyleBackColor = true;
            this.btnCard.Click += new System.EventHandler(this.btnCard_Click);
            // 
            // btnCash
            // 
            this.btnCash.Location = new System.Drawing.Point(15, 29);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(75, 36);
            this.btnCash.TabIndex = 0;
            this.btnCash.Text = "Cash";
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnClear);
            this.groupBox4.Controls.Add(this.textPurchase);
            this.groupBox4.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox4.Location = new System.Drawing.Point(600, 23);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(251, 367);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Purchase list";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(157, 310);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 36);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // textPurchase
            // 
            this.textPurchase.Location = new System.Drawing.Point(16, 33);
            this.textPurchase.Multiline = true;
            this.textPurchase.Name = "textPurchase";
            this.textPurchase.Size = new System.Drawing.Size(216, 261);
            this.textPurchase.TabIndex = 0;
            // 
            // frmPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 401);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPOS";
            this.Text = "Bar POS";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnWine;
        private System.Windows.Forms.Button btnWhisky;
        private System.Windows.Forms.Button btnTaquila;
        private System.Windows.Forms.Button btnBeer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labPayment;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCard;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox textPurchase;
    }
}