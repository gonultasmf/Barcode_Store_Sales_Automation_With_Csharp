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
    public partial class FrmHesapHareketDuzenle : Form
    {
        DataBase db = new DataBase();
        Theme theme;
        string islemNo;
        public FrmHesapHareketDuzenle(string fisNo)
        {
            islemNo = fisNo;
            InitializeComponent();
        }

        private void FrmHesapHareketDuzenle_Load(object sender, EventArgs e)
        {
            List<SystemDB> list = db.Info_System_Database();
            theme = new Theme(list[0].IndexTheme);
            theme.backArray(this);
            theme.buttonArray(btnEkle, btnIptal, btnUrunSec);
            theme.textBoxArray(txtIslemNo, txtTarih, txtTutar, txtMiktar, txtBirimFiyat);
            theme.richArray(txtAciklama);
            theme.panelArray(panel1);
            theme.comboArray(comboBirim);
            theme.labelArray(label5, label4, label3, label2, label1, label7, label6);
            txtTarih.Text = DateTime.Now.ToString();
            comboBirim.Items.Clear();
            List<BirimDB> birim = db.Info_Birim_Database();
            foreach (var item in birim)
                comboBirim.Items.Add(item.Birim);
            List<HesapHareketDB> hareket = db.Info_HesapHareket_Database(islemNo);
            txtAciklama.Text = hareket[0].Aciklama;
            txtBirimFiyat.Text = hareket[0].BirimFİyat.ToString();
            txtIslemNo.Text = islemNo;
            txtMiktar.Text = hareket[0].Miktar.ToString();
            txtTarih.Text = hareket[0].IslemTarihi.ToString();
            txtTutar.Text = hareket[0].Bakiye.ToString().Replace("-", "");
            comboBirim.Text = hareket[0].Birim;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUrunSec_Click(object sender, EventArgs e)
        {
            FrmStokSec stokSec = new FrmStokSec();
            stokSec.ShowDialog();
            List<ProductDB> list = db.Info_Product_Database(FrmStokSec.barkod);
            txtBirimFiyat.Text = list[0].SatisFiyat_1.ToString();
            txtAciklama.Text = list[0].StokAdi;
            comboBirim.Text = list[0].Birim;
            txtMiktar.Text = "1";
            txtTutar.Text = (Convert.ToDouble(txtMiktar.Text) * Convert.ToDouble(txtBirimFiyat.Text)).ToString();
        }

        private void txtMiktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) &&
                e.KeyChar != ',' && e.KeyChar != '.';
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtIslemNo.TextLength.Equals(0))
            {
                MessageBox.Show("Fiş / İşlem No Boş Bırakılamaz!!!", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                List<SellDB> sell = db.Info_Sells_IslemNo_Database(txtIslemNo.Text);
                List<HesapHareketDB> hareket = db.Info_HesapHareket_Database(islemNo);
                db.Update_HesapHareket_Database(hareket[0].Id, hareket[0].MusteriKod, txtIslemNo.Text,
                    "Satış", txtAciklama.Text, Convert.ToDouble(txtMiktar.Text),
                    comboBirim.Text, Convert.ToDouble(txtBirimFiyat.Text),
                    Convert.ToDouble(txtTutar.Text), 0, Convert.ToDouble(txtTutar.Text),
                    hareket[0].Ayrinti);
                
                db.Update_Sell_Database(sell[0].Id, txtIslemNo.Text, sell[0].Barkod, sell[0].UrunAd,
                    sell[0].Tarih, Convert.ToDouble(txtMiktar.Text), comboBirim.Text,
                    Convert.ToDouble(txtBirimFiyat.Text), sell[0].UygulanacakFiyat, sell[0].Kategori,
                    sell[0].Personel, sell[0].AlisFiyat);
                this.Close();
            }
        }

        private void txtMiktar_TextChanged(object sender, EventArgs e)
        {
            if (txtMiktar.TextLength.Equals(0))
                txtMiktar.Text = "0";
            txtTutar.Text = (Convert.ToDouble(txtMiktar.Text) * Convert.ToDouble(txtBirimFiyat.Text)).ToString();
        }
    }
}
