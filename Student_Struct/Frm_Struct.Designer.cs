namespace Student_Struct
{
    partial class FrmStruct
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
            this.labName = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textChinese = new System.Windows.Forms.TextBox();
            this.labChinese = new System.Windows.Forms.Label();
            this.textEnglish = new System.Windows.Forms.TextBox();
            this.labEnglish = new System.Windows.Forms.Label();
            this.textMath = new System.Windows.Forms.TextBox();
            this.labMath = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textScore = new System.Windows.Forms.TextBox();
            this.textShow = new System.Windows.Forms.TextBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(34, 40);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(35, 12);
            this.labName.TabIndex = 0;
            this.labName.Text = "Name:";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(82, 38);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 22);
            this.textName.TabIndex = 1;
            // 
            // textChinese
            // 
            this.textChinese.Location = new System.Drawing.Point(82, 91);
            this.textChinese.Name = "textChinese";
            this.textChinese.Size = new System.Drawing.Size(100, 22);
            this.textChinese.TabIndex = 3;
            this.textChinese.Text = "0";
            // 
            // labChinese
            // 
            this.labChinese.AutoSize = true;
            this.labChinese.Location = new System.Drawing.Point(34, 93);
            this.labChinese.Name = "labChinese";
            this.labChinese.Size = new System.Drawing.Size(45, 12);
            this.labChinese.TabIndex = 2;
            this.labChinese.Text = "Chinese:";
            // 
            // textEnglish
            // 
            this.textEnglish.Location = new System.Drawing.Point(82, 125);
            this.textEnglish.Name = "textEnglish";
            this.textEnglish.Size = new System.Drawing.Size(100, 22);
            this.textEnglish.TabIndex = 5;
            this.textEnglish.Text = "0";
            // 
            // labEnglish
            // 
            this.labEnglish.AutoSize = true;
            this.labEnglish.Location = new System.Drawing.Point(34, 127);
            this.labEnglish.Name = "labEnglish";
            this.labEnglish.Size = new System.Drawing.Size(43, 12);
            this.labEnglish.TabIndex = 4;
            this.labEnglish.Text = "English:";
            // 
            // textMath
            // 
            this.textMath.Location = new System.Drawing.Point(82, 156);
            this.textMath.Name = "textMath";
            this.textMath.Size = new System.Drawing.Size(100, 22);
            this.textMath.TabIndex = 7;
            this.textMath.Text = "0";
            // 
            // labMath
            // 
            this.labMath.AutoSize = true;
            this.labMath.BackColor = System.Drawing.SystemColors.Control;
            this.labMath.Location = new System.Drawing.Point(34, 158);
            this.labMath.Name = "labMath";
            this.labMath.Size = new System.Drawing.Size(32, 12);
            this.labMath.TabIndex = 6;
            this.labMath.Text = "Math:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(21, 200);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 41);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(120, 200);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(93, 41);
            this.btnDisplay.TabIndex = 9;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textScore);
            this.groupBox1.Controls.Add(this.textShow);
            this.groupBox1.Location = new System.Drawing.Point(251, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 208);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grade";
            // 
            // textScore
            // 
            this.textScore.Location = new System.Drawing.Point(12, 144);
            this.textScore.Multiline = true;
            this.textScore.Name = "textScore";
            this.textScore.Size = new System.Drawing.Size(205, 52);
            this.textScore.TabIndex = 1;
            // 
            // textShow
            // 
            this.textShow.Location = new System.Drawing.Point(12, 15);
            this.textShow.Multiline = true;
            this.textShow.Name = "textShow";
            this.textShow.Size = new System.Drawing.Size(205, 123);
            this.textShow.TabIndex = 0;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(315, 246);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(153, 41);
            this.btnSort.TabIndex = 11;
            this.btnSort.Text = "Highest or lowest score";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // FrmStruct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 296);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textMath);
            this.Controls.Add(this.labMath);
            this.Controls.Add(this.textEnglish);
            this.Controls.Add(this.labEnglish);
            this.Controls.Add(this.textChinese);
            this.Controls.Add(this.labChinese);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.labName);
            this.Name = "FrmStruct";
            this.Text = "Student Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textChinese;
        private System.Windows.Forms.Label labChinese;
        private System.Windows.Forms.TextBox textEnglish;
        private System.Windows.Forms.Label labEnglish;
        private System.Windows.Forms.TextBox textMath;
        private System.Windows.Forms.Label labMath;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textScore;
        private System.Windows.Forms.TextBox textShow;
        private System.Windows.Forms.Button btnSort;
    }
}

