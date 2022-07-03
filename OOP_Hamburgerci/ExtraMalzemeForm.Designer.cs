
namespace OOP_Hamburgerci
{
    partial class ExtraMalzemeForm
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
            this.grbMalzemeBilgiler = new System.Windows.Forms.GroupBox();
            this.btnExtraEkle = new System.Windows.Forms.Button();
            this.nmrExtraFiyati = new System.Windows.Forms.NumericUpDown();
            this.txtExtraMalzemeler = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbMalzemeBilgiler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrExtraFiyati)).BeginInit();
            this.SuspendLayout();
            // 
            // grbMalzemeBilgiler
            // 
            this.grbMalzemeBilgiler.BackColor = System.Drawing.Color.LightPink;
            this.grbMalzemeBilgiler.Controls.Add(this.btnExtraEkle);
            this.grbMalzemeBilgiler.Controls.Add(this.nmrExtraFiyati);
            this.grbMalzemeBilgiler.Controls.Add(this.txtExtraMalzemeler);
            this.grbMalzemeBilgiler.Controls.Add(this.label2);
            this.grbMalzemeBilgiler.Controls.Add(this.label1);
            this.grbMalzemeBilgiler.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbMalzemeBilgiler.Location = new System.Drawing.Point(15, 11);
            this.grbMalzemeBilgiler.Name = "grbMalzemeBilgiler";
            this.grbMalzemeBilgiler.Size = new System.Drawing.Size(318, 179);
            this.grbMalzemeBilgiler.TabIndex = 1;
            this.grbMalzemeBilgiler.TabStop = false;
            this.grbMalzemeBilgiler.Text = "Extra Malzeme Bilgileri";
            // 
            // btnExtraEkle
            // 
            this.btnExtraEkle.BackColor = System.Drawing.Color.Orchid;
            this.btnExtraEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExtraEkle.Location = new System.Drawing.Point(127, 110);
            this.btnExtraEkle.Name = "btnExtraEkle";
            this.btnExtraEkle.Size = new System.Drawing.Size(167, 43);
            this.btnExtraEkle.TabIndex = 4;
            this.btnExtraEkle.Text = "EXTRA MALZEMEYI KAYDET";
            this.btnExtraEkle.UseVisualStyleBackColor = false;
            this.btnExtraEkle.Click += new System.EventHandler(this.btnExtraEkle_Click);
            // 
            // nmrExtraFiyati
            // 
            this.nmrExtraFiyati.Location = new System.Drawing.Point(127, 78);
            this.nmrExtraFiyati.Name = "nmrExtraFiyati";
            this.nmrExtraFiyati.Size = new System.Drawing.Size(167, 26);
            this.nmrExtraFiyati.TabIndex = 3;
            // 
            // txtExtraMalzemeler
            // 
            this.txtExtraMalzemeler.Location = new System.Drawing.Point(127, 29);
            this.txtExtraMalzemeler.Name = "txtExtraMalzemeler";
            this.txtExtraMalzemeler.Size = new System.Drawing.Size(167, 26);
            this.txtExtraMalzemeler.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 80);
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
            this.label1.Size = new System.Drawing.Size(97, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Malzeme Adi";
            // 
            // ExtraMalzemeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 200);
            this.Controls.Add(this.grbMalzemeBilgiler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExtraMalzemeForm";
            this.Text = "Ekstra Malzeme Bilgileri";
            this.grbMalzemeBilgiler.ResumeLayout(false);
            this.grbMalzemeBilgiler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrExtraFiyati)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbMalzemeBilgiler;
        private System.Windows.Forms.Button btnExtraEkle;
        private System.Windows.Forms.NumericUpDown nmrExtraFiyati;
        private System.Windows.Forms.TextBox txtExtraMalzemeler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}