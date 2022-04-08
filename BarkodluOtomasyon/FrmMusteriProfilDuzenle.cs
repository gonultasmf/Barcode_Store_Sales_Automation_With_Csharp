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
    public partial class FrmMusteriProfilDuzenle : Form
    {
        DataBase db = new DataBase();
        Function function = new Function();
        Theme theme;
        public FrmMusteriProfilDuzenle()
        {
            InitializeComponent();
        }

        private void FrmMusteriProfilDuzenle_Load(object sender, EventArgs e)
        {
            List<SystemDB> list = db.Info_System_Database();
            theme = new Theme(list[0].IndexTheme);
            theme.backArray(this);
            theme.buttonArray(btnAdiİlgiliyeAta, btnEkle,
                btnHesapTurBilgi, btnIptal, btnKaydet,
                btnResimYukle, btnSil);
            theme.comboArray(comboHesapTur, comboMusteriGrup, comboParaTur);
            theme.labelArray(label1, label10, label11,
                label12, label2, label3, label4, label5,
                label6, label7, label8, label9);
            theme.textBoxArray(txtePosta, txtFaxNo, txtGsmNo,
                txtMusteriAd, txtMusteriKod, txtMusteriyleIlgili,
                txtTelNo, txtVergiDairesi, txtVergiNo);
            theme.richArray(txtAdres);
            theme.panelArray(panel1);
            comboMusteriGrupDoldur();
            List<CustomerDB> customers = db.Info_Customer_Database(FrmMusteriIslemleri.musteriKod);
            txtAdres.Text = customers[0].Adres;
            txtePosta.Text = customers[0].Eposta;
            txtFaxNo.Text = customers[0].FaxNo;
            txtGsmNo.Text = customers[0].GsmNo;
            txtMusteriAd.Text = customers[0].MusteriAdi;
            txtMusteriKod.Text = customers[0].MusteriKod.ToString();
            txtMusteriyleIlgili.Text = customers[0].İlgili;
            txtTelNo.Text = customers[0].TelNo;
            txtVergiDairesi.Text = customers[0].VergiDairesi;
            txtVergiNo.Text = customers[0].VergiNo;
            comboHesapTur.Text = customers[0].HesapTuru;
            comboMusteriGrup.Text = customers[0].MusteriGrup;
            comboParaTur.Text = customers[0].ParaTuru;
            pcrtProfil.ImageLocation = customers[0].ImagePath;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtMusteriAd.TextLength.Equals(0) ||
                txtMusteriKod.TextLength.Equals(0))
            {
                MessageBox.Show("Müşteri Adı Boş Bırakılamaz!!!", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                List<CustomerDB> list = db.Info_Customer_Database(FrmMusteriIslemleri.musteriKod);
                db.Update_Customer_Database(list[0].Id,Convert.ToInt32(txtMusteriKod.Text),
                    comboHesapTur.Text, comboMusteriGrup.Text, txtMusteriAd.Text,
                    txtMusteriyleIlgili.Text, txtTelNo.Text, txtFaxNo.Text,
                    txtGsmNo.Text, txtAdres.Text, txtVergiDairesi.Text, txtVergiNo.Text,
                    txtePosta.Text, comboParaTur.Text, pcrtProfil.ImageLocation,
                    list[0].Bakiye, list[0].Not, list[0].HesapAyrinti, list[0].KayitTarih);
                this.Close();
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmMusteriGrupIslemleri musteriGrupIslemleri = new FrmMusteriGrupIslemleri();
            musteriGrupIslemleri.ShowDialog();
            comboMusteriGrupDoldur();
        }

        private void btnAdiİlgiliyeAta_Click(object sender, EventArgs e)
        {
            txtMusteriyleIlgili.Text = txtMusteriAd.Text;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            pcrtProfil.ImageLocation = "";
        }

        private void btnResimYukle_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Resim Dosyası |*.jpg;*.nef;*.png | Tüm Dosyalar |*.*";
            fileDialog.Title = "www.drahnasoft.com";
            fileDialog.ShowDialog();
            if (fileDialog.FileName.Length != 0)
                pcrtProfil.ImageLocation = fileDialog.FileName;
        }
        public void comboMusteriGrupDoldur()
        {
            List<MusteriGrupDB> list = db.Info_MusteriGrup_Database();
            comboMusteriGrup.Items.Clear();
            foreach (var item in list)
                comboMusteriGrup.Items.Add(item.MusteriGrup);
        }
        private void txtMusteriKod_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar);
        }
        private void btnHesapTurBilgi_Click(object sender, EventArgs e)
        {
            FrmHesapTurBilgi hesapTurBilgi = new FrmHesapTurBilgi();
            hesapTurBilgi.ShowDialog();
        }
    }
}
