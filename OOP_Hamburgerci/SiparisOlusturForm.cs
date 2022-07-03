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
    public partial class SiparisOlusturForm : Form
    {
        public SiparisOlusturForm()
        {
            InitializeComponent();
        }
        public static List<Siparis> tumSiparisler = new List<Siparis>();
        public static List<Siparis> mevcutSiparisler = new List<Siparis>();

        public static List<Menu> menuler = new List<Menu>()
        {
           new Menu{MenuAdi ="Big King", Fiyati =30.25m },
           new Menu{MenuAdi ="Double King Chicken", Fiyati =25.25m },
           new Menu{MenuAdi ="SteakHouse", Fiyati =40m },
           new Menu{MenuAdi ="Whooper", Fiyati =32.50m },
           new Menu{MenuAdi ="Whooper Jr.", Fiyati =25.25m },
           new Menu{MenuAdi ="Chicken Royal", Fiyati =26.85m },
        };

        public static List<Ekstra> ekstralar = new List<Ekstra>()
        {
            new Ekstra{EkstraAdi = "Ketcap", Fiyat = 0.25m},
            new Ekstra{EkstraAdi = "Mayonez", Fiyat = 0.50m},
            new Ekstra{EkstraAdi = "Hardal", Fiyat = 0.75m},
            new Ekstra{EkstraAdi = "BBQ", Fiyat = 1},
            new Ekstra{EkstraAdi = "Ranch", Fiyat = 0.80m},
            new Ekstra{EkstraAdi = "Sarımsaklı Mayonez", Fiyat = 1.20m},
        };

        private void SiparisOlusturForm_Load(object sender, EventArgs e)
        {
            foreach (Menu item in menuler)
            {
                cmbMenuler.Items.Add(item);// ToString() metodunu override ettigimiz icin MenuAdi + Menu olarak combobox a yazilmaktadir.
            }
            foreach (Ekstra item in ekstralar)
            {
                flpExtraMalzemeler.Controls.Add(new CheckBox() { Text = item.EkstraAdi, Tag = item });// Tag property si object tutar.
            }
            foreach (Siparis item in mevcutSiparisler)
            {
                lbxSiparisler.Items.Add(item);
            }
            TutarHesapla();

            rdKucuk.Checked = true;
            cmbMenuler.SelectedIndex = 0;
        }

        public decimal TutarHesapla()
        {
            decimal toplamTutar = 0;
            for (int i = 0; i < lbxSiparisler.Items.Count; i++)
            {
                Siparis gelenSiparis = (Siparis)lbxSiparisler.Items[i];
                toplamTutar += gelenSiparis.ToplamTutar;
            }
            lbltoplamTutar.Text = toplamTutar.ToString("c2");
            return toplamTutar;
        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            Siparis yeniSiparis = new Siparis();
            yeniSiparis.SeciliMenu = (Menu)cmbMenuler.SelectedItem;

            if (rdKucuk.Checked)
                yeniSiparis.Boyut = Boyut.Kucuk;
            else if (rdOrta.Checked)
                yeniSiparis.Boyut = Boyut.Orta;
            else
                yeniSiparis.Boyut = Boyut.Buyuk;

            yeniSiparis.EkstraMalzeme = new List<Ekstra>();
            foreach (CheckBox item in flpExtraMalzemeler.Controls)
            {
                if (item.Checked)                
                    yeniSiparis.EkstraMalzeme.Add((Ekstra)item.Tag);// FlowLayoutPanel deki kontrollerden secilenlerin her birinin Tag propertysinde tutulan ekstra malzemenin kopyasini verir. 
                
            }
            yeniSiparis.Adet = Convert.ToInt32(nmrAdet.Value);
            yeniSiparis.Hesapla(); //Siparis classindaki hesapla metodu olusan yeni siparislerin toplam fiyatini hesaplar
            tumSiparisler.Add(yeniSiparis);
            mevcutSiparisler.Add(yeniSiparis);
            lbxSiparisler.Items.Add(yeniSiparis);
            TutarHesapla();

            
            Fonksiyon.Temizle(this.Controls);

        }

        private void btnSiparisTamamla_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Toplam siparis tutariniz: " + TutarHesapla().ToString("c2") + "\nSatin almayi tamamlamak ister misiniz?","Siparis Bilgisi",MessageBoxButtons.YesNo,MessageBoxIcon.Information);

            if (dr ==DialogResult.Yes)
            {
                lbxSiparisler.Items.Clear();
                mevcutSiparisler.Clear();
                TutarHesapla();
                MessageBox.Show("Sipariniz Tamamlandi");
            }
            else            
                MessageBox.Show("Iptal Edildi!");
            
        }
    }
}
