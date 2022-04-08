using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkodluOtomasyon.Database
{
    public class AlarmDB
    {
        public int Id { get; set; }
        public int MusteriKod { get; set; }
        public string MusteriAd { get; set; }
        public string HesapTur { get; set; }
        public string MusteriGrup { get; set; }
        public string TelefonNo { get; set; }
        public string Bakiye { get; set; }
        public string Aciklama { get; set; }
        public DateTime AlarmTarihi { get; set; }
    }
}
