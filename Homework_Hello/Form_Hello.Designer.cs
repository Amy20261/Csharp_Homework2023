namespace Homework_Hello
{
    partial class frmHello
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHello));
            this.lab_cName = new System.Windows.Forms.Label();
            this.text_cname = new System.Windows.Forms.TextBox();
            this.text_ename = new System.Windows.Forms.TextBox();
            this.lab_eName = new System.Windows.Forms.Label();
            this.text_sign = new System.Windows.Forms.TextBox();
            this.lab_sign = new System.Windows.Forms.Label();
            this.text_gender = new System.Windows.Forms.TextBox();
            this.lab_gender = new System.Windows.Forms.Label();
            this.button_say_hello = new System.Windows.Forms.Button();
            this.button_say_hi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lab_cName
            // 
            this.lab_cName.AutoSize = true;
            this.lab_cName.BackColor = System.Drawing.Color.Transparent;
            this.lab_cName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lab_cName.Location = new System.Drawing.Point(86, 134);
            this.lab_cName.Name = "lab_cName";
            this.lab_cName.Size = new System.Drawing.Size(32, 12);
            this.lab_cName.TabIndex = 0;
            this.lab_cName.Text = "姓名:";
            // 
            // text_cname
            // 
            this.text_cname.Location = new System.Drawing.Point(146, 134);
            this.text_cname.Name = "text_cname";
            this.text_cname.Size = new System.Drawing.Size(100, 22);
            this.text_cname.TabIndex = 2;
            // 
            // text_ename
            // 
            this.text_ename.Location = new System.Drawing.Point(146, 162);
            this.text_ename.Name = "text_ename";
            this.text_ename.Size = new System.Drawing.Size(100, 22);
            this.text_ename.TabIndex = 4;
            // 
            // lab_eName
            // 
            this.lab_eName.AutoSize = true;
            this.lab_eName.BackColor = System.Drawing.Color.Transparent;
            this.lab_eName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lab_eName.Location = new System.Drawing.Point(86, 162);
            this.lab_eName.Name = "lab_eName";
            this.lab_eName.Size = new System.Drawing.Size(35, 12);
            this.lab_eName.TabIndex = 3;
            this.lab_eName.Text = "Name:";
            // 
            // text_sign
            // 
            this.text_sign.Location = new System.Drawing.Point(146, 218);
            this.text_sign.Name = "text_sign";
            this.text_sign.Size = new System.Drawing.Size(100, 22);
            this.text_sign.TabIndex = 6;
            // 
            // lab_sign
            // 
            this.lab_sign.AutoSize = true;
            this.lab_sign.BackColor = System.Drawing.Color.Transparent;
            this.lab_sign.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lab_sign.Location = new System.Drawing.Point(86, 218);
            this.lab_sign.Name = "lab_sign";
            this.lab_sign.Size = new System.Drawing.Size(32, 12);
            this.lab_sign.TabIndex = 5;
            this.lab_sign.Text = "星座:";
            // 
            // text_gender
            // 
            this.text_gender.Location = new System.Drawing.Point(146, 190);
            this.text_gender.Name = "text_gender";
            this.text_gender.Size = new System.Drawing.Size(100, 22);
            this.text_gender.TabIndex = 8;
            // 
            // lab_gender
            // 
            this.lab_gender.AutoSize = true;
            this.lab_gender.BackColor = System.Drawing.Color.Transparent;
            this.lab_gender.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lab_gender.Location = new System.Drawing.Point(86, 190);
            this.lab_gender.Name = "lab_gender";
            this.lab_gender.Size = new System.Drawing.Size(32, 12);
            this.lab_gender.TabIndex = 7;
            this.lab_gender.Text = "性別:";
            // 
            // button_say_hello
            // 
            this.button_say_hello.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_say_hello.Image = ((System.Drawing.Image)(resources.GetObject("button_say_hello.Image")));
            this.button_say_hello.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_say_hello.Location = new System.Drawing.Point(60, 263);
            this.button_say_hello.Name = "button_say_hello";
            this.button_say_hello.Size = new System.Drawing.Size(114, 23);
            this.button_say_hello.TabIndex = 9;
            this.button_say_hello.Text = "Say Hello!";
            this.button_say_hello.UseVisualStyleBackColor = true;
            this.button_say_hello.Click += new System.EventHandler(this.button_say_hello_Click);
            // 
            // button_say_hi
            // 
            this.button_say_hi.Image = ((System.Drawing.Image)(resources.GetObject("button_say_hi.Image")));
            this.button_say_hi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_say_hi.Location = new System.Drawing.Point(180, 263);
            this.button_say_hi.Name = "button_say_hi";
            this.button_say_hi.Size = new System.Drawing.Size(114, 23);
            this.button_say_hi.TabIndex = 10;
            this.button_say_hi.Text = "Say Hi!";
            this.button_say_hi.UseVisualStyleBackColor = true;
            this.button_say_hi.Click += new System.EventHandler(this.button_say_hi_Click);
            // 
            // frmHello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(836, 449);
            this.Controls.Add(this.button_say_hi);
            this.Controls.Add(this.button_say_hello);
            this.Controls.Add(this.text_gender);
            this.Controls.Add(this.lab_gender);
            this.Controls.Add(this.text_sign);
            this.Controls.Add(this.lab_sign);
            this.Controls.Add(this.text_ename);
            this.Controls.Add(this.lab_eName);
            this.Controls.Add(this.text_cname);
            this.Controls.Add(this.lab_cName);
            this.Name = "frmHello";
            this.Text = "Hello Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_cName;
        private System.Windows.Forms.TextBox text_cname;
        private System.Windows.Forms.TextBox text_ename;
        private System.Windows.Forms.Label lab_eName;
        private System.Windows.Forms.TextBox text_sign;
        private System.Windows.Forms.Label lab_sign;
        private System.Windows.Forms.TextBox text_gender;
        private System.Windows.Forms.Label lab_gender;
        private System.Windows.Forms.Button button_say_hello;
        private System.Windows.Forms.Button button_say_hi;
    }
}

