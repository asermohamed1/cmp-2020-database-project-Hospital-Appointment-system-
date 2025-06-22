namespace HospitalAppointmentSystem
{
    partial class ContactUs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactUs));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.exitprogram = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addDoc = new System.Windows.Forms.PictureBox();
            this.adddoclabel = new System.Windows.Forms.Label();
            this.manHos = new System.Windows.Forms.PictureBox();
            this.manHoslabel = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addDoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manHos)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.exitprogram});
            this.toolStrip1.Location = new System.Drawing.Point(573, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(40, 328);
            this.toolStrip1.TabIndex = 69;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(37, 24);
            this.toolStripButton1.Text = "contact us";
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 68;
            this.pictureBox1.TabStop = false;
            // 
            // addDoc
            // 
            this.addDoc.Image = ((System.Drawing.Image)(resources.GetObject("addDoc.Image")));
            this.addDoc.Location = new System.Drawing.Point(203, 185);
            this.addDoc.Name = "addDoc";
            this.addDoc.Size = new System.Drawing.Size(67, 63);
            this.addDoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.addDoc.TabIndex = 73;
            this.addDoc.TabStop = false;
            // 
            // adddoclabel
            // 
            this.adddoclabel.AutoSize = true;
            this.adddoclabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adddoclabel.Location = new System.Drawing.Point(277, 203);
            this.adddoclabel.Name = "adddoclabel";
            this.adddoclabel.Size = new System.Drawing.Size(152, 22);
            this.adddoclabel.TabIndex = 72;
            this.adddoclabel.Text = "appin@gmail.com";
            // 
            // manHos
            // 
            this.manHos.Image = ((System.Drawing.Image)(resources.GetObject("manHos.Image")));
            this.manHos.Location = new System.Drawing.Point(203, 103);
            this.manHos.Name = "manHos";
            this.manHos.Size = new System.Drawing.Size(67, 63);
            this.manHos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.manHos.TabIndex = 71;
            this.manHos.TabStop = false;
            this.manHos.Click += new System.EventHandler(this.manHos_Click);
            // 
            // manHoslabel
            // 
            this.manHoslabel.AutoSize = true;
            this.manHoslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manHoslabel.Location = new System.Drawing.Point(277, 121);
            this.manHoslabel.Name = "manHoslabel";
            this.manHoslabel.Size = new System.Drawing.Size(120, 22);
            this.manHoslabel.TabIndex = 70;
            this.manHoslabel.Text = "01149365145";
            // 
            // ContactUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(241)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(613, 328);
            this.Controls.Add(this.addDoc);
            this.Controls.Add(this.adddoclabel);
            this.Controls.Add(this.manHos);
            this.Controls.Add(this.manHoslabel);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ContactUs";
            this.Text = "ContactUs";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.contactus_close);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addDoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manHos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton exitprogram;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox addDoc;
        private System.Windows.Forms.Label adddoclabel;
        private System.Windows.Forms.PictureBox manHos;
        private System.Windows.Forms.Label manHoslabel;
    }
}