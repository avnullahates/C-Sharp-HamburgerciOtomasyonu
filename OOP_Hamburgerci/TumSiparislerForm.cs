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
    public partial class TumSiparislerForm : Form
    {
        public TumSiparislerForm()
        {
            InitializeComponent();
        }

        private void TumSiparislerForm_Load(object sender, EventArgs e)
        {
            decimal ciro = 0;
            decimal ekstraMalzemeGeliri = 0;
            int satisAdeti = 0;
            foreach (Siparis siparis in SiparisOlusturForm.tumSiparisler)
            {
                ciro += siparis.ToplamTutar;
                foreach (Ekstra ekstraMalzeme in siparis.EkstraMalzeme)
                {
                    ekstraMalzemeGeliri += ekstraMalzeme.Fiyat;
                }
                satisAdeti += siparis.Adet;
                lbxTumSiparisler.Items.Add(siparis);
            }

            lblToplamSiparisSayisi.Text = lbxTumSiparisler.Items.Count.ToString();
            lblCiro.Text = ciro.ToString("c2");
            lblExtraMalzemeGeliri.Text = ekstraMalzemeGeliri.ToString("c2");
            lblSatilanUrunAdeti.Text = satisAdeti.ToString();

        }
    }
}
