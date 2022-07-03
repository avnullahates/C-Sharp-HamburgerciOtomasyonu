
namespace OOP_Hamburgerci
{
    partial class SiparisOlusturForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiparisOlusturForm));
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.cmbMenuler = new System.Windows.Forms.ComboBox();
            this.rdKucuk = new System.Windows.Forms.RadioButton();
            this.rdBuyuk = new System.Windows.Forms.RadioButton();
            this.rdOrta = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flpExtraMalzemeler = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.nmrAdet = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSiparisEkle = new System.Windows.Forms.Button();
            this.lbxSiparisler = new System.Windows.Forms.ListBox();
            this.btnSiparisTamamla = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbltoplamTutar = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(13, 13);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(199, 95);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // cmbMenuler
            // 
            this.cmbMenuler.FormattingEnabled = true;
            this.cmbMenuler.Location = new System.Drawing.Point(13, 130);
            this.cmbMenuler.Name = "cmbMenuler";
            this.cmbMenuler.Size = new System.Drawing.Size(275, 21);
            this.cmbMenuler.TabIndex = 1;
            // 
            // rdKucuk
            // 
            this.rdKucuk.AutoSize = true;
            this.rdKucuk.Location = new System.Drawing.Point(15, 19);
            this.rdKucuk.Name = "rdKucuk";
            this.rdKucuk.Size = new System.Drawing.Size(61, 17);
            this.rdKucuk.TabIndex = 2;
            this.rdKucuk.TabStop = true;
            this.rdKucuk.Text = "Kucuk";
            this.rdKucuk.UseVisualStyleBackColor = true;
            // 
            // rdBuyuk
            // 
            this.rdBuyuk.AutoSize = true;
            this.rdBuyuk.Location = new System.Drawing.Point(15, 65);
            this.rdBuyuk.Name = "rdBuyuk";
            this.rdBuyuk.Size = new System.Drawing.Size(60, 17);
            this.rdBuyuk.TabIndex = 3;
            this.rdBuyuk.TabStop = true;
            this.rdBuyuk.Text = "Buyuk";
            this.rdBuyuk.UseVisualStyleBackColor = true;
            // 
            // rdOrta
            // 
            this.rdOrta.AutoSize = true;
            this.rdOrta.Location = new System.Drawing.Point(15, 42);
            this.rdOrta.Name = "rdOrta";
            this.rdOrta.Size = new System.Drawing.Size(49, 17);
            this.rdOrta.TabIndex = 4;
            this.rdOrta.TabStop = true;
            this.rdOrta.Text = "Orta";
            this.rdOrta.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdKucuk);
            this.groupBox1.Controls.Add(this.rdOrta);
            this.groupBox1.Controls.Add(this.rdBuyuk);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Teal;
            this.groupBox1.Location = new System.Drawing.Point(13, 175);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 113);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BOYUT SECINIZ";
            // 
            // flpExtraMalzemeler
            // 
            this.flpExtraMalzemeler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpExtraMalzemeler.Location = new System.Drawing.Point(13, 320);
            this.flpExtraMalzemeler.Name = "flpExtraMalzemeler";
            this.flpExtraMalzemeler.Size = new System.Drawing.Size(328, 143);
            this.flpExtraMalzemeler.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(13, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "EXTRA MALZEME SECINIZ";
            // 
            // nmrAdet
            // 
            this.nmrAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrAdet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nmrAdet.Location = new System.Drawing.Point(66, 469);
            this.nmrAdet.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nmrAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrAdet.Name = "nmrAdet";
            this.nmrAdet.Size = new System.Drawing.Size(120, 23);
            this.nmrAdet.TabIndex = 0;
            this.nmrAdet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmrAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(16, 473);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "ADET:";
            // 
            // btnSiparisEkle
            // 
            this.btnSiparisEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSiparisEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiparisEkle.ForeColor = System.Drawing.Color.Red;
            this.btnSiparisEkle.Location = new System.Drawing.Point(16, 505);
            this.btnSiparisEkle.Name = "btnSiparisEkle";
            this.btnSiparisEkle.Size = new System.Drawing.Size(253, 41);
            this.btnSiparisEkle.TabIndex = 9;
            this.btnSiparisEkle.Text = "SIPARIS EKLE";
            this.btnSiparisEkle.UseVisualStyleBackColor = false;
            this.btnSiparisEkle.Click += new System.EventHandler(this.btnSiparisEkle_Click);
            // 
            // lbxSiparisler
            // 
            this.lbxSiparisler.FormattingEnabled = true;
            this.lbxSiparisler.Location = new System.Drawing.Point(350, 13);
            this.lbxSiparisler.Name = "lbxSiparisler";
            this.lbxSiparisler.Size = new System.Drawing.Size(450, 407);
            this.lbxSiparisler.TabIndex = 10;
            // 
            // btnSiparisTamamla
            // 
            this.btnSiparisTamamla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiparisTamamla.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSiparisTamamla.Location = new System.Drawing.Point(350, 445);
            this.btnSiparisTamamla.Name = "btnSiparisTamamla";
            this.btnSiparisTamamla.Size = new System.Drawing.Size(170, 41);
            this.btnSiparisTamamla.TabIndex = 11;
            this.btnSiparisTamamla.Text = "SIPARIS TAMAMLA";
            this.btnSiparisTamamla.UseVisualStyleBackColor = true;
            this.btnSiparisTamamla.Click += new System.EventHandler(this.btnSiparisTamamla_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(347, 429);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "TOPLAM TUTAR: ";
            // 
            // lbltoplamTutar
            // 
            this.lbltoplamTutar.AutoSize = true;
            this.lbltoplamTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltoplamTutar.ForeColor = System.Drawing.Color.Red;
            this.lbltoplamTutar.Location = new System.Drawing.Point(464, 429);
            this.lbltoplamTutar.Name = "lbltoplamTutar";
            this.lbltoplamTutar.Size = new System.Drawing.Size(14, 13);
            this.lbltoplamTutar.TabIndex = 13;
            this.lbltoplamTutar.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(13, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "MENU SECIN";
            // 
            // SiparisOlusturForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 626);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbltoplamTutar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSiparisTamamla);
            this.Controls.Add(this.lbxSiparisler);
            this.Controls.Add(this.btnSiparisEkle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nmrAdet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flpExtraMalzemeler);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbMenuler);
            this.Controls.Add(this.pbLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SiparisOlusturForm";
            this.Text = "SiparisOlustur";
            this.Load += new System.EventHandler(this.SiparisOlusturForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.ComboBox cmbMenuler;
        private System.Windows.Forms.RadioButton rdKucuk;
        private System.Windows.Forms.RadioButton rdBuyuk;
        private System.Windows.Forms.RadioButton rdOrta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flpExtraMalzemeler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmrAdet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSiparisEkle;
        private System.Windows.Forms.ListBox lbxSiparisler;
        private System.Windows.Forms.Button btnSiparisTamamla;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbltoplamTutar;
        private System.Windows.Forms.Label label4;
    }
}