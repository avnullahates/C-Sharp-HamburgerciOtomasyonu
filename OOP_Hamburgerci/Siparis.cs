using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Hamburgerci
{
    public class Siparis
    {

        public Menu SeciliMenu { get; set; }

        public Boyut Boyut { get; set; }

        public List<Ekstra> EkstraMalzeme { get; set; }

        public int Adet { get; set; }

        public decimal ToplamTutar { get; set; }

        //Kucuk boy secerse normal fiyat,
        //Orta boy ise yuzde 10 fazlasi
        //Buyuk boy ise yuzde 25 fazlasi olacak

        public void Hesapla()
        {
            ToplamTutar = 0;
            ToplamTutar += SeciliMenu.Fiyati;

            switch (Boyut)
            {
                case Boyut.Orta:
                    ToplamTutar += ToplamTutar * 0.10m;
                    break;

                case Boyut.Buyuk:
                    ToplamTutar += ToplamTutar * 0.25m;
                    break;

                default:
                    break;
            }

            foreach (Ekstra ekstra in EkstraMalzeme) //{ketcap=0,25 : mayanoz=0,50 : BBQ=1,25} 
            {
                ToplamTutar += ekstra.Fiyat;
            }

            ToplamTutar = ToplamTutar * Adet;


        }
        public override string ToString()
        {
            //Extra malzeme secilmesdiyse secilen siparisin list box a nasil yazilacainin formatini belirliyoruz
            if (EkstraMalzeme.Count < 1) //Extra malzeme yoksa
            {
                return string.Format("{0} Menu x {1} Adet, {2} Boy, Toplam: {3}", SeciliMenu.MenuAdi, Adet, Boyut, ToplamTutar.ToString("C2")); // c2 dormatinda yazsin, parasal deger formati
            }
            //Extra malzeme secildiyse secilen siparisin list box a nasil yazilacainin formatini belirliyoruz
            else
            {
                string extraMalzemeler = null;
                foreach (Ekstra ekstra in EkstraMalzeme)
                {
                    extraMalzemeler += ekstra.EkstraAdi + ",";
                }
                //extraMalzemeler = ketcap, mayanoz, BBQ, hardal
                extraMalzemeler = extraMalzemeler.Trim(','); // en son eklenen virgulu temizler
                return string.Format("{0} Menu x {1} Adet, {2} Boy, {3} , Toplam: {4}", SeciliMenu.MenuAdi, Adet, Boyut, extraMalzemeler, ToplamTutar.ToString("C2"));
            }
        }
    }
}
