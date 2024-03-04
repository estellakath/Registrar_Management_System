namespace AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtloginusername = new System.Windows.Forms.TextBox();
            this.txtloginpass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.loginshowpass = new System.Windows.Forms.CheckBox();
            this.buttonloginacc = new System.Windows.Forms.Button();
            this.buttonsignup = new System.Windows.Forms.Button();
            this.loginexit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F);
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(306, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login Account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(308, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username:";
            // 
            // txtloginusername
            // 
            this.txtloginusername.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtloginusername.Location = new System.Drawing.Point(311, 198);
            this.txtloginusername.Multiline = true;
            this.txtloginusername.Name = "txtloginusername";
            this.txtloginusername.Size = new System.Drawing.Size(386, 30);
            this.txtloginusername.TabIndex = 2;
            // 
            // txtloginpass
            // 
            this.txtloginpass.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtloginpass.Location = new System.Drawing.Point(311, 287);
            this.txtloginpass.Multiline = true;
            this.txtloginpass.Name = "txtloginpass";
            this.txtloginpass.PasswordChar = '*';
            this.txtloginpass.Size = new System.Drawing.Size(386, 30);
            this.txtloginpass.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(308, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password:";
            // 
            // loginshowpass
            // 
            this.loginshowpass.AutoSize = true;
            this.loginshowpass.BackColor = System.Drawing.Color.Transparent;
            this.loginshowpass.Font = new System.Drawing.Font("Calibri", 7.8F);
            this.loginshowpass.ForeColor = System.Drawing.SystemColors.Control;
            this.loginshowpass.Location = new System.Drawing.Point(582, 323);
            this.loginshowpass.Name = "loginshowpass";
            this.loginshowpass.Size = new System.Drawing.Size(115, 19);
            this.loginshowpass.TabIndex = 5;
            this.loginshowpass.Text = "Show Password";
            this.loginshowpass.UseVisualStyleBackColor = false;
            this.loginshowpass.CheckedChanged += new System.EventHandler(this.loginshowpass_CheckedChanged);
            // 
            // buttonloginacc
            // 
            this.buttonloginacc.BackColor = System.Drawing.Color.Gold;
            this.buttonloginacc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonloginacc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonloginacc.Font = new System.Drawing.Font("Roboto Medium", 11F, System.Drawing.FontStyle.Bold);
            this.buttonloginacc.Location = new System.Drawing.Point(311, 366);
            this.buttonloginacc.Name = "buttonloginacc";
            this.buttonloginacc.Size = new System.Drawing.Size(123, 45);
            this.buttonloginacc.TabIndex = 6;
            this.buttonloginacc.Text = "LOGIN";
            this.buttonloginacc.UseVisualStyleBackColor = false;
            this.buttonloginacc.Click += new System.EventHandler(this.buttonloginacc_Click);
            // 
            // buttonsignup
            // 
            this.buttonsignup.BackColor = System.Drawing.Color.DarkBlue;
            this.buttonsignup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonsignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonsignup.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Bold);
            this.buttonsignup.ForeColor = System.Drawing.Color.Gold;
            this.buttonsignup.Location = new System.Drawing.Point(48, 381);
            this.buttonsignup.Name = "buttonsignup";
            this.buttonsignup.Size = new System.Drawing.Size(157, 38);
            this.buttonsignup.TabIndex = 7;
            this.buttonsignup.Text = "SIGN UP";
            this.buttonsignup.UseVisualStyleBackColor = false;
            this.buttonsignup.Click += new System.EventHandler(this.buttonsignup_Click);
            // 
            // loginexit
            // 
            this.loginexit.AutoSize = true;
            this.loginexit.BackColor = System.Drawing.Color.Transparent;
            this.loginexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.loginexit.ForeColor = System.Drawing.SystemColors.Control;
            this.loginexit.Location = new System.Drawing.Point(708, 9);
            this.loginexit.Name = "loginexit";
            this.loginexit.Size = new System.Drawing.Size(24, 24);
            this.loginexit.TabIndex = 19;
            this.loginexit.Text = "X";
            this.loginexit.Click += new System.EventHandler(this.loginexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(744, 447);
            this.Controls.Add(this.loginexit);
            this.Controls.Add(this.buttonsignup);
            this.Controls.Add(this.buttonloginacc);
            this.Controls.Add(this.loginshowpass);
            this.Controls.Add(this.txtloginpass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtloginusername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtloginusername;
        private System.Windows.Forms.TextBox txtloginpass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox loginshowpass;
        private System.Windows.Forms.Button buttonloginacc;
        private System.Windows.Forms.Button buttonsignup;
        private System.Windows.Forms.Label loginexit;
    }
}

