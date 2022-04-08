using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkodluOtomasyon.Database
{
    public class ProductDB
    {
        public int Id { get; set; }
        public string StokTuru { get; set; }
        public string Barkod { get; set; }
        public string StokAdi { get; set; }
        public string Birim { get; set; }
        public double StokBirimSayisi { get; set; }
        public double KDV { get; set; }
        public string StokGrup { get; set; }
        public double AlisFiyat { get; set; }
        public double SatisFiyat_1 { get; set; }
        public double SatisFiyat_2 { get; set; }
        public double SatisFiyat_3 { get; set; }
        public double KrediSatisFiyat { get; set; }
        public double Tutar { get; set; }
        public string UrunAciklama { get; set; }
        public string Tedarikci { get; set; }
        public string Beden_No { get; set; }
        public string Renk { get; set; }
        public DateTime IndirimBaslangic { get; set; }
        public DateTime IndirimBitis { get; set; }
        public DateTime KayitTarihi { get; set; }
        public bool IndirimControl { get; set; }
        public double SatisFiyatKarOran { get; set; }
        public double KKFaizOran { get; set; }
    }
}
