using LiteDB;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarkodluOtomasyon.Database
{
    public class DataBase
    {
        private LiteDatabase db;
        private string dbFilePath = @"C:\ProgramData\database\database.db";
        public static int index;
        public bool mainPage;
        public static bool yetkiliMi;
        public static string islemYapan;
        public DataBase()
        {
            if (!Directory.Exists(@"C:\ProgramData\database"))
                Directory.CreateDirectory(@"C:\ProgramData\database");
            
            if (!File.Exists(@"C:\ProgramData\database\database.db"))
            {
                Add_User_Database("Drahnasoft", "Drahnasoft", "0000", true);
                Add_System_Database(0, false, "smtp.gmail.com", 587, true,
                    "yabulut764@gmail.com", "holding2345", 0, true, 0, 0,
                    "", "", "", 0, "", "", 0, 0, 0, "", "", "", "", false, 0);
                Add_Birim_Database("Adet");
                Add_Birim_Database("Paket");
                Add_Birim_Database("Kilogram (kg)");
                Add_Birim_Database("Litre (L)");
                Add_Birim_Database("Metre");
                Add_Birim_Database("Çuval");
                Add_Birim_Database("Gram (gr)");
                Add_Birim_Database("Top");
                Add_Birim_Database("Deste");
                Add_Kategori_Database("Genel");
                Add_Kategori_Database("Yiyecek");
                Add_Kategori_Database("İçecek");
                Add_Kategori_Database("Temizlik Ürünü");
                Add_Kategori_Database("Kırtasiye Ürünü");
                Add_Kategori_Database("Giyim");
                Add_Kategori_Database("Züccaciye Ürünü");
                Add_Kategori_Database("Oyuncak");
            }
        }
        public void Add_User_Database(string Name, string UserName,
            string Password, bool isManager)
        {
            try
            {
                db = new LiteDatabase(dbFilePath);
                var col = db.GetCollection<UserDB>("User_Table");
                var manager = new UserDB
                {
                    UserName = UserName,
                    Name = Name,
                    Password = Password,
                    IsManager = isManager
                };
                col.Insert(manager);
                db.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public List<UserDB> Info_Users_Database()
        {
            db = new LiteDatabase(dbFilePath);
            var col = db.GetCollection<UserDB>("User_Table");
            List<UserDB> list = col.FindAll().ToList();
            db.Dispose();
            return list;
        }
        public void Delete_User_Database(string UserName)
        {
            try
            {
                db = new LiteDatabase(dbFilePath);
                var col = db.GetCollection<UserDB>("User_Table");
                List<UserDB> list = col.Find(x => x.UserName.Equals(UserName)).ToList();
                if(list[0].UserName != "Drahnasoft")
                    col.Delete(list[0].Id);
                db.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Login_Program(FrmGiris giris, TextBox UserName, TextBox Password,
            Label hata, ComboBox yetki)
        {
            try
            {
                db = new LiteDatabase(dbFilePath);
                var col = db.GetCollection<UserDB>("User_Table");
                if (yetki.SelectedIndex.Equals(0))
                {
                    List<UserDB> list = col.Find("$.UserName = '" + UserName.Text +
                        "' AND $.Password = '" + Password.Text +
                        "' AND $.IsManager = true").ToList();
                    db.Dispose();
                    if (list.Count != 0)
                    {
                        index = list[0].Id;
                        hata.Visible = false;
                        FrmGiris.control = true;
                        mainPage = true;
                        yetkiliMi = true;
                        List<UserDB> user = Info_Users_Database();
                        foreach (var item in user)
                            if (item.Id.Equals(index))
                                islemYapan = item.Name;
                        giris.Close();
                    }
                    else
                    {
                        UserName.ResetText();
                        Password.ResetText();
                        FrmGiris.control = false;
                        hata.Visible = true;
                    }
                }
                else
                {
                    List<UserDB> list = col.Find("$.UserName = '" + UserName.Text +
                       "' AND $.Password = '" + Password.Text +
                       "' AND $.IsManager = false").ToList();
                    db.Dispose();
                    if (list.Count != 0)
                    {
                        index = list[0].Id;
                        hata.Visible = false;
                        FrmGiris.control = true;
                        mainPage = false;
                        yetkiliMi = false;
                        List<UserDB> user = Info_Users_Database();
                        foreach (var item in user)
                            if (item.Id.Equals(index))
                                islemYapan = item.Name;
                        giris.Close();
                    }
                    else
                    {
                        UserName.ResetText();
                        Password.ResetText();
                        FrmGiris.control = false;
                        hata.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Add_System_Database(int theme, bool backup, string mailHost,
            int mailPort, bool mailSSL, string mail, string mailPassword, int aErtele,
            bool zilSesi, int zilSesim, int zilSesTekrar, string fisAciklama,
            string mesaj1, string mesaj2, int SMS, string SmsKAdi, string SmsSifre,
            int yazici, int pos, int etiket, string sirketAdi, string backupPath,
            string telNo, string adres, bool fisGenislik,  int fisYaziBuyukluk)
        {
            try
            {
                db = new LiteDatabase(dbFilePath);
                var col = db.GetCollection<SystemDB>("System_Table");
                var system = new SystemDB
                {
                    IndexTheme = theme,
                    Backup = backup,
                    MailHost = mailHost,
                    MailPort = mailPort,
                    MailSSL = mailSSL,
                    Mail = mail,
                    MailPassword = mailPassword,
                    AErtele = aErtele,
                    ZilSes = zilSesi,
                    ZilSesim = zilSesim,
                    ZilSesTekrar = zilSesTekrar,
                    FisAciklama = fisAciklama,
                    Mesaj1 = mesaj1,
                    Mesaj2 = mesaj2,
                    SMS = SMS,
                    SmsKAdi = SmsKAdi,
                    SmsSifre = SmsSifre,
                    Yazici = yazici,
                    Pos = pos,
                    Etiket = etiket,
                    FirmaAdi = sirketAdi,
                    BackupPath = backupPath,
                    FirmaTelNo = telNo,
                    Adres = adres,
                    FisGenislik = fisGenislik,
                    FisYaziBoyut = fisYaziBuyukluk
                };
                col.Insert(system);
                db.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Update_System_Database(int theme, bool backup, string mailHost,
            int mailPort, bool mailSSL, string mail, string mailPassword, int aErtele,
            bool zilSesi, int zilSesim, int zilSesTekrar, string fisAciklama,
            string mesaj1, string mesaj2, int SMS, string SmsKAdi, string SmsSifre,
            int yazici, int pos, int etiket, string sirketAdi, string backupPath,
            string telNo, string adres, bool fisGenislik, int fisYaziBuyukluk)
        {
            try
            {
                db = new LiteDatabase(dbFilePath);
                var col = db.GetCollection<SystemDB>("System_Table");
                var system = new SystemDB
                {
                    Id = 1,
                    IndexTheme = theme,
                    Backup = backup,
                    MailHost = mailHost,
                    MailPort = mailPort,
                    MailSSL = mailSSL,
                    Mail = mail,
                    MailPassword = mailPassword,
                    AErtele = aErtele,
                    ZilSes = zilSesi,
                    ZilSesim = zilSesim,
                    ZilSesTekrar = zilSesTekrar,
                    FisAciklama = fisAciklama,
                    Mesaj1 = mesaj1,
                    Mesaj2 = mesaj2,
                    SMS = SMS,
                    SmsKAdi = SmsKAdi,
                    SmsSifre = SmsSifre,
                    Yazici = yazici,
                    Pos = pos,
                    Etiket = etiket,
                    FirmaAdi = sirketAdi,
                    BackupPath = backupPath,
                    FirmaTelNo = telNo,
                    Adres = adres,
                    FisGenislik = fisGenislik,
                    FisYaziBoyut = fisYaziBuyukluk
                };
                col.Update(system);
                db.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public List<SystemDB> Info_System_Database()
        {
            db = new LiteDatabase(dbFilePath);
            var col = db.GetCollection<SystemDB>("System_Table");
            List<SystemDB> list = col.FindAll().ToList();
            db.Dispose();
            return list;
        }
        public void Backup_Database(string path)
        {
            File.Copy(dbFilePath, path, true);
        }
        public void Add_Product_Database(string barCode, string stockType,
             string stockName, string Unit, double adet, double KDV,
             double purchasePrice, double salePrice1, double salePrice2,
             double salePrice3, double KPrice, string priceDescription, string cinsi,
             string renk, string bedenNo, DateTime baslangic, DateTime bitis,
             string tedarikci, double kkFaizOran, double satisKarOran, bool indirimControl)
        {
            try
            {
                db = new LiteDatabase(dbFilePath);
                var col = db.GetCollection<ProductDB>("Product_Table");
                var product = new ProductDB
                {
                    Barkod = barCode,
                    StokTuru = stockType,
                    StokAdi = stockName,
                    Birim = Unit,
                    StokBirimSayisi = adet,
                    KDV = KDV,
                    AlisFiyat = purchasePrice,
                    SatisFiyat_1 = salePrice1,
                    SatisFiyat_2 = salePrice2,
                    SatisFiyat_3 = salePrice3,
                    Tutar = salePrice1,
                    UrunAciklama = priceDescription,
                    KrediSatisFiyat = KPrice,
                    StokGrup = cinsi,
                    IndirimBaslangic = baslangic,
                    IndirimBitis = bitis,
                    KayitTarihi = DateTime.Now,
                    Renk = renk,
                    Beden_No = bedenNo,
                    Tedarikci = tedarikci,
                    KKFaizOran = kkFaizOran,
                    SatisFiyatKarOran = satisKarOran,
                    IndirimControl = indirimControl
                };
                col.Insert(product);
                db.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Update_Product_Database(int id, string barCode, string stockType,
             string stockName, string Unit, double adet, double KDV,
             double purchasePrice, double salePrice1, double salePrice2,
             double salePrice3, double KPrice, string priceDescription, string cinsi,
             string renk, string bedenNo, DateTime baslangic, DateTime bitis,
             string tedarikci, double kkFaizOran, double satisKarOran,
             bool indirimControl, DateTime kayitTarihi)
        {
            try
            {
                db = new LiteDatabase(dbFilePath);
                var col = db.GetCollection<ProductDB>("Product_Table");
                var product = new ProductDB
                {
                    Id = id,
                    Barkod = barCode,
                    StokTuru = stockType,
                    StokAdi = stockName,
                    Birim = Unit,
                    StokBirimSayisi = adet,
                    KDV = KDV,
                    AlisFiyat = purchasePrice,
                    SatisFiyat_1 = salePrice1,
                    SatisFiyat_2 = salePrice2,
                    SatisFiyat_3 = salePrice3,
                    UrunAciklama = priceDescription,
                    KrediSatisFiyat = KPrice,
                    StokGrup = cinsi,
                    IndirimBaslangic = baslangic,
                    IndirimBitis = bitis,
                    Renk = renk,
                    Beden_No = bedenNo,
                    Tedarikci = tedarikci,
                    KKFaizOran = kkFaizOran,
                    SatisFiyatKarOran = satisKarOran,
                    IndirimControl = indirimControl,
                    KayitTarihi = kayitTarihi
                };
                col.Update(product);
                db.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Delete_Product_Database(string barkod)
        {
            try
            {
                db = new LiteDatabase(dbFilePath);
                var col = db.GetCollection<ProductDB>("Product_Table");
                List<ProductDB> list = col.Find(x => x.Barkod.Equals(barkod)).ToList();
                col.Delete(list[0].Id);
                db.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public List<ProductDB> Info_Productes_Database()
        {
            db = new LiteDatabase(dbFilePath);
            var col = db.GetCollection<ProductDB>("Product_Table");
            List<ProductDB> list = col.FindAll().ToList();
            db.Dispose();
            return list;
        }
        public List<ProductDB> Info_Product_Database(string barkod)
        {
            db = new LiteDatabase(dbFilePath);
            var col = db.GetCollection<ProductDB>("Product_Table");
            List<ProductDB> list = col.Find(x=>x.Barkod.Equals(barkod)).ToList();
            db.Dispose();
            return list;
        }
        public void Add_Safe_Database(string kasa, DateTime tarih,
            string islemTur, string fis_islemNo, string aciklama,
            string odemeSekli, double girenMiktar, double cikanMiktar,
            List<SellDB> ayrinti, string personel)
        {
            try
            {
                db = new LiteDatabase(dbFilePath);
                var col = db.GetCollection<SafeDB>("Safe_Table");
                var safe = new SafeDB
                {
                    Kasa = kasa,
                    Personel = personel,
                    Tarih = tarih,
                    IslemTur = islemTur,
                    Fis_IslemNo = fis_islemNo,
                    Aciklama = aciklama,
                    OdemeSekli = odemeSekli,
                    GirenMiktar = girenMiktar,
                    CikanMiktar = cikanMiktar,
                    Ayrinti = ayrinti
                };
                col.Insert(safe);
                db.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public List<SafeDB> Info_Safes_Database()
        {
            db = new LiteDatabase(dbFilePath);
            var col = db.GetCollection<SafeDB>("Safe_Table");
            List<SafeDB> list = col.FindAll().ToList();
            db.Dispose();
            return list;
        }
        public void Delete_Safe_Database(string fis_islemNo)
        {
            try
            {
                db = new LiteDatabase(dbFilePath);
                var col = db.GetCollection<SafeDB>("Safe_Table");
                List<SafeDB> list = col.Find(x => x.Fis_IslemNo.Equals(fis_islemNo)).ToList();
                col.Delete(list[0].Id);
                db.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Add_Sell_Database(string islemNo, string barkod, string urunAd,
            DateTime tarih, double miktar, string birim, double satisFiyat,
             string uygulanacakFiyat, string kategori, string personel, double alisFiyat)
        {
            try
            {
                db = new LiteDatabase(dbFilePath);
                var col = db.GetCollection<SellDB>("Sell_Table");
                var sell = new SellDB
                {
                   Fis_IslemNo = islemNo,
                   Barkod = barkod,
                   UrunAd = urunAd,
                   Tarih = tarih,
                   Miktar = miktar,
                   Birim = birim,
                   SatisFiyat = satisFiyat,
                   AlisFiyat = alisFiyat,
                   Kar = satisFiyat-alisFiyat,
                   UygulanacakFiyat = uygulanacakFiyat,
                   Kategori = kategori,
                   Personel = personel
                };
                col.Insert(sell);
                db.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Update_Sell_Database(int id, string islemNo, string barkod, string urunAd,
            DateTime tarih, double miktar, string birim, double satisFiyat,
             string uygulanacakFiyat, string kategori, string personel, double alisFiyat)
        {
            try
            {
                db = new LiteDatabase(dbFilePath);
                var col = db.GetCollection<SellDB>("Sell_Table");
                var sell = new SellDB
                {
                    Id = id,
                    Fis_IslemNo = islemNo,
                    Barkod = barkod,
                    UrunAd = urunAd,
                    Tarih = tarih,
                    Miktar = miktar,
                    Birim = birim,
                    SatisFiyat = satisFiyat,
                    AlisFiyat = alisFiyat,
                    Kar = satisFiyat - alisFiyat,
                    UygulanacakFiyat = uygulanacakFiyat,
                    Kategori = kategori,
                    Personel = personel
                };
                col.Update(sell);
                db.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public List<SellDB> Info_Sells_Database()
        {
            db = new LiteDatabase(dbFilePath);
            var col = db.GetCollection<SellDB>("Sell_Table");
            List<SellDB> list = col.FindAll().ToList();
            db.Dispose();
            return list;
        }
        public List<SellDB> Info_Sells_IslemNo_Database(string islemNo)
        {
            db = new LiteDatabase(dbFilePath);
            var col = db.GetCollection<SellDB>("Sell_Table");
            List<SellDB> list = col.Find(x=>x.Fis_IslemNo.Equals(islemNo)).ToList();
            db.Dispose();
            return list;
        }
        public void Delete_Sell_Database(string islemNo)
        {
            try
            {
                db = new LiteDatabase(dbFilePath);
                var col = db.GetCollection<SellDB>("Sell_Table");
                List<SellDB> list = col.Find(x => x.Fis_IslemNo.Equals(islemNo)).ToList();
                col.Delete(list[0].Id);
                db.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Delete_Sell_Barcode_Database(string barcode)
        {
            try
            {
                db = new LiteDatabase(dbFilePath);
                var col = db.GetCollection<SellDB>("Sell_Table");
                List<SellDB> list = col.Find(x => x.Barkod.Equals(barcode)).ToList();
                col.Delete(list[0].Id);
                db.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Add_Kategori_Database(string kategori)
        {
            try
            {
                db = new LiteDatabase(dbFilePath);
                var col = db.GetCollection<KategoriDB>("Kategori_Table");
                var kategorim = new KategoriDB
                {
                    Kategori = kategori
                };
                col.Insert(kategorim);
                db.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public List<KategoriDB> Info_Kategori_Database()
        {
            db = new LiteDatabase(dbFilePath);
            var col = db.GetCollection<KategoriDB>("Kategori_Table");
            List<KategoriDB> list = col.FindAll().ToList();
            db.Dispose();
            return list;
        }
        public void Delete_Kategori_Database(string kategori)
        {
            try
            {
                db = new LiteDatabase(dbFilePath);
                var col = db.GetCollection<KategoriDB>("Kategori_Table");
                List<KategoriDB> list = col.Find(x => x.Kategori.Equals(kategori)).ToList();
                col.Delete(list[0].Id);
                db.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Add_Birim_Database(string birim)
        {
            try
            {
                db = new LiteDatabase(dbFilePath);
                var col = db.GetCollection<BirimDB>("Birim_Table");
                var birimDB = new BirimDB
                {
                    Birim = birim
                };
                col.Insert(birimDB);
                db.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public List<BirimDB> Info_Birim_Database()
        {
            db = new LiteDatabase(dbFilePath);
            var col = db.GetCollection<BirimDB>("Birim_Table");
            List<BirimDB> list = col.FindAll().ToList();
            db.Dispose();
            return list;
        }
        public void Delete_Birim_Database(string birim)
        {
            try
            {
                db = new LiteDatabase(dbFilePath);
                var col = db.GetCollection<BirimDB>("Birim_Table");
                List<BirimDB> list = col.Find(x => x.Birim.Equals(birim)).ToList();
                col.Delete(list[0].Id);
                db.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Add_Tedarikci_Database(string tedarikciAdi)
        {
            try
            {
                db = new LiteDatabase(dbFilePath);
                var col = db.GetCollection<TedarikciDB>("Tedarikci_Table");
                var tedarikci = new TedarikciDB
                {
                    Tedarikci = tedarikciAdi
                };
                col.Insert(tedarikci);
                db.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public List<TedarikciDB> Info_Tedarikci_Database()
        {
            db = new LiteDatabase(dbFilePath);
            var col = db.GetCollection<TedarikciDB>("Tedarikci_Table");
            List<TedarikciDB> list = col.FindAll().ToList();
            db.Dispose();
            return list;
        }
        public void Delete_Tedarikci_Database(string tedarikci)
        {
            try
            {
                db = new LiteDatabase(dbFilePath);
                var col = db.GetCollection<TedarikciDB>("Tedarikci_Table");
                List<TedarikciDB> list = col.Find(x => x.Tedarikci.Equals(tedarikci)).ToList();
                col.Delete(list[0].Id);
                db.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Add_Iade_Database(string fisIslemNo, string barkod,
            string urunAd, string personel, string birim, double miktar,
            double fiyat, string uygulanacakFiyat, string aciklama)
        {
            try
            {
                db = new LiteDatabase(dbFilePath);
                var col = db.GetCollection<IadeDB>("Iade_Table");
                var iade = new IadeDB
                {
                    Fis_IslemNo = fisIslemNo,
                    Barkod = barkod,
                    UrunAd = urunAd,
                    Personel = personel,
                    Birim = birim,
                    Miktar = miktar,
                    Fiyat = fiyat,
                    UygulananFiyat = uygulanacakFiyat,
                    Aciklama = aciklama,
                    Tarih = DateTime.Now
                };
                col.Insert(iade);
                db.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public List<IadeDB> Info_Iade_Database()
        {
            db = new LiteDatabase(dbFilePath);
            var col = db.GetCollection<IadeDB>("Iade_Table");
            List<IadeDB> list = col.FindAll().ToList();
            db.Dispose();
            return list;
        }
        public void Add_MusteriGrup_Database(string musteriGrup)
        {
            try
            {
                db = new LiteDatabase(dbFilePath);
                var col = db.GetCollection<MusteriGrupDB>("MusteriGrup_Table");
                var musteriGrupDB = new MusteriGrupDB
                {
                    MusteriGrup = musteriGrup
                };
                col.Insert(musteriGrupDB);
                db.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Delete_MusteriGrup_Database(string musteriGrup)
        {
            try
            {
                db = new LiteDatabase(dbFilePath);
                var col = db.GetCollection<MusteriGrupDB>("MusteriGrup_Table");
                List<MusteriGrupDB> list = col.Find(x => x.MusteriGrup.Equals(musteriGrup)).ToList();
                col.Delete(list[0].Id);
                db.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public List<MusteriGrupDB> Info_MusteriGrup_Database()
        {
            db = new LiteDatabase(dbFilePath);
            var col = db.GetCollection<MusteriGrupDB>("MusteriGrup_Table");
            List<MusteriGrupDB> list = col.FindAll().ToList();
            db.Dispose();
            return list;
        }
        public void Add_Customer_Database(int musteriKod, string hesapTuru,
            string musteriGrup, string musteriAdi, string ilgili, string telNo,
            string faxNo, string gsmNo, string adres, string vergiDaire, 
            string vergiNo, string ePosta, string paraTuru, string imagePath,
            List<HesapHareketDB> list)
        {
            try
            {
                list = new List<HesapHareketDB>();
                db = new LiteDatabase(dbFilePath);
                var col = db.GetCollection<CustomerDB>("Customer_Table");
                var customer = new CustomerDB
                {
                    MusteriKod = musteriKod,
                    HesapTuru = hesapTuru,
                    MusteriGrup = musteriGrup,
                    MusteriAdi = musteriAdi,
                    İlgili = ilgili,
                    TelNo = telNo,
                    FaxNo = faxNo,
                    GsmNo = gsmNo,
                    Adres = adres,
                    VergiDairesi = vergiDaire,
                    VergiNo = vergiNo,
                    Eposta = ePosta,
                    ParaTuru = paraTuru,
                    ImagePath = imagePath,
                    KayitTarih = DateTime.Now,
                    SonIslemTarih = DateTime.Now,
                    HesapAyrinti = list,
                    Not = "",
                    Bakiye = 0
                };
                col.Insert(customer);
                db.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Update_Customer_Database(int id, int musteriKod, string hesapTuru,
            string musteriGrup, string musteriAdi, string ilgili, string telNo,
            string faxNo, string gsmNo, string adres, string vergiDaire, string vergiNo,
            string ePosta, string paraTuru, string imagePath, double bakiye, string not,
            List<HesapHareketDB> list, DateTime kayitTarihi)
        {
            try
            {
                db = new LiteDatabase(dbFilePath);
                var col = db.GetCollection<CustomerDB>("Customer_Table");
                var customer = new CustomerDB
                {
                    Id = id,
                    MusteriKod = musteriKod,
                    HesapTuru = hesapTuru,
                    MusteriGrup = musteriGrup,
                    MusteriAdi = musteriAdi,
                    İlgili = ilgili,
                    TelNo = telNo,
                    FaxNo = faxNo,
                    GsmNo = gsmNo,
                    Adres = adres,
                    VergiDairesi = vergiDaire,
                    VergiNo = vergiNo,
                    Eposta = ePosta,
                    ParaTuru = paraTuru,
                    ImagePath = imagePath,
                    SonIslemTarih = DateTime.Now,
                    Bakiye = bakiye,
                    Not = not,
                    HesapAyrinti = list,
                    KayitTarih = kayitTarihi
                };
                col.Update(customer);
                db.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Delete_Customer_Database(int musteriKod)
        {
            try
            {
                db = new LiteDatabase(dbFilePath);
                var col = db.GetCollection<CustomerDB>("Customer_Table");
                List<CustomerDB> list = col.Find(x => x.MusteriKod.Equals(musteriKod)).ToList();
                col.Delete(list[0].Id);
                db.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public List<CustomerDB> Info_Customer_Database(int musteriKod)
        {
            db = new LiteDatabase(dbFilePath);
            var col = db.GetCollection<CustomerDB>("Customer_Table");
            List<CustomerDB> list = col.Find(x => x.MusteriKod.Equals(musteriKod)).ToList();
            db.Dispose();
            return list;
        }
        public List<CustomerDB> Info_Customers_Database()
        {
            db = new LiteDatabase(dbFilePath);
            var col = db.GetCollection<CustomerDB>("Customer_Table");
            List<CustomerDB> list = col.FindAll().ToList();
            db.Dispose();
            return list;
        }
        public void Add_HesapHareket_Database(int musteriKod, string fısIslemNo,
           string islemTuru, string acıklama, double miktar, string birim,
           double birimFiyat, double borc, double alacak, double bakiye)
        {
            try
            {
                db = new LiteDatabase(dbFilePath);
                var col = db.GetCollection<HesapHareketDB>("HesapHareket_Table");
                var hesapHareket = new HesapHareketDB
                {
                    MusteriKod = musteriKod,
                    Fıs_IslemNo = fısIslemNo,
                    IslemTuru = islemTuru,
                    Aciklama = acıklama,
                    Miktar = miktar,
                    Birim = birim,
                    BirimFİyat = birimFiyat,
                    Borc = borc,
                    Alacak = alacak,
                    Bakiye = bakiye,
                    IslemTarihi = DateTime.Now,
                    Ayrinti = null
                };
                col.Insert(hesapHareket);
                db.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Update_HesapHareket_Database(int id, int musteriKod, string fısIslemNo,
           string islemTuru, string acıklama, double miktar, string birim,
           double birimFiyat, double borc, double alacak, double bakiye, List<SellDB> list)
        {
            try
            {
                db = new LiteDatabase(dbFilePath);
                var col = db.GetCollection<HesapHareketDB>("HesapHareket_Table");
                var hesapHareket = new HesapHareketDB
                {
                    Id = id,
                    MusteriKod = musteriKod,
                    Fıs_IslemNo = fısIslemNo,
                    IslemTuru = islemTuru,
                    Aciklama = acıklama,
                    Miktar = miktar,
                    Birim = birim,
                    BirimFİyat = birimFiyat,
                    Borc = borc,
                    Alacak = alacak,
                    Bakiye = bakiye,
                    IslemTarihi = DateTime.Now,
                    Ayrinti = list
                };
                col.Update(hesapHareket);
                db.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Delete_HesapHareket_Database(int musteriKod)
        {
            try
            {
                db = new LiteDatabase(dbFilePath);
                var col = db.GetCollection<HesapHareketDB>("HesapHareket_Table");
                List<HesapHareketDB> list = col.Find(x => x.MusteriKod.Equals(musteriKod)).ToList();
                col.Delete(list[0].Id);
                db.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public List<HesapHareketDB> Info_HesapHarekets_Database(int musteriKod)
        {
            db = new LiteDatabase(dbFilePath);
            var col = db.GetCollection<HesapHareketDB>("HesapHareket_Table");
            List<HesapHareketDB> list = col.Find(x => x.MusteriKod.Equals(musteriKod)).ToList();
            db.Dispose();
            return list;
        }
        public List<HesapHareketDB> Info_HesapHareket_Database(string islemNo)
        {
            db = new LiteDatabase(dbFilePath);
            var col = db.GetCollection<HesapHareketDB>("HesapHareket_Table");
            List<HesapHareketDB> list = col.Find(x => x.Fıs_IslemNo.Equals(islemNo)).ToList();
            db.Dispose();
            return list;
        }
        public void Add_Alarm_Database(int musteriKod, string musteriAd,
           string hesapTur, string musteriGrup, string telNo,
           string bakiye, DateTime alarmTarih, string aciklama)
        {
            try
            {
                db = new LiteDatabase(dbFilePath);
                var col = db.GetCollection<AlarmDB>("Alarm_Table");
                var alarm = new AlarmDB
                {
                    MusteriKod = musteriKod,
                    MusteriAd = musteriAd,
                    HesapTur = hesapTur,
                    MusteriGrup = musteriGrup,
                    TelefonNo = telNo,
                    Bakiye = bakiye,
                    AlarmTarihi = alarmTarih,
                    Aciklama = aciklama
                };
                col.Insert(alarm);
                db.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Update_Alarm_Database(int id, int musteriKod,
            string musteriAd, string hesapTur, string musteriGrup,
            string telNo, string bakiye, DateTime alarmTarih,
            string aciklama)
        {
            try
            {
                db = new LiteDatabase(dbFilePath);
                var col = db.GetCollection<AlarmDB>("Alarm_Table");
                var alarm = new AlarmDB
                {
                    Id = id,
                    MusteriKod = musteriKod,
                    MusteriAd = musteriAd,
                    HesapTur = hesapTur,
                    MusteriGrup = musteriGrup,
                    TelefonNo = telNo,
                    Bakiye = bakiye,
                    AlarmTarihi = alarmTarih,
                    Aciklama = aciklama
                };
                col.Update(alarm);
                db.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Delete_Alarm_Database(int musteriKod)
        {
            try
            {
                db = new LiteDatabase(dbFilePath);
                var col = db.GetCollection<AlarmDB>("Alarm_Table");
                List<AlarmDB> list = col.Find(x => x.MusteriKod.Equals(musteriKod)).ToList();
                col.Delete(list[0].Id);
                db.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public List<AlarmDB> Info_Alarms_Database()
        {
            db = new LiteDatabase(dbFilePath);
            var col = db.GetCollection<AlarmDB>("Alarm_Table");
            List<AlarmDB> list = col.FindAll().ToList();
            db.Dispose();
            return list;
        }
        public List<AlarmDB> Info_Alarm_Database(int musteriKod)
        {
            db = new LiteDatabase(dbFilePath);
            var col = db.GetCollection<AlarmDB>("Alarm_Table");
            List<AlarmDB> list = col.Find(x => x.MusteriKod.Equals(musteriKod)).ToList();
            db.Dispose();
            return list;
        }
    }
}
