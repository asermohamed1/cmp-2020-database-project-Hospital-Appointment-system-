namespace HospitalAppointmentSystem
{
    partial class PatientInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientInfo));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Home = new System.Windows.Forms.ToolStripButton();
            this.contactus = new System.Windows.Forms.ToolStripButton();
            this.exitprogram = new System.Windows.Forms.ToolStripButton();
            this.FNlabel = new System.Windows.Forms.Label();
            this.pEmail = new System.Windows.Forms.TextBox();
            this.pMedHist = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.DName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxyear = new System.Windows.Forms.TextBox();
            this.addDis = new System.Windows.Forms.RadioButton();
            this.cured = new System.Windows.Forms.RadioButton();
            this.submit = new System.Windows.Forms.Button();
            this.show = new System.Windows.Forms.Button();
            this.PPrescription = new System.Windows.Forms.DataGridView();
            this.showBuutton = new System.Windows.Forms.Button();
            this.showButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pMedHist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PPrescription)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, 0);
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
            this.Home,
            this.contactus,
            this.exitprogram});
            this.toolStrip1.Location = new System.Drawing.Point(1033, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(40, 662);
            this.toolStrip1.TabIndex = 54;
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
            // FNlabel
            // 
            this.FNlabel.AutoSize = true;
            this.FNlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FNlabel.Location = new System.Drawing.Point(52, 115);
            this.FNlabel.Name = "FNlabel";
            this.FNlabel.Size = new System.Drawing.Size(108, 20);
            this.FNlabel.TabIndex = 57;
            this.FNlabel.Text = "Pateint Email";
            // 
            // pEmail
            // 
            this.pEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pEmail.Location = new System.Drawing.Point(186, 115);
            this.pEmail.Name = "pEmail";
            this.pEmail.Size = new System.Drawing.Size(170, 22);
            this.pEmail.TabIndex = 56;
            // 
            // pMedHist
            // 
            this.pMedHist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pMedHist.Location = new System.Drawing.Point(396, 115);
            this.pMedHist.Name = "pMedHist";
            this.pMedHist.RowHeadersWidth = 51;
            this.pMedHist.RowTemplate.Height = 24;
            this.pMedHist.Size = new System.Drawing.Size(309, 112);
            this.pMedHist.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 61;
            this.label2.Text = "Disease Discription";
            // 
            // DName
            // 
            this.DName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DName.Location = new System.Drawing.Point(186, 271);
            this.DName.Name = "DName";
            this.DName.Size = new System.Drawing.Size(170, 22);
            this.DName.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 64;
            this.label1.Text = "Year";
            // 
            // textBoxyear
            // 
            this.textBoxyear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxyear.Location = new System.Drawing.Point(186, 324);
            this.textBoxyear.Name = "textBoxyear";
            this.textBoxyear.Size = new System.Drawing.Size(73, 22);
            this.textBoxyear.TabIndex = 63;
            // 
            // addDis
            // 
            this.addDis.AutoSize = true;
            this.addDis.Location = new System.Drawing.Point(396, 270);
            this.addDis.Name = "addDis";
            this.addDis.Size = new System.Drawing.Size(137, 20);
            this.addDis.TabIndex = 65;
            this.addDis.TabStop = true;
            this.addDis.Text = "Add New Disease";
            this.addDis.UseVisualStyleBackColor = true;
            // 
            // cured
            // 
            this.cured.AutoSize = true;
            this.cured.Location = new System.Drawing.Point(396, 296);
            this.cured.Name = "cured";
            this.cured.Size = new System.Drawing.Size(116, 20);
            this.cured.TabIndex = 66;
            this.cured.TabStop = true;
            this.cured.Text = "Mark As Cured";
            this.cured.UseVisualStyleBackColor = true;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(396, 340);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 68;
            this.submit.Text = "submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // show
            // 
            this.show.Location = new System.Drawing.Point(186, 166);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(75, 23);
            this.show.TabIndex = 69;
            this.show.Text = "show";
            this.show.UseVisualStyleBackColor = true;
            // 
            // PPrescription
            // 
            this.PPrescription.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PPrescription.Location = new System.Drawing.Point(711, 115);
            this.PPrescription.Name = "PPrescription";
            this.PPrescription.RowHeadersWidth = 51;
            this.PPrescription.RowTemplate.Height = 24;
            this.PPrescription.Size = new System.Drawing.Size(309, 112);
            this.PPrescription.TabIndex = 67;
            // 
            // showBuutton
            // 
            this.showBuutton.Location = new System.Drawing.Point(396, 326);
            this.showBuutton.Name = "showBuutton";
            this.showBuutton.Size = new System.Drawing.Size(75, 23);
            this.showBuutton.TabIndex = 68;
            this.showBuutton.Text = "submit";
            this.showBuutton.UseVisualStyleBackColor = true;
            this.showBuutton.Click += new System.EventHandler(this.showBuutton_Click);
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(281, 158);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 69;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // PatientInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(241)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(1073, 662);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.showBuutton);
            this.Controls.Add(this.PPrescription);
            this.Controls.Add(this.cured);
            this.Controls.Add(this.addDis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxyear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DName);
            this.Controls.Add(this.pMedHist);
            this.Controls.Add(this.FNlabel);
            this.Controls.Add(this.pEmail);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PatientInfo";
            this.Text = "PatientInfo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.patinfo_close);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pMedHist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PPrescription)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Home;
        private System.Windows.Forms.ToolStripButton contactus;
        private System.Windows.Forms.ToolStripButton exitprogram;
        private System.Windows.Forms.Label FNlabel;
        private System.Windows.Forms.TextBox pEmail;
        private System.Windows.Forms.DataGridView pMedHist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxyear;
        private System.Windows.Forms.RadioButton addDis;
        private System.Windows.Forms.RadioButton cured;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.DataGridView PPrescription;
        private System.Windows.Forms.Button showBuutton;
        private System.Windows.Forms.Button showButton;
    }
}