using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patika_Kütüphane
{
    internal class Kitap
    {
        public Kitap()
        {
            Ad = "Bilinmiyor";
            YazarAdı = "Bilinmiyor";
            YazarSoyadı = "Bilinmiyor";
            SayfaSayısı = "0";
            YayınEvi = "Bilinmiyor";
            KayıtTarihi = DateTime.Now;
        }

        public Kitap(string ad, string yazarAdı, string yazarSoyadı, string sayfaSayısı, string yayınEvi, DateTime kayıtTarihi)
        {
            Ad = ad;
            YazarAdı = yazarAdı;
            YazarSoyadı = yazarSoyadı;
            SayfaSayısı = sayfaSayısı;
            YayınEvi = yayınEvi;
            KayıtTarihi = kayıtTarihi;
        }

        public string Ad { get; set; }
        public string YazarAdı { get; set; }
        public string YazarSoyadı { get; set; }

        public string SayfaSayısı { get; set; }

        public string YayınEvi { get; set; }

        public DateTime KayıtTarihi { get; set; }
    }
}
