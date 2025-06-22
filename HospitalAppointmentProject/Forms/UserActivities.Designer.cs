namespace HospitalAppointmentSystem
{
    partial class UserActivities
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserActivities));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.activityforallusers = new System.Windows.Forms.DataGridView();
            this.FNlabel = new System.Windows.Forms.Label();
            this.activityforcertainuser = new System.Windows.Forms.DataGridView();
            this.UserIDtextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Home = new System.Windows.Forms.ToolStripButton();
            this.contactus = new System.Windows.Forms.ToolStripButton();
            this.exitprogram = new System.Windows.Forms.ToolStripButton();
            this.startingtime = new System.Windows.Forms.DateTimePicker();
            this.GetActivityForuser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityforallusers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityforcertainuser)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-5, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // activityforallusers
            // 
            this.activityforallusers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activityforallusers.Location = new System.Drawing.Point(303, 49);
            this.activityforallusers.Name = "activityforallusers";
            this.activityforallusers.RowHeadersWidth = 51;
            this.activityforallusers.RowTemplate.Height = 24;
            this.activityforallusers.Size = new System.Drawing.Size(579, 300);
            this.activityforallusers.TabIndex = 39;
            this.activityforallusers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.activityforallusers_CellContentClick);
            // 
            // FNlabel
            // 
            this.FNlabel.AutoSize = true;
            this.FNlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FNlabel.Location = new System.Drawing.Point(38, 136);
            this.FNlabel.Name = "FNlabel";
            this.FNlabel.Size = new System.Drawing.Size(115, 20);
            this.FNlabel.TabIndex = 79;
            this.FNlabel.Text = "System Users";
            // 
            // activityforcertainuser
            // 
            this.activityforcertainuser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activityforcertainuser.Location = new System.Drawing.Point(303, 465);
            this.activityforcertainuser.Name = "activityforcertainuser";
            this.activityforcertainuser.RowHeadersWidth = 51;
            this.activityforcertainuser.RowTemplate.Height = 24;
            this.activityforcertainuser.Size = new System.Drawing.Size(579, 145);
            this.activityforcertainuser.TabIndex = 80;
            // 
            // UserIDtextbox
            // 
            this.UserIDtextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserIDtextbox.Location = new System.Drawing.Point(134, 465);
            this.UserIDtextbox.Name = "UserIDtextbox";
            this.UserIDtextbox.Size = new System.Drawing.Size(127, 22);
            this.UserIDtextbox.TabIndex = 81;
            this.UserIDtextbox.TextChanged += new System.EventHandler(this.UserID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 467);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 82;
            this.label1.Text = "UserID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 435);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 16);
            this.label2.TabIndex = 83;
            this.label2.Text = "Write the userID to see a specific user Activity";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Home,
            this.contactus,
            this.exitprogram});
            this.toolStrip1.Location = new System.Drawing.Point(1327, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(40, 699);
            this.toolStrip1.TabIndex = 84;
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
            // startingtime
            // 
            this.startingtime.Location = new System.Drawing.Point(42, 179);
            this.startingtime.Name = "startingtime";
            this.startingtime.Size = new System.Drawing.Size(228, 22);
            this.startingtime.TabIndex = 86;
            this.startingtime.ValueChanged += new System.EventHandler(this.startingtime_ValueChanged);
            // 
            // GetActivityForuser
            // 
            this.GetActivityForuser.Location = new System.Drawing.Point(123, 525);
            this.GetActivityForuser.Name = "GetActivityForuser";
            this.GetActivityForuser.Size = new System.Drawing.Size(137, 23);
            this.GetActivityForuser.TabIndex = 87;
            this.GetActivityForuser.Text = "Get Activities";
            this.GetActivityForuser.UseVisualStyleBackColor = true;
            this.GetActivityForuser.Click += new System.EventHandler(this.GetActivityForuser_Click);
            // 
            // UserActivities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(241)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(1367, 699);
            this.Controls.Add(this.GetActivityForuser);
            this.Controls.Add(this.startingtime);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserIDtextbox);
            this.Controls.Add(this.activityforcertainuser);
            this.Controls.Add(this.FNlabel);
            this.Controls.Add(this.activityforallusers);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserActivities";
            this.Text = "UserActivities";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ua_close);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityforallusers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityforcertainuser)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView activityforallusers;
        private System.Windows.Forms.Label FNlabel;
        private System.Windows.Forms.DataGridView activityforcertainuser;
        private System.Windows.Forms.TextBox UserIDtextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Home;
        private System.Windows.Forms.ToolStripButton contactus;
        private System.Windows.Forms.ToolStripButton exitprogram;
        private System.Windows.Forms.DateTimePicker startingtime;
        private System.Windows.Forms.Button GetActivityForuser;
    }
}