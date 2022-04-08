using BarkodluOtomasyon.Database;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarkodluOtomasyon.Class
{
    class Function
    {
        public double toplamDevirTutar,toplamStokMiktar;
        public double toplamAlisFiyat,toplamSatisFiyat1,toplamSatisFiyat2;
        DataBase db = new DataBase();
        public Function()
        {
            
        }
        public void IsEmptyTextBoxes(params TextBox[] textBoxes)
        {
            foreach (TextBox textBox in textBoxes)
            {
                if (textBox.TextLength.Equals(0))
                {
                    textBox.Text = "0";
                }
            }
        }
        public string FisIslemNo_Uret()
        {
            List<SafeDB> list = db.Info_Safes_Database();
            Random random = new Random();
            string sayi = random.Next(100000, 999999).ToString() +
                random.Next(1000000, 9999999).ToString();
            foreach (SafeDB item in list)
                while (true)
                {
                    if (item.Fis_IslemNo == sayi)
                        sayi = random.Next(100000000, 999999999).ToString();
                    else
                        break;
                }
            return sayi;
        }
        public void ListDoldurSafe(DataGridView gridView)
        {
            try
            {
                DataTable tablomSafe = new DataTable();
                List<SafeDB> list = db.Info_Safes_Database();
                tablomSafe.Columns.Add("TARİH", typeof(DateTime));
                tablomSafe.Columns.Add("TÜR", typeof(string));
                tablomSafe.Columns.Add("İŞLEM_NO", typeof(string));
                tablomSafe.Columns.Add("AÇIKLAMA", typeof(string));
                tablomSafe.Columns.Add("ÖDEME_ŞEKLİ", typeof(string));
                tablomSafe.Columns.Add("GİREN_MİKTAR", typeof(double));
                tablomSafe.Columns.Add("ÇIKAN_MİKTAR", typeof(double));
                tablomSafe.Columns.Add("KASA", typeof(string));
                tablomSafe.Columns.Add("PERSONEL", typeof(string));
                double girenler = 0, cikanlar = 0;
                for (int i = 0; i < list.Count; i++)
                {
                    tablomSafe.Rows.Add(list[i].Tarih, list[i].IslemTur,
                        list[i].Fis_IslemNo, list[i].Aciklama, list[i].OdemeSekli,
                        list[i].GirenMiktar, list[i].CikanMiktar, list[i].Kasa,
                        list[i].Personel);
                    girenler += list[i].GirenMiktar;
                    cikanlar += list[i].CikanMiktar;
                }
                gridView.DataSource = tablomSafe;
                toplamDevirTutar = girenler - cikanlar;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ListAramaTarihSafe(DataGridView gridView, DateTime baslangic, DateTime bitis)
        {
            try
            {
                DataTable tablomSafe = new DataTable();
                List<SafeDB> list = db.Info_Safes_Database();
                tablomSafe.Columns.Add("TARİH", typeof(DateTime));
                tablomSafe.Columns.Add("TÜR", typeof(string));
                tablomSafe.Columns.Add("İŞLEM_NO", typeof(string));
                tablomSafe.Columns.Add("AÇIKLAMA", typeof(string));
                tablomSafe.Columns.Add("ÖDEME_ŞEKLİ", typeof(string));
                tablomSafe.Columns.Add("GİREN_MİKTAR", typeof(double));
                tablomSafe.Columns.Add("ÇIKAN_MİKTAR", typeof(double));
                tablomSafe.Columns.Add("KASA", typeof(string));
                tablomSafe.Columns.Add("PERSONEL", typeof(string));
                double girenler = 0, cikanlar = 0;
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Tarih >= baslangic && list[i].Tarih < bitis)
                    {
                        tablomSafe.Rows.Add(list[i].Tarih, list[i].IslemTur,
                            list[i].Fis_IslemNo, list[i].Aciklama, list[i].OdemeSekli,
                            list[i].GirenMiktar, list[i].CikanMiktar, list[i].Kasa,
                            list[i].Personel);
                        girenler += list[i].GirenMiktar;
                        cikanlar += list[i].CikanMiktar;
                    }
                }
                gridView.DataSource = tablomSafe;
                toplamDevirTutar = girenler - cikanlar;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ListDoldurStok(DataGridView gridView)
        {
            try
            {
                DataTable tablomStok = new DataTable();
                tablomStok.Columns.Add("BARKOD", typeof(string));
                tablomStok.Columns.Add("ÜRÜN", typeof(string));
                tablomStok.Columns.Add("ALIŞ_FİYAT", typeof(double));
                tablomStok.Columns.Add("SATIŞ_1", typeof(double));
                tablomStok.Columns.Add("SATIŞ_2", typeof(double));
                tablomStok.Columns.Add("KATEGORİ", typeof(string));
                tablomStok.Columns.Add("MİKTAR", typeof(double));
                tablomStok.Columns.Add("BİRİM", typeof(string));
                tablomStok.Columns.Add("AÇIKLAMA", typeof(string));
                toplamAlisFiyat = 0;
                toplamSatisFiyat1 = 0;
                toplamSatisFiyat2 = 0;
                toplamStokMiktar = 0;
                List<ProductDB> products = db.Info_Productes_Database();
                foreach (var item in products)
                {
                    tablomStok.Rows.Add(item.Barkod, item.StokAdi, item.AlisFiyat,
                        item.SatisFiyat_1, item.SatisFiyat_2, item.StokTuru,
                        item.StokBirimSayisi, item.Birim, item.UrunAciklama);
                    toplamAlisFiyat += item.AlisFiyat;
                    toplamSatisFiyat1 += item.SatisFiyat_1;
                    toplamSatisFiyat2 += item.SatisFiyat_2;
                    toplamStokMiktar += item.StokBirimSayisi;
                }
                gridView.DataSource = tablomStok;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ListDoldurCustomer(DataGridView gridView)
        {
            try
            {
                DataTable tablomCustomer = new DataTable();
                List<CustomerDB> list = db.Info_Customers_Database();
                tablomCustomer.Columns.Add("HESAP_TÜRÜ", typeof(string));
                tablomCustomer.Columns.Add("MÜŞTERİ_NO", typeof(int));
                tablomCustomer.Columns.Add("MÜŞTERİ_ADI", typeof(string));
                tablomCustomer.Columns.Add("SON_İŞLEM_TARİHİ", typeof(DateTime));
                tablomCustomer.Columns.Add("BAKİYE", typeof(double));
                tablomCustomer.Columns.Add("PARA_TÜRÜ", typeof(string));
                for (int i = 0; i < list.Count; i++)
                {
                    tablomCustomer.Rows.Add(list[i].HesapTuru, list[i].MusteriKod,
                        list[i].MusteriAdi, list[i].SonIslemTarih, list[i].Bakiye,
                        list[i].ParaTuru);
                }
                gridView.DataSource = tablomCustomer;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ListDoldurAlarm(DataGridView gridView)
        {
            try
            {
                DataTable tablomAlarm = new DataTable();
                List<AlarmDB> list = db.Info_Alarms_Database();
                tablomAlarm.Columns.Add("HESAP_TÜRÜ", typeof(string));
                tablomAlarm.Columns.Add("MÜŞTERİ_NO", typeof(int));
                tablomAlarm.Columns.Add("MÜŞTERİ_ADI", typeof(string));
                tablomAlarm.Columns.Add("ALARM_TARİHİ", typeof(DateTime));
                tablomAlarm.Columns.Add("BAKİYE", typeof(string));
                tablomAlarm.Columns.Add("AÇIKLAMA", typeof(string));
                for (int i = 0; i < list.Count; i++)
                {
                    tablomAlarm.Rows.Add(list[i].HesapTur, list[i].MusteriKod,
                        list[i].MusteriAd, list[i].AlarmTarihi, list[i].Bakiye,
                        list[i].Aciklama);
                }
                gridView.DataSource = tablomAlarm;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ListDoldurHesapHareket(DataGridView gridView, 
            DateTime baslangic, DateTime bitis, TextBox tBorc,
            TextBox tOdenen, TextBox tBakiye, int musteriKod)
        {
            try
            {
                double borc = 0, odenen = 0, bakiye = 0;
                DataTable tablomCustomer = new DataTable();
                List<HesapHareketDB> list = db.Info_HesapHarekets_Database(musteriKod);
                tablomCustomer.Columns.Add("İŞLEM_TARİHİ", typeof(DateTime));
                tablomCustomer.Columns.Add("İŞLEM_NO", typeof(string));
                tablomCustomer.Columns.Add("İŞLEM_TÜRÜ", typeof(string));
                tablomCustomer.Columns.Add("AÇIKLAMA", typeof(string));
                tablomCustomer.Columns.Add("MİKTAR", typeof(double));
                tablomCustomer.Columns.Add("BİRİM", typeof(string));
                tablomCustomer.Columns.Add("BİRİM_FİYAT", typeof(double));
                tablomCustomer.Columns.Add("BORÇ", typeof(double));
                tablomCustomer.Columns.Add("ALACAK", typeof(double));
                tablomCustomer.Columns.Add("BAKİYE", typeof(double));
                for (int i = 0; i < list.Count; i++)
                {
                    if(list[i].IslemTarihi < bitis && list[i].IslemTarihi > baslangic)
                    {
                        tablomCustomer.Rows.Add(list[i].IslemTarihi, list[i].Fıs_IslemNo,
                            list[i].IslemTuru, list[i].Aciklama, list[i].Miktar, list[i].Birim,
                            list[i].BirimFİyat, list[i].Borc, list[i].Alacak, list[i].Bakiye);
                        borc += list[i].Borc;
                        odenen += list[i].Alacak;
                        bakiye += list[i].Bakiye;
                    }
                }
                tBakiye.Text = bakiye.ToString("0.00");
                tBorc.Text = borc.ToString("0.00");
                tOdenen.Text = odenen.ToString("0.00");
                gridView.DataSource = tablomCustomer;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ListDoldurSell(DataGridView gridView, string islemNo)
        {
            try
            {
                List<SellDB> list = db.Info_Sells_Database();
                DataTable tablomSell = new DataTable();
                tablomSell.Columns.Add("TARİH", typeof(DateTime));
                tablomSell.Columns.Add("BARKOD", typeof(string));
                tablomSell.Columns.Add("ÜRÜN", typeof(string));
                tablomSell.Columns.Add("KATEGORİ", typeof(string));
                tablomSell.Columns.Add("MİKTAR", typeof(double));
                tablomSell.Columns.Add("BİRİM", typeof(string));
                tablomSell.Columns.Add("SATIŞ_FİYAT", typeof(double));
                tablomSell.Columns.Add("UYGULANAN_FİYAT", typeof(string));
                for (int i = 0; i < list.Count; i++)
                {
                    if(list[i].Fis_IslemNo == islemNo)
                        tablomSell.Rows.Add(list[i].Tarih, list[i].Barkod,
                            list[i].UrunAd, list[i].Kategori, list[i].Miktar, list[i].Birim,
                            list[i].SatisFiyat, list[i].UygulanacakFiyat);
                }
                gridView.DataSource = tablomSell;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ListDoldurSellReport(DataGridView gridView, DateTime x, DateTime y)
        {
            try
            {
                List<SellDB> list = db.Info_Sells_Database();
                DataTable tablomSell = new DataTable();
                tablomSell.Columns.Add("TARİH", typeof(DateTime));
                tablomSell.Columns.Add("BARKOD", typeof(string));
                tablomSell.Columns.Add("ÜRÜN", typeof(string));
                tablomSell.Columns.Add("KATEGORİ", typeof(string));
                tablomSell.Columns.Add("MİKTAR", typeof(double));
                tablomSell.Columns.Add("BİRİM", typeof(string));
                tablomSell.Columns.Add("ALIŞ_FİYAT", typeof(string));
                tablomSell.Columns.Add("SATIŞ_FİYAT", typeof(double));
                tablomSell.Columns.Add("UYGULANAN_FİYAT", typeof(string));
                for (int i = 0; i < list.Count; i++)
                {
                    if(list[i].Tarih >= x && list[i].Tarih < y)
                        tablomSell.Rows.Add(list[i].Tarih, list[i].Barkod,
                            list[i].UrunAd, list[i].Kategori, list[i].Miktar, list[i].Birim,
                            list[i].AlisFiyat, list[i].SatisFiyat, list[i].UygulanacakFiyat);
                }
                gridView.DataSource = tablomSell;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ListDoldurSellReportKategori(DataGridView gridView, string kategori)
        {
            try
            {
                List<SellDB> list = db.Info_Sells_Database();
                DataTable tablomSell = new DataTable();
                tablomSell.Columns.Add("TARİH", typeof(DateTime));
                tablomSell.Columns.Add("BARKOD", typeof(string));
                tablomSell.Columns.Add("ÜRÜN", typeof(string));
                tablomSell.Columns.Add("KATEGORİ", typeof(string));
                tablomSell.Columns.Add("MİKTAR", typeof(double));
                tablomSell.Columns.Add("BİRİM", typeof(string));
                tablomSell.Columns.Add("ALIŞ_FİYAT", typeof(string));
                tablomSell.Columns.Add("SATIŞ_FİYAT", typeof(double));
                tablomSell.Columns.Add("UYGULANAN_FİYAT", typeof(string));
                for (int i = 0; i < list.Count; i++)
                {
                    if(list[i].Kategori == kategori)
                        tablomSell.Rows.Add(list[i].Tarih, list[i].Barkod,
                            list[i].UrunAd, list[i].Kategori, list[i].Miktar, list[i].Birim,
                            list[i].AlisFiyat, list[i].SatisFiyat, list[i].UygulanacakFiyat);
                }
                gridView.DataSource = tablomSell;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ListDoldurSellReportUrun(DataGridView gridView, string urun)
        {
            try
            {
                List<SellDB> list = db.Info_Sells_Database();
                DataTable tablomSell = new DataTable();
                tablomSell.Columns.Add("TARİH", typeof(DateTime));
                tablomSell.Columns.Add("BARKOD", typeof(string));
                tablomSell.Columns.Add("ÜRÜN", typeof(string));
                tablomSell.Columns.Add("KATEGORİ", typeof(string));
                tablomSell.Columns.Add("MİKTAR", typeof(double));
                tablomSell.Columns.Add("BİRİM", typeof(string));
                tablomSell.Columns.Add("ALIŞ_FİYAT", typeof(string));
                tablomSell.Columns.Add("SATIŞ_FİYAT", typeof(double));
                tablomSell.Columns.Add("UYGULANAN_FİYAT", typeof(string));
                for (int i = 0; i < list.Count; i++)
                {
                    if(list[i].UrunAd == urun)
                        tablomSell.Rows.Add(list[i].Tarih, list[i].Barkod,
                            list[i].UrunAd, list[i].Kategori, list[i].Miktar, list[i].Birim,
                            list[i].AlisFiyat, list[i].SatisFiyat, list[i].UygulanacakFiyat);
                }
                gridView.DataSource = tablomSell;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ListDoldurSellReportPersonel(DataGridView gridView, string personel,
            DateTime x, DateTime y, TextBox tSMiktar, TextBox tSTutar, TextBox tATutar,
            TextBox tKTutar)
        {
            try
            {
                List<SellDB> list = db.Info_Sells_Database();
                DataTable tablomSell = new DataTable();
                double sTutar=0, miktar=0, aTutar=0, tKar=0;
                tablomSell.Columns.Add("TARİH", typeof(DateTime));
                tablomSell.Columns.Add("BARKOD", typeof(string));
                tablomSell.Columns.Add("ÜRÜN", typeof(string));
                tablomSell.Columns.Add("KATEGORİ", typeof(string));
                tablomSell.Columns.Add("MİKTAR", typeof(double));
                tablomSell.Columns.Add("BİRİM", typeof(string));
                tablomSell.Columns.Add("ALIŞ_FİYAT", typeof(string));
                tablomSell.Columns.Add("SATIŞ_FİYAT", typeof(double));
                tablomSell.Columns.Add("UYGULANAN_FİYAT", typeof(string));
                for (int i = 0; i < list.Count; i++)
                {
                    if(list[i].Personel == personel && list[i].Tarih >= x && list[i].Tarih < y)
                    {
                        tablomSell.Rows.Add(list[i].Tarih, list[i].Barkod,
                            list[i].UrunAd, list[i].Kategori, list[i].Miktar, list[i].Birim,
                            list[i].AlisFiyat, list[i].SatisFiyat, list[i].UygulanacakFiyat);
                        miktar += list[i].Miktar;
                        sTutar += list[i].SatisFiyat;
                        aTutar += list[i].AlisFiyat;
                        tKar += list[i].Kar;
                    }
                }
                tSMiktar.Text = miktar.ToString();
                tATutar.Text = aTutar.ToString("0.00") + " ₺";
                tKTutar.Text = tKar.ToString("0.00") + " ₺";
                tSTutar.Text = sTutar.ToString("0.00") + " ₺";
                gridView.DataSource = tablomSell;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ListDoldurStokRapor(DataGridView gridView, DateTime baslangic,
            DateTime bitis, TextBox tAlisTutar, TextBox tSatisTutar, TextBox Kar)
        {
            try
            {
                double tAlisFiyat = 0, tSatisFiyat1 = 0, tKar = 0;
                DataTable tablomStok = new DataTable();
                List<ProductDB> list = db.Info_Productes_Database();
                tablomStok.Columns.Add("BARKOD", typeof(string));
                tablomStok.Columns.Add("ÜRÜN", typeof(string));
                tablomStok.Columns.Add("ALIŞ_FİYAT", typeof(double));
                tablomStok.Columns.Add("SATIŞ_1", typeof(double));
                tablomStok.Columns.Add("SATIŞ_2", typeof(double));
                tablomStok.Columns.Add("KATEGORİ", typeof(string));
                tablomStok.Columns.Add("MİKTAR", typeof(double));
                tablomStok.Columns.Add("BİRİM", typeof(string));
                tablomStok.Columns.Add("AÇIKLAMA", typeof(string));
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].KayitTarihi >= baslangic && list[i].KayitTarihi < bitis)
                    {
                        tablomStok.Rows.Add(list[i].Barkod, list[i].StokAdi, list[i].AlisFiyat,
                            list[i].SatisFiyat_1, list[i].SatisFiyat_2, list[i].StokTuru,
                            list[i].StokBirimSayisi, list[i].Birim, list[i].UrunAciklama);
                        tAlisFiyat += list[i].AlisFiyat;
                        tSatisFiyat1 += list[i].SatisFiyat_1;
                        tKar += tSatisFiyat1 - tAlisFiyat;
                    }
                    tAlisTutar.Text = tAlisFiyat.ToString("0.00") + " ₺";
                    tSatisTutar.Text = tSatisFiyat1.ToString("0.00") + " ₺";
                    Kar.Text = tKar.ToString("0.00") + " ₺";
                }
                gridView.DataSource = tablomStok;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ListDoldurStokRaporKategori(DataGridView gridView, string kategori,
            TextBox tAlisTutar, TextBox tSatisTutar, TextBox Kar)
        {
            try
            {
                double tAlisFiyat = 0, tSatisFiyat1 = 0, tKar = 0;
                DataTable tablomStok = new DataTable();
                List<ProductDB> list = db.Info_Productes_Database();
                tablomStok.Columns.Add("BARKOD", typeof(string));
                tablomStok.Columns.Add("ÜRÜN", typeof(string));
                tablomStok.Columns.Add("ALIŞ_FİYAT", typeof(double));
                tablomStok.Columns.Add("SATIŞ_1", typeof(double));
                tablomStok.Columns.Add("SATIŞ_2", typeof(double));
                tablomStok.Columns.Add("KATEGORİ", typeof(string));
                tablomStok.Columns.Add("MİKTAR", typeof(double));
                tablomStok.Columns.Add("BİRİM", typeof(string));
                tablomStok.Columns.Add("AÇIKLAMA", typeof(string));
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].StokTuru == kategori)
                    {
                        tablomStok.Rows.Add(list[i].Barkod, list[i].StokAdi, list[i].AlisFiyat,
                            list[i].SatisFiyat_1, list[i].SatisFiyat_2, list[i].StokTuru,
                            list[i].StokBirimSayisi, list[i].Birim, list[i].UrunAciklama);
                        tAlisFiyat += list[i].AlisFiyat;
                        tSatisFiyat1 += list[i].SatisFiyat_1;
                        tKar += tSatisFiyat1 - tAlisFiyat;
                    }
                    tAlisTutar.Text = tAlisFiyat.ToString("0.00") + " ₺";
                    tSatisTutar.Text = tSatisFiyat1.ToString("0.00") + " ₺";
                    Kar.Text = tKar.ToString("0.00") + " ₺";
                }
                gridView.DataSource = tablomStok;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ListDoldurStokRaporTukenen(DataGridView gridView,
            TextBox tAlisTutar, TextBox tSatisTutar, TextBox Kar)
        {
            try
            {
                double tAlisFiyat = 0, tSatisFiyat1 = 0, tKar = 0;
                DataTable tablomStok = new DataTable();
                List<ProductDB> list = db.Info_Productes_Database();
                tablomStok.Columns.Add("BARKOD", typeof(string));
                tablomStok.Columns.Add("ÜRÜN", typeof(string));
                tablomStok.Columns.Add("ALIŞ_FİYAT", typeof(double));
                tablomStok.Columns.Add("SATIŞ_1", typeof(double));
                tablomStok.Columns.Add("SATIŞ_2", typeof(double));
                tablomStok.Columns.Add("KATEGORİ", typeof(string));
                tablomStok.Columns.Add("MİKTAR", typeof(double));
                tablomStok.Columns.Add("BİRİM", typeof(string));
                tablomStok.Columns.Add("AÇIKLAMA", typeof(string));
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].StokBirimSayisi <= 0)
                    {
                        tablomStok.Rows.Add(list[i].Barkod, list[i].StokAdi, list[i].AlisFiyat,
                            list[i].SatisFiyat_1, list[i].SatisFiyat_2, list[i].StokTuru,
                            list[i].StokBirimSayisi, list[i].Birim, list[i].UrunAciklama);
                        tAlisFiyat += list[i].AlisFiyat;
                        tSatisFiyat1 += list[i].SatisFiyat_1;
                        tKar += tSatisFiyat1 - tAlisFiyat;
                    }
                    tAlisTutar.Text = tAlisFiyat.ToString("0.00") + " ₺";
                    tSatisTutar.Text = tSatisFiyat1.ToString("0.00") + " ₺";
                    Kar.Text = tKar.ToString("0.00") + " ₺";
                }
                gridView.DataSource = tablomStok;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ListDoldurSatisEkran(DataGridView gridView, List<SellDB> sells, SellDB sell)
        {
            try
            {
                sells.Add(sell);
                DataTable tablomSell = new DataTable();
                tablomSell.Columns.Add("BARKOD", typeof(string));
                tablomSell.Columns.Add("ÜRÜN", typeof(string));
                tablomSell.Columns.Add("MİKTAR", typeof(double));
                tablomSell.Columns.Add("BİRİM", typeof(string));
                tablomSell.Columns.Add("FİYAT", typeof(double));
                for (int i = 0; i < sells.Count; i++)
                {
                    tablomSell.Rows.Add(sells[0].Barkod, sells[i].UrunAd,
                        sells[i].Miktar, sells[i].Birim, sells[i].SatisFiyat);
                }
                gridView.DataSource = tablomSell;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ListDoldurKategori(DataGridView gridView)
        {
            try
            {
                List<KategoriDB> list = db.Info_Kategori_Database();
                DataTable tablomKategori = new DataTable();
                tablomKategori.Columns.Add("ID", typeof(int));
                tablomKategori.Columns.Add("KATEGORİ", typeof(string));
                for (int i = 0; i < list.Count; i++)
                {
                    tablomKategori.Rows.Add(list[i].Id, list[i].Kategori);
                }
                gridView.DataSource = tablomKategori;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ListDoldurMusteriGrup(DataGridView gridView)
        {
            try
            {
                List<MusteriGrupDB> list = db.Info_MusteriGrup_Database();
                DataTable tablomMusteriGrup = new DataTable();
                tablomMusteriGrup.Columns.Add("ID", typeof(int));
                tablomMusteriGrup.Columns.Add("MÜŞTERİ_GRUP", typeof(string));
                for (int i = 0; i < list.Count; i++)
                {
                    tablomMusteriGrup.Rows.Add(list[i].Id, list[i].MusteriGrup);
                }
                gridView.DataSource = tablomMusteriGrup;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ListDoldurBirim(DataGridView gridView)
        {
            try
            {
                List<BirimDB> list = db.Info_Birim_Database();
                DataTable tablomBirim = new DataTable();
                tablomBirim.Columns.Add("ID", typeof(int));
                tablomBirim.Columns.Add("BİRİM", typeof(string));
                for (int i = 0; i < list.Count; i++)
                {
                    tablomBirim.Rows.Add(list[i].Id, list[i].Birim);
                }
                gridView.DataSource = tablomBirim;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ListDoldurTedarikci(DataGridView gridView)
        {
            try
            {
                List<TedarikciDB> list = db.Info_Tedarikci_Database();
                DataTable tablomTedarikci = new DataTable();
                tablomTedarikci.Columns.Add("ID", typeof(int));
                tablomTedarikci.Columns.Add("TEDARİKÇİ", typeof(string));
                for (int i = 0; i < list.Count; i++)
                {
                    tablomTedarikci.Rows.Add(list[i].Id, list[i].Tedarikci);
                }
                gridView.DataSource = tablomTedarikci;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ListDoldurUser(DataGridView gridView)
        {
            try
            {
                gridView.DataSource = null;
                DataTable tablomStok = new DataTable();
                List<UserDB> list = db.Info_Users_Database();
                tablomStok.Columns.Add("KULLANICI ADI", typeof(string));
                tablomStok.Columns.Add("AD/SOYAD", typeof(string));
                tablomStok.Columns.Add("YETKİ", typeof(bool));
                tablomStok.Columns.Add("ŞİFRE", typeof(string));
                for (int i = 0; i < list.Count; i++)
                {
                    tablomStok.Rows.Add(list[i].UserName, list[i].Name,
                        list[i].IsManager, list[i].Password);
                }
                gridView.DataSource = tablomStok;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void IsciSilmeBilgiSil(string name)
        {
            try
            {
                List<SellDB> sellList = db.Info_Sells_Database();
                List<SafeDB> safeList = db.Info_Safes_Database();
                for (int i = 0; i < sellList.Count; i++)
                    if (sellList[i].Personel.Equals(name))
                        db.Delete_Sell_Database(sellList[i].Fis_IslemNo);
                for (int i = 0; i < safeList.Count; i++)
                    if (safeList[i].Personel.Equals(name))
                        db.Delete_Safe_Database(safeList[i].Fis_IslemNo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ListDoldurIade(DataGridView gridView, TextBox fiyat, 
            TextBox miktar)
        {
            try
            {
                double tMiktar = 0, tTutar = 0;
                List<IadeDB> list = db.Info_Iade_Database();
                DataTable tablomSell = new DataTable();
                tablomSell.Columns.Add("TARİH", typeof(DateTime));
                tablomSell.Columns.Add("FİŞ_İŞLEM", typeof(string));
                tablomSell.Columns.Add("BARKOD", typeof(string));
                tablomSell.Columns.Add("ÜRÜN", typeof(string));
                tablomSell.Columns.Add("MİKTAR", typeof(double));
                tablomSell.Columns.Add("BİRİM", typeof(string));
                tablomSell.Columns.Add("SATIŞ_FİYAT", typeof(double));
                tablomSell.Columns.Add("UYGULANAN_FİYAT", typeof(string));
                tablomSell.Columns.Add("PERSONEL", typeof(string));
                tablomSell.Columns.Add("AÇIKLAMA", typeof(string));
                for (int i = 0; i < list.Count; i++)
                {
                    tablomSell.Rows.Add(list[i].Tarih, list[i].Fis_IslemNo, list[i].Barkod,
                            list[i].UrunAd, list[i].Miktar, list[i].Birim, list[i].Fiyat,
                            list[i].UygulananFiyat, list[i].Personel, list[i].Aciklama);
                    tMiktar += list[i].Miktar;
                    tTutar += list[i].Fiyat * list[i].Miktar;
                }
                fiyat.Text = tTutar.ToString("0.00") + " ₺";
                miktar.Text = tMiktar.ToString();
                gridView.DataSource = tablomSell;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Search_Safe(int index, DataGridView list,
           string searchWord)
        {
            try
            {
                DataTable tablomSafe = new DataTable();
                List<SafeDB> liste = db.Info_Safes_Database();
                tablomSafe.Columns.Add("TARİH", typeof(DateTime));
                tablomSafe.Columns.Add("TÜR", typeof(string));
                tablomSafe.Columns.Add("İŞLEM_NO", typeof(string));
                tablomSafe.Columns.Add("AÇIKLAMA", typeof(string));
                tablomSafe.Columns.Add("ÖDEME_ŞEKLİ", typeof(string));
                tablomSafe.Columns.Add("GİREN_MİKTAR", typeof(double));
                tablomSafe.Columns.Add("ÇIKAN_MİKTAR", typeof(double));
                tablomSafe.Columns.Add("KASA", typeof(string));
                tablomSafe.Columns.Add("PERSONEL", typeof(string));
                double girenler = 0, cikanlar = 0;
                for (int i = 0; i < liste.Count; i++)
                {
                    tablomSafe.Rows.Add(liste[i].Tarih, liste[i].IslemTur,
                        liste[i].Fis_IslemNo, liste[i].Aciklama, liste[i].OdemeSekli,
                        liste[i].GirenMiktar, liste[i].CikanMiktar, liste[i].Kasa,
                        liste[i].Personel);
                    girenler += liste[i].GirenMiktar;
                    cikanlar += liste[i].CikanMiktar;
                }
                DataView dv = tablomSafe.DefaultView;
                if (index == 0)
                {
                    dv.RowFilter = "İŞLEM_NO" + " LIKE '%" + searchWord + "%'";
                    list.DataSource = dv;
                }
                else if (index == 1)
                {
                    dv.RowFilter = "AÇIKLAMA" + " LIKE '%" + searchWord + "%'";
                    list.DataSource = dv;
                }
                else if (index == 2)
                {
                    dv.RowFilter = "ÖDEME_ŞEKLİ" + " LIKE '%" + searchWord + "%'";
                    list.DataSource = dv;
                }
                else if (index == 3)
                {
                    dv.RowFilter = "KASA" + " LIKE '%" + searchWord + "%'";
                    list.DataSource = dv;
                }
                else if(index == 4)
                {
                    dv.RowFilter = "TÜR" + " LIKE '%" + searchWord + "%'";
                    list.DataSource = dv;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Search_Stok(int index, DataGridView list,
          string searchWord)
        {
            try
            {
                DataTable tablomStok = new DataTable();
                List<ProductDB> liste = db.Info_Productes_Database();
                tablomStok.Columns.Add("BARKOD", typeof(string));
                tablomStok.Columns.Add("ÜRÜN", typeof(string));
                tablomStok.Columns.Add("ALIŞ_FİYAT", typeof(double));
                tablomStok.Columns.Add("SATIŞ_1", typeof(double));
                tablomStok.Columns.Add("SATIŞ_2", typeof(double));
                tablomStok.Columns.Add("KATEGORİ", typeof(string));
                tablomStok.Columns.Add("MİKTAR", typeof(double));
                tablomStok.Columns.Add("BİRİM", typeof(string));
                tablomStok.Columns.Add("AÇIKLAMA", typeof(string));
                for (int i = 0; i < liste.Count; i++)
                {
                    tablomStok.Rows.Add(liste[i].Barkod, liste[i].StokAdi, liste[i].AlisFiyat,
                        liste[i].SatisFiyat_1, liste[i].SatisFiyat_2, liste[i].StokTuru,
                        liste[i].StokBirimSayisi, liste[i].Birim, liste[i].UrunAciklama);
                }
                DataView dv = tablomStok.DefaultView;
                if (index == 0)
                {
                    dv.RowFilter = "BARKOD" + " LIKE '%" + searchWord + "%'";
                    list.DataSource = dv;
                }
                else if (index == 1)
                {
                    dv.RowFilter = "ÜRÜN" + " LIKE '%" + searchWord + "%'";
                    list.DataSource = dv;
                }
                else if (index == 2)
                {
                    dv.RowFilter = "KATEGORİ" + " LIKE '%" + searchWord + "%'";
                    list.DataSource = dv;
                }
                else if (index == 3)
                {
                    dv.RowFilter = "AÇIKLAMA" + " LIKE '%" + searchWord + "%'";
                    list.DataSource = dv;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Search_Customer(int index, DataGridView list,
           string searchWord)
        {
            try
            {
                DataTable tablomCustomer = new DataTable();
                List<CustomerDB> liste = db.Info_Customers_Database();
                tablomCustomer.Columns.Add("HESAP_TÜRÜ", typeof(string));
                tablomCustomer.Columns.Add("MÜŞTERİ_NO", typeof(int));
                tablomCustomer.Columns.Add("MÜŞTERİ_ADI", typeof(string));
                tablomCustomer.Columns.Add("SON_İŞLEM_TARİHİ", typeof(DateTime));
                tablomCustomer.Columns.Add("BAKİYE", typeof(double));
                tablomCustomer.Columns.Add("PARA_TÜRÜ", typeof(string));
                for (int i = 0; i < liste.Count; i++)
                {
                    tablomCustomer.Rows.Add(liste[i].HesapTuru, liste[i].MusteriKod,
                        liste[i].MusteriAdi, liste[i].SonIslemTarih, liste[i].Bakiye,
                        liste[i].ParaTuru);
                }
                DataView dv = tablomCustomer.DefaultView;
                if (index == 0)
                {
                    dv.RowFilter = "MÜŞTERİ_NO" + " LIKE '%" + searchWord + "%'";
                    list.DataSource = dv;
                }
                else if (index == 1)
                {
                    dv.RowFilter = "MÜŞTERİ_ADI" + " LIKE '%" + searchWord + "%'";
                    list.DataSource = dv;
                }
                else if (index == 2)
                {
                    dv.RowFilter = "HESAP_TÜRÜ" + " LIKE '%" + searchWord + "%'";
                    list.DataSource = dv;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void IadeListeDoldur(int index, DataGridView listem,
         string searchWord, TextBox miktar, TextBox fiyat)
        {
            try
            {
                double tMiktar = 0, tTutar = 0;
                List<SellDB> list = db.Info_Sells_Database();
                DataTable tablomSell = new DataTable();
                tablomSell.Columns.Add("TARİH", typeof(DateTime));
                tablomSell.Columns.Add("FİŞ_İŞLEM", typeof(string));
                tablomSell.Columns.Add("BARKOD", typeof(string));
                tablomSell.Columns.Add("ÜRÜN", typeof(string));
                tablomSell.Columns.Add("MİKTAR", typeof(double));
                tablomSell.Columns.Add("BİRİM", typeof(string));
                tablomSell.Columns.Add("SATIŞ_FİYAT", typeof(double));
                tablomSell.Columns.Add("UYGULANAN_FİYAT", typeof(string));
                tablomSell.Columns.Add("PERSONEL", typeof(string));
                if (index.Equals(0))
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i].Fis_IslemNo.Equals(searchWord) && list[i].Tarih > DateTime.Now.AddDays(-7))
                        {
                            tablomSell.Rows.Add(list[i].Tarih, list[i].Fis_IslemNo, list[i].Barkod,
                                list[i].UrunAd, list[i].Miktar, list[i].Birim, list[i].SatisFiyat,
                                list[i].UygulanacakFiyat, list[i].Personel);
                            tMiktar += list[i].Miktar;
                            tTutar += list[i].SatisFiyat;
                        }
                    }
                }  
                else if (index.Equals(1))
                {
                    for (int k = 0; k < list.Count; k++)
                    {
                        if (list[k].Barkod.Equals(searchWord) && list[k].Tarih > DateTime.Now.AddDays(-7))
                        {
                            tablomSell.Rows.Add(list[k].Tarih, list[k].Fis_IslemNo, list[k].Barkod,
                                list[k].UrunAd, list[k].Miktar, list[k].Birim, list[k].SatisFiyat,
                                list[k].UygulanacakFiyat, list[k].Personel);
                            tMiktar += list[k].Miktar;
                            tTutar += list[k].SatisFiyat;
                        }
                    }  
                }
                miktar.Text = tMiktar.ToString();
                fiyat.Text = tTutar.ToString("0.00") + " ₺";
                listem.DataSource = tablomSell;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       public void ListeYazdır(object sender, PrintPageEventArgs e, DataGridView liste, string Baslik)
        {
            StringFormat strFormat;
            ArrayList arrColumnLefts = new ArrayList();
            ArrayList arrColumnWidths = new ArrayList();
            int iCellHeight = 0;
            int iTotalWidth = 0;
            int iRow = 0;
            bool bFirstPage = false;
            bool bNewPage = false;
            int iHeaderHeight = 0;
            int iLeftMargin = e.MarginBounds.Left;
            int iTopMargin = e.MarginBounds.Top;
            bool bMorePagesToPrint = false;
            int iTmpWidth = 0;
            try
            {
                strFormat = new StringFormat();
                strFormat.Alignment = StringAlignment.Near;
                strFormat.LineAlignment = StringAlignment.Center;
                strFormat.Trimming = StringTrimming.EllipsisCharacter;
                arrColumnLefts.Clear();
                arrColumnWidths.Clear();
                iCellHeight = 0;
                iRow = 0;
                bFirstPage = true;
                bNewPage = true;
                iTotalWidth = 0;
                foreach (DataGridViewColumn dgvGridCol in liste.Columns)
                {
                    iTotalWidth += dgvGridCol.Width;
                }
                if (bFirstPage)
                {
                    foreach (DataGridViewColumn GridCol in liste.Columns)
                    {
                        iTmpWidth = (int)(Math.Floor((double)((double)GridCol.Width /
                                       (double)iTotalWidth * (double)iTotalWidth *
                                       ((double)e.MarginBounds.Width / (double)iTotalWidth))));

                        iHeaderHeight = (int)(e.Graphics.MeasureString(GridCol.HeaderText,
                                    GridCol.InheritedStyle.Font, iTmpWidth).Height) + 11;

                        arrColumnLefts.Add(iLeftMargin);
                        arrColumnWidths.Add(iTmpWidth);
                        iLeftMargin += iTmpWidth;
                    }
                }

                while (iRow <= liste.Rows.Count - 1)
                {
                    DataGridViewRow GridRow = liste.Rows[iRow];

                    iCellHeight = GridRow.Height + 5;
                    int iCount = 0;

                    if (iTopMargin + iCellHeight >= e.MarginBounds.Height + e.MarginBounds.Top)
                    {
                        bNewPage = true;
                        bFirstPage = false;
                        bMorePagesToPrint = true;
                        break;
                    }
                    else
                    {
                        if (bNewPage)
                        {
                            e.Graphics.DrawString(Baslik + " Raporu", new Font(liste.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top -
                                    e.Graphics.MeasureString(Baslik + " Raporu", new Font(liste.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                            String strDate = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();

                            e.Graphics.DrawString(strDate, new Font(liste.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width -
                                    e.Graphics.MeasureString(strDate, new Font(liste.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Width), e.MarginBounds.Top -
                                    e.Graphics.MeasureString(Baslik + " Raporu", new Font(new Font(liste.Font,
                                    FontStyle.Bold), FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                            iTopMargin = e.MarginBounds.Top;
                            foreach (DataGridViewColumn GridCol in liste.Columns)
                            {
                                e.Graphics.FillRectangle(new SolidBrush(Color.White),
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawRectangle(Pens.Black,
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawString(GridCol.HeaderText, GridCol.InheritedStyle.Font,
                                    Brushes.DarkBlue,
                                    new RectangleF((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight), strFormat);
                                iCount++;
                            }
                            bNewPage = false;
                            iTopMargin += iHeaderHeight;
                        }
                        iCount = 0;

                        foreach (DataGridViewCell Cel in GridRow.Cells)
                        {
                            if (Cel.Value != null)
                            {
                                Font font = new Font(Cel.InheritedStyle.Font.Name,
                                    Cel.InheritedStyle.Font.Size-1.5F, Cel.InheritedStyle.Font.Style);
                                e.Graphics.DrawString(Cel.Value.ToString(), font, Brushes.Black,
                                            new RectangleF((int)arrColumnLefts[iCount], (float)iTopMargin,
                                            (int)arrColumnWidths[iCount], (float)iCellHeight), strFormat);
                            }

                            e.Graphics.DrawRectangle(Pens.Black, new Rectangle((int)arrColumnLefts[iCount],
                                    iTopMargin, (int)arrColumnWidths[iCount], iCellHeight));

                            iCount++;
                        }
                    }
                    iRow++;
                    iTopMargin += iCellHeight;
                }

                if (bMorePagesToPrint)
                    e.HasMorePages = true;
                else
                    e.HasMorePages = false;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
