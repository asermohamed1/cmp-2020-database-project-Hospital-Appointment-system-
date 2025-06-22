namespace HospitalAppointmentSystem
{
    partial class Doctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doctor));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Home = new System.Windows.Forms.ToolStripButton();
            this.contactus = new System.Windows.Forms.ToolStripButton();
            this.profile = new System.Windows.Forms.ToolStripSplitButton();
            this.viewProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitprogram = new System.Windows.Forms.ToolStripButton();
            this.greeting = new System.Windows.Forms.Label();
            this.curApplabel = new System.Windows.Forms.Label();
            this.addprelabel = new System.Windows.Forms.Label();
            this.pinfolabel = new System.Windows.Forms.Label();
            this.feedbacklabel = new System.Windows.Forms.Label();
            this.feedbacks = new System.Windows.Forms.PictureBox();
            this.pInfo = new System.Windows.Forms.PictureBox();
            this.addpre = new System.Windows.Forms.PictureBox();
            this.Appoints = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.feedbacks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addpre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Appoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.toolStrip1.Location = new System.Drawing.Point(950, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(40, 476);
            this.toolStrip1.TabIndex = 51;
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
            // 
            // profile
            // 
            this.profile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.profile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewProfileToolStripMenuItem,
            this.removeAccountToolStripMenuItem});
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
            // removeAccountToolStripMenuItem
            // 
            this.removeAccountToolStripMenuItem.Name = "removeAccountToolStripMenuItem";
            this.removeAccountToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.removeAccountToolStripMenuItem.Text = "Logout";
            this.removeAccountToolStripMenuItem.Click += new System.EventHandler(this.removeAccountToolStripMenuItem_Click);
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
            this.greeting.Location = new System.Drawing.Point(161, 102);
            this.greeting.Name = "greeting";
            this.greeting.Size = new System.Drawing.Size(51, 22);
            this.greeting.TabIndex = 53;
            this.greeting.Text = "Hello";
            // 
            // curApplabel
            // 
            this.curApplabel.AutoSize = true;
            this.curApplabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curApplabel.Location = new System.Drawing.Point(238, 171);
            this.curApplabel.Name = "curApplabel";
            this.curApplabel.Size = new System.Drawing.Size(184, 22);
            this.curApplabel.TabIndex = 54;
            this.curApplabel.Text = "Current Appointments";
            this.curApplabel.Click += new System.EventHandler(this.curApplabel_Click);
            this.curApplabel.MouseHover += new System.EventHandler(this.curApplable_hover);
            // 
            // addprelabel
            // 
            this.addprelabel.AutoSize = true;
            this.addprelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addprelabel.Location = new System.Drawing.Point(238, 252);
            this.addprelabel.Name = "addprelabel";
            this.addprelabel.Size = new System.Drawing.Size(146, 22);
            this.addprelabel.TabIndex = 55;
            this.addprelabel.Text = "New Prescription";
            this.addprelabel.Click += new System.EventHandler(this.addprelabel_Click);
            this.addprelabel.MouseHover += new System.EventHandler(this.addprelabel_hover);
            // 
            // pinfolabel
            // 
            this.pinfolabel.AutoSize = true;
            this.pinfolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinfolabel.Location = new System.Drawing.Point(238, 334);
            this.pinfolabel.Name = "pinfolabel";
            this.pinfolabel.Size = new System.Drawing.Size(100, 22);
            this.pinfolabel.TabIndex = 57;
            this.pinfolabel.Text = "Patient Info";
            this.pinfolabel.Click += new System.EventHandler(this.pinfolabel_Click);
            this.pinfolabel.MouseHover += new System.EventHandler(this.pinfolabel_hover);
            // 
            // feedbacklabel
            // 
            this.feedbacklabel.AutoSize = true;
            this.feedbacklabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedbacklabel.Location = new System.Drawing.Point(583, 171);
            this.feedbacklabel.Name = "feedbacklabel";
            this.feedbacklabel.Size = new System.Drawing.Size(159, 22);
            this.feedbacklabel.TabIndex = 59;
            this.feedbacklabel.Text = "Patient Feedbacks";
            this.feedbacklabel.MouseHover += new System.EventHandler(this.feedbackslabel_hover);
            // 
            // feedbacks
            // 
            this.feedbacks.Image = ((System.Drawing.Image)(resources.GetObject("feedbacks.Image")));
            this.feedbacks.Location = new System.Drawing.Point(510, 153);
            this.feedbacks.Name = "feedbacks";
            this.feedbacks.Size = new System.Drawing.Size(67, 63);
            this.feedbacks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.feedbacks.TabIndex = 60;
            this.feedbacks.TabStop = false;
            this.feedbacks.Click += new System.EventHandler(this.feedbacks_Click);
            this.feedbacks.MouseHover += new System.EventHandler(this.feedbacks_hover);
            // 
            // pInfo
            // 
            this.pInfo.Image = ((System.Drawing.Image)(resources.GetObject("pInfo.Image")));
            this.pInfo.Location = new System.Drawing.Point(165, 316);
            this.pInfo.Name = "pInfo";
            this.pInfo.Size = new System.Drawing.Size(67, 63);
            this.pInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pInfo.TabIndex = 58;
            this.pInfo.TabStop = false;
            this.pInfo.Click += new System.EventHandler(this.pInfo_Click);
            this.pInfo.MouseHover += new System.EventHandler(this.pInfo_hover);
            // 
            // addpre
            // 
            this.addpre.Image = ((System.Drawing.Image)(resources.GetObject("addpre.Image")));
            this.addpre.Location = new System.Drawing.Point(165, 234);
            this.addpre.Name = "addpre";
            this.addpre.Size = new System.Drawing.Size(67, 63);
            this.addpre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.addpre.TabIndex = 56;
            this.addpre.TabStop = false;
            this.addpre.Click += new System.EventHandler(this.addpre_Click);
            this.addpre.MouseHover += new System.EventHandler(this.addpre_hover);
            // 
            // Appoints
            // 
            this.Appoints.Image = ((System.Drawing.Image)(resources.GetObject("Appoints.Image")));
            this.Appoints.Location = new System.Drawing.Point(165, 149);
            this.Appoints.Name = "Appoints";
            this.Appoints.Size = new System.Drawing.Size(67, 63);
            this.Appoints.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Appoints.TabIndex = 52;
            this.Appoints.TabStop = false;
            this.Appoints.Click += new System.EventHandler(this.Appoints_Click);
            this.Appoints.MouseHover += new System.EventHandler(this.Appoints_hover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(241)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(990, 476);
            this.Controls.Add(this.feedbacks);
            this.Controls.Add(this.feedbacklabel);
            this.Controls.Add(this.pInfo);
            this.Controls.Add(this.pinfolabel);
            this.Controls.Add(this.addpre);
            this.Controls.Add(this.addprelabel);
            this.Controls.Add(this.curApplabel);
            this.Controls.Add(this.greeting);
            this.Controls.Add(this.Appoints);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Doctor";
            this.Text = "Doctor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Doctor_Close);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.feedbacks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addpre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Appoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Home;
        private System.Windows.Forms.ToolStripButton contactus;
        private System.Windows.Forms.ToolStripSplitButton profile;
        private System.Windows.Forms.ToolStripMenuItem viewProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton exitprogram;
        private System.Windows.Forms.PictureBox Appoints;
        private System.Windows.Forms.Label greeting;
        private System.Windows.Forms.Label curApplabel;
        private System.Windows.Forms.PictureBox addpre;
        private System.Windows.Forms.Label addprelabel;
        private System.Windows.Forms.PictureBox pInfo;
        private System.Windows.Forms.Label pinfolabel;
        private System.Windows.Forms.PictureBox feedbacks;
        private System.Windows.Forms.Label feedbacklabel;
    }
}