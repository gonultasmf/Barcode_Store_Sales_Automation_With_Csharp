using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkodluOtomasyon.Database
{
    public class HesapHareketDB
    {
        public int Id { get; set; }
        public int MusteriKod { get; set; }
        public DateTime IslemTarihi { get; set; }
        public string Fıs_IslemNo { get; set; }
        public string IslemTuru { get; set; }
        public string Aciklama { get; set; }
        public double Miktar { get; set; }
        public string Birim { get; set; }
        public double BirimFİyat { get; set; }
        public double Borc { get; set; }
        public double Alacak { get; set; }
        public double Bakiye { get; set; }
        public List<SellDB> Ayrinti { get; set; }
    }
}
