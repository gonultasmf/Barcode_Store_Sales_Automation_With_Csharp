using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkodluOtomasyon.Database
{
    public class IadeDB
    {
        public int Id { get; set; }
        public string Fis_IslemNo { get; set; }
        public string Barkod { get; set; }
        public DateTime Tarih { get; set; }
        public string UrunAd { get; set; }
        public string Personel { get; set; }
        public string Birim { get; set; }
        public double Miktar { get; set; }
        public double Fiyat { get; set; }
        public string UygulananFiyat { get; set; }
        public string Aciklama { get; set; }
    }
}
