
namespace OOP_Hamburgerci
{
    partial class MyMdiForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.siparisYonetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSiparisOlustur = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSpiarisBilgiler = new System.Windows.Forms.ToolStripMenuItem();
            this.urunYonetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMenuEkleme = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExtraEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparisYonetimiToolStripMenuItem,
            this.urunYonetimiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // siparisYonetimiToolStripMenuItem
            // 
            this.siparisYonetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSiparisOlustur,
            this.tsmSpiarisBilgiler});
            this.siparisYonetimiToolStripMenuItem.Name = "siparisYonetimiToolStripMenuItem";
            this.siparisYonetimiToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.siparisYonetimiToolStripMenuItem.Text = "Siparis Yonetimi";
            // 
            // tsmSiparisOlustur
            // 
            this.tsmSiparisOlustur.Name = "tsmSiparisOlustur";
            this.tsmSiparisOlustur.Size = new System.Drawing.Size(150, 22);
            this.tsmSiparisOlustur.Text = "Siparis Olustur";
            this.tsmSiparisOlustur.Click += new System.EventHandler(this.tsmSiparisOlustur_Click);
            // 
            // tsmSpiarisBilgiler
            // 
            this.tsmSpiarisBilgiler.Name = "tsmSpiarisBilgiler";
            this.tsmSpiarisBilgiler.Size = new System.Drawing.Size(150, 22);
            this.tsmSpiarisBilgiler.Text = "Siparis Bilgileri";
            this.tsmSpiarisBilgiler.Click += new System.EventHandler(this.tsmSpiarisBilgiler_Click);
            // 
            // urunYonetimiToolStripMenuItem
            // 
            this.urunYonetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmMenuEkleme,
            this.tsmExtraEkle});
            this.urunYonetimiToolStripMenuItem.Name = "urunYonetimiToolStripMenuItem";
            this.urunYonetimiToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.urunYonetimiToolStripMenuItem.Text = "Urun Yonetimi";
            // 
            // tsmMenuEkleme
            // 
            this.tsmMenuEkleme.Name = "tsmMenuEkleme";
            this.tsmMenuEkleme.Size = new System.Drawing.Size(180, 22);
            this.tsmMenuEkleme.Text = "Menu Ekle";
            this.tsmMenuEkleme.Click += new System.EventHandler(this.tsmMenuEkleme_Click);
            // 
            // tsmExtraEkle
            // 
            this.tsmExtraEkle.Name = "tsmExtraEkle";
            this.tsmExtraEkle.Size = new System.Drawing.Size(180, 22);
            this.tsmExtraEkle.Text = "Ekstra Malzeme Ekle";
            this.tsmExtraEkle.Click += new System.EventHandler(this.tsmExtraEkle_Click);
            // 
            // MyMdiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MyMdiForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem siparisYonetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmSiparisOlustur;
        private System.Windows.Forms.ToolStripMenuItem tsmSpiarisBilgiler;
        private System.Windows.Forms.ToolStripMenuItem urunYonetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmMenuEkleme;
        private System.Windows.Forms.ToolStripMenuItem tsmExtraEkle;
    }
}

