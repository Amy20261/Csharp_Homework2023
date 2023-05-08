namespace _14_Alarm_clock
{
    partial class frmAlarm
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LabTime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Setted = new System.Windows.Forms.CheckBox();
            this.Sec = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.Min = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.Hour = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Sec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hour)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LabTime);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Setted);
            this.groupBox1.Controls.Add(this.Sec);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Min);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Hour);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(35, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 178);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Set Alarm";
            // 
            // LabTime
            // 
            this.LabTime.AutoSize = true;
            this.LabTime.Location = new System.Drawing.Point(128, 45);
            this.LabTime.Name = "LabTime";
            this.LabTime.Size = new System.Drawing.Size(27, 12);
            this.LabTime.TabIndex = 8;
            this.LabTime.Text = "Now";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(65, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Time:";
            // 
            // Setted
            // 
            this.Setted.AutoSize = true;
            this.Setted.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Setted.Location = new System.Drawing.Point(128, 140);
            this.Setted.Name = "Setted";
            this.Setted.Size = new System.Drawing.Size(73, 23);
            this.Setted.TabIndex = 6;
            this.Setted.Text = "Setted";
            this.Setted.UseVisualStyleBackColor = true;
            this.Setted.CheckedChanged += new System.EventHandler(this.Setted_CheckedChanged);
            // 
            // Sec
            // 
            this.Sec.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Sec.Location = new System.Drawing.Point(284, 86);
            this.Sec.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.Sec.Name = "Sec";
            this.Sec.Size = new System.Drawing.Size(51, 30);
            this.Sec.TabIndex = 5;
            this.Sec.ValueChanged += new System.EventHandler(this.Sec_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(263, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = ":";
            // 
            // Min
            // 
            this.Min.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Min.Location = new System.Drawing.Point(206, 85);
            this.Min.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(51, 30);
            this.Min.TabIndex = 3;
            this.Min.ValueChanged += new System.EventHandler(this.Min_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(185, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = ":";
            // 
            // Hour
            // 
            this.Hour.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Hour.Location = new System.Drawing.Point(128, 86);
            this.Hour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.Hour.Name = "Hour";
            this.Hour.Size = new System.Drawing.Size(51, 30);
            this.Hour.TabIndex = 1;
            this.Hour.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.Hour.ValueChanged += new System.EventHandler(this.Hour_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(14, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alarm time:";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 243);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAlarm";
            this.Text = "Alarm";
            this.Load += new System.EventHandler(this.Alarm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Sec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hour)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox Setted;
        private System.Windows.Forms.NumericUpDown Sec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Min;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Hour;
        private System.Windows.Forms.Label LabTime;
        private System.Windows.Forms.Timer timer1;
    }
}

