namespace HospitalAppointmentSystem
{
    partial class FireDoctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FireDoctor));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Home = new System.Windows.Forms.ToolStripButton();
            this.contactus = new System.Windows.Forms.ToolStripButton();
            this.exitprogram = new System.Windows.Forms.ToolStripButton();
            this.DoctorsinDeps = new System.Windows.Forms.DataGridView();
            this.departmentcomboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.manHoslabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DocIdtextBox1 = new System.Windows.Forms.TextBox();
            this.DocLName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DocFName = new System.Windows.Forms.TextBox();
            this.DoctorsSearch = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.updoclabel = new System.Windows.Forms.Label();
            this.updoc = new System.Windows.Forms.PictureBox();
            this.firedoclabel = new System.Windows.Forms.Label();
            this.firedoc = new System.Windows.Forms.PictureBox();
            this.DocAge = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lnameDoc = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.fnameDoc = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.DocDatagroupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorsinDeps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorsSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firedoc)).BeginInit();
            this.DocDatagroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 39;
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
            this.toolStrip1.Location = new System.Drawing.Point(988, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(30, 630);
            this.toolStrip1.TabIndex = 67;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Home
            // 
            this.Home.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Home.Image = ((System.Drawing.Image)(resources.GetObject("Home.Image")));
            this.Home.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(27, 24);
            this.Home.Text = "home page";
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // contactus
            // 
            this.contactus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.contactus.Image = ((System.Drawing.Image)(resources.GetObject("contactus.Image")));
            this.contactus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.contactus.Name = "contactus";
            this.contactus.Size = new System.Drawing.Size(27, 24);
            this.contactus.Text = "contact us";
            this.contactus.Click += new System.EventHandler(this.contactus_Click);
            // 
            // exitprogram
            // 
            this.exitprogram.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.exitprogram.Image = ((System.Drawing.Image)(resources.GetObject("exitprogram.Image")));
            this.exitprogram.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exitprogram.Name = "exitprogram";
            this.exitprogram.Size = new System.Drawing.Size(27, 24);
            this.exitprogram.Text = "exit";
            this.exitprogram.Click += new System.EventHandler(this.exitprogram_Click);
            // 
            // DoctorsinDeps
            // 
            this.DoctorsinDeps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DoctorsinDeps.Location = new System.Drawing.Point(550, 142);
            this.DoctorsinDeps.Name = "DoctorsinDeps";
            this.DoctorsinDeps.RowHeadersWidth = 51;
            this.DoctorsinDeps.RowTemplate.Height = 24;
            this.DoctorsinDeps.Size = new System.Drawing.Size(361, 85);
            this.DoctorsinDeps.TabIndex = 68;
            // 
            // departmentcomboBox1
            // 
            this.departmentcomboBox1.FormattingEnabled = true;
            this.departmentcomboBox1.Location = new System.Drawing.Point(198, 150);
            this.departmentcomboBox1.Name = "departmentcomboBox1";
            this.departmentcomboBox1.Size = new System.Drawing.Size(121, 24);
            this.departmentcomboBox1.TabIndex = 69;
            this.departmentcomboBox1.SelectedIndexChanged += new System.EventHandler(this.departmentcomboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 16);
            this.label1.TabIndex = 70;
            this.label1.Text = "Select Department to view its Doctors";
            // 
            // manHoslabel
            // 
            this.manHoslabel.AutoSize = true;
            this.manHoslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manHoslabel.Location = new System.Drawing.Point(69, 150);
            this.manHoslabel.Name = "manHoslabel";
            this.manHoslabel.Size = new System.Drawing.Size(112, 22);
            this.manHoslabel.TabIndex = 71;
            this.manHoslabel.Text = "Departments";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(447, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 22);
            this.label2.TabIndex = 72;
            this.label2.Text = "Doctors";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-1, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(979, 16);
            this.label6.TabIndex = 98;
            this.label6.Text = resources.GetString("label6.Text");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 16);
            this.label4.TabIndex = 99;
            this.label4.Text = "Search Doctor By name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(104, 492);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 106;
            this.label5.Text = "DoctorID";
            // 
            // DocIdtextBox1
            // 
            this.DocIdtextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DocIdtextBox1.Location = new System.Drawing.Point(189, 493);
            this.DocIdtextBox1.Name = "DocIdtextBox1";
            this.DocIdtextBox1.Size = new System.Drawing.Size(127, 22);
            this.DocIdtextBox1.TabIndex = 105;
            // 
            // DocLName
            // 
            this.DocLName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DocLName.Location = new System.Drawing.Point(403, 321);
            this.DocLName.Name = "DocLName";
            this.DocLName.Size = new System.Drawing.Size(127, 22);
            this.DocLName.TabIndex = 104;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(306, 323);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 20);
            this.label8.TabIndex = 103;
            this.label8.Text = "Last Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(61, 321);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 20);
            this.label9.TabIndex = 102;
            this.label9.Text = "First Name";
            // 
            // DocFName
            // 
            this.DocFName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DocFName.Location = new System.Drawing.Point(159, 321);
            this.DocFName.Name = "DocFName";
            this.DocFName.Size = new System.Drawing.Size(127, 22);
            this.DocFName.TabIndex = 101;
            // 
            // DoctorsSearch
            // 
            this.DoctorsSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DoctorsSearch.Location = new System.Drawing.Point(569, 312);
            this.DoctorsSearch.Name = "DoctorsSearch";
            this.DoctorsSearch.RowHeadersWidth = 51;
            this.DoctorsSearch.RowTemplate.Height = 24;
            this.DoctorsSearch.Size = new System.Drawing.Size(361, 85);
            this.DoctorsSearch.TabIndex = 107;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-4, 425);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(979, 16);
            this.label3.TabIndex = 108;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(156, 454);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 16);
            this.label7.TabIndex = 109;
            this.label7.Text = "Edit Doctors";
            // 
            // updoclabel
            // 
            this.updoclabel.AutoSize = true;
            this.updoclabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updoclabel.Location = new System.Drawing.Point(431, 558);
            this.updoclabel.Name = "updoclabel";
            this.updoclabel.Size = new System.Drawing.Size(59, 20);
            this.updoclabel.TabIndex = 111;
            this.updoclabel.Text = "update";
            this.updoclabel.MouseHover += new System.EventHandler(this.updoclabel_hover);
            // 
            // updoc
            // 
            this.updoc.Image = ((System.Drawing.Image)(resources.GetObject("updoc.Image")));
            this.updoc.Location = new System.Drawing.Point(358, 539);
            this.updoc.Name = "updoc";
            this.updoc.Size = new System.Drawing.Size(67, 57);
            this.updoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.updoc.TabIndex = 110;
            this.updoc.TabStop = false;
            this.updoc.Click += new System.EventHandler(this.updoc_Click);
            this.updoc.MouseHover += new System.EventHandler(this.updoc_hover);
            // 
            // firedoclabel
            // 
            this.firedoclabel.AutoSize = true;
            this.firedoclabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firedoclabel.Location = new System.Drawing.Point(431, 495);
            this.firedoclabel.Name = "firedoclabel";
            this.firedoclabel.Size = new System.Drawing.Size(33, 20);
            this.firedoclabel.TabIndex = 113;
            this.firedoclabel.Text = "fire";
            this.firedoclabel.MouseHover += new System.EventHandler(this.firedoclabel_hover);
            // 
            // firedoc
            // 
            this.firedoc.Image = ((System.Drawing.Image)(resources.GetObject("firedoc.Image")));
            this.firedoc.Location = new System.Drawing.Point(358, 476);
            this.firedoc.Name = "firedoc";
            this.firedoc.Size = new System.Drawing.Size(67, 57);
            this.firedoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.firedoc.TabIndex = 112;
            this.firedoc.TabStop = false;
            this.firedoc.Click += new System.EventHandler(this.firedoc_Click);
            // 
            // DocAge
            // 
            this.DocAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DocAge.Location = new System.Drawing.Point(108, 95);
            this.DocAge.Name = "DocAge";
            this.DocAge.Size = new System.Drawing.Size(127, 22);
            this.DocAge.TabIndex = 119;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(20, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 20);
            this.label11.TabIndex = 118;
            this.label11.Text = "Age";
            // 
            // lnameDoc
            // 
            this.lnameDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lnameDoc.Location = new System.Drawing.Point(108, 54);
            this.lnameDoc.Name = "lnameDoc";
            this.lnameDoc.Size = new System.Drawing.Size(127, 22);
            this.lnameDoc.TabIndex = 117;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(-3, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 20);
            this.label12.TabIndex = 116;
            this.label12.Text = "Last Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(-4, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 20);
            this.label13.TabIndex = 115;
            this.label13.Text = "First Name";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // fnameDoc
            // 
            this.fnameDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fnameDoc.Location = new System.Drawing.Point(108, 22);
            this.fnameDoc.Name = "fnameDoc";
            this.fnameDoc.Size = new System.Drawing.Size(127, 22);
            this.fnameDoc.TabIndex = 114;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(137, 145);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 120;
            this.submit.Text = "Update";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(403, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 121;
            this.button1.Text = "SEARCH";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DocDatagroupBox1
            // 
            this.DocDatagroupBox1.Controls.Add(this.label11);
            this.DocDatagroupBox1.Controls.Add(this.DocAge);
            this.DocDatagroupBox1.Controls.Add(this.submit);
            this.DocDatagroupBox1.Controls.Add(this.label12);
            this.DocDatagroupBox1.Controls.Add(this.label13);
            this.DocDatagroupBox1.Controls.Add(this.lnameDoc);
            this.DocDatagroupBox1.Controls.Add(this.fnameDoc);
            this.DocDatagroupBox1.Enabled = false;
            this.DocDatagroupBox1.Location = new System.Drawing.Point(644, 444);
            this.DocDatagroupBox1.Name = "DocDatagroupBox1";
            this.DocDatagroupBox1.Size = new System.Drawing.Size(267, 174);
            this.DocDatagroupBox1.TabIndex = 122;
            this.DocDatagroupBox1.TabStop = false;
            // 
            // FireDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(241)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(1018, 630);
            this.Controls.Add(this.DocDatagroupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.firedoclabel);
            this.Controls.Add(this.firedoc);
            this.Controls.Add(this.updoclabel);
            this.Controls.Add(this.updoc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DoctorsSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DocIdtextBox1);
            this.Controls.Add(this.DocLName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DocFName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.manHoslabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.departmentcomboBox1);
            this.Controls.Add(this.DoctorsinDeps);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FireDoctor";
            this.Text = "ManageDoctors";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.firedoc_close);
            this.MouseHover += new System.EventHandler(this.firedoc_hover);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorsinDeps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorsSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firedoc)).EndInit();
            this.DocDatagroupBox1.ResumeLayout(false);
            this.DocDatagroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Home;
        private System.Windows.Forms.ToolStripButton contactus;
        private System.Windows.Forms.ToolStripButton exitprogram;
        private System.Windows.Forms.DataGridView DoctorsinDeps;
        private System.Windows.Forms.ComboBox departmentcomboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label manHoslabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DocIdtextBox1;
        private System.Windows.Forms.TextBox DocLName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox DocFName;
        private System.Windows.Forms.DataGridView DoctorsSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label updoclabel;
        private System.Windows.Forms.PictureBox updoc;
        private System.Windows.Forms.Label firedoclabel;
        private System.Windows.Forms.PictureBox firedoc;
        private System.Windows.Forms.TextBox DocAge;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox lnameDoc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox fnameDoc;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox DocDatagroupBox1;
    }
}