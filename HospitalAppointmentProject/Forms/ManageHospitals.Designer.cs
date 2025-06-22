namespace HospitalAppointmentSystem
{
    partial class ManageHospitals
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageHospitals));
            this.label1 = new System.Windows.Forms.Label();
            this.modHoslabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Timfrom = new System.Windows.Forms.TextBox();
            this.timeto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sat = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fri = new System.Windows.Forms.CheckBox();
            this.weden = new System.Windows.Forms.CheckBox();
            this.thur = new System.Windows.Forms.CheckBox();
            this.tues = new System.Windows.Forms.CheckBox();
            this.mon = new System.Windows.Forms.CheckBox();
            this.sun = new System.Windows.Forms.CheckBox();
            this.Ava = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.upHos = new System.Windows.Forms.Button();
            this.HosLoction = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.HosPN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.HosEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.HosName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Home = new System.Windows.Forms.ToolStripButton();
            this.contactus = new System.Windows.Forms.ToolStripButton();
            this.exitprogram = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "Set Hospital Availabelity";
            // 
            // modHoslabel
            // 
            this.modHoslabel.AutoSize = true;
            this.modHoslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modHoslabel.Location = new System.Drawing.Point(362, 134);
            this.modHoslabel.Name = "modHoslabel";
            this.modHoslabel.Size = new System.Drawing.Size(82, 22);
            this.modHoslabel.TabIndex = 60;
            this.modHoslabel.Text = "Set Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(363, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 61;
            this.label2.Text = "from";
            // 
            // Timfrom
            // 
            this.Timfrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Timfrom.Location = new System.Drawing.Point(402, 171);
            this.Timfrom.Name = "Timfrom";
            this.Timfrom.Size = new System.Drawing.Size(69, 22);
            this.Timfrom.TabIndex = 62;
            // 
            // timeto
            // 
            this.timeto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeto.Location = new System.Drawing.Point(518, 171);
            this.timeto.Name = "timeto";
            this.timeto.Size = new System.Drawing.Size(69, 22);
            this.timeto.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(494, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 16);
            this.label3.TabIndex = 63;
            this.label3.Text = "to";
            // 
            // sat
            // 
            this.sat.AutoSize = true;
            this.sat.Location = new System.Drawing.Point(24, 31);
            this.sat.Name = "sat";
            this.sat.Size = new System.Drawing.Size(83, 20);
            this.sat.TabIndex = 65;
            this.sat.Text = "Saturday";
            this.sat.UseVisualStyleBackColor = true;
            this.sat.CheckedChanged += new System.EventHandler(this.sat_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fri);
            this.groupBox1.Controls.Add(this.weden);
            this.groupBox1.Controls.Add(this.thur);
            this.groupBox1.Controls.Add(this.tues);
            this.groupBox1.Controls.Add(this.mon);
            this.groupBox1.Controls.Add(this.sun);
            this.groupBox1.Controls.Add(this.sat);
            this.groupBox1.Location = new System.Drawing.Point(38, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 218);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Open Days";
            // 
            // fri
            // 
            this.fri.AutoSize = true;
            this.fri.Location = new System.Drawing.Point(24, 187);
            this.fri.Name = "fri";
            this.fri.Size = new System.Drawing.Size(67, 20);
            this.fri.TabIndex = 71;
            this.fri.Text = "Friday";
            this.fri.UseVisualStyleBackColor = true;
            this.fri.CheckedChanged += new System.EventHandler(this.fri_CheckedChanged);
            // 
            // weden
            // 
            this.weden.AutoSize = true;
            this.weden.Location = new System.Drawing.Point(24, 135);
            this.weden.Name = "weden";
            this.weden.Size = new System.Drawing.Size(103, 20);
            this.weden.TabIndex = 70;
            this.weden.Text = "Wednesday";
            this.weden.UseVisualStyleBackColor = true;
            this.weden.CheckedChanged += new System.EventHandler(this.weden_CheckedChanged);
            // 
            // thur
            // 
            this.thur.AutoSize = true;
            this.thur.Location = new System.Drawing.Point(24, 161);
            this.thur.Name = "thur";
            this.thur.Size = new System.Drawing.Size(86, 20);
            this.thur.TabIndex = 69;
            this.thur.Text = "Thursday";
            this.thur.UseVisualStyleBackColor = true;
            this.thur.CheckedChanged += new System.EventHandler(this.thur_CheckedChanged);
            // 
            // tues
            // 
            this.tues.AutoSize = true;
            this.tues.Location = new System.Drawing.Point(24, 109);
            this.tues.Name = "tues";
            this.tues.Size = new System.Drawing.Size(83, 20);
            this.tues.TabIndex = 68;
            this.tues.Text = "Tuesday";
            this.tues.UseVisualStyleBackColor = true;
            this.tues.CheckedChanged += new System.EventHandler(this.tues_CheckedChanged);
            // 
            // mon
            // 
            this.mon.AutoSize = true;
            this.mon.Location = new System.Drawing.Point(24, 83);
            this.mon.Name = "mon";
            this.mon.Size = new System.Drawing.Size(78, 20);
            this.mon.TabIndex = 67;
            this.mon.Text = "Monday";
            this.mon.UseVisualStyleBackColor = true;
            this.mon.CheckedChanged += new System.EventHandler(this.mon_CheckedChanged);
            // 
            // sun
            // 
            this.sun.AutoSize = true;
            this.sun.Location = new System.Drawing.Point(24, 57);
            this.sun.Name = "sun";
            this.sun.Size = new System.Drawing.Size(75, 20);
            this.sun.TabIndex = 66;
            this.sun.Text = "Sunday";
            this.sun.UseVisualStyleBackColor = true;
            this.sun.CheckedChanged += new System.EventHandler(this.sun_CheckedChanged);
            // 
            // Ava
            // 
            this.Ava.AutoSize = true;
            this.Ava.Location = new System.Drawing.Point(218, 118);
            this.Ava.Name = "Ava";
            this.Ava.Size = new System.Drawing.Size(99, 20);
            this.Ava.TabIndex = 67;
            this.Ava.Text = "Is Available";
            this.Ava.UseVisualStyleBackColor = true;
            this.Ava.CheckedChanged += new System.EventHandler(this.Ava_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-4, 387);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(979, 16);
            this.label6.TabIndex = 73;
            this.label6.Text = resources.GetString("label6.Text");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 419);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 16);
            this.label4.TabIndex = 74;
            this.label4.Text = "Edit Hospital Information";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(611, 170);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 75;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // upHos
            // 
            this.upHos.Location = new System.Drawing.Point(435, 616);
            this.upHos.Name = "upHos";
            this.upHos.Size = new System.Drawing.Size(119, 23);
            this.upHos.TabIndex = 84;
            this.upHos.Text = "Update Hospital";
            this.upHos.UseVisualStyleBackColor = true;
            this.upHos.Click += new System.EventHandler(this.upHos_Click);
            // 
            // HosLoction
            // 
            this.HosLoction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HosLoction.Location = new System.Drawing.Point(269, 616);
            this.HosLoction.Name = "HosLoction";
            this.HosLoction.Size = new System.Drawing.Size(127, 22);
            this.HosLoction.TabIndex = 83;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(85, 615);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 20);
            this.label5.TabIndex = 82;
            this.label5.Text = "Hospital Location";
            // 
            // HosPN
            // 
            this.HosPN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HosPN.Location = new System.Drawing.Point(269, 565);
            this.HosPN.Name = "HosPN";
            this.HosPN.Size = new System.Drawing.Size(127, 22);
            this.HosPN.TabIndex = 81;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(83, 567);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 20);
            this.label7.TabIndex = 80;
            this.label7.Text = "Hospital PhoneNumber";
            // 
            // HosEmail
            // 
            this.HosEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HosEmail.Location = new System.Drawing.Point(269, 507);
            this.HosEmail.Name = "HosEmail";
            this.HosEmail.Size = new System.Drawing.Size(127, 22);
            this.HosEmail.TabIndex = 79;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(83, 509);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 20);
            this.label8.TabIndex = 78;
            this.label8.Text = "Hospital Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(83, 454);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 20);
            this.label9.TabIndex = 77;
            this.label9.Text = "Hospital Name";
            // 
            // HosName
            // 
            this.HosName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HosName.Location = new System.Drawing.Point(269, 449);
            this.HosName.Name = "HosName";
            this.HosName.Size = new System.Drawing.Size(127, 22);
            this.HosName.TabIndex = 76;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -4);
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
            this.toolStrip1.Location = new System.Drawing.Point(938, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(30, 695);
            this.toolStrip1.TabIndex = 85;
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
            // ManageHospitals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(241)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(968, 695);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.upHos);
            this.Controls.Add(this.HosLoction);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.HosPN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.HosEmail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.HosName);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Ava);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.timeto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Timfrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.modHoslabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageHospitals";
            this.Text = "ManageHospitals";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Manhos_close);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label modHoslabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Timfrom;
        private System.Windows.Forms.TextBox timeto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox sat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox fri;
        private System.Windows.Forms.CheckBox weden;
        private System.Windows.Forms.CheckBox thur;
        private System.Windows.Forms.CheckBox tues;
        private System.Windows.Forms.CheckBox mon;
        private System.Windows.Forms.CheckBox sun;
        private System.Windows.Forms.CheckBox Ava;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button upHos;
        private System.Windows.Forms.TextBox HosLoction;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox HosPN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox HosEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox HosName;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Home;
        private System.Windows.Forms.ToolStripButton exitprogram;
        private System.Windows.Forms.ToolStripButton contactus;
    }
}