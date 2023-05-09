namespace LibraryMS
{
    partial class login
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
            this.panllogin = new System.Windows.Forms.Panel();
            this.clodebtn = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.Label();
            this.pnlpassword = new System.Windows.Forms.Panel();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.Label();
            this.panlusername = new System.Windows.Forms.Panel();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panl = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panllogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clodebtn)).BeginInit();
            this.pnlpassword.SuspendLayout();
            this.panlusername.SuspendLayout();
            this.panl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panllogin
            // 
            this.panllogin.Controls.Add(this.clodebtn);
            this.panllogin.Controls.Add(this.label3);
            this.panllogin.Controls.Add(this.btnLogin);
            this.panllogin.Controls.Add(this.password);
            this.panllogin.Controls.Add(this.pnlpassword);
            this.panllogin.Controls.Add(this.username);
            this.panllogin.Controls.Add(this.panlusername);
            this.panllogin.Controls.Add(this.label2);
            this.panllogin.Location = new System.Drawing.Point(231, 5);
            this.panllogin.Margin = new System.Windows.Forms.Padding(0);
            this.panllogin.Name = "panllogin";
            this.panllogin.Size = new System.Drawing.Size(259, 345);
            this.panllogin.TabIndex = 0;
            // 
            // clodebtn
            // 
            this.clodebtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.clodebtn.Image = global::LibraryMS.Properties.Resources.close;
            this.clodebtn.Location = new System.Drawing.Point(229, 0);
            this.clodebtn.Margin = new System.Windows.Forms.Padding(0);
            this.clodebtn.Name = "clodebtn";
            this.clodebtn.Size = new System.Drawing.Size(30, 25);
            this.clodebtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.clodebtn.TabIndex = 7;
            this.clodebtn.TabStop = false;
            this.clodebtn.Click += new System.EventHandler(this.clodebtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(330, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Don\'t have an Account?";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(76, 235);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(103, 31);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(20, 162);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(160, 38);
            this.password.TabIndex = 3;
            this.password.Text = "Password";
            // 
            // pnlpassword
            // 
            this.pnlpassword.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlpassword.Controls.Add(this.txtpassword);
            this.pnlpassword.ForeColor = System.Drawing.Color.White;
            this.pnlpassword.Location = new System.Drawing.Point(24, 186);
            this.pnlpassword.Name = "pnlpassword";
            this.pnlpassword.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.pnlpassword.Size = new System.Drawing.Size(216, 29);
            this.pnlpassword.TabIndex = 2;
            // 
            // txtpassword
            // 
            this.txtpassword.BackColor = System.Drawing.Color.White;
            this.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtpassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtpassword.Location = new System.Drawing.Point(0, 0);
            this.txtpassword.Multiline = true;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(216, 26);
            this.txtpassword.TabIndex = 0;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(19, 87);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(186, 38);
            this.username.TabIndex = 2;
            this.username.Text = "User Name";
            // 
            // panlusername
            // 
            this.panlusername.BackColor = System.Drawing.Color.DodgerBlue;
            this.panlusername.Controls.Add(this.txtusername);
            this.panlusername.ForeColor = System.Drawing.Color.White;
            this.panlusername.Location = new System.Drawing.Point(23, 111);
            this.panlusername.Name = "panlusername";
            this.panlusername.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.panlusername.Size = new System.Drawing.Size(216, 29);
            this.panlusername.TabIndex = 1;
            // 
            // txtusername
            // 
            this.txtusername.BackColor = System.Drawing.Color.White;
            this.txtusername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtusername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtusername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtusername.Location = new System.Drawing.Point(0, 0);
            this.txtusername.Multiline = true;
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(216, 26);
            this.txtusername.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 56);
            this.label2.TabIndex = 0;
            this.label2.Text = "Login";
            // 
            // panl
            // 
            this.panl.BackColor = System.Drawing.Color.DodgerBlue;
            this.panl.Controls.Add(this.label1);
            this.panl.Controls.Add(this.pictureBox1);
            this.panl.ForeColor = System.Drawing.Color.White;
            this.panl.Location = new System.Drawing.Point(5, 5);
            this.panl.Margin = new System.Windows.Forms.Padding(0);
            this.panl.Name = "panl";
            this.panl.Size = new System.Drawing.Size(226, 345);
            this.panl.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 88);
            this.label1.TabIndex = 1;
            this.label1.Text = "Library Managment\r\n System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox1.Image = global::LibraryMS.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(56, 88);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(497, 355);
            this.Controls.Add(this.panl);
            this.Controls.Add(this.panllogin);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DodgerBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.login_Load);
            this.panllogin.ResumeLayout(false);
            this.panllogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clodebtn)).EndInit();
            this.pnlpassword.ResumeLayout(false);
            this.pnlpassword.PerformLayout();
            this.panlusername.ResumeLayout(false);
            this.panlusername.PerformLayout();
            this.panl.ResumeLayout(false);
            this.panl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panllogin;
        private System.Windows.Forms.Panel panl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Panel panlusername;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Panel pnlpassword;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox clodebtn;
    }
}

