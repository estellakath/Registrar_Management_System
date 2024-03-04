namespace AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.buttonsignin = new System.Windows.Forms.Button();
            this.buttonsignup = new System.Windows.Forms.Button();
            this.signupshowpass = new System.Windows.Forms.CheckBox();
            this.signupusername = new System.Windows.Forms.TextBox();
            this.lblusername = new System.Windows.Forms.Label();
            this.signupemail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.signuppass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.signupexit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonsignin
            // 
            this.buttonsignin.BackColor = System.Drawing.Color.DarkBlue;
            this.buttonsignin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonsignin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonsignin.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Bold);
            this.buttonsignin.ForeColor = System.Drawing.Color.Gold;
            this.buttonsignin.Location = new System.Drawing.Point(42, 372);
            this.buttonsignin.Name = "buttonsignin";
            this.buttonsignin.Size = new System.Drawing.Size(157, 38);
            this.buttonsignin.TabIndex = 15;
            this.buttonsignin.Text = "LOGIN";
            this.buttonsignin.UseVisualStyleBackColor = false;
            this.buttonsignin.Click += new System.EventHandler(this.buttonsignin_Click);
            // 
            // buttonsignup
            // 
            this.buttonsignup.BackColor = System.Drawing.Color.Gold;
            this.buttonsignup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonsignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonsignup.Font = new System.Drawing.Font("Roboto Medium", 11F, System.Drawing.FontStyle.Bold);
            this.buttonsignup.ForeColor = System.Drawing.Color.DarkBlue;
            this.buttonsignup.Location = new System.Drawing.Point(306, 373);
            this.buttonsignup.Name = "buttonsignup";
            this.buttonsignup.Size = new System.Drawing.Size(123, 45);
            this.buttonsignup.TabIndex = 14;
            this.buttonsignup.Text = "SIGN UP";
            this.buttonsignup.UseVisualStyleBackColor = false;
            this.buttonsignup.Click += new System.EventHandler(this.buttonlogin_Click);
            // 
            // signupshowpass
            // 
            this.signupshowpass.AutoSize = true;
            this.signupshowpass.BackColor = System.Drawing.Color.Transparent;
            this.signupshowpass.Font = new System.Drawing.Font("Calibri", 7.8F);
            this.signupshowpass.ForeColor = System.Drawing.SystemColors.Control;
            this.signupshowpass.Location = new System.Drawing.Point(578, 343);
            this.signupshowpass.Name = "signupshowpass";
            this.signupshowpass.Size = new System.Drawing.Size(115, 19);
            this.signupshowpass.TabIndex = 13;
            this.signupshowpass.Text = "Show Password";
            this.signupshowpass.UseVisualStyleBackColor = false;
            this.signupshowpass.CheckedChanged += new System.EventHandler(this.signupshowpass_CheckedChanged);
            // 
            // signupusername
            // 
            this.signupusername.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupusername.Location = new System.Drawing.Point(307, 220);
            this.signupusername.Multiline = true;
            this.signupusername.Name = "signupusername";
            this.signupusername.Size = new System.Drawing.Size(386, 30);
            this.signupusername.TabIndex = 12;
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.BackColor = System.Drawing.Color.Transparent;
            this.lblusername.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.lblusername.ForeColor = System.Drawing.SystemColors.Control;
            this.lblusername.Location = new System.Drawing.Point(304, 183);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(91, 21);
            this.lblusername.TabIndex = 11;
            this.lblusername.Text = "Username:";
            // 
            // signupemail
            // 
            this.signupemail.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupemail.Location = new System.Drawing.Point(307, 131);
            this.signupemail.Multiline = true;
            this.signupemail.Name = "signupemail";
            this.signupemail.Size = new System.Drawing.Size(386, 30);
            this.signupemail.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(304, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Email Address:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F);
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(300, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Register Account";
            // 
            // signuppass
            // 
            this.signuppass.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signuppass.Location = new System.Drawing.Point(306, 307);
            this.signuppass.Multiline = true;
            this.signuppass.Name = "signuppass";
            this.signuppass.PasswordChar = '*';
            this.signuppass.Size = new System.Drawing.Size(386, 30);
            this.signuppass.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(303, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 21);
            this.label4.TabIndex = 16;
            this.label4.Text = "Password:";
            // 
            // signupexit
            // 
            this.signupexit.AutoSize = true;
            this.signupexit.BackColor = System.Drawing.Color.Transparent;
            this.signupexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.signupexit.ForeColor = System.Drawing.SystemColors.Control;
            this.signupexit.Location = new System.Drawing.Point(708, 9);
            this.signupexit.Name = "signupexit";
            this.signupexit.Size = new System.Drawing.Size(24, 24);
            this.signupexit.TabIndex = 18;
            this.signupexit.Text = "X";
            this.signupexit.Click += new System.EventHandler(this.signupexit_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(744, 447);
            this.Controls.Add(this.signupexit);
            this.Controls.Add(this.signuppass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonsignin);
            this.Controls.Add(this.buttonsignup);
            this.Controls.Add(this.signupshowpass);
            this.Controls.Add(this.signupusername);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.signupemail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonsignin;
        private System.Windows.Forms.Button buttonsignup;
        private System.Windows.Forms.CheckBox signupshowpass;
        private System.Windows.Forms.TextBox signupusername;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.TextBox signupemail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox signuppass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label signupexit;
    }
}