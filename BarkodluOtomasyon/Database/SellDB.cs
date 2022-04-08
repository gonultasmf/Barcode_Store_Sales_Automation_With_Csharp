using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkodluOtomasyon.Database
{
    public class SellDB
    {
        public int Id { get; set; }
        public string Fis_IslemNo { get; set; }
        public string Barkod { get; set; }
        public string UrunAd { get; set; }
        public DateTime Tarih { get; set; }
        public double Miktar { get; set; }
        public string Birim { get; set; }
        public double SatisFiyat { get; set; }
        public double AlisFiyat { get; set; }
        public double Kar { get; set; }
        public string UygulanacakFiyat { get; set; }
        public string Kategori { get; set; }
        public string Personel { get; set; }
    }
}
