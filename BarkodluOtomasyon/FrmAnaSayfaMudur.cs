using BarkodluOtomasyon.Class;
using BarkodluOtomasyon.Database;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarkodluOtomasyon
{
    public partial class FrmAnaSayfaMudur : Form
    {
        
        DataBase db = new DataBase();
        Function function = new Function();
       List<SellDB> sells = new List<SellDB>();
        Theme theme;
        string islemNo;
        public static int musteriKod;
        static bool sellControl = false;
        bool barkodOkumaControl = true;
        static bool fisYaz = true;
        public FrmAnaSayfaMudur()
        {
            
            this.Hide();
            FrmGiris frmGiris = new FrmGiris();
            frmGiris.ShowDialog();
            InitializeComponent();
            this.ActiveControl = txtEldenBarkod;
            txtEldenBarkod.Focus();
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
        private void FrmMainPageM_Load(object sender, EventArgs e)
        {
            if (!FrmGiris.control)
            {
                this.Close();
                return;
            }
            islemNo = FisIslemNo_Uret();
            List<SystemDB> list = db.Info_System_Database();
            theme = new Theme(list[0].IndexTheme);
            theme.backArray(this);
            theme.buttonArray(btnIndirimliSatis, btnKrediSatis,
                btnNakitKrediSatis, btnNakitSatis, btnTemizle,
                btnVeresiyeSatis, btnFiyatGor, btnUrunIade,
                btnKlavye, btnIslemIptal, btnMusteriSec, btnSeriSatis,
                btnFiyatEkle, btnEkle, btnUrunBul);
            theme.comboArray(comboIslemYapan, comboKasaNo,
                comboUygulanacakFiyat);
            theme.textBoxArray(txtEldenBarkod);
            theme.labelArray(lblTarih, lblZaman, lblSirketAdi,
                label1, label2, label3, label4, label5, label9,
                label10);
            theme.menuItemArray(aktivasyonToolStripMenuItem1,
                alarmAyarlarıToolStripMenuItem, aYARLARToolStripMenuItem4,
                birimİşlemleriToolStripMenuItem, dilAyarlarıToolStripMenuItem1,
                geriBildirimToolStripMenuItem, hakkındaToolStripMenuItem1,
                iadeİşlemleriToolStripMenuItem, işçiİşlemleriToolStripMenuItem,
                kASAİŞLEMToolStripMenuItem, kategoriİşlemleriToolStripMenuItem,
                kullanıcıİşlemleriToolStripMenuItem, kullanımKılavuzuToolStripMenuItem1,
                mailAyarlarıToolStripMenuItem, müşteriGrupİşlemleriToolStripMenuItem,
                mÜŞTERİİŞLEMToolStripMenuItem, personelRaporuToolStripMenuItem,
                rAPORLARToolStripMenuItem3, satışRaporuToolStripMenuItem,
                sEÇENEKLERToolStripMenuItem4, sistemAyarlarıToolStripMenuItem1,
                sMSAyarlarıToolStripMenuItem, stokRaporuToolStripMenuItem,
                sTOKİŞLEMToolStripMenuItem2, tedarikçiİşlemleriToolStripMenuItem,
                veriTabanıAyarlarıToolStripMenuItem, yARDIMToolStripMenuItem3,
                yazıcıAyarlarıToolStripMenuItem1);
            theme.tableArray(listSatis);
            theme.panelArray(panel1, panel2, panel3, panel5);
            theme.panelUstArray(panel4, panel6, panel7);
            theme.menuArray(menuStrip1);
            theme.menuItemArray();
            timer1.Start();
            txtAlinanPara.Text = "0,00";
            txtParaUstu.Text = "0,00";
            txtKasaFiyat.Text = "0,00";
            comboKasaNo.SelectedIndex = 0;
            comboUygulanacakFiyat.SelectedIndex = 0;
            lblSirketAdi.Text = list[0].FirmaAdi;
            pctrFisYaz.Image = Properties.Resources.controlson;
            List<ProductDB> products = db.Info_Productes_Database();
            foreach (var item in products)
            {
                if (item.IndirimControl)
                {
                    if ((item.IndirimBaslangic <= DateTime.Now && item.IndirimBitis >= DateTime.Now))
                    {
                        db.Update_Product_Database(item.Id, item.Barkod,
                            item.StokTuru, item.StokAdi, item.Birim,
                            item.StokBirimSayisi, item.KDV, item.AlisFiyat,
                            item.SatisFiyat_1, item.SatisFiyat_2, item.SatisFiyat_3,
                            item.KrediSatisFiyat, item.UrunAciklama, item.StokGrup,
                            item.Renk, item.Beden_No, item.IndirimBaslangic,
                            item.IndirimBitis, item.Tedarikci, item.KKFaizOran,
                            item.SatisFiyatKarOran, true, item.KayitTarihi);
                    }
                    else
                    {
                        db.Update_Product_Database(item.Id, item.Barkod,
                            item.StokTuru, item.StokAdi, item.Birim,
                            item.StokBirimSayisi, item.KDV, item.AlisFiyat,
                            item.SatisFiyat_1, item.SatisFiyat_2, item.SatisFiyat_3,
                            item.KrediSatisFiyat, item.UrunAciklama, item.StokGrup,
                            item.Renk, item.Beden_No, item.IndirimBaslangic,
                            item.IndirimBitis, item.Tedarikci, item.KKFaizOran,
                            item.SatisFiyatKarOran, false, item.KayitTarihi);
                    }
                }
            }
            List<UserDB> kullanicilar = db.Info_Users_Database();
            comboIslemYapan.Items.Clear();
            foreach (var item in kullanicilar)
            {
                comboIslemYapan.Items.Add(item.Name);
            }
            comboIslemYapan.SelectedText = DataBase.islemYapan;
            if (DataBase.yetkiliMi)
            {
                mÜŞTERİİŞLEMToolStripMenuItem.Enabled = true;
                kASAİŞLEMToolStripMenuItem.Enabled = true;
                rAPORLARToolStripMenuItem3.Enabled = true;
                sEÇENEKLERToolStripMenuItem4.Enabled = true;
                btnVeresiyeSatis.Enabled = true;
                btnMusteriSec.Enabled = true;
            }
            else
            {
                mÜŞTERİİŞLEMToolStripMenuItem.Enabled = false;
                kASAİŞLEMToolStripMenuItem.Enabled = false;
                rAPORLARToolStripMenuItem3.Enabled = false;
                sEÇENEKLERToolStripMenuItem4.Enabled = false;
                btnVeresiyeSatis.Enabled = false;
                btnMusteriSec.Enabled = false;
            }
            aciklama.SetToolTip(btnUrunBul, "Ürün Bulmak İçin Tıklayın...");
            aciklama.SetToolTip(txtEldenBarkod, "Ürün Barkodu Yazınız...");
            aciklama.SetToolTip(pctrFisYaz, "Her İşlem Sonrası Fiş Yazdırma Yapılsın/Yapılmasın...");
            aciklama.SetToolTip(btnKlavye, "Ekran Sayı Klavyesi...");
            aciklama.SetToolTip(btnEkle, "Girilen Barkodlu Ürünü Satışa Ekle...");
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                lblZaman.Text = DateTime.Now.ToLongTimeString();
                lblTarih.Text = DateTime.Now.ToShortDateString();
                List<AlarmDB> alarmDB = db.Info_Alarms_Database();
                foreach (var item in alarmDB)
                {
                    if (item.AlarmTarihi.ToShortDateString().Equals(lblTarih.Text) &&
                        item.AlarmTarihi.ToLongTimeString().Equals(lblZaman.Text))
                    {
                        FrmAlarm alarm = new FrmAlarm(item.MusteriKod);
                        alarm.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAlinanPara.Text = "0,00";
            txtParaUstu.Text = "0,00";
        }
        private void txtAlinanPara_TextChanged(object sender, EventArgs e)
        {
            if (txtKasaFiyat.TextLength.Equals(0))
                txtKasaFiyat.Text = "0,00";
            else if (txtAlinanPara.TextLength.Equals(0))
                txtAlinanPara.Text = "0,00";
            else
                txtParaUstu.Text = (Convert.ToDouble(txtAlinanPara.Text) -
                   Convert.ToDouble(txtKasaFiyat.Text)).ToString("0.00");
        }
        public void AlinanParaHesap(int para)
        {
            double sonuc;
            if (txtAlinanPara.TextLength.Equals(0))
                txtAlinanPara.Text = "0,00";
            sonuc = Convert.ToDouble(txtAlinanPara.Text) + para;
            txtAlinanPara.Text = sonuc.ToString("0.00");
        }
        private void btnIslemIptal_Click(object sender, EventArgs e)
        {
            if (sellControl)
            {
                if (MessageBox.Show("İşlemi İPTAL Etmek İstediğinizden Emin misiniz???",
                    "", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    txtAlinanPara.Text = "0,00";
                    txtParaUstu.Text = "0,00";
                    txtKasaFiyat.Text = "0,00";
                    foreach (var item in sells)
                    {
                        List<ProductDB> list = db.Info_Product_Database(item.Barkod);
                        if(list.Count != 0)
                            db.Update_Product_Database(list[0].Id, list[0].Barkod,
                                list[0].StokGrup, list[0].StokAdi, list[0].Birim,
                                list[0].StokBirimSayisi + item.Miktar, list[0].KDV,
                                list[0].AlisFiyat, list[0].SatisFiyat_1, list[0].SatisFiyat_2,
                                list[0].SatisFiyat_3, list[0].KrediSatisFiyat, list[0].UrunAciklama,
                                list[0].StokTuru, list[0].Renk, list[0].Beden_No,
                                list[0].IndirimBaslangic, list[0].IndirimBitis, list[0].Tedarikci,
                                list[0].KKFaizOran, list[0].SatisFiyatKarOran, list[0].IndirimControl,
                                list[0].KayitTarihi);
                    }
                    sells.Clear();
                    while (listSatis.RowCount > 0)
                        listSatis.Rows.RemoveAt(0);
                    btnNakitKrediSatis.Enabled = true;
                    btnNakitSatis.Enabled = true;
                    btnKrediSatis.Enabled = true;
                    btnIndirimliSatis.Enabled = true;
                    btnVeresiyeSatis.Enabled = false;
                    sellControl = false;
                }
            }
        }
        private void txtAlinanPara_Click(object sender, EventArgs e)
        {
            txtAlinanPara.SelectAll();
        }
        private void txtAlinanPara_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar) &&
                e.KeyChar != ',';
        }
        private void btn200_MouseMove(object sender, MouseEventArgs e)
        {
            btn200.Image = Properties.Resources.slayt12;
        }
        private void btn200_MouseLeave(object sender, EventArgs e)
        {
            btn200.Image = Properties.Resources.slayt11;
        }
        private void btn100_MouseMove(object sender, MouseEventArgs e)
        {
            btn100.Image = Properties.Resources.Webp_net_resizeimage;
        }
        private void btn100_MouseLeave(object sender, EventArgs e)
        {
            btn100.Image = Properties.Resources.slayt10;
        }
        private void btn50_MouseMove(object sender, MouseEventArgs e)
        {
            btn50.Image = Properties.Resources.Webp_net_resizeimage__2_;
        }
        private void btn50_MouseLeave(object sender, EventArgs e)
        {
            btn50.Image = Properties.Resources.Webp_net_resizeimage__1_;
        }
        private void btn20_MouseMove(object sender, MouseEventArgs e)
        {
            btn20.Image = Properties.Resources.Webp_net_resizeimage__3_;
        }
        private void btn20_MouseLeave(object sender, EventArgs e)
        {
            btn20.Image = Properties.Resources.Webp_net_resizeimage__4_;
        }
        private void btn10_MouseMove(object sender, MouseEventArgs e)
        {
            btn10.Image = Properties.Resources.Webp_net_resizeimage__6_;
        }
        private void btn10_MouseLeave(object sender, EventArgs e)
        {
            btn10.Image = Properties.Resources.Webp_net_resizeimage__5_;
        }
        private void btn5_MouseMove(object sender, MouseEventArgs e)
        {
            btn5.Image = Properties.Resources.Webp_net_resizeimage__7_;
        }
        private void btn5_MouseLeave(object sender, EventArgs e)
        {
            btn5.Image = Properties.Resources.Webp_net_resizeimage__8_;
        }
        private void btn200_Click(object sender, EventArgs e)
        {
            AlinanParaHesap(200);
        }
        private void btn100_Click(object sender, EventArgs e)
        {
            AlinanParaHesap(100);
        }
        private void btn50_Click(object sender, EventArgs e)
        {
            AlinanParaHesap(50);
        }
        private void btn20_Click(object sender, EventArgs e)
        {
            AlinanParaHesap(20);
        }
        private void btn10_Click(object sender, EventArgs e)
        {
            AlinanParaHesap(10);
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            AlinanParaHesap(5);
        }
        private void btnKlavye_Click(object sender, EventArgs e)
        {
            FrmSayiKlavye keyPad = new FrmSayiKlavye();
            keyPad.ShowDialog();
            txtEldenBarkod.Text = keyPad.txtBoxText;
        }
        private void txtEldenBarkod_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar) &&
                e.KeyChar != ',' && e.KeyChar != '.';
        }
        private void sTOKİŞLEMToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmStokIslemleri stokIslemleri = new FrmStokIslemleri();
            stokIslemleri.ShowDialog();
        }
        private void kASAİŞLEMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKasaIslemleri kasaIslemleri = new FrmKasaIslemleri();
            kasaIslemleri.ShowDialog();
        }
        private void stokRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStokRaporlari stokRaporlari = new FrmStokRaporlari();
            stokRaporlari.ShowDialog();
        }
        private void satışRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSatisRapor stokRapor = new FrmSatisRapor();
            stokRapor.ShowDialog();
        }
        private void personelRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPersonelRapor personelRapor = new FrmPersonelRapor();
            personelRapor.ShowDialog();
        }
        private void btnSeriSatis_Click(object sender, EventArgs e)
        {
            FrmSeriSatis seriSatis = new FrmSeriSatis();
            seriSatis.ShowDialog();
            if (seriSatis.control)
            {
                SatisEkle(seriSatis.barkod, FrmSeriSatis.miktar);
                txtParaUstu.Text = (Convert.ToDouble(txtAlinanPara.Text) -
                    Convert.ToDouble(txtKasaFiyat.Text)).ToString("0.00");
            }
        }
        public void SatisEkle(string barCode, double miktar)
        {
            List<ProductDB> list = db.Info_Product_Database(barCode);
            if(list[0].StokBirimSayisi > 0)
            {
                if(miktar > list[0].StokBirimSayisi)
                {
                    MessageBox.Show("Girdiğiniz Miktar Ürünün Stok Miktarını Aştı!!! " +
                        "\nMiktar Kalan Stok Miktarınca Alınacaktır...", "", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    miktar = list[0].StokBirimSayisi;
                }
                double tutar = list[0].SatisFiyat_1;
                if (comboUygulanacakFiyat.SelectedIndex.Equals(0))
                    tutar = list[0].SatisFiyat_1;
                else if (comboUygulanacakFiyat.SelectedIndex.Equals(1))
                    tutar = list[0].SatisFiyat_2;
                else if (comboUygulanacakFiyat.SelectedIndex.Equals(2))
                    tutar = list[0].SatisFiyat_3;
                else if (comboUygulanacakFiyat.SelectedIndex.Equals(3))
                    tutar = list[0].KrediSatisFiyat;
                if (list[0].IndirimControl)
                    if ((list[0].IndirimBaslangic <= DateTime.Now && list[0].IndirimBitis >= DateTime.Now))
                        tutar = list[0].SatisFiyat_3;
                var sell = new SellDB
                {
                    Fis_IslemNo = islemNo,
                    Barkod = list[0].Barkod,
                    UrunAd = list[0].StokAdi,
                    Tarih = DateTime.Now,
                    Miktar = miktar,
                    Birim = list[0].Birim,
                    SatisFiyat = tutar,
                    AlisFiyat = list[0].AlisFiyat,
                    Kar = tutar - list[0].AlisFiyat,
                    UygulanacakFiyat = comboUygulanacakFiyat.Text,
                    Kategori = list[0].StokTuru,
                    Personel = comboIslemYapan.Text
                };
                function.ListDoldurSatisEkran(listSatis, sells, sell);
                txtEldenBarkod.ResetText();
                double toplamSonuc = 0.00;
                foreach (var item in sells)
                {
                    toplamSonuc += (item.Miktar * item.SatisFiyat);
                }
                txtKasaFiyat.Text = toplamSonuc.ToString("0.00");
                sellControl = true;
                db.Update_Product_Database(list[0].Id, list[0].Barkod,
                    list[0].StokGrup, list[0].StokAdi, list[0].Birim,
                    list[0].StokBirimSayisi - miktar, list[0].KDV,
                    list[0].AlisFiyat, list[0].SatisFiyat_1, list[0].SatisFiyat_2,
                    list[0].SatisFiyat_3, list[0].KrediSatisFiyat, list[0].UrunAciklama,
                    list[0].StokTuru, list[0].Renk, list[0].Beden_No,
                    list[0].IndirimBaslangic, list[0].IndirimBitis, list[0].Tedarikci,
                    list[0].KKFaizOran, list[0].SatisFiyatKarOran, list[0].IndirimControl,
                    list[0].KayitTarihi);
            }
            else
            {
                MessageBox.Show("Ürün Stokta Tükenmiştir!!!", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEldenBarkod.ResetText();
            }
            
        }
        public void SatisiSelleEkle()
        {
            foreach (var list in sells)
            {
                db.Add_Sell_Database(list.Fis_IslemNo, list.Barkod, list.UrunAd,
                    list.Tarih, list.Miktar, list.Birim, list.SatisFiyat,
                    list.UygulanacakFiyat, list.Kategori, list.Personel,
                    list.AlisFiyat);
            }
        }
        private void frm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ShiftKey)
                btnFiyatEkle_Click(null, null);
            else if (e.KeyCode == Keys.F7)
                btnFiyatGor_Click(null, null);
            else if (e.KeyCode == Keys.F6)
                btnIndirimliSatis_Click(null, null);
            else if (e.KeyCode == Keys.F5)
                btnSeriSatis_Click(null, null);
            else if (e.KeyCode == Keys.F11)
                btnNakitSatis_Click(null, null);
            else if (e.KeyCode == Keys.F12)
                btnKrediSatis_Click(null, null);
            else if (e.KeyCode == Keys.F10)
                btnNakitKrediSatis_Click(null, null);
            else if (e.KeyCode == Keys.F9)
                btnUrunIade_Click(null, null);
            else if (e.KeyCode == Keys.F8)
                btnVeresiyeSatis_Click(null, null);
            else if (e.KeyCode == Keys.Escape)
                FrmAnaSayfaMudur_FormClosing(null, null);
        }
        private void listSatis_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (MessageBox.Show("Ürün : " + listSatis.CurrentRow.Cells[1].Value.ToString() +
                    "\nMiktar : " + listSatis.CurrentRow.Cells[2].Value.ToString() + " " +
                    listSatis.CurrentRow.Cells[3].Value.ToString() +
                    "\nÇıkarmak İstediğinizden Emin misiniz???", "", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    List<ProductDB> list = db.Info_Product_Database(listSatis.CurrentRow.Cells[0].Value.ToString());
                    if(list.Count != 0)
                        db.Update_Product_Database(list[0].Id, list[0].Barkod,
                            list[0].StokGrup, list[0].StokAdi, list[0].Birim,
                            list[0].StokBirimSayisi + Convert.ToDouble(listSatis.CurrentRow.Cells[2].Value.ToString()),
                            list[0].KDV, list[0].AlisFiyat, list[0].SatisFiyat_1, list[0].SatisFiyat_2,
                            list[0].SatisFiyat_3, list[0].KrediSatisFiyat, list[0].UrunAciklama,
                            list[0].StokTuru, list[0].Renk, list[0].Beden_No, list[0].IndirimBaslangic,
                            list[0].IndirimBitis, list[0].Tedarikci, list[0].KKFaizOran, list[0].SatisFiyatKarOran,
                            list[0].IndirimControl, list[0].KayitTarihi);
                    sells.RemoveAt(e.RowIndex);
                    listSatis.Rows.RemoveAt(e.RowIndex);
                    double toplamSonuc = 0.00;
                    foreach (var item in sells)
                    {
                        toplamSonuc += (item.Miktar * item.SatisFiyat);
                    }
                    txtKasaFiyat.Text = toplamSonuc.ToString("0.00");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void FrmAnaSayfaMudur_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Çıkmak İstediğinizden Emin misiniz??? ", "", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (sellControl)
                {
                    if (MessageBox.Show("Devam Eden Satış İşlemi Var Çıkarsanız Silinecektir!!!\n" +
                        "Çıkmak İstediğinizden Emin misiniz??? ", "", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Error) == DialogResult.Yes)
                    {
                        btnIslemIptal_Click(null, null);
                    }
                    else
                        e.Cancel = true;
                }
            }
            else
                e.Cancel = true;
        }
        //**********************************************
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            //List<SellDB> sells = db.Info_Sells_IslemNo_Database(islemNo);
            List<SystemDB> system = db.Info_System_Database();
            try
            {
                if (system[0].FisGenislik)
                {
                    Font fontBuyuk = new Font("Verdana", 8.5F, FontStyle.Bold);
                    Font fontKucuk = new Font("Verdana", 6.5F, FontStyle.Regular);
                    Font font = new Font("Verdana", 7.5F, FontStyle.Regular);
                    Font fontBaslik = new Font("Verdana", 7.5F, FontStyle.Bold);
                    StringFormat format = new StringFormat();
                    format.FormatFlags = StringFormatFlags.DirectionRightToLeft;
                    StringFormat sf = new StringFormat();
                    sf.Alignment = StringAlignment.Center;
                    float yPozisyon = 20;
                    float leftMargin = e.MarginBounds.Left;
                    float rightMargin = e.MarginBounds.Right;
                    float topMargin = e.MarginBounds.Top;
                    String strDate = DateTime.Now.ToShortDateString() + "  " + DateTime.Now.ToLongTimeString();

                    e.Graphics.DrawString(system[0].FirmaAdi, fontBaslik, Brushes.Black, leftMargin + 15, yPozisyon, sf);
                    yPozisyon += fontBaslik.GetHeight(e.Graphics);
                    string adres = system[0].Adres;
                    int lineCountAdres = 0;
                    if (adres.Length > 30)
                    {
                        int startvalue = 31;
                        while (startvalue < adres.Length)
                        {
                            if (adres[startvalue] == ' ')
                            {
                                adres = adres.Insert(startvalue, Environment.NewLine).TrimEnd();
                                startvalue += 31;
                            }
                            else
                            {
                                int i = adres.LastIndexOf(" ", startvalue);
                                startvalue = i++;
                                adres = adres.Insert(startvalue, Environment.NewLine).TrimEnd();
                                startvalue += 31;
                            }
                            lineCountAdres++;
                        }
                    }
                    e.Graphics.DrawString(adres, font, Brushes.Black, leftMargin - 80, yPozisyon);
                    yPozisyon += (font.GetHeight(e.Graphics) * (lineCountAdres+2));
                    e.Graphics.DrawString(strDate, fontKucuk, Brushes.Black, leftMargin - 85, yPozisyon);
                    yPozisyon += fontKucuk.GetHeight(e.Graphics);
                    e.Graphics.DrawString("Fiş No: " + islemNo, fontKucuk, Brushes.Black, leftMargin - 85, yPozisyon);
                    yPozisyon += fontKucuk.GetHeight(e.Graphics) + 10;
                    int sayi = 0;
                    while (sayi < sells.Count)
                    {
                        string strUrunAd = sells[sayi].UrunAd;
                        string strUrunFiyat = sells[sayi].SatisFiyat.ToString();
                        string strUrunMiktar = sells[sayi].Miktar.ToString();
                        string strUrunBirim = sells[sayi].Birim;
                        int lineCount = 0;
                        if (strUrunAd.Length > 14)
                        {
                            int startvalue = 15;
                            while (startvalue < strUrunAd.Length)
                            {
                                if (strUrunAd[startvalue] == ' ')
                                {
                                    strUrunAd = strUrunAd.Insert(startvalue, Environment.NewLine).TrimEnd();
                                    startvalue += 15;
                                }
                                else
                                {
                                    int i = strUrunAd.LastIndexOf(" ", startvalue);
                                    startvalue = i++;
                                    strUrunAd = strUrunAd.Insert(startvalue, Environment.NewLine).TrimEnd();
                                    startvalue += 15;
                                }
                                lineCount++;
                            }
                            e.Graphics.DrawString(strUrunAd, font, Brushes.Black, leftMargin - 85, yPozisyon);
                            yPozisyon += font.GetHeight(e.Graphics) * lineCount;
                            e.Graphics.DrawString(strUrunMiktar, font, Brushes.Black, leftMargin + 20, yPozisyon, format);
                            e.Graphics.DrawString(strUrunBirim, font, Brushes.Black, leftMargin + 60, yPozisyon, format);
                            e.Graphics.DrawString(strUrunFiyat, font, Brushes.Black, leftMargin + 110, yPozisyon, format);
                            yPozisyon += font.GetHeight(e.Graphics);
                        }
                        else
                        {
                            e.Graphics.DrawString(strUrunAd, font, Brushes.Black, leftMargin - 85, yPozisyon);
                            e.Graphics.DrawString(strUrunMiktar, font, Brushes.Black, leftMargin + 20, yPozisyon, format);
                            e.Graphics.DrawString(strUrunBirim, font, Brushes.Black, leftMargin + 60, yPozisyon, format);
                            e.Graphics.DrawString(strUrunFiyat, font, Brushes.Black, leftMargin + 110, yPozisyon, format);
                            yPozisyon += font.GetHeight(e.Graphics);
                        }
                        sayi++;
                    }
                    yPozisyon += font.GetHeight(e.Graphics) + 5;
                    e.Graphics.DrawString("TOPLAM", fontBuyuk, Brushes.Black, leftMargin - 85, yPozisyon);
                    e.Graphics.DrawString(txtKasaFiyat.Text, fontBuyuk, Brushes.Black, leftMargin + 110, yPozisyon, format);
                    yPozisyon += fontBuyuk.GetHeight(e.Graphics) + 5;
                    e.Graphics.DrawString("Nakit", font, Brushes.Black, leftMargin - 85, yPozisyon);
                    e.Graphics.DrawString(txtAlinanPara.Text, font, Brushes.Black, leftMargin + 90, yPozisyon, format);
                    e.Graphics.DrawString("TL", font, Brushes.Black, leftMargin + 110, yPozisyon, format);
                    yPozisyon += font.GetHeight(e.Graphics);
                    e.Graphics.DrawString("Para Üstü", font, Brushes.Black, leftMargin - 85, yPozisyon);
                    e.Graphics.DrawString(txtParaUstu.Text, font, Brushes.Black, leftMargin + 90, yPozisyon, format);
                    e.Graphics.DrawString("TL", font, Brushes.Black, leftMargin + 110, yPozisyon, format);
                    yPozisyon += font.GetHeight(e.Graphics) + 10;
                    e.Graphics.DrawString("İyi Günler, yine bekleriz...", font, Brushes.Black, leftMargin - 85, yPozisyon);
                    yPozisyon += font.GetHeight(e.Graphics) + 5;
                    string aciklama = system[0].FisAciklama;

                    if (aciklama.Length > 30)
                    {
                        int startvalue = 31;
                        while (startvalue < aciklama.Length)
                        {
                            if (aciklama[startvalue] == ' ')
                            {
                                aciklama = aciklama.Insert(startvalue, Environment.NewLine).TrimEnd();
                                startvalue += 31;
                            }
                            else
                            {
                                int i = aciklama.LastIndexOf(" ", startvalue);
                                startvalue = i++;
                                aciklama = aciklama.Insert(startvalue, Environment.NewLine).TrimEnd();
                                startvalue += 31;
                            }
                        }
                    }
                    e.Graphics.DrawString(aciklama, font, Brushes.Black, leftMargin - 85, yPozisyon);
                }
                else
                {
                    Font fontBuyuk = new Font("Verdana", 10.5F, FontStyle.Bold);
                    Font fontKucuk = new Font("Verdana", 8.5F, FontStyle.Regular);
                    Font font = new Font("Verdana", 9.5F, FontStyle.Regular);
                    Font fontBaslik = new Font("Verdana", 9.5F, FontStyle.Bold);
                    StringFormat format = new StringFormat();
                    format.FormatFlags = StringFormatFlags.DirectionRightToLeft;
                    StringFormat sf = new StringFormat();
                    sf.Alignment = StringAlignment.Center;
                    float yPozisyon = 15;
                    float leftMargin = e.MarginBounds.Left;
                    float rightMargin = e.MarginBounds.Right;
                    float topMargin = e.MarginBounds.Top;
                    String strDate = DateTime.Now.ToShortDateString() + "  " + DateTime.Now.ToLongTimeString();

                    e.Graphics.DrawString(system[0].FirmaAdi, fontBaslik, Brushes.Black, leftMargin + 30, yPozisyon, sf);
                    yPozisyon += fontBaslik.GetHeight(e.Graphics);
                    string adres = system[0].Adres;
                    int lineCountAdres = 0;
                    if (adres.Length > 31)
                    {
                        int startvalue = 32;
                        while (startvalue < adres.Length)
                        {
                            if (adres[startvalue] == ' ')
                            {
                                adres = adres.Insert(startvalue, Environment.NewLine).TrimEnd();
                                startvalue += 32;
                            }
                            else
                            {
                                int i = adres.LastIndexOf(" ", startvalue);
                                startvalue = i++;
                                adres = adres.Insert(startvalue, Environment.NewLine).TrimEnd();
                                startvalue += 32;
                            }
                            lineCountAdres++;
                        }
                    }
                    e.Graphics.DrawString(adres, font, Brushes.Black, leftMargin - 75, yPozisyon);
                    yPozisyon += (font.GetHeight(e.Graphics) * (lineCountAdres + 2));
                    e.Graphics.DrawString("Tarih :  " + strDate, fontKucuk, Brushes.Black, leftMargin - 80, yPozisyon);
                    yPozisyon += fontKucuk.GetHeight(e.Graphics);
                    e.Graphics.DrawString("Fiş No : " + islemNo, fontKucuk, Brushes.Black, leftMargin - 80, yPozisyon);
                    yPozisyon += fontKucuk.GetHeight(e.Graphics) + 10;
                    int sayi = 0;
                    while (sayi < sells.Count)
                    {
                        string strUrunAd = sells[sayi].UrunAd;
                        string strUrunFiyat = sells[sayi].SatisFiyat.ToString();
                        string strUrunMiktar = sells[sayi].Miktar.ToString();
                        string strUrunBirim = sells[sayi].Birim;
                        int lineCount = 0;
                        if (strUrunAd.Length > 18)
                        {
                            int startvalue = 19;
                            while (startvalue < strUrunAd.Length)
                            {
                                if (strUrunAd[startvalue] == ' ')
                                {
                                    strUrunAd = strUrunAd.Insert(startvalue, Environment.NewLine).TrimEnd();
                                    startvalue += 19;
                                }
                                else
                                {
                                    int i = strUrunAd.LastIndexOf(" ", startvalue);
                                    startvalue = i++;
                                    strUrunAd = strUrunAd.Insert(startvalue, Environment.NewLine).TrimEnd();
                                    startvalue += 19;
                                }
                                lineCount++;
                            }
                            e.Graphics.DrawString(strUrunAd, font, Brushes.Black, leftMargin - 80, yPozisyon);
                            yPozisyon += font.GetHeight(e.Graphics) * lineCount;
                            e.Graphics.DrawString(strUrunMiktar, font, Brushes.Black, leftMargin + 80, yPozisyon, format);
                            e.Graphics.DrawString(strUrunBirim, font, Brushes.Black, leftMargin + 120, yPozisyon, format);
                            e.Graphics.DrawString(strUrunFiyat, font, Brushes.Black, leftMargin + 180, yPozisyon, format);
                            yPozisyon += font.GetHeight(e.Graphics);
                        }
                        else
                        {
                            e.Graphics.DrawString(strUrunAd, font, Brushes.Black, leftMargin - 80, yPozisyon);
                            e.Graphics.DrawString(strUrunMiktar, font, Brushes.Black, leftMargin + 80, yPozisyon, format);
                            e.Graphics.DrawString(strUrunBirim, font, Brushes.Black, leftMargin + 120, yPozisyon, format);
                            e.Graphics.DrawString(strUrunFiyat, font, Brushes.Black, leftMargin + 180, yPozisyon, format);
                            yPozisyon += font.GetHeight(e.Graphics);
                        }
                        sayi++;
                    }
                    yPozisyon += font.GetHeight(e.Graphics) + 10;
                    e.Graphics.DrawString("TOPLAM", fontBuyuk, Brushes.Black, leftMargin - 80, yPozisyon);
                    e.Graphics.DrawString(txtKasaFiyat.Text, fontBuyuk, Brushes.Black, leftMargin + 180, yPozisyon, format);
                    yPozisyon += fontBuyuk.GetHeight(e.Graphics) + 5;
                    e.Graphics.DrawString("Nakit", font, Brushes.Black, leftMargin - 80, yPozisyon);
                    e.Graphics.DrawString(txtAlinanPara.Text, font, Brushes.Black, leftMargin + 150, yPozisyon, format);
                    e.Graphics.DrawString("TL", font, Brushes.Black, leftMargin + 180, yPozisyon, format);
                    yPozisyon += font.GetHeight(e.Graphics);
                    e.Graphics.DrawString("Para Üstü", font, Brushes.Black, leftMargin - 80, yPozisyon);
                    e.Graphics.DrawString(txtParaUstu.Text, font, Brushes.Black, leftMargin + 150, yPozisyon, format);
                    e.Graphics.DrawString("TL", font, Brushes.Black, leftMargin + 180, yPozisyon, format);
                    yPozisyon += font.GetHeight(e.Graphics) + 10;
                    e.Graphics.DrawString("İyi Günler, yine bekleriz...", font, Brushes.Black, leftMargin - 80, yPozisyon);
                    yPozisyon += font.GetHeight(e.Graphics) + 5;
                    string aciklama = system[0].FisAciklama;

                    if (aciklama.Length > 34)
                    {
                        int startvalue = 35;
                        while (startvalue < aciklama.Length)
                        {
                            if (aciklama[startvalue] == ' ')
                            {
                                aciklama = aciklama.Insert(startvalue, Environment.NewLine).TrimEnd();
                                startvalue += 35;
                            }
                            else
                            {
                                int i = aciklama.LastIndexOf(" ", startvalue);
                                startvalue = i++;
                                aciklama = aciklama.Insert(startvalue, Environment.NewLine).TrimEnd();
                                startvalue += 35;
                            }
                        }
                    }
                    e.Graphics.DrawString(aciklama, font, Brushes.Black, leftMargin - 80, yPozisyon);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //**********************************************
        private void btnNakitSatis_Click(object sender, EventArgs e )
        {
            SatisiSelleEkle();
            List<SellDB> list = db.Info_Sells_IslemNo_Database(islemNo);
            db.Add_Safe_Database(comboKasaNo.Text, DateTime.Now, "Giren",
                islemNo, "Kasa Satışı", "Nakit", Convert.ToDouble(txtAlinanPara.Text),
                Convert.ToDouble(txtParaUstu.Text), list, comboIslemYapan.Text);
            foreach (var item in list)
            {
                List<ProductDB> products = db.Info_Product_Database(item.Barkod);
                db.Update_Product_Database(products[0].Id, products[0].Barkod,
                    products[0].StokGrup, products[0].StokAdi, products[0].Birim,
                    products[0].StokBirimSayisi - item.Miktar, products[0].KDV,
                    products[0].AlisFiyat, products[0].SatisFiyat_1, products[0].SatisFiyat_2,
                    products[0].SatisFiyat_3, products[0].KrediSatisFiyat, products[0].UrunAciklama,
                    products[0].StokTuru, products[0].Renk, products[0].Beden_No,
                    products[0].IndirimBaslangic, products[0].IndirimBitis, products[0].Tedarikci,
                    products[0].KKFaizOran, products[0].SatisFiyatKarOran, products[0].IndirimControl,
                    products[0].KayitTarihi);
            }
            if (fisYaz)
            {
                try
                {
                    printDialog1.PrinterSettings.PrinterName = FrmYaziciAyarlari.yazici;
                    printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
                    printDocument1.DocumentName = "Fiş No: " + islemNo;
                    printDocument1.Print();
                /*
                    PrintPreviewDialog onizleme = new PrintPreviewDialog();
                    onizleme.Document = printDocument1;
                    printDialog1.PrinterSettings.PrinterName = FrmYaziciAyarlari.yazici;
                    onizleme.ShowDialog();*/
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            sellControl = false;
            islemNo = FisIslemNo_Uret();
            sells.Clear();
            while (listSatis.Rows.Count > 0)
                listSatis.Rows.Remove(listSatis.Rows[0]);
            txtAlinanPara.Text = "0,00";
            txtParaUstu.Text = "0,00";
            txtKasaFiyat.Text = "0,00";
            txtAlinanPara.ReadOnly = true;
            barkodOkumaControl = true;
            txtEldenBarkod.Focus();
        }
        private void btnKrediSatis_Click(object sender, EventArgs e)
        {
            SatisiSelleEkle();
            List<SellDB> list = db.Info_Sells_IslemNo_Database(islemNo);
            db.Add_Safe_Database(comboKasaNo.Text, DateTime.Now, "Giren",
                islemNo, "Kasa Satışı", "POS", Convert.ToDouble(txtAlinanPara.Text),
                Convert.ToDouble(txtParaUstu.Text), list, comboIslemYapan.Text);
            foreach (var item in list)
            {
                List<ProductDB> products = db.Info_Product_Database(item.Barkod);
                db.Update_Product_Database(products[0].Id, products[0].Barkod,
                    products[0].StokGrup, products[0].StokAdi, products[0].Birim,
                    products[0].StokBirimSayisi - item.Miktar, products[0].KDV,
                    products[0].AlisFiyat, products[0].SatisFiyat_1, products[0].SatisFiyat_2,
                    products[0].SatisFiyat_3, products[0].KrediSatisFiyat, products[0].UrunAciklama,
                    products[0].StokTuru, products[0].Renk, products[0].Beden_No,
                    products[0].IndirimBaslangic, products[0].IndirimBitis, products[0].Tedarikci,
                    products[0].KKFaizOran, products[0].SatisFiyatKarOran, products[0].IndirimControl,
                    products[0].KayitTarihi);
            }
            if (fisYaz)
            {
                try
                {
                    printDialog1.PrinterSettings.PrinterName = FrmYaziciAyarlari.yazici;
                    printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
                    printDocument1.DocumentName = "Fiş No: " + islemNo;
                    printDocument1.Print();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            sellControl = false;
            islemNo = FisIslemNo_Uret();
            while (listSatis.Rows.Count > 0)
                listSatis.Rows.Remove(listSatis.Rows[0]);
            txtAlinanPara.Text = "0,00";
            txtParaUstu.Text = "0,00";
            txtKasaFiyat.Text = "0,00";
            txtAlinanPara.ReadOnly = true;
            barkodOkumaControl = true;
            txtEldenBarkod.Focus();
            sells.Clear();
        }
        private void btnNakitKrediSatis_Click(object sender, EventArgs e)
        {
            SatisiSelleEkle();
            FrmNakitPosSatis nakitPosSatis =  new FrmNakitPosSatis();
            FrmNakitPosSatis.fiyat = Convert.ToDouble(txtKasaFiyat.Text);
            nakitPosSatis.ShowDialog();
            if (FrmNakitPosSatis.sattiMi)
            {
                List<SellDB> list = db.Info_Sells_IslemNo_Database(islemNo);
                db.Add_Safe_Database(comboKasaNo.Text, DateTime.Now, "Giren",
                    islemNo, "Kasa Satışı", "POS", FrmNakitPosSatis.posFİyat,
                    Convert.ToDouble(txtParaUstu.Text), list, comboIslemYapan.Text);
                db.Add_Safe_Database(comboKasaNo.Text, DateTime.Now, "Giren",
                    islemNo, "Kasa Satışı", "Nakit", FrmNakitPosSatis.nakitFiyat,
                    0, list, comboIslemYapan.Text);
                foreach (var item in list)
                {
                    List<ProductDB> products = db.Info_Product_Database(item.Barkod);
                    db.Update_Product_Database(products[0].Id, products[0].Barkod,
                        products[0].StokGrup, products[0].StokAdi, products[0].Birim,
                        products[0].StokBirimSayisi - item.Miktar, products[0].KDV,
                        products[0].AlisFiyat, products[0].SatisFiyat_1, products[0].SatisFiyat_2,
                        products[0].SatisFiyat_3, products[0].KrediSatisFiyat, products[0].UrunAciklama,
                        products[0].StokTuru, products[0].Renk, products[0].Beden_No,
                        products[0].IndirimBaslangic, products[0].IndirimBitis, products[0].Tedarikci,
                        products[0].KKFaizOran, products[0].SatisFiyatKarOran, products[0].IndirimControl,
                        products[0].KayitTarihi);
                }
                if (fisYaz)
                {
                    try
                    {
                        printDialog1.PrinterSettings.PrinterName = FrmYaziciAyarlari.yazici;
                        printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
                        printDocument1.DocumentName = "Fiş No: " + islemNo;
                        printDocument1.Print();
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                sellControl = false;
                islemNo = FisIslemNo_Uret();
                while (listSatis.Rows.Count > 0)
                    listSatis.Rows.Remove(listSatis.Rows[0]);
                txtAlinanPara.Text = "0,00";
                txtParaUstu.Text = "0,00";
                txtKasaFiyat.Text = "0,00";
                txtAlinanPara.ReadOnly = true;
                barkodOkumaControl = true;
                txtEldenBarkod.Focus();
                sells.Clear();
            }
        }
        private void btnIndirimliSatis_Click(object sender, EventArgs e)
        {
            SatisiSelleEkle();
            FrmIndirimliSatis ındirimliSatis = new FrmIndirimliSatis();
            FrmIndirimliSatis.fiyat = Convert.ToDouble(txtKasaFiyat.Text);
            ındirimliSatis.ShowDialog();
            if (FrmIndirimliSatis.sattiMi)
            {
                List<SellDB> list = db.Info_Sells_IslemNo_Database(islemNo);
                db.Add_Safe_Database(comboKasaNo.Text, DateTime.Now, "Giren",
                    islemNo, "Kasa %"+FrmIndirimliSatis.indirim+ " İndirimli Satışı",
                    FrmIndirimliSatis.satisTürü, FrmIndirimliSatis.genelFiyat,
                    Convert.ToDouble(txtParaUstu.Text), list, comboIslemYapan.Text);
                foreach (var item in list)
                {
                    List<ProductDB> products = db.Info_Product_Database(item.Barkod);
                    db.Update_Product_Database(products[0].Id, products[0].Barkod,
                        products[0].StokGrup, products[0].StokAdi, products[0].Birim,
                        products[0].StokBirimSayisi - item.Miktar, products[0].KDV,
                        products[0].AlisFiyat, products[0].SatisFiyat_1, products[0].SatisFiyat_2,
                        products[0].SatisFiyat_3, products[0].KrediSatisFiyat, products[0].UrunAciklama,
                        products[0].StokTuru, products[0].Renk, products[0].Beden_No,
                        products[0].IndirimBaslangic, products[0].IndirimBitis, products[0].Tedarikci,
                        products[0].KKFaizOran, products[0].SatisFiyatKarOran, products[0].IndirimControl,
                        products[0].KayitTarihi);
                }
                if (fisYaz)
                {
                    try
                    {
                        printDialog1.PrinterSettings.PrinterName = FrmYaziciAyarlari.yazici;
                        printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
                        printDocument1.DocumentName = "Fiş No: " + islemNo;
                        printDocument1.Print();
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                sellControl = false;
                islemNo = FisIslemNo_Uret();
                while (listSatis.Rows.Count > 0)
                    listSatis.Rows.Remove(listSatis.Rows[0]);
                txtAlinanPara.Text = "0,00";
                txtParaUstu.Text = "0,00";
                txtKasaFiyat.Text = "0,00";
                txtAlinanPara.ReadOnly = true;
                barkodOkumaControl = true;
                txtEldenBarkod.Focus();
                sells.Clear();
            }
        }
        private void btnFiyatGor_Click(object sender, EventArgs e)
        {
            FrmFiyatGör fiyatGör = new FrmFiyatGör();
            fiyatGör.ShowDialog();
        }
        private void kategoriİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKategoriIslemleri kategoriIslemleri = new FrmKategoriIslemleri();
            kategoriIslemleri.ShowDialog();
        }
        private void birimİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBirimIslemleri birimIslemleri = new FrmBirimIslemleri();
            birimIslemleri.ShowDialog();
        }
        private void tedarikçiİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTedarikciIslemleri tedarikciIslemleri = new FrmTedarikciIslemleri();
            tedarikciIslemleri.ShowDialog();
        }
        private void kullanıcıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKullaniciIslemleri kullaniciIslemleri = new FrmKullaniciIslemleri();
            kullaniciIslemleri.ShowDialog();
        }
        private void pERSONELToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmIsciIslemleri ısciIslemleri = new FrmIsciIslemleri();
            ısciIslemleri.ShowDialog();
        }
        private void btnUrunIade_Click(object sender, EventArgs e)
        {
            FrmUrunIade urunIade = new FrmUrunIade(comboIslemYapan.Text, comboKasaNo.Text);
            urunIade.ShowDialog();
        }
        private void iadeİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUrunIadeIslem urunIadeIslem = new FrmUrunIadeIslem();
            urunIadeIslem.ShowDialog();
        }
        private void müşteriGrupİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMusteriGrupIslemleri musteriGrupIslemleri = new FrmMusteriGrupIslemleri();
            musteriGrupIslemleri.ShowDialog();
        }
        private void mÜŞTERİİŞLEMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMusteriIslemleri musteriIslemleri = new FrmMusteriIslemleri();
            musteriIslemleri.ShowDialog();
        }
        private void alarmAyarlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAlarmAyar alarmAyar = new FrmAlarmAyar();
            alarmAyar.ShowDialog();
        }
        private void mailAyarlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMailAyarlari mailAyarlari = new FrmMailAyarlari();
            mailAyarlari.ShowDialog();
        }
        private void yazıcıAyarlarıToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmYaziciAyarlari yaziciAyarlari = new FrmYaziciAyarlari();
            yaziciAyarlari.ShowDialog();
        }
        private void veriTabanıAyarlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVeritabani veritabani = new FrmVeritabani();
            veritabani.ShowDialog();
        }
        private void sMSAyarlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSmsAyarlari smsAyarlari = new FrmSmsAyarlari();
            smsAyarlari.ShowDialog();
        }
        private void sistemAyarlarıToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmSistemAyarlari sistemAyarlari = new FrmSistemAyarlari();
            sistemAyarlari.ShowDialog();
            List<SystemDB> list = db.Info_System_Database();
            theme = new Theme(list[0].IndexTheme);
            theme.backArray(this);
            theme.buttonArray(btnIndirimliSatis, btnKrediSatis,
                btnNakitKrediSatis, btnNakitSatis, btnTemizle,
                btnVeresiyeSatis, btnFiyatGor, btnUrunIade,
                btnKlavye, btnIslemIptal, btnMusteriSec, btnSeriSatis,
                btnFiyatEkle, btnEkle, btnUrunBul);
            theme.comboArray(comboIslemYapan, comboKasaNo,
                comboUygulanacakFiyat);
            theme.textBoxArray(txtEldenBarkod);
            theme.labelArray(lblTarih, lblZaman, lblSirketAdi,
                label1, label2, label3, label4, label5, label9,
                label10);
            theme.menuItemArray(aktivasyonToolStripMenuItem1,
                alarmAyarlarıToolStripMenuItem, aYARLARToolStripMenuItem4,
                birimİşlemleriToolStripMenuItem, dilAyarlarıToolStripMenuItem1,
                geriBildirimToolStripMenuItem, hakkındaToolStripMenuItem1,
                iadeİşlemleriToolStripMenuItem, işçiİşlemleriToolStripMenuItem,
                kASAİŞLEMToolStripMenuItem, kategoriİşlemleriToolStripMenuItem,
                kullanıcıİşlemleriToolStripMenuItem, kullanımKılavuzuToolStripMenuItem1,
                mailAyarlarıToolStripMenuItem, müşteriGrupİşlemleriToolStripMenuItem,
                mÜŞTERİİŞLEMToolStripMenuItem, personelRaporuToolStripMenuItem,
                rAPORLARToolStripMenuItem3, satışRaporuToolStripMenuItem,
                sEÇENEKLERToolStripMenuItem4, sistemAyarlarıToolStripMenuItem1,
                sMSAyarlarıToolStripMenuItem, stokRaporuToolStripMenuItem,
                sTOKİŞLEMToolStripMenuItem2, tedarikçiİşlemleriToolStripMenuItem,
                veriTabanıAyarlarıToolStripMenuItem, yARDIMToolStripMenuItem3,
                yazıcıAyarlarıToolStripMenuItem1);
            theme.tableArray(listSatis);
            theme.panelArray(panel1, panel2, panel3, panel5);
            theme.panelUstArray(panel4, panel6, panel7);
            theme.menuArray(menuStrip1);
            theme.menuItemArray();
        }
        private void kullanımKılavuzuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCMsYLATtQ0aPB7q9d4o-umw");
        }
        private void aktivasyonToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmAktivasyon aktivasyon = new FrmAktivasyon();
            aktivasyon.ShowDialog();
        }
        private void btnMusteriSec_Click(object sender, EventArgs e)
        {
            FrmMusteriSec musteriSec = new FrmMusteriSec();
            musteriSec.ShowDialog();
            if (FrmMusteriSec.control)
            {
                btnNakitKrediSatis.Enabled = false;
                btnNakitSatis.Enabled = false;
                btnKrediSatis.Enabled = false;
                btnIndirimliSatis.Enabled = false;
                btnVeresiyeSatis.Enabled = true;
            }
        }
        private void geriBildirimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFeedback feedback = new FrmFeedback();
            feedback.ShowDialog();
        }
        private void btnVeresiyeSatis_Click(object sender, EventArgs e)
        {
            if (FrmMusteriSec.control)
            {
                FrmVeresiyeSatis veresiyeSatis = new FrmVeresiyeSatis(islemNo);
                veresiyeSatis.ShowDialog();
                if (FrmVeresiyeSatis.sattiMi)
                {
                    if (fisYaz)
                    {
                        try
                        {
                            /*
                        printDialog1.PrinterSettings.PrinterName = FrmYaziciAyarlari.yazici;
                        printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
                        printDocument1.Print();
                        */
                            PrintPreviewDialog onizleme = new PrintPreviewDialog();
                            onizleme.Document = printDocument1;
                            printDialog1.PrinterSettings.PrinterName = FrmYaziciAyarlari.yazici;
                            onizleme.ShowDialog();
                        }
                        catch (Exception exc)
                        {
                            MessageBox.Show(exc.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    islemNo = FisIslemNo_Uret();
                    while (listSatis.Rows.Count > 0)
                        listSatis.Rows.Remove(listSatis.Rows[0]);
                    txtAlinanPara.Text = "0,00";
                    txtParaUstu.Text = "0,00";
                    txtKasaFiyat.Text = "0,00";
                }
            }
            else
            {
                MessageBox.Show("Müşteri Seçilmemiştir!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void hakkındaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmHakkinda hakkinda = new FrmHakkinda();
            hakkinda.ShowDialog();
        }
        private void btnUrunBul_Click(object sender, EventArgs e)
        {
            FrmStokSec stokSec = new FrmStokSec();
            stokSec.ShowDialog();
            txtEldenBarkod.Text = FrmStokSec.barkod;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (!fisYaz)
            {
                pctrFisYaz.Image = Properties.Resources.controlson;
                fisYaz = true;
            }
            else
            {
                pctrFisYaz.Image = Properties.Resources.controlsoff;
                fisYaz = false;
            }
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            List<ProductDB> list = db.Info_Product_Database(txtEldenBarkod.Text);
            if (list.Count.Equals(0))
            {
                if (MessageBox.Show("Girdiğiniz BARKOD'a Ait Bir Ürün Bulıunamadı!!! \n" +
                    "Bu Barkod'la Ürün Eklemek İstiyor Musunuz???",
                    "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    FrmHizliStokEkle hizliStokEkle = new FrmHizliStokEkle(txtEldenBarkod.Text);
                    hizliStokEkle.ShowDialog();
                    if (FrmHizliStokEkle.control)
                    {
                        SatisEkle(txtEldenBarkod.Text, 1);
                        txtParaUstu.Text = (Convert.ToDouble(txtAlinanPara.Text) -
                            Convert.ToDouble(txtKasaFiyat.Text)).ToString("0.00");
                    }
                }
            }
            else
            {
                SatisEkle(txtEldenBarkod.Text, 1);
                txtParaUstu.Text = (Convert.ToDouble(txtAlinanPara.Text) -
                    Convert.ToDouble(txtKasaFiyat.Text)).ToString("0.00");
            }
        }
        private void btnFiyatEkle_Click(object sender, EventArgs e)
        {
            txtAlinanPara.ReadOnly = false;
            barkodOkumaControl = false;
            txtAlinanPara.Focus();
        }
        private void txtEldenBarkod_Leave(object sender, EventArgs e)
        {
            if (barkodOkumaControl)
                txtEldenBarkod.Focus();
        }
        private void comboKasaNo_Click(object sender, EventArgs e)
        {
            barkodOkumaControl = false;
            comboKasaNo.Focus();
        }
        private void comboUygulanacakFiyat_Click(object sender, EventArgs e)
        {
            barkodOkumaControl = false;
            comboUygulanacakFiyat.Focus();
        }
        private void comboIslemYapan_Leave(object sender, EventArgs e)
        {
            barkodOkumaControl = true;
            txtEldenBarkod.Focus();
        }
        private void txtEldenBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnEkle_Click(null, null);
        }
        private void txtKasaFiyat_TextChanged(object sender, EventArgs e)
        {
            txtParaUstu.Text = (Convert.ToDouble(txtAlinanPara.Text) - 
                Convert.ToDouble(txtKasaFiyat.Text)).ToString("0.00");
        }
    }
}
