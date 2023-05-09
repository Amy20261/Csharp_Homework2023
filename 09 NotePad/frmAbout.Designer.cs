namespace _09_NotePad
{
    partial class frmAbout
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
            this.AboutTile = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AboutTile
            // 
            this.AboutTile.AutoSize = true;
            this.AboutTile.Location = new System.Drawing.Point(22, 32);
            this.AboutTile.Name = "AboutTile";
            this.AboutTile.Size = new System.Drawing.Size(65, 12);
            this.AboutTile.TabIndex = 0;
            this.AboutTile.Text = "關於我版權";
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 187);
            this.Controls.Add(this.AboutTile);
            this.Name = "frmAbout";
            this.Text = "關於";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AboutTile;
    }
}