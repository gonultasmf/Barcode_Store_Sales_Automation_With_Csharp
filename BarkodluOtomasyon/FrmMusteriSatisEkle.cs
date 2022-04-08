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
    public partial class FrmMusteriSatisEkle : Form
    {
        DataBase db = new DataBase();
        Function function = new Function();
        Theme theme;
        public FrmMusteriSatisEkle()
        {
            InitializeComponent();
        }
        private void FrmMusteriSatisEkle_Load(object sender, EventArgs e)
        {
            List<SystemDB> list = db.Info_System_Database();
            theme = new Theme(list[0].IndexTheme);
            theme.backArray(this);
            theme.buttonArray(btnEkle, btnIptal, btnIslemNoVer, btnUrunSec);
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
            comboBirim.SelectedIndex = 0;
        }
       
        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIslemNoVer_Click(object sender, EventArgs e)
        {
            txtIslemNo.Text = function.FisIslemNo_Uret();
        }

        private void txtMiktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) &&
                e.KeyChar != ',' && e.KeyChar != '.';
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
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtIslemNo.TextLength.Equals(0))
            {
                MessageBox.Show("Fiş / İşlem No Boş Bırakılamaz!!!", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                List<CustomerDB> list = db.Info_Customer_Database(FrmMusteriIslemleri.musteriKod);
                db.Add_HesapHareket_Database(list[0].MusteriKod, txtIslemNo.Text,
                    "Satış", txtAciklama.Text, Convert.ToDouble(txtMiktar.Text),
                    comboBirim.Text, Convert.ToDouble(txtBirimFiyat.Text),
                    Convert.ToDouble(txtTutar.Text), 0, Convert.ToDouble(txtTutar.Text));
                List<ProductDB> products = db.Info_Product_Database(FrmStokSec.barkod);
                db.Add_Sell_Database(txtIslemNo.Text, products[0].Barkod, products[0].StokAdi,
                    products[0].KayitTarihi, Convert.ToDouble(txtMiktar.Text), comboBirim.Text,
                    Convert.ToDouble(txtBirimFiyat.Text), "Satış Fiyat-1", products[0].StokTuru,
                    "Müdür", products[0].AlisFiyat);
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
