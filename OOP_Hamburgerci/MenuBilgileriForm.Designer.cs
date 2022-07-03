
namespace OOP_Hamburgerci
{
    partial class MenuBilgileriForm
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
            this.grbMenuBilgileri = new System.Windows.Forms.GroupBox();
            this.btnMenuEkle = new System.Windows.Forms.Button();
            this.nmrMeniFiyati = new System.Windows.Forms.NumericUpDown();
            this.txtMenuAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbMenuBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrMeniFiyati)).BeginInit();
            this.SuspendLayout();
            // 
            // grbMenuBilgileri
            // 
            this.grbMenuBilgileri.BackColor = System.Drawing.Color.LightPink;
            this.grbMenuBilgileri.Controls.Add(this.btnMenuEkle);
            this.grbMenuBilgileri.Controls.Add(this.nmrMeniFiyati);
            this.grbMenuBilgileri.Controls.Add(this.txtMenuAdi);
            this.grbMenuBilgileri.Controls.Add(this.label2);
            this.grbMenuBilgileri.Controls.Add(this.label1);
            this.grbMenuBilgileri.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbMenuBilgileri.Location = new System.Drawing.Point(13, 13);
            this.grbMenuBilgileri.Name = "grbMenuBilgileri";
            this.grbMenuBilgileri.Size = new System.Drawing.Size(318, 179);
            this.grbMenuBilgileri.TabIndex = 0;
            this.grbMenuBilgileri.TabStop = false;
            this.grbMenuBilgileri.Text = "Menu Bilgileri";
            // 
            // btnMenuEkle
            // 
            this.btnMenuEkle.BackColor = System.Drawing.Color.Orchid;
            this.btnMenuEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMenuEkle.Location = new System.Drawing.Point(105, 110);
            this.btnMenuEkle.Name = "btnMenuEkle";
            this.btnMenuEkle.Size = new System.Drawing.Size(167, 43);
            this.btnMenuEkle.TabIndex = 4;
            this.btnMenuEkle.Text = "MENUYU KAYDET";
            this.btnMenuEkle.UseVisualStyleBackColor = false;
            this.btnMenuEkle.Click += new System.EventHandler(this.btnMenuEkle_Click);
            // 
            // nmrMeniFiyati
            // 
            this.nmrMeniFiyati.Location = new System.Drawing.Point(105, 78);
            this.nmrMeniFiyati.Name = "nmrMeniFiyati";
            this.nmrMeniFiyati.Size = new System.Drawing.Size(167, 26);
            this.nmrMeniFiyati.TabIndex = 3;
            // 
            // txtMenuAdi
            // 
            this.txtMenuAdi.Location = new System.Drawing.Point(105, 29);
            this.txtMenuAdi.Name = "txtMenuAdi";
            this.txtMenuAdi.Size = new System.Drawing.Size(167, 26);
            this.txtMenuAdi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fiyati";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu Adi";
            // 
            // MenuBilgileriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 204);
            this.Controls.Add(this.grbMenuBilgileri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuBilgileriForm";
            this.Text = "Menu Bilgiler";
            this.grbMenuBilgileri.ResumeLayout(false);
            this.grbMenuBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrMeniFiyati)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbMenuBilgileri;
        private System.Windows.Forms.Button btnMenuEkle;
        private System.Windows.Forms.NumericUpDown nmrMeniFiyati;
        private System.Windows.Forms.TextBox txtMenuAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}