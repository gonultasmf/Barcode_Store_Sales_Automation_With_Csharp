using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkodluOtomasyon.Database
{
    public class CustomerDB
    {
        public int Id { get; set; }
        public int MusteriKod { get; set; }
        public string HesapTuru { get; set; }
        public string MusteriGrup { get; set; }
        public string MusteriAdi { get; set; }
        public string İlgili { get; set; }
        public string TelNo { get; set; }
        public string FaxNo { get; set; }
        public string GsmNo { get; set; }
        public string Adres { get; set; }
        public string VergiDairesi { get; set; }
        public string VergiNo { get; set; }
        public string Eposta { get; set; }
        public string ParaTuru { get; set; }
        public string ImagePath { get; set; }
        public DateTime KayitTarih { get; set; }
        public DateTime SonIslemTarih { get; set; }
        public double Bakiye { get; set; }
        public string Not { get; set; }
        public List<HesapHareketDB> HesapAyrinti { get; set; }
    }
}
