namespace HospitalAppointmentSystem
{
    partial class PharmacyManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PharmacyManager));
            this.manmedlabel = new System.Windows.Forms.Label();
            this.manphlabel = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Home = new System.Windows.Forms.ToolStripButton();
            this.contactus = new System.Windows.Forms.ToolStripButton();
            this.profile = new System.Windows.Forms.ToolStripSplitButton();
            this.viewProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitprogram = new System.Windows.Forms.ToolStripButton();
            this.greeting = new System.Windows.Forms.Label();
            this.manmed = new System.Windows.Forms.PictureBox();
            this.manph = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manmed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // manmedlabel
            // 
            this.manmedlabel.AutoSize = true;
            this.manmedlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manmedlabel.Location = new System.Drawing.Point(216, 257);
            this.manmedlabel.Name = "manmedlabel";
            this.manmedlabel.Size = new System.Drawing.Size(159, 22);
            this.manmedlabel.TabIndex = 68;
            this.manmedlabel.Text = "Manage Medicines";
            this.manmedlabel.Click += new System.EventHandler(this.manmedlabel_Click);
            this.manmedlabel.MouseHover += new System.EventHandler(this.manmedlabel_hover);
            // 
            // manphlabel
            // 
            this.manphlabel.AutoSize = true;
            this.manphlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manphlabel.Location = new System.Drawing.Point(216, 171);
            this.manphlabel.Name = "manphlabel";
            this.manphlabel.Size = new System.Drawing.Size(173, 22);
            this.manphlabel.TabIndex = 66;
            this.manphlabel.Text = "Manage Pharmacies";
            this.manphlabel.Click += new System.EventHandler(this.manphlabel_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Home,
            this.contactus,
            this.profile,
            this.exitprogram});
            this.toolStrip1.Location = new System.Drawing.Point(869, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(40, 468);
            this.toolStrip1.TabIndex = 70;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Home
            // 
            this.Home.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Home.Image = ((System.Drawing.Image)(resources.GetObject("Home.Image")));
            this.Home.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(37, 24);
            this.Home.Text = "home page";
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
            // profile
            // 
            this.profile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.profile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewProfileToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.profile.Image = ((System.Drawing.Image)(resources.GetObject("profile.Image")));
            this.profile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(37, 24);
            this.profile.Text = "Your profile";
            // 
            // viewProfileToolStripMenuItem
            // 
            this.viewProfileToolStripMenuItem.Name = "viewProfileToolStripMenuItem";
            this.viewProfileToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.viewProfileToolStripMenuItem.Text = "view profile";
            this.viewProfileToolStripMenuItem.Click += new System.EventHandler(this.viewProfileToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.logoutToolStripMenuItem.Text = "logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
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
            // greeting
            // 
            this.greeting.AutoSize = true;
            this.greeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greeting.Location = new System.Drawing.Point(159, 109);
            this.greeting.Name = "greeting";
            this.greeting.Size = new System.Drawing.Size(51, 22);
            this.greeting.TabIndex = 71;
            this.greeting.Text = "Hello";
            // 
            // manmed
            // 
            this.manmed.Image = ((System.Drawing.Image)(resources.GetObject("manmed.Image")));
            this.manmed.Location = new System.Drawing.Point(143, 242);
            this.manmed.Name = "manmed";
            this.manmed.Size = new System.Drawing.Size(67, 63);
            this.manmed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.manmed.TabIndex = 69;
            this.manmed.TabStop = false;
            this.manmed.Click += new System.EventHandler(this.manmed_Click);
            this.manmed.MouseHover += new System.EventHandler(this.manmed_hover);
            // 
            // manph
            // 
            this.manph.Image = ((System.Drawing.Image)(resources.GetObject("manph.Image")));
            this.manph.Location = new System.Drawing.Point(143, 153);
            this.manph.Name = "manph";
            this.manph.Size = new System.Drawing.Size(67, 63);
            this.manph.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.manph.TabIndex = 67;
            this.manph.TabStop = false;
            this.manph.Click += new System.EventHandler(this.manph_Click);
            this.manph.MouseHover += new System.EventHandler(this.manph_hover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // PharmacyManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(241)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(909, 468);
            this.Controls.Add(this.greeting);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.manmed);
            this.Controls.Add(this.manmedlabel);
            this.Controls.Add(this.manph);
            this.Controls.Add(this.manphlabel);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PharmacyManager";
            this.Text = "PharmacyManager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.phman_close);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manmed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox manmed;
        private System.Windows.Forms.Label manmedlabel;
        private System.Windows.Forms.PictureBox manph;
        private System.Windows.Forms.Label manphlabel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Home;
        private System.Windows.Forms.ToolStripButton contactus;
        private System.Windows.Forms.ToolStripSplitButton profile;
        private System.Windows.Forms.ToolStripMenuItem viewProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton exitprogram;
        private System.Windows.Forms.Label greeting;
    }
}