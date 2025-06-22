namespace HospitalAppointmentSystem
{
    partial class medicines
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(medicines));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Home = new System.Windows.Forms.ToolStripButton();
            this.contactus = new System.Windows.Forms.ToolStripButton();
            this.exitprogram = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ListOfMed = new System.Windows.Forms.ComboBox();
            this.greeting = new System.Windows.Forms.Label();
            this.MedinStock = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Medamount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.upmedlabel = new System.Windows.Forms.Label();
            this.upmed = new System.Windows.Forms.PictureBox();
            this.addmedlabel = new System.Windows.Forms.Label();
            this.addMed = new System.Windows.Forms.PictureBox();
            this.delmedic = new System.Windows.Forms.PictureBox();
            this.delmedabel4 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MedinStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upmed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addMed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delmedic)).BeginInit();
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
            this.toolStrip1.Location = new System.Drawing.Point(813, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(30, 464);
            this.toolStrip1.TabIndex = 68;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 67;
            this.pictureBox1.TabStop = false;
            // 
            // ListOfMed
            // 
            this.ListOfMed.FormattingEnabled = true;
            this.ListOfMed.Location = new System.Drawing.Point(190, 332);
            this.ListOfMed.Name = "ListOfMed";
            this.ListOfMed.Size = new System.Drawing.Size(175, 24);
            this.ListOfMed.TabIndex = 69;
            // 
            // greeting
            // 
            this.greeting.AutoSize = true;
            this.greeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greeting.Location = new System.Drawing.Point(48, 330);
            this.greeting.Name = "greeting";
            this.greeting.Size = new System.Drawing.Size(136, 22);
            this.greeting.TabIndex = 70;
            this.greeting.Text = "Select Medicine";
            this.greeting.Click += new System.EventHandler(this.greeting_Click);
            // 
            // MedinStock
            // 
            this.MedinStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MedinStock.Location = new System.Drawing.Point(207, 129);
            this.MedinStock.Name = "MedinStock";
            this.MedinStock.RowHeadersWidth = 51;
            this.MedinStock.RowTemplate.Height = 24;
            this.MedinStock.Size = new System.Drawing.Size(439, 108);
            this.MedinStock.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 22);
            this.label1.TabIndex = 72;
            this.label1.Text = "Medicine In Stock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 16);
            this.label2.TabIndex = 73;
            this.label2.Text = "Add Medicine or Update Medicine in Stock";
            // 
            // Medamount
            // 
            this.Medamount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Medamount.Location = new System.Drawing.Point(568, 330);
            this.Medamount.Name = "Medamount";
            this.Medamount.Size = new System.Drawing.Size(78, 22);
            this.Medamount.TabIndex = 115;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-3, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(807, 16);
            this.label6.TabIndex = 116;
            this.label6.Text = "---------------------------------------------------------------------------------" +
    "--------------------------------------------------------------------------------" +
    "---------------------------------------";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(409, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 22);
            this.label3.TabIndex = 117;
            this.label3.Text = "Medicine Quantity";
            // 
            // upmedlabel
            // 
            this.upmedlabel.AutoSize = true;
            this.upmedlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upmedlabel.Location = new System.Drawing.Point(725, 333);
            this.upmedlabel.Name = "upmedlabel";
            this.upmedlabel.Size = new System.Drawing.Size(62, 20);
            this.upmedlabel.TabIndex = 119;
            this.upmedlabel.Text = "Update";
            this.upmedlabel.MouseHover += new System.EventHandler(this.upmedlabel_hover);
            // 
            // upmed
            // 
            this.upmed.Image = ((System.Drawing.Image)(resources.GetObject("upmed.Image")));
            this.upmed.Location = new System.Drawing.Point(652, 316);
            this.upmed.Name = "upmed";
            this.upmed.Size = new System.Drawing.Size(67, 57);
            this.upmed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.upmed.TabIndex = 118;
            this.upmed.TabStop = false;
            this.upmed.Click += new System.EventHandler(this.upmed_Click);
            this.upmed.MouseHover += new System.EventHandler(this.upmed_hover);
            // 
            // addmedlabel
            // 
            this.addmedlabel.AutoSize = true;
            this.addmedlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addmedlabel.Location = new System.Drawing.Point(725, 398);
            this.addmedlabel.Name = "addmedlabel";
            this.addmedlabel.Size = new System.Drawing.Size(38, 20);
            this.addmedlabel.TabIndex = 121;
            this.addmedlabel.Text = "Add";
            this.addmedlabel.MouseHover += new System.EventHandler(this.addmedlabel_hover);
            // 
            // addMed
            // 
            this.addMed.Image = ((System.Drawing.Image)(resources.GetObject("addMed.Image")));
            this.addMed.Location = new System.Drawing.Point(652, 379);
            this.addMed.Name = "addMed";
            this.addMed.Size = new System.Drawing.Size(67, 57);
            this.addMed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.addMed.TabIndex = 120;
            this.addMed.TabStop = false;
            this.addMed.Click += new System.EventHandler(this.addMed_Click);
            this.addMed.MouseHover += new System.EventHandler(this.addmed_hover);
            // 
            // delmedic
            // 
            this.delmedic.Image = ((System.Drawing.Image)(resources.GetObject("delmedic.Image")));
            this.delmedic.Location = new System.Drawing.Point(64, 379);
            this.delmedic.Name = "delmedic";
            this.delmedic.Size = new System.Drawing.Size(67, 57);
            this.delmedic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.delmedic.TabIndex = 125;
            this.delmedic.TabStop = false;
            this.delmedic.Click += new System.EventHandler(this.delmedic_Click);
            // 
            // delmedabel4
            // 
            this.delmedabel4.AutoSize = true;
            this.delmedabel4.Location = new System.Drawing.Point(137, 401);
            this.delmedabel4.Name = "delmedabel4";
            this.delmedabel4.Size = new System.Drawing.Size(60, 16);
            this.delmedabel4.TabIndex = 126;
            this.delmedabel4.Text = "DELETE";
            // 
            // medicines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(241)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(843, 464);
            this.Controls.Add(this.delmedabel4);
            this.Controls.Add(this.delmedic);
            this.Controls.Add(this.addmedlabel);
            this.Controls.Add(this.addMed);
            this.Controls.Add(this.upmedlabel);
            this.Controls.Add(this.upmed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Medamount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MedinStock);
            this.Controls.Add(this.greeting);
            this.Controls.Add(this.ListOfMed);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "medicines";
            this.Text = "Medicines";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Med_close);
            this.Load += new System.EventHandler(this.medicines_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MedinStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upmed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addMed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delmedic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Home;
        private System.Windows.Forms.ToolStripButton contactus;
        private System.Windows.Forms.ToolStripButton exitprogram;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox ListOfMed;
        private System.Windows.Forms.Label greeting;
        private System.Windows.Forms.DataGridView MedinStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Medamount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label upmedlabel;
        private System.Windows.Forms.PictureBox upmed;
        private System.Windows.Forms.Label addmedlabel;
        private System.Windows.Forms.PictureBox addMed;
        private System.Windows.Forms.PictureBox delmedic;
        private System.Windows.Forms.Label delmedabel4;
    }
}