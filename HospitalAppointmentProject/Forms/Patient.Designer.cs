namespace HospitalAppointmentSystem
{
    partial class Patient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patient));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.contactus = new System.Windows.Forms.ToolStripButton();
            this.profile = new System.Windows.Forms.ToolStripSplitButton();
            this.viewProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitprogram = new System.Windows.Forms.ToolStripButton();
            this.appointlabel = new System.Windows.Forms.Label();
            this.greeting = new System.Windows.Forms.Label();
            this.showAppointmentslabel = new System.Windows.Forms.Label();
            this.DocSearchlabel = new System.Windows.Forms.Label();
            this.Prescriptionslabel = new System.Windows.Forms.Label();
            this.Prescript = new System.Windows.Forms.PictureBox();
            this.DocSearch = new System.Windows.Forms.PictureBox();
            this.showappoints = new System.Windows.Forms.PictureBox();
            this.addappoint = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.medHistory = new System.Windows.Forms.PictureBox();
            this.midhistlablel = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Prescript)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DocSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showappoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addappoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contactus,
            this.profile,
            this.exitprogram});
            this.toolStrip1.Location = new System.Drawing.Point(1048, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(40, 612);
            this.toolStrip1.TabIndex = 28;
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
            this.profile.ButtonClick += new System.EventHandler(this.profile_ButtonClick);
            // 
            // viewProfileToolStripMenuItem
            // 
            this.viewProfileToolStripMenuItem.Name = "viewProfileToolStripMenuItem";
            this.viewProfileToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.viewProfileToolStripMenuItem.Text = "view profile";
            this.viewProfileToolStripMenuItem.Click += new System.EventHandler(this.viewProfileToolStripMenuItem_Click);
            // 
            // removeAccountToolStripMenuItem
            // 
            this.removeAccountToolStripMenuItem.Name = "removeAccountToolStripMenuItem";
            this.removeAccountToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
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
            // appointlabel
            // 
            this.appointlabel.AutoSize = true;
            this.appointlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointlabel.Location = new System.Drawing.Point(238, 183);
            this.appointlabel.Name = "appointlabel";
            this.appointlabel.Size = new System.Drawing.Size(151, 22);
            this.appointlabel.TabIndex = 29;
            this.appointlabel.Text = "New Appointment";
            this.appointlabel.Click += new System.EventHandler(this.appointlabel_Click);
            this.appointlabel.MouseHover += new System.EventHandler(this.appointlabel_hover);
            // 
            // greeting
            // 
            this.greeting.AutoSize = true;
            this.greeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greeting.Location = new System.Drawing.Point(21, 101);
            this.greeting.Name = "greeting";
            this.greeting.Size = new System.Drawing.Size(51, 22);
            this.greeting.TabIndex = 35;
            this.greeting.Text = "Hello";
            // 
            // showAppointmentslabel
            // 
            this.showAppointmentslabel.AutoSize = true;
            this.showAppointmentslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAppointmentslabel.Location = new System.Drawing.Point(238, 270);
            this.showAppointmentslabel.Name = "showAppointmentslabel";
            this.showAppointmentslabel.Size = new System.Drawing.Size(204, 22);
            this.showAppointmentslabel.TabIndex = 37;
            this.showAppointmentslabel.Text = "Upcoming Appointments";
            this.showAppointmentslabel.Click += new System.EventHandler(this.showAppointmentslabel_Click);
            this.showAppointmentslabel.MouseHover += new System.EventHandler(this.showAppointmentslabel_hover);
            // 
            // DocSearchlabel
            // 
            this.DocSearchlabel.AutoSize = true;
            this.DocSearchlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocSearchlabel.Location = new System.Drawing.Point(648, 183);
            this.DocSearchlabel.Name = "DocSearchlabel";
            this.DocSearchlabel.Size = new System.Drawing.Size(134, 22);
            this.DocSearchlabel.TabIndex = 41;
            this.DocSearchlabel.Text = "Search Doctors";
            this.DocSearchlabel.Click += new System.EventHandler(this.DocSearchlabel_Click);
            this.DocSearchlabel.MouseHover += new System.EventHandler(this.DocSearchlabel_hover);
            // 
            // Prescriptionslabel
            // 
            this.Prescriptionslabel.AutoSize = true;
            this.Prescriptionslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prescriptionslabel.Location = new System.Drawing.Point(648, 261);
            this.Prescriptionslabel.Name = "Prescriptionslabel";
            this.Prescriptionslabel.Size = new System.Drawing.Size(114, 22);
            this.Prescriptionslabel.TabIndex = 43;
            this.Prescriptionslabel.Text = "Prescriptions";
            this.Prescriptionslabel.Click += new System.EventHandler(this.Prescriptionslabel_Click);
            this.Prescriptionslabel.MouseHover += new System.EventHandler(this.Prescriptionslabel_hover);
            // 
            // Prescript
            // 
            this.Prescript.Image = ((System.Drawing.Image)(resources.GetObject("Prescript.Image")));
            this.Prescript.Location = new System.Drawing.Point(575, 242);
            this.Prescript.Name = "Prescript";
            this.Prescript.Size = new System.Drawing.Size(67, 50);
            this.Prescript.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Prescript.TabIndex = 42;
            this.Prescript.TabStop = false;
            this.Prescript.Click += new System.EventHandler(this.Prescript_Click);
            this.Prescript.MouseHover += new System.EventHandler(this.Prescript_hover);
            // 
            // DocSearch
            // 
            this.DocSearch.Image = ((System.Drawing.Image)(resources.GetObject("DocSearch.Image")));
            this.DocSearch.Location = new System.Drawing.Point(575, 165);
            this.DocSearch.Name = "DocSearch";
            this.DocSearch.Size = new System.Drawing.Size(67, 59);
            this.DocSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.DocSearch.TabIndex = 40;
            this.DocSearch.TabStop = false;
            this.DocSearch.Click += new System.EventHandler(this.DocSearch_Click);
            this.DocSearch.MouseHover += new System.EventHandler(this.DocSearch_hover);
            // 
            // showappoints
            // 
            this.showappoints.Image = ((System.Drawing.Image)(resources.GetObject("showappoints.Image")));
            this.showappoints.Location = new System.Drawing.Point(161, 251);
            this.showappoints.Name = "showappoints";
            this.showappoints.Size = new System.Drawing.Size(71, 67);
            this.showappoints.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.showappoints.TabIndex = 36;
            this.showappoints.TabStop = false;
            this.showappoints.Click += new System.EventHandler(this.showappoints_Click);
            this.showappoints.MouseHover += new System.EventHandler(this.showappoints_hover);
            // 
            // addappoint
            // 
            this.addappoint.Image = ((System.Drawing.Image)(resources.GetObject("addappoint.Image")));
            this.addappoint.Location = new System.Drawing.Point(165, 165);
            this.addappoint.Name = "addappoint";
            this.addappoint.Size = new System.Drawing.Size(67, 63);
            this.addappoint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.addappoint.TabIndex = 34;
            this.addappoint.TabStop = false;
            this.addappoint.Click += new System.EventHandler(this.addappoint_Click);
            this.addappoint.MouseHover += new System.EventHandler(this.addappoint_hover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // medHistory
            // 
            this.medHistory.Image = ((System.Drawing.Image)(resources.GetObject("medHistory.Image")));
            this.medHistory.Location = new System.Drawing.Point(392, 340);
            this.medHistory.Name = "medHistory";
            this.medHistory.Size = new System.Drawing.Size(67, 59);
            this.medHistory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.medHistory.TabIndex = 44;
            this.medHistory.TabStop = false;
            this.medHistory.Click += new System.EventHandler(this.medHistory_Click);
            this.medHistory.MouseHover += new System.EventHandler(this.medHistory_hover);
            // 
            // midhistlablel
            // 
            this.midhistlablel.AutoSize = true;
            this.midhistlablel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.midhistlablel.Location = new System.Drawing.Point(467, 363);
            this.midhistlablel.Name = "midhistlablel";
            this.midhistlablel.Size = new System.Drawing.Size(175, 22);
            this.midhistlablel.TabIndex = 45;
            this.midhistlablel.Text = "Your Medical History";
            this.midhistlablel.Click += new System.EventHandler(this.midhistlablel_Click);
            this.midhistlablel.MouseHover += new System.EventHandler(this.medhistlablel_hover);
            // 
            // Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(241)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(1088, 612);
            this.Controls.Add(this.midhistlablel);
            this.Controls.Add(this.medHistory);
            this.Controls.Add(this.Prescriptionslabel);
            this.Controls.Add(this.Prescript);
            this.Controls.Add(this.DocSearchlabel);
            this.Controls.Add(this.DocSearch);
            this.Controls.Add(this.showAppointmentslabel);
            this.Controls.Add(this.showappoints);
            this.Controls.Add(this.greeting);
            this.Controls.Add(this.addappoint);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.appointlabel);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Patient";
            this.Text = "Patient";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.patient_close);
            this.Load += new System.EventHandler(this.Patient_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Prescript)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DocSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showappoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addappoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton contactus;
        private System.Windows.Forms.ToolStripButton exitprogram;
        private System.Windows.Forms.ToolStripSplitButton profile;
        private System.Windows.Forms.ToolStripMenuItem viewProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeAccountToolStripMenuItem;
        private System.Windows.Forms.Label appointlabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox addappoint;
        private System.Windows.Forms.Label greeting;
        private System.Windows.Forms.PictureBox showappoints;
        private System.Windows.Forms.Label showAppointmentslabel;
        private System.Windows.Forms.Label DocSearchlabel;
        private System.Windows.Forms.PictureBox DocSearch;
        private System.Windows.Forms.Label Prescriptionslabel;
        private System.Windows.Forms.PictureBox Prescript;
        private System.Windows.Forms.PictureBox medHistory;
        private System.Windows.Forms.Label midhistlablel;
    }
}