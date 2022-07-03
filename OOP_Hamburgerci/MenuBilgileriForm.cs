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
    public partial class MenuBilgileriForm : Form
    {
        public MenuBilgileriForm()
        {
            InitializeComponent();
        }

        private void btnMenuEkle_Click(object sender, EventArgs e)
        {
            SiparisOlusturForm.menuler.Add(new Menu { MenuAdi = txtMenuAdi.Text, Fiyati = nmrMeniFiyati.Value });

            Fonksiyon.Temizle(this.Controls);
            MessageBox.Show("Menu Basarili Sekilde Eklendi");
        }
    }
}
