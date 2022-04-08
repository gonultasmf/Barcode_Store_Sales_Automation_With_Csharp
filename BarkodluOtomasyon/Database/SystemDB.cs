using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkodluOtomasyon.Database
{
    public class SystemDB
    {
        public int Id { get; set; }
        public int IndexTheme { get; set; }
        public bool Backup { get; set; }
        public string MailHost { get; set; }
        public int MailPort { get; set; }
        public bool MailSSL { get; set; }
        public string Mail { get; set; }
        public string MailPassword { get; set; }
        public int AErtele { get; set; }
        public bool ZilSes { get; set; }
        public int ZilSesim { get; set; }
        public int ZilSesTekrar { get; set; }
        public string FisAciklama { get; set; }
        public string Mesaj1 { get; set; }
        public string Mesaj2 { get; set; }
        public int SMS { get; set; }
        public string SmsKAdi { get; set; }
        public string SmsSifre { get; set; }
        public int Yazici { get; set; }
        public int Pos { get; set; }
        public int Etiket { get; set; }
        public string FirmaAdi { get; set; }
        public string BackupPath { get; set; }
        public string FirmaTelNo { get; set; }
        public string Adres { get; set; }
        public bool FisGenislik { get; set; }
        public int FisYaziBoyut { get; set; }
    }
}
