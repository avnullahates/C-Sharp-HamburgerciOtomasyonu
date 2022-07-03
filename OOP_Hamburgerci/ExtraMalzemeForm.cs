using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Hamburgerci
{
    public partial class ExtraMalzemeForm : Form
    {
        public ExtraMalzemeForm()
        {
            InitializeComponent();
        }

        private void btnExtraEkle_Click(object sender, EventArgs e)
        {
            SiparisOlusturForm.ekstralar.Add(new Ekstra { EkstraAdi = txtExtraMalzemeler.Text, Fiyat = nmrExtraFiyati.Value });
            Fonksiyon.Temizle(this.Controls);

            MessageBox.Show("Ekstra Basarili Sekilde Eklendi");
        }
    }
}
