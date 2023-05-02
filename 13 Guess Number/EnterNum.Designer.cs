namespace _13_Guess_Number
{
    partial class EnterNum
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
            this.label1 = new System.Windows.Forms.Label();
            this.textGuessNum = new System.Windows.Forms.TextBox();
            this.btnGuessNum = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter a number.";
            // 
            // textGuessNum
            // 
            this.textGuessNum.Location = new System.Drawing.Point(33, 55);
            this.textGuessNum.Name = "textGuessNum";
            this.textGuessNum.Size = new System.Drawing.Size(176, 22);
            this.textGuessNum.TabIndex = 1;
            // 
            // btnGuessNum
            // 
            this.btnGuessNum.Location = new System.Drawing.Point(233, 51);
            this.btnGuessNum.Name = "btnGuessNum";
            this.btnGuessNum.Size = new System.Drawing.Size(69, 25);
            this.btnGuessNum.TabIndex = 2;
            this.btnGuessNum.Text = "Enter";
            this.btnGuessNum.UseVisualStyleBackColor = true;
            this.btnGuessNum.Click += new System.EventHandler(this.btnGuessNum_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(233, 82);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(69, 25);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // EnterNum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 164);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnGuessNum);
            this.Controls.Add(this.textGuessNum);
            this.Controls.Add(this.label1);
            this.Name = "EnterNum";
            this.Text = "EnterNum";
            this.Load += new System.EventHandler(this.EnterNum_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textGuessNum;
        private System.Windows.Forms.Button btnGuessNum;
        private System.Windows.Forms.Button btnCancel;
    }
}