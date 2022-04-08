using BarkodluOtomasyon.Class;
using BarkodluOtomasyon.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarkodluOtomasyon
{
    public partial class FrmMusteriHesabı : Form
    {
        DataBase db = new DataBase();
        Function function = new Function();
        Theme theme;
        public static string islemNo;
        public FrmMusteriHesabı()
        {
            InitializeComponent();
        }

        private void FrmMusteriHesabı_Load(object sender, EventArgs e)
        {
            List<SystemDB> list = db.Info_System_Database();
            theme = new Theme(list[0].IndexTheme);
            theme.backArray(this);
            theme.panelArray(panel1, panel2);
            theme.labelArray(label9, label8, label7, label6,
                label5, label4, label3, label2, label11,
                label10, label1);
            theme.comboArray(comboHesapTur);
            theme.tableArray(listeHesapHareketleri);
            theme.textBoxArray(txtEposta, txtGsmNo, txtIlgili,
                txtKayitTarih, txtMusteriAd, txtMusteriKod,
                txtTBakiye, txtTBorc, txtTelNo, txtTOdenen);
            theme.buttonArray(btnAlacakEkle, btnAlarm,
                btnIslemAyrıntı, btnIslemDuzenle, btnIslemSil,
                btnListele, btnMailGonder, btnMesajGonder,
                btnOdemeYap, btnProfilDuzenle, btnSmsGonder,
                btnSatisEkle, btnHesapMakinesi, btnNotEkle);
            theme.dateArray(dateBitis, dateBaslangic);
            function.ListDoldurHesapHareket(listeHesapHareketleri,
                DateTime.MinValue, DateTime.MaxValue, txtTBorc,
                txtTOdenen, txtTBakiye, FrmMusteriIslemleri.musteriKod);
            ProfilGetir();
        }
        private void btnHesapMakinesi_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process p = System.Diagnostics.Process.Start("calc.exe");
            p.WaitForInputIdle();
        }

        private void btnNotEkle_Click(object sender, EventArgs e)
        {
            FrmNot not = new FrmNot();
            not.ShowDialog();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            DateTime tarihB = new DateTime(dateBaslangic.Value.Year, dateBaslangic.Value.Month, dateBaslangic.Value.Day, 0, 0, 0);
            DateTime tarihS = new DateTime(dateBitis.Value.Year, dateBitis.Value.Month, dateBitis.Value.Day, 0, 0, 0);
            function.ListDoldurHesapHareket(listeHesapHareketleri, tarihB,
                tarihS, txtTBorc, txtTOdenen, txtTBakiye, FrmMusteriIslemleri.musteriKod);
            ProfilGetir();
        }
        private void btnProfilDuzenle_Click(object sender, EventArgs e)
        {
            FrmMusteriProfilDuzenle musteriProfilDuzenle = new FrmMusteriProfilDuzenle();
            musteriProfilDuzenle.ShowDialog();
            ProfilGetir();
        }
        public void ProfilGetir()
        {
            List<CustomerDB> customers = db.Info_Customer_Database(FrmMusteriIslemleri.musteriKod);
            txtMusteriKod.Text = customers[0].MusteriKod.ToString();
            txtMusteriAd.Text = customers[0].MusteriAdi;
            txtKayitTarih.Text = customers[0].KayitTarih.ToString();
            txtIlgili.Text = customers[0].İlgili;
            txtEposta.Text = customers[0].Eposta;
            txtGsmNo.Text = customers[0].GsmNo;
            txtTelNo.Text = customers[0].TelNo;
            pctrProfil.ImageLocation = customers[0].ImagePath;
            comboHesapTur.Text = customers[0].HesapTuru;
            txtTOdenen.Text += " " + customers[0].ParaTuru;
            txtTBorc.Text += " " + customers[0].ParaTuru;
            txtTBakiye.Text += " " + customers[0].ParaTuru;
        }
        private void btnAlacakEkle_Click(object sender, EventArgs e)
        {
            FrmMusteriAlacakEkle musteriAlacakEkle = new FrmMusteriAlacakEkle();
            musteriAlacakEkle.ShowDialog();
            function.ListDoldurHesapHareket(listeHesapHareketleri,
                DateTime.MinValue, DateTime.MaxValue, txtTBorc,
                txtTOdenen, txtTBakiye, FrmMusteriIslemleri.musteriKod);
            ProfilGetir();
        }
        private void btnOdemeYap_Click(object sender, EventArgs e)
        {
            FrmMusteriOdemeEkle odemeEkle = new FrmMusteriOdemeEkle();
            odemeEkle.ShowDialog();
            function.ListDoldurHesapHareket(listeHesapHareketleri,
                DateTime.MinValue, DateTime.MaxValue, txtTBorc,
                txtTOdenen, txtTBakiye, FrmMusteriIslemleri.musteriKod);
            ProfilGetir();
        }
        private void btnSatisEkle_Click(object sender, EventArgs e)
        {
            FrmMusteriSatisEkle satisEkle = new FrmMusteriSatisEkle();
            satisEkle.ShowDialog();
            function.ListDoldurHesapHareket(listeHesapHareketleri,
               DateTime.MinValue, DateTime.MaxValue, txtTBorc,
               txtTOdenen, txtTBakiye, FrmMusteriIslemleri.musteriKod);
            ProfilGetir();
        }
        private void listeHesapHareketleri_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (listeHesapHareketleri.RowCount.Equals(0))
            {
                MessageBox.Show("Müşteri Hesap İşlemi Bulunmamaktadır!!!", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                islemNo = listeHesapHareketleri.CurrentRow.Cells[1].Value.ToString();
                FrmKasaIslemAyrinti ıslemAyrinti = new FrmKasaIslemAyrinti(islemNo);
                ıslemAyrinti.ShowDialog();
            }
        }
        private void btnIslemAyrıntı_Click(object sender, EventArgs e)
        {
            if (listeHesapHareketleri.RowCount.Equals(0))
            {
                MessageBox.Show("Müşteri Hesap İşlemi Bulunmamaktadır!!!", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                islemNo = listeHesapHareketleri.CurrentRow.Cells[1].Value.ToString();
                FrmKasaIslemAyrinti ıslemAyrinti = new FrmKasaIslemAyrinti(islemNo);
                ıslemAyrinti.ShowDialog();
            }
        }
        private void btnIslemSil_Click(object sender, EventArgs e)
        {
            if (listeHesapHareketleri.RowCount.Equals(0))
            {
                MessageBox.Show("Müşteri Hesap İşlemi Bulunmamaktadır!!!", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                islemNo = listeHesapHareketleri.CurrentRow.Cells[1].Value.ToString();
                FrmHesapHareketSil hesapHareketSil = new FrmHesapHareketSil(islemNo);
                hesapHareketSil.ShowDialog();
                function.ListDoldurHesapHareket(listeHesapHareketleri,
                   DateTime.MinValue, DateTime.MaxValue, txtTBorc,
                   txtTOdenen, txtTBakiye, FrmMusteriIslemleri.musteriKod);
                ProfilGetir();
            }
        }

        private void btnIslemDuzenle_Click(object sender, EventArgs e)
        {
            if (listeHesapHareketleri.RowCount.Equals(0))
            {
                MessageBox.Show("Müşteri Hesap İşlemi Bulunmamaktadır!!!", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                islemNo = listeHesapHareketleri.CurrentRow.Cells[1].Value.ToString();
                FrmHesapHareketDuzenle hareketDuzenle = new FrmHesapHareketDuzenle(islemNo);
                hareketDuzenle.ShowDialog();
                function.ListDoldurHesapHareket(listeHesapHareketleri,
                   DateTime.MinValue, DateTime.MaxValue, txtTBorc,
                   txtTOdenen, txtTBakiye, FrmMusteriIslemleri.musteriKod);
                ProfilGetir();
            }
        }
        private void btnAlarm_Click(object sender, EventArgs e)
        {
            FrmAlarmKur alarmKur = new FrmAlarmKur(FrmMusteriIslemleri.musteriKod);
            alarmKur.ShowDialog();
        }
        private void btnMesajGonder_Click(object sender, EventArgs e)
        {
            FrmWp wp = new FrmWp(txtTelNo.Text);
            wp.ShowDialog();
        }
        private void btnMailGonder_Click(object sender, EventArgs e)
        {
            FrmMail mail = new FrmMail(txtEposta.Text);
            mail.ShowDialog();
        }
        private void btnSmsGonder_Click(object sender, EventArgs e)
        {
            FrmSms sms = new FrmSms(txtTelNo.Text);
            sms.ShowDialog();
        }
    }
}
