namespace HospitalAppointmentSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.Submit = new System.Windows.Forms.Button();
            this.genderlabel = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.ComboBox();
            this.Age = new System.Windows.Forms.TextBox();
            this.agelabel = new System.Windows.Forms.Label();
            this.confirmPass = new System.Windows.Forms.TextBox();
            this.conpasslabel = new System.Windows.Forms.Label();
            this.SetPassword = new System.Windows.Forms.TextBox();
            this.passuplabel = new System.Windows.Forms.Label();
            this.SignupEmail = new System.Windows.Forms.TextBox();
            this.Euplabel = new System.Windows.Forms.Label();
            this.LName = new System.Windows.Forms.TextBox();
            this.Fname = new System.Windows.Forms.TextBox();
            this.LNlabel = new System.Windows.Forms.Label();
            this.FNlabel = new System.Windows.Forms.Label();
            this.signuplabel = new System.Windows.Forms.Label();
            this.Eloglabel = new System.Windows.Forms.Label();
            this.log_in_here = new System.Windows.Forms.Button();
            this.showpass = new System.Windows.Forms.CheckBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.passloglabel = new System.Windows.Forms.Label();
            this.signup = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.contactus = new System.Windows.Forms.ToolStripButton();
            this.exitprogram = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.retlogin = new System.Windows.Forms.Button();
            this.retloginlabel = new System.Windows.Forms.Label();
            this.upshowpass = new System.Windows.Forms.CheckBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Submit
            // 
            this.Submit.Enabled = false;
            this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Submit.Location = new System.Drawing.Point(344, 382);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 28);
            this.Submit.TabIndex = 22;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Visible = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // genderlabel
            // 
            this.genderlabel.AutoSize = true;
            this.genderlabel.Enabled = false;
            this.genderlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderlabel.Location = new System.Drawing.Point(274, 322);
            this.genderlabel.Name = "genderlabel";
            this.genderlabel.Size = new System.Drawing.Size(64, 20);
            this.genderlabel.TabIndex = 21;
            this.genderlabel.Text = "Gender";
            this.genderlabel.Visible = false;
            // 
            // Gender
            // 
            this.Gender.Enabled = false;
            this.Gender.FormattingEnabled = true;
            this.Gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.Gender.Location = new System.Drawing.Point(354, 322);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(121, 24);
            this.Gender.TabIndex = 20;
            this.Gender.Visible = false;
            // 
            // Age
            // 
            this.Age.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Age.Enabled = false;
            this.Age.Location = new System.Drawing.Point(354, 280);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(45, 22);
            this.Age.TabIndex = 19;
            this.Age.Visible = false;
            // 
            // agelabel
            // 
            this.agelabel.AutoSize = true;
            this.agelabel.Enabled = false;
            this.agelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agelabel.Location = new System.Drawing.Point(274, 279);
            this.agelabel.Name = "agelabel";
            this.agelabel.Size = new System.Drawing.Size(38, 20);
            this.agelabel.TabIndex = 18;
            this.agelabel.Text = "Age";
            this.agelabel.Visible = false;
            this.agelabel.Click += new System.EventHandler(this.label9_Click);
            // 
            // confirmPass
            // 
            this.confirmPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.confirmPass.Enabled = false;
            this.confirmPass.Location = new System.Drawing.Point(448, 234);
            this.confirmPass.Name = "confirmPass";
            this.confirmPass.PasswordChar = '*';
            this.confirmPass.Size = new System.Drawing.Size(136, 22);
            this.confirmPass.TabIndex = 17;
            this.confirmPass.Visible = false;
            // 
            // conpasslabel
            // 
            this.conpasslabel.AutoSize = true;
            this.conpasslabel.Enabled = false;
            this.conpasslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conpasslabel.Location = new System.Drawing.Point(274, 233);
            this.conpasslabel.Name = "conpasslabel";
            this.conpasslabel.Size = new System.Drawing.Size(147, 20);
            this.conpasslabel.TabIndex = 16;
            this.conpasslabel.Text = "Confirm Password";
            this.conpasslabel.Visible = false;
            // 
            // SetPassword
            // 
            this.SetPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SetPassword.Enabled = false;
            this.SetPassword.Location = new System.Drawing.Point(448, 188);
            this.SetPassword.Name = "SetPassword";
            this.SetPassword.PasswordChar = '*';
            this.SetPassword.Size = new System.Drawing.Size(136, 22);
            this.SetPassword.TabIndex = 15;
            this.SetPassword.Visible = false;
            // 
            // passuplabel
            // 
            this.passuplabel.AutoSize = true;
            this.passuplabel.Enabled = false;
            this.passuplabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passuplabel.Location = new System.Drawing.Point(274, 187);
            this.passuplabel.Name = "passuplabel";
            this.passuplabel.Size = new System.Drawing.Size(83, 20);
            this.passuplabel.TabIndex = 14;
            this.passuplabel.Text = "Password";
            this.passuplabel.Visible = false;
            // 
            // SignupEmail
            // 
            this.SignupEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SignupEmail.Enabled = false;
            this.SignupEmail.Location = new System.Drawing.Point(448, 144);
            this.SignupEmail.Name = "SignupEmail";
            this.SignupEmail.Size = new System.Drawing.Size(136, 22);
            this.SignupEmail.TabIndex = 13;
            this.SignupEmail.Visible = false;
            // 
            // Euplabel
            // 
            this.Euplabel.AutoSize = true;
            this.Euplabel.Enabled = false;
            this.Euplabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Euplabel.Location = new System.Drawing.Point(274, 146);
            this.Euplabel.Name = "Euplabel";
            this.Euplabel.Size = new System.Drawing.Size(51, 20);
            this.Euplabel.TabIndex = 12;
            this.Euplabel.Text = "Email";
            this.Euplabel.Visible = false;
            // 
            // LName
            // 
            this.LName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LName.Enabled = false;
            this.LName.Location = new System.Drawing.Point(448, 101);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(136, 22);
            this.LName.TabIndex = 11;
            this.LName.Visible = false;
            // 
            // Fname
            // 
            this.Fname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Fname.Enabled = false;
            this.Fname.Location = new System.Drawing.Point(448, 61);
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(136, 22);
            this.Fname.TabIndex = 10;
            this.Fname.Visible = false;
            // 
            // LNlabel
            // 
            this.LNlabel.AutoSize = true;
            this.LNlabel.Enabled = false;
            this.LNlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNlabel.Location = new System.Drawing.Point(274, 101);
            this.LNlabel.Name = "LNlabel";
            this.LNlabel.Size = new System.Drawing.Size(91, 20);
            this.LNlabel.TabIndex = 9;
            this.LNlabel.Text = "Last Name";
            this.LNlabel.Visible = false;
            // 
            // FNlabel
            // 
            this.FNlabel.AutoSize = true;
            this.FNlabel.Enabled = false;
            this.FNlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FNlabel.Location = new System.Drawing.Point(274, 61);
            this.FNlabel.Name = "FNlabel";
            this.FNlabel.Size = new System.Drawing.Size(92, 20);
            this.FNlabel.TabIndex = 8;
            this.FNlabel.Text = "First Name";
            this.FNlabel.Visible = false;
            // 
            // signuplabel
            // 
            this.signuplabel.AutoSize = true;
            this.signuplabel.Location = new System.Drawing.Point(472, 425);
            this.signuplabel.Name = "signuplabel";
            this.signuplabel.Size = new System.Drawing.Size(326, 16);
            this.signuplabel.TabIndex = 7;
            this.signuplabel.Text = "If you don\'t have an account you can sign up from here";
            // 
            // Eloglabel
            // 
            this.Eloglabel.AutoSize = true;
            this.Eloglabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eloglabel.Location = new System.Drawing.Point(234, 178);
            this.Eloglabel.Name = "Eloglabel";
            this.Eloglabel.Size = new System.Drawing.Size(51, 20);
            this.Eloglabel.TabIndex = 0;
            this.Eloglabel.Text = "Email";
            // 
            // log_in_here
            // 
            this.log_in_here.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.log_in_here.Location = new System.Drawing.Point(291, 267);
            this.log_in_here.Name = "log_in_here";
            this.log_in_here.Size = new System.Drawing.Size(75, 28);
            this.log_in_here.TabIndex = 5;
            this.log_in_here.Text = "login";
            this.log_in_here.UseVisualStyleBackColor = true;
            this.log_in_here.Click += new System.EventHandler(this.log_in_here_Click);
            // 
            // showpass
            // 
            this.showpass.AutoSize = true;
            this.showpass.Location = new System.Drawing.Point(546, 219);
            this.showpass.Name = "showpass";
            this.showpass.Size = new System.Drawing.Size(122, 20);
            this.showpass.TabIndex = 4;
            this.showpass.Text = "show password";
            this.showpass.UseVisualStyleBackColor = true;
            this.showpass.CheckedChanged += new System.EventHandler(this.showpass_CheckedChanged);
            // 
            // Password
            // 
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(291, 220);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(249, 24);
            this.Password.TabIndex = 3;
            // 
            // Email
            // 
            this.Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Email.Location = new System.Drawing.Point(291, 178);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(249, 22);
            this.Email.TabIndex = 2;
            // 
            // passloglabel
            // 
            this.passloglabel.AutoSize = true;
            this.passloglabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passloglabel.Location = new System.Drawing.Point(202, 219);
            this.passloglabel.Name = "passloglabel";
            this.passloglabel.Size = new System.Drawing.Size(83, 20);
            this.passloglabel.TabIndex = 1;
            this.passloglabel.Text = "Password";
            // 
            // signup
            // 
            this.signup.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.signup.Location = new System.Drawing.Point(827, 419);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(75, 28);
            this.signup.TabIndex = 23;
            this.signup.Text = "sign up";
            this.signup.UseVisualStyleBackColor = true;
            this.signup.Click += new System.EventHandler(this.signup_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contactus,
            this.exitprogram});
            this.toolStrip1.Location = new System.Drawing.Point(929, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(40, 476);
            this.toolStrip1.TabIndex = 25;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // contactus
            // 
            this.contactus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.contactus.Image = ((System.Drawing.Image)(resources.GetObject("contactus.Image")));
            this.contactus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.contactus.Name = "contactus";
            this.contactus.Size = new System.Drawing.Size(37, 24);
            this.contactus.Text = "contact us";
            this.contactus.Click += new System.EventHandler(this.contactus_Click);
            // 
            // exitprogram
            // 
            this.exitprogram.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.exitprogram.Image = ((System.Drawing.Image)(resources.GetObject("exitprogram.Image")));
            this.exitprogram.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exitprogram.Name = "exitprogram";
            this.exitprogram.Size = new System.Drawing.Size(37, 24);
            this.exitprogram.Text = "exit";
            this.exitprogram.Click += new System.EventHandler(this.exitprogram_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // retlogin
            // 
            this.retlogin.Enabled = false;
            this.retlogin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.retlogin.Location = new System.Drawing.Point(827, 394);
            this.retlogin.Name = "retlogin";
            this.retlogin.Size = new System.Drawing.Size(75, 28);
            this.retlogin.TabIndex = 36;
            this.retlogin.Text = "login";
            this.retlogin.UseVisualStyleBackColor = true;
            this.retlogin.Visible = false;
            this.retlogin.Click += new System.EventHandler(this.retlogin_Click);
            // 
            // retloginlabel
            // 
            this.retloginlabel.AutoSize = true;
            this.retloginlabel.Enabled = false;
            this.retloginlabel.Location = new System.Drawing.Point(671, 400);
            this.retloginlabel.Name = "retloginlabel";
            this.retloginlabel.Size = new System.Drawing.Size(127, 16);
            this.retloginlabel.TabIndex = 35;
            this.retloginlabel.Text = "Return to login page";
            this.retloginlabel.Visible = false;
            // 
            // upshowpass
            // 
            this.upshowpass.AutoSize = true;
            this.upshowpass.Enabled = false;
            this.upshowpass.Location = new System.Drawing.Point(599, 188);
            this.upshowpass.Name = "upshowpass";
            this.upshowpass.Size = new System.Drawing.Size(122, 20);
            this.upshowpass.TabIndex = 37;
            this.upshowpass.Text = "show password";
            this.upshowpass.UseVisualStyleBackColor = true;
            this.upshowpass.Visible = false;
            this.upshowpass.CheckedChanged += new System.EventHandler(this.upshowpass_CheckedChanged);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(241)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(969, 476);
            this.Controls.Add(this.upshowpass);
            this.Controls.Add(this.retlogin);
            this.Controls.Add(this.retloginlabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.signup);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.genderlabel);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.agelabel);
            this.Controls.Add(this.confirmPass);
            this.Controls.Add(this.conpasslabel);
            this.Controls.Add(this.SetPassword);
            this.Controls.Add(this.passuplabel);
            this.Controls.Add(this.SignupEmail);
            this.Controls.Add(this.Euplabel);
            this.Controls.Add(this.LName);
            this.Controls.Add(this.Fname);
            this.Controls.Add(this.LNlabel);
            this.Controls.Add(this.FNlabel);
            this.Controls.Add(this.signuplabel);
            this.Controls.Add(this.log_in_here);
            this.Controls.Add(this.showpass);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.passloglabel);
            this.Controls.Add(this.Eloglabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "login";
            this.Text = "login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.login_close);
            this.Load += new System.EventHandler(this.login_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label genderlabel;
        private System.Windows.Forms.ComboBox Gender;
        private System.Windows.Forms.TextBox Age;
        private System.Windows.Forms.Label agelabel;
        private System.Windows.Forms.TextBox confirmPass;
        private System.Windows.Forms.Label conpasslabel;
        private System.Windows.Forms.TextBox SetPassword;
        private System.Windows.Forms.Label passuplabel;
        private System.Windows.Forms.TextBox SignupEmail;
        private System.Windows.Forms.Label Euplabel;
        private System.Windows.Forms.TextBox LName;
        private System.Windows.Forms.TextBox Fname;
        private System.Windows.Forms.Label LNlabel;
        private System.Windows.Forms.Label FNlabel;
        private System.Windows.Forms.Label signuplabel;
        private System.Windows.Forms.Label Eloglabel;
        private System.Windows.Forms.Button log_in_here;
        private System.Windows.Forms.CheckBox showpass;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label passloglabel;
        private System.Windows.Forms.Button signup;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton contactus;
        private System.Windows.Forms.ToolStripButton exitprogram;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button retlogin;
        private System.Windows.Forms.Label retloginlabel;
        private System.Windows.Forms.CheckBox upshowpass;
    }
}