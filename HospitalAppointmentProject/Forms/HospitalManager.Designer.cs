namespace HospitalAppointmentSystem
{
    partial class HospitalManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HospitalManager));
            this.manHoslabel = new System.Windows.Forms.Label();
            this.greeting = new System.Windows.Forms.Label();
            this.adddoclabel = new System.Windows.Forms.Label();
            this.fireDoclabel = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Home = new System.Windows.Forms.ToolStripButton();
            this.contactus = new System.Windows.Forms.ToolStripButton();
            this.profile = new System.Windows.Forms.ToolStripSplitButton();
            this.viewProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitprogram = new System.Windows.Forms.ToolStripButton();
            this.fireDoc = new System.Windows.Forms.PictureBox();
            this.addDoc = new System.Windows.Forms.PictureBox();
            this.manHos = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fireDoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addDoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manHos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // manHoslabel
            // 
            this.manHoslabel.AutoSize = true;
            this.manHoslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manHoslabel.Location = new System.Drawing.Point(176, 167);
            this.manHoslabel.Name = "manHoslabel";
            this.manHoslabel.Size = new System.Drawing.Size(153, 22);
            this.manHoslabel.TabIndex = 59;
            this.manHoslabel.Text = "Manage Hospitals";
            this.manHoslabel.Click += new System.EventHandler(this.manHoslabel_Click);
            this.manHoslabel.MouseHover += new System.EventHandler(this.manHoslabel_hover);
            // 
            // greeting
            // 
            this.greeting.AutoSize = true;
            this.greeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greeting.Location = new System.Drawing.Point(119, 104);
            this.greeting.Name = "greeting";
            this.greeting.Size = new System.Drawing.Size(51, 22);
            this.greeting.TabIndex = 61;
            this.greeting.Text = "Hello";
            // 
            // adddoclabel
            // 
            this.adddoclabel.AutoSize = true;
            this.adddoclabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adddoclabel.Location = new System.Drawing.Point(176, 249);
            this.adddoclabel.Name = "adddoclabel";
            this.adddoclabel.Size = new System.Drawing.Size(101, 22);
            this.adddoclabel.TabIndex = 62;
            this.adddoclabel.Text = "Hire Doctor";
            this.adddoclabel.Click += new System.EventHandler(this.adddoclabel_Click);
            this.adddoclabel.MouseHover += new System.EventHandler(this.adddoclabel_hover);
            // 
            // fireDoclabel
            // 
            this.fireDoclabel.AutoSize = true;
            this.fireDoclabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fireDoclabel.Location = new System.Drawing.Point(176, 328);
            this.fireDoclabel.Name = "fireDoclabel";
            this.fireDoclabel.Size = new System.Drawing.Size(141, 22);
            this.fireDoclabel.TabIndex = 64;
            this.fireDoclabel.Text = "Manage Doctors";
            this.fireDoclabel.Click += new System.EventHandler(this.fireDoclabel_Click);
            this.fireDoclabel.MouseHover += new System.EventHandler(this.fireDoclabel_hover);
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
            this.toolStrip1.Location = new System.Drawing.Point(998, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(40, 611);
            this.toolStrip1.TabIndex = 66;
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
            this.Home.Click += new System.EventHandler(this.Home_Click);
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
            this.viewProfileToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.viewProfileToolStripMenuItem.Text = "view profile";
            this.viewProfileToolStripMenuItem.Click += new System.EventHandler(this.viewProfileToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
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
            // fireDoc
            // 
            this.fireDoc.Image = ((System.Drawing.Image)(resources.GetObject("fireDoc.Image")));
            this.fireDoc.Location = new System.Drawing.Point(103, 313);
            this.fireDoc.Name = "fireDoc";
            this.fireDoc.Size = new System.Drawing.Size(67, 63);
            this.fireDoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.fireDoc.TabIndex = 65;
            this.fireDoc.TabStop = false;
            this.fireDoc.Click += new System.EventHandler(this.fireDoc_Click);
            this.fireDoc.MouseHover += new System.EventHandler(this.fireDoc_hover);
            // 
            // addDoc
            // 
            this.addDoc.Image = ((System.Drawing.Image)(resources.GetObject("addDoc.Image")));
            this.addDoc.Location = new System.Drawing.Point(103, 231);
            this.addDoc.Name = "addDoc";
            this.addDoc.Size = new System.Drawing.Size(67, 63);
            this.addDoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.addDoc.TabIndex = 63;
            this.addDoc.TabStop = false;
            this.addDoc.Click += new System.EventHandler(this.addDoc_Click);
            this.addDoc.MouseHover += new System.EventHandler(this.adddoc_hover);
            // 
            // manHos
            // 
            this.manHos.Image = ((System.Drawing.Image)(resources.GetObject("manHos.Image")));
            this.manHos.Location = new System.Drawing.Point(103, 149);
            this.manHos.Name = "manHos";
            this.manHos.Size = new System.Drawing.Size(67, 63);
            this.manHos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.manHos.TabIndex = 60;
            this.manHos.TabStop = false;
            this.manHos.Click += new System.EventHandler(this.manHos_Click);
            this.manHos.MouseHover += new System.EventHandler(this.manHos_hover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // HospitalManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(241)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(1038, 611);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.fireDoc);
            this.Controls.Add(this.fireDoclabel);
            this.Controls.Add(this.addDoc);
            this.Controls.Add(this.adddoclabel);
            this.Controls.Add(this.greeting);
            this.Controls.Add(this.manHos);
            this.Controls.Add(this.manHoslabel);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HospitalManager";
            this.Text = "HospitalManager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManHos_close);
            this.Load += new System.EventHandler(this.HospitalManager_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fireDoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addDoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manHos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox manHos;
        private System.Windows.Forms.Label manHoslabel;
        private System.Windows.Forms.Label greeting;
        private System.Windows.Forms.PictureBox addDoc;
        private System.Windows.Forms.Label adddoclabel;
        private System.Windows.Forms.PictureBox fireDoc;
        private System.Windows.Forms.Label fireDoclabel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Home;
        private System.Windows.Forms.ToolStripButton contactus;
        private System.Windows.Forms.ToolStripSplitButton profile;
        private System.Windows.Forms.ToolStripMenuItem viewProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton exitprogram;
    }
}