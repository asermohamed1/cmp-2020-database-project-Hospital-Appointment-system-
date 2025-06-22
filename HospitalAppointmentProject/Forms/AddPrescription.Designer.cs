namespace HospitalAppointmentSystem
{
    partial class AddPrescription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPrescription));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Home = new System.Windows.Forms.ToolStripButton();
            this.contactus = new System.Windows.Forms.ToolStripButton();
            this.exitprogram = new System.Windows.Forms.ToolStripButton();
            this.pEmail = new System.Windows.Forms.TextBox();
            this.FNlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DName = new System.Windows.Forms.TextBox();
            this.Ddiscription = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.preDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addprelabel = new System.Windows.Forms.Label();
            this.addpre = new System.Windows.Forms.PictureBox();
            this.listViewMed = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxmed = new System.Windows.Forms.ComboBox();
            this.addmed = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addpre)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Home,
            this.contactus,
            this.exitprogram});
            this.toolStrip1.Location = new System.Drawing.Point(835, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(40, 563);
            this.toolStrip1.TabIndex = 53;
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
            // pEmail
            // 
            this.pEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pEmail.Location = new System.Drawing.Point(187, 126);
            this.pEmail.Name = "pEmail";
            this.pEmail.Size = new System.Drawing.Size(170, 22);
            this.pEmail.TabIndex = 54;
            // 
            // FNlabel
            // 
            this.FNlabel.AutoSize = true;
            this.FNlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FNlabel.Location = new System.Drawing.Point(53, 126);
            this.FNlabel.Name = "FNlabel";
            this.FNlabel.Size = new System.Drawing.Size(108, 20);
            this.FNlabel.TabIndex = 55;
            this.FNlabel.Text = "Pateint Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 57;
            this.label1.Text = "Disease Name";
            // 
            // DName
            // 
            this.DName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DName.Location = new System.Drawing.Point(187, 175);
            this.DName.Name = "DName";
            this.DName.Size = new System.Drawing.Size(170, 22);
            this.DName.TabIndex = 56;
            // 
            // Ddiscription
            // 
            this.Ddiscription.Location = new System.Drawing.Point(187, 229);
            this.Ddiscription.Name = "Ddiscription";
            this.Ddiscription.Size = new System.Drawing.Size(170, 96);
            this.Ddiscription.TabIndex = 58;
            this.Ddiscription.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 59;
            this.label2.Text = "Disease Discription";
            // 
            // preDate
            // 
            this.preDate.Location = new System.Drawing.Point(187, 354);
            this.preDate.Name = "preDate";
            this.preDate.Size = new System.Drawing.Size(200, 22);
            this.preDate.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(137, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 61;
            this.label3.Text = "date";
            this.label3.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // addprelabel
            // 
            this.addprelabel.AutoSize = true;
            this.addprelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addprelabel.Location = new System.Drawing.Point(466, 353);
            this.addprelabel.Name = "addprelabel";
            this.addprelabel.Size = new System.Drawing.Size(38, 20);
            this.addprelabel.TabIndex = 63;
            this.addprelabel.Text = "Add";
            this.addprelabel.Click += new System.EventHandler(this.addprelabel_Click);
            this.addprelabel.MouseHover += new System.EventHandler(this.addprelabel_hover);
            // 
            // addpre
            // 
            this.addpre.Image = ((System.Drawing.Image)(resources.GetObject("addpre.Image")));
            this.addpre.Location = new System.Drawing.Point(393, 334);
            this.addpre.Name = "addpre";
            this.addpre.Size = new System.Drawing.Size(67, 57);
            this.addpre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.addpre.TabIndex = 62;
            this.addpre.TabStop = false;
            this.addpre.Click += new System.EventHandler(this.addpre_Click);
            this.addpre.MouseHover += new System.EventHandler(this.addpre_hover);
            // 
            // listViewMed
            // 
            this.listViewMed.HideSelection = false;
            this.listViewMed.Location = new System.Drawing.Point(602, 126);
            this.listViewMed.Name = "listViewMed";
            this.listViewMed.Size = new System.Drawing.Size(211, 97);
            this.listViewMed.TabIndex = 64;
            this.listViewMed.UseCompatibleStateImageBehavior = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(389, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 65;
            this.label4.Text = "Medicines";
            // 
            // comboBoxmed
            // 
            this.comboBoxmed.FormattingEnabled = true;
            this.comboBoxmed.Location = new System.Drawing.Point(393, 124);
            this.comboBoxmed.Name = "comboBoxmed";
            this.comboBoxmed.Size = new System.Drawing.Size(121, 24);
            this.comboBoxmed.TabIndex = 66;
            // 
            // addmed
            // 
            this.addmed.Location = new System.Drawing.Point(521, 124);
            this.addmed.Name = "addmed";
            this.addmed.Size = new System.Drawing.Size(75, 23);
            this.addmed.TabIndex = 67;
            this.addmed.Text = "add";
            this.addmed.UseVisualStyleBackColor = true;
            this.addmed.Click += new System.EventHandler(this.addmed_Click);
            // 
            // AddPrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(241)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(875, 563);
            this.Controls.Add(this.addmed);
            this.Controls.Add(this.comboBoxmed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listViewMed);
            this.Controls.Add(this.addprelabel);
            this.Controls.Add(this.addpre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.preDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Ddiscription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DName);
            this.Controls.Add(this.FNlabel);
            this.Controls.Add(this.pEmail);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddPrescription";
            this.Text = "AddPrescription";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Addpre_close);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addpre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Home;
        private System.Windows.Forms.ToolStripButton contactus;
        private System.Windows.Forms.ToolStripButton exitprogram;
        private System.Windows.Forms.TextBox pEmail;
        private System.Windows.Forms.Label FNlabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DName;
        private System.Windows.Forms.RichTextBox Ddiscription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker preDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label addprelabel;
        private System.Windows.Forms.PictureBox addpre;
        private System.Windows.Forms.ListView listViewMed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxmed;
        private System.Windows.Forms.Button addmed;
    }
}