namespace HospitalAppointmentSystem
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.contactus = new System.Windows.Forms.ToolStripButton();
            this.profile = new System.Windows.Forms.ToolStripSplitButton();
            this.viewProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitprogram = new System.Windows.Forms.ToolStripButton();
            this.modHos = new System.Windows.Forms.PictureBox();
            this.modHoslabel = new System.Windows.Forms.Label();
            this.Modphlabel = new System.Windows.Forms.Label();
            this.log = new System.Windows.Forms.PictureBox();
            this.loglabel = new System.Windows.Forms.Label();
            this.Modph = new System.Windows.Forms.PictureBox();
            this.reports = new System.Windows.Forms.PictureBox();
            this.reportslabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modHos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.log)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Modph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reports)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contactus,
            this.profile,
            this.exitprogram});
            this.toolStrip1.Location = new System.Drawing.Point(862, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(40, 450);
            this.toolStrip1.TabIndex = 52;
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
            this.editProfileToolStripMenuItem});
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
            // editProfileToolStripMenuItem
            // 
            this.editProfileToolStripMenuItem.Name = "editProfileToolStripMenuItem";
            this.editProfileToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.editProfileToolStripMenuItem.Text = "Logout";
            this.editProfileToolStripMenuItem.Click += new System.EventHandler(this.editProfileToolStripMenuItem_Click);
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
            // modHos
            // 
            this.modHos.Image = ((System.Drawing.Image)(resources.GetObject("modHos.Image")));
            this.modHos.Location = new System.Drawing.Point(113, 139);
            this.modHos.Name = "modHos";
            this.modHos.Size = new System.Drawing.Size(67, 63);
            this.modHos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.modHos.TabIndex = 58;
            this.modHos.TabStop = false;
            this.modHos.Click += new System.EventHandler(this.modHos_Click);
            this.modHos.MouseHover += new System.EventHandler(this.modHos_hover);
            // 
            // modHoslabel
            // 
            this.modHoslabel.AutoSize = true;
            this.modHoslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modHoslabel.Location = new System.Drawing.Point(186, 157);
            this.modHoslabel.Name = "modHoslabel";
            this.modHoslabel.Size = new System.Drawing.Size(141, 22);
            this.modHoslabel.TabIndex = 57;
            this.modHoslabel.Text = "Modify Hospitals";
            this.modHoslabel.Click += new System.EventHandler(this.modHoslabel_Click);
            this.modHoslabel.MouseHover += new System.EventHandler(this.modHoslabel_hover);
            // 
            // Modphlabel
            // 
            this.Modphlabel.AutoSize = true;
            this.Modphlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modphlabel.Location = new System.Drawing.Point(186, 231);
            this.Modphlabel.Name = "Modphlabel";
            this.Modphlabel.Size = new System.Drawing.Size(161, 22);
            this.Modphlabel.TabIndex = 59;
            this.Modphlabel.Text = "Modify Pharmacies";
            this.Modphlabel.Click += new System.EventHandler(this.Modphlabel_Click);
            this.Modphlabel.MouseHover += new System.EventHandler(this.Modphlabel_hover);
            // 
            // log
            // 
            this.log.Image = ((System.Drawing.Image)(resources.GetObject("log.Image")));
            this.log.Location = new System.Drawing.Point(113, 291);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(67, 63);
            this.log.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.log.TabIndex = 62;
            this.log.TabStop = false;
            this.log.Click += new System.EventHandler(this.log_Click);
            this.log.MouseHover += new System.EventHandler(this.log_hover);
            // 
            // loglabel
            // 
            this.loglabel.AutoSize = true;
            this.loglabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loglabel.Location = new System.Drawing.Point(186, 309);
            this.loglabel.Name = "loglabel";
            this.loglabel.Size = new System.Drawing.Size(124, 22);
            this.loglabel.TabIndex = 61;
            this.loglabel.Text = "User Activities";
            this.loglabel.Click += new System.EventHandler(this.loglabel_Click);
            this.loglabel.MouseHover += new System.EventHandler(this.loglabel_hover);
            // 
            // Modph
            // 
            this.Modph.Image = ((System.Drawing.Image)(resources.GetObject("Modph.Image")));
            this.Modph.Location = new System.Drawing.Point(113, 208);
            this.Modph.Name = "Modph";
            this.Modph.Size = new System.Drawing.Size(67, 63);
            this.Modph.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Modph.TabIndex = 63;
            this.Modph.TabStop = false;
            this.Modph.Click += new System.EventHandler(this.Modph_Click);
            this.Modph.MouseHover += new System.EventHandler(this.modph_hover);
            // 
            // reports
            // 
            this.reports.Image = ((System.Drawing.Image)(resources.GetObject("reports.Image")));
            this.reports.Location = new System.Drawing.Point(422, 139);
            this.reports.Name = "reports";
            this.reports.Size = new System.Drawing.Size(67, 63);
            this.reports.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.reports.TabIndex = 65;
            this.reports.TabStop = false;
            this.reports.Click += new System.EventHandler(this.reports_Click);
            this.reports.MouseHover += new System.EventHandler(this.reports_hover);
            // 
            // reportslabel
            // 
            this.reportslabel.AutoSize = true;
            this.reportslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportslabel.Location = new System.Drawing.Point(495, 157);
            this.reportslabel.Name = "reportslabel";
            this.reportslabel.Size = new System.Drawing.Size(137, 22);
            this.reportslabel.TabIndex = 64;
            this.reportslabel.Text = "System Reports";
            this.reportslabel.Click += new System.EventHandler(this.reportslabel_Click);
            this.reportslabel.MouseHover += new System.EventHandler(this.reportslabel_hover);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(241)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(902, 450);
            this.Controls.Add(this.reports);
            this.Controls.Add(this.reportslabel);
            this.Controls.Add(this.Modph);
            this.Controls.Add(this.log);
            this.Controls.Add(this.loglabel);
            this.Controls.Add(this.Modphlabel);
            this.Controls.Add(this.modHos);
            this.Controls.Add(this.modHoslabel);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin";
            this.Text = "Admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.admin_close);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modHos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.log)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Modph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reports)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton contactus;
        private System.Windows.Forms.ToolStripSplitButton profile;
        private System.Windows.Forms.ToolStripMenuItem viewProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton exitprogram;
        private System.Windows.Forms.PictureBox modHos;
        private System.Windows.Forms.Label modHoslabel;
        private System.Windows.Forms.Label Modphlabel;
        private System.Windows.Forms.PictureBox log;
        private System.Windows.Forms.Label loglabel;
        private System.Windows.Forms.PictureBox Modph;
        private System.Windows.Forms.PictureBox reports;
        private System.Windows.Forms.Label reportslabel;
    }
}