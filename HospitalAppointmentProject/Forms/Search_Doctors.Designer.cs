namespace HospitalAppointmentSystem
{
    partial class Search_Doctors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search_Doctors));
            this.Doctors = new System.Windows.Forms.ComboBox();
            this.Hospitals = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Departments = new System.Windows.Forms.ComboBox();
            this.appointlabel = new System.Windows.Forms.Label();
            this.feedbacktxtbox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Home = new System.Windows.Forms.ToolStripButton();
            this.contactus = new System.Windows.Forms.ToolStripButton();
            this.exitprogram = new System.Windows.Forms.ToolStripButton();
            this.PateintFeedbacks = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.Submit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PateintFeedbacks)).BeginInit();
            this.SuspendLayout();
            // 
            // Doctors
            // 
            this.Doctors.Enabled = false;
            this.Doctors.FormattingEnabled = true;
            this.Doctors.Location = new System.Drawing.Point(241, 228);
            this.Doctors.Name = "Doctors";
            this.Doctors.Size = new System.Drawing.Size(121, 24);
            this.Doctors.TabIndex = 56;
            this.Doctors.SelectedIndexChanged += new System.EventHandler(this.Doctors_SelectedIndexChanged);
            // 
            // Hospitals
            // 
            this.Hospitals.Enabled = false;
            this.Hospitals.FormattingEnabled = true;
            this.Hospitals.Location = new System.Drawing.Point(241, 165);
            this.Hospitals.Name = "Hospitals";
            this.Hospitals.Size = new System.Drawing.Size(121, 24);
            this.Hospitals.TabIndex = 55;
            this.Hospitals.SelectedIndexChanged += new System.EventHandler(this.Hospitals_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 22);
            this.label2.TabIndex = 53;
            this.label2.Text = "Select Doctor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 22);
            this.label1.TabIndex = 52;
            this.label1.Text = "Select Hospital";
            // 
            // Departments
            // 
            this.Departments.FormattingEnabled = true;
            this.Departments.Location = new System.Drawing.Point(241, 98);
            this.Departments.Name = "Departments";
            this.Departments.Size = new System.Drawing.Size(121, 24);
            this.Departments.TabIndex = 51;
            this.Departments.SelectedIndexChanged += new System.EventHandler(this.Departments_SelectedIndexChanged_1);
            // 
            // appointlabel
            // 
            this.appointlabel.AutoSize = true;
            this.appointlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointlabel.Location = new System.Drawing.Point(54, 96);
            this.appointlabel.Name = "appointlabel";
            this.appointlabel.Size = new System.Drawing.Size(158, 22);
            this.appointlabel.TabIndex = 50;
            this.appointlabel.Text = "Select Department";
            // 
            // feedbacktxtbox
            // 
            this.feedbacktxtbox.Location = new System.Drawing.Point(241, 305);
            this.feedbacktxtbox.Name = "feedbacktxtbox";
            this.feedbacktxtbox.Size = new System.Drawing.Size(426, 96);
            this.feedbacktxtbox.TabIndex = 57;
            this.feedbacktxtbox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 22);
            this.label3.TabIndex = 58;
            this.label3.Text = "Your Feedback";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Home,
            this.contactus,
            this.exitprogram});
            this.toolStrip1.Location = new System.Drawing.Point(899, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(40, 483);
            this.toolStrip1.TabIndex = 62;
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
            // PateintFeedbacks
            // 
            this.PateintFeedbacks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PateintFeedbacks.Location = new System.Drawing.Point(425, 96);
            this.PateintFeedbacks.Name = "PateintFeedbacks";
            this.PateintFeedbacks.RowHeadersWidth = 51;
            this.PateintFeedbacks.RowTemplate.Height = 24;
            this.PateintFeedbacks.Size = new System.Drawing.Size(426, 104);
            this.PateintFeedbacks.TabIndex = 63;
            this.PateintFeedbacks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PateintFeedbacks_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(421, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 22);
            this.label5.TabIndex = 64;
            this.label5.Text = "Feedbacks";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Submit
            // 
            this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Submit.Location = new System.Drawing.Point(694, 373);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 28);
            this.Submit.TabIndex = 65;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Search_Doctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(241)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(939, 483);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PateintFeedbacks);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.feedbacktxtbox);
            this.Controls.Add(this.Doctors);
            this.Controls.Add(this.Hospitals);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Departments);
            this.Controls.Add(this.appointlabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Search_Doctors";
            this.Text = "Search_Doctors";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.search_doctors_close);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PateintFeedbacks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Doctors;
        private System.Windows.Forms.ComboBox Hospitals;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Departments;
        private System.Windows.Forms.Label appointlabel;
        private System.Windows.Forms.RichTextBox feedbacktxtbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Home;
        private System.Windows.Forms.ToolStripButton contactus;
        private System.Windows.Forms.ToolStripButton exitprogram;
        private System.Windows.Forms.DataGridView PateintFeedbacks;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Submit;
    }
}