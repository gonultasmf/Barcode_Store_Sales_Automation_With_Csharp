using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkodluOtomasyon.Database
{
    public class SafeDB
    {
        public int Id { get; set; }
        public string Kasa { get; set; }
        public string Personel { get; set; }
        public DateTime Tarih { get; set; }
        public string IslemTur { get; set; }
        public string Fis_IslemNo { get; set; }
        public string Aciklama { get; set; }
        public string OdemeSekli { get; set; }
        public double GirenMiktar { get; set; }
        public double CikanMiktar { get; set; }
        public List<SellDB> Ayrinti { get; set; }
    }
}
