using BarkodluOtomasyon.Class;
using BarkodluOtomasyon.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarkodluOtomasyon
{
    public partial class FrmStokIslemleri : Form
    {
        DataBase db = new DataBase();
        Function function = new Function();
        Theme theme;
        private bool control = false;
        private bool changeValueControl = false;
        public FrmStokIslemleri()
        {
            InitializeComponent();
        }
        private void btnBarkodUret_Click(object sender, EventArgs e)
        {
            List<ProductDB> list = db.Info_Productes_Database();
            Random random = new Random();
            string sayi = random.Next(100000, 999999).ToString() +
                random.Next(1000000, 9999999).ToString();
            foreach (ProductDB item in list)
                while (true)
                {
                    if (item.Barkod == sayi)
                        sayi = random.Next(100000, 999999).ToString() +
                            random.Next(1000000, 9999999).ToString();
                    else
                         break;
                }
            txtBarkod.Text = sayi;
        }
        private void FrmStokIslemleri_Load(object sender, EventArgs e)
        {
            List<SystemDB> list = db.Info_System_Database();
            theme = new Theme(list[0].IndexTheme);
            theme.backArray(this);
            theme.buttonArray(btnBarkodUret, btnIslemIptal,
                btnUrunDuzenle, btnUrunEkle, btnUrunSil,
                btnUrunuKaydet, btnBarkodYaz, btnBirimEkle,
                btnKategoriEkle, btnTedarikciEkle);
            theme.textBoxArray(txtAlisFiyat, txtArama, txtBarkod, txtBeden_No,
                txtCinsi, txtKKFaizOran, txtKKSatis, txtMiktari,
                txtRenk, txtSatisFiyatKarOran, txtSatisFiyat_1,
                txtSatisFiyat_2, txtSatisFiyat_3, txtToplamAlisFiyat,
                txtToplamSatisFiyat_1, txtToplamSatisFiyat_2, txtToplamStokMiktar,
                txtUrunAdi, txtUrunSayisi,txtAciklama);
            theme.labelArray(label1, label10, label11, label12, label13, label14, label15,
                label16, label17, label18, label19, label2, label20, label21, label22, label23,
                label24, label3, label4, label5, label6, label7, label8, label9,label25);
            theme.comboArray(comboArama, comboBirim, comboKategori, comboTedarikci);
            theme.dateArray(dateBaslangic, dateBitis);
            theme.tableArray(listeUrun);
            theme.panelArray(panel1, panel2);
            theme.panelUstArray(panel3, panel4,panel5);
            TextReadOnly(true);
            control = false;
            function.ListDoldurStok(listeUrun);
            txtToplamAlisFiyat.Text = function.toplamAlisFiyat.ToString();
            txtToplamSatisFiyat_1.Text = function.toplamSatisFiyat1.ToString();
            txtToplamSatisFiyat_2.Text = function.toplamSatisFiyat2.ToString();
            txtToplamStokMiktar.Text = function.toplamStokMiktar.ToString();
            btnUrunuKaydet.Enabled = false;
            btnIslemIptal.Enabled = false;
            if (listeUrun.RowCount != 0)
            {
                btnUrunDuzenle.Enabled = true;
                btnUrunEkle.Enabled = true;
                btnUrunSil.Enabled = true;
            }
            else
            {
                btnUrunDuzenle.Enabled = false;
                btnUrunEkle.Enabled = true;
                btnUrunSil.Enabled = false;
            }
            ToplamSonuclar();
            comboArama.SelectedIndex = 0;
            comboDoldur();
            aciklama.SetToolTip(btnBarkodUret, "Otomatik BARKOD Üretir...");
            aciklama.SetToolTip(btnBirimEkle, "Birim Ekle...");
            aciklama.SetToolTip(btnKategoriEkle, "Kategori Ekle...");
            aciklama.SetToolTip(btnTedarikciEkle, "Tedarikçi Ekle...");
            aciklama.SetToolTip(txtKKFaizOran, "Faiz Oranı İle Otomatik KK. Fiyat Hesabı İçin Giriniz...");
            aciklama.SetToolTip(txtSatisFiyatKarOran, "Kar Oranı İle Otomatik Satış Fiyat Hesabı İçin Giriniz...");
        }
        private void txtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) &&
                e.KeyChar != ',' && e.KeyChar != '.';
        }
        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            TextTemizle();
            txtBarkod.Clear();
            txtAciklama.Clear();
            TextReadOnly(false);
            function.IsEmptyTextBoxes(txtAlisFiyat, txtKKFaizOran, txtKKSatis, txtMiktari,
                txtSatisFiyatKarOran, txtSatisFiyat_1, txtSatisFiyat_2, txtSatisFiyat_3,
                txtUrunSayisi);
            dateBitis.Value = DateTime.Now.AddDays(1);
            btnUrunDuzenle.Enabled = false;
            btnUrunEkle.Enabled = false;
            btnUrunuKaydet.Enabled = true;
            btnIslemIptal.Enabled = true;
            btnUrunSil.Enabled = false;
            control = true;
            changeValueControl = true;
        }
        private void btnUrunuKaydet_Click(object sender, EventArgs e)
        {
            if (txtBarkod.TextLength.Equals(0) || txtUrunAdi.TextLength.Equals(0))
                MessageBox.Show("Barkod veya Ürün Adı boş bırakılamaz!!!", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                function.IsEmptyTextBoxes(txtAlisFiyat, txtKKFaizOran, txtKKSatis, txtMiktari,
                    txtSatisFiyatKarOran, txtSatisFiyat_1, txtSatisFiyat_2, txtSatisFiyat_3,
                    txtUrunSayisi);
                if (control)
                {
                    db.Add_Product_Database(txtBarkod.Text, comboKategori.Text, txtUrunAdi.Text,
                       comboBirim.Text, Convert.ToDouble(txtMiktari.Text),
                       Convert.ToDouble(numericKDVOran.Value), Convert.ToDouble(txtAlisFiyat.Text),
                       Convert.ToDouble(txtSatisFiyat_1.Text), Convert.ToDouble(txtSatisFiyat_2.Text),
                       Convert.ToDouble(txtSatisFiyat_3.Text), Convert.ToDouble(txtKKSatis.Text),
                       txtAciklama.Text, txtCinsi.Text, txtRenk.Text, txtBeden_No.Text,
                       Convert.ToDateTime(dateBaslangic.Value), Convert.ToDateTime(dateBitis.Value),
                       comboTedarikci.Text, Convert.ToDouble(txtKKFaizOran.Text),
                       Convert.ToDouble(txtSatisFiyatKarOran.Text), chckIndirim.Checked);
                }
                else
                {
                    List<ProductDB> list = db.Info_Product_Database(txtBarkod.Text);
                    db.Update_Product_Database(list[0].Id, txtBarkod.Text, comboKategori.Text, txtUrunAdi.Text,
                        comboBirim.Text, Convert.ToDouble(txtMiktari.Text),
                        Convert.ToDouble(numericKDVOran.Value), Convert.ToDouble(txtAlisFiyat.Text),
                        Convert.ToDouble(txtSatisFiyat_1.Text), Convert.ToDouble(txtSatisFiyat_2.Text),
                        Convert.ToDouble(txtSatisFiyat_3.Text), Convert.ToDouble(txtKKSatis.Text),
                        txtAciklama.Text, txtCinsi.Text, txtRenk.Text, txtBeden_No.Text,
                        Convert.ToDateTime(dateBaslangic.Value), Convert.ToDateTime(dateBitis.Value),
                        comboTedarikci.Text, Convert.ToDouble(txtKKFaizOran.Text),
                        Convert.ToDouble(txtSatisFiyatKarOran.Text), chckIndirim.Checked,
                        list[0].KayitTarihi);
                }
                changeValueControl = false;
                TextTemizle();
                TextReadOnly(true);
                function.ListDoldurStok(listeUrun);
                ToplamSonuclar();
                btnUrunuKaydet.Enabled = false;
                btnIslemIptal.Enabled = false;
                btnUrunDuzenle.Enabled = true;
                btnUrunEkle.Enabled = true;
                btnUrunSil.Enabled = true;
                control = false;
            }
        }
        public void ToplamSonuclar()
        {
            txtToplamAlisFiyat.Text = function.toplamAlisFiyat.ToString() + " ₺";
            txtToplamSatisFiyat_1.Text = function.toplamSatisFiyat1.ToString() + " ₺";
            txtToplamSatisFiyat_2.Text = function.toplamSatisFiyat2.ToString() + " ₺";
            txtToplamStokMiktar.Text = function.toplamStokMiktar.ToString();
            txtUrunSayisi.Text = listeUrun.Rows.Count.ToString();
        }
        public void UrunGetir()
        {
            try
            {
                List<ProductDB> list = db.Info_Product_Database(
                    listeUrun.CurrentRow.Cells[0].Value.ToString());
                txtBarkod.Text = list[0].Barkod;
                txtAciklama.Text = list[0].UrunAciklama;
                txtAlisFiyat.Text = list[0].AlisFiyat.ToString();
                txtBeden_No.Text = list[0].Beden_No;
                txtCinsi.Text = list[0].StokGrup;
                comboKategori.Text = list[0].StokTuru;
                txtKKFaizOran.Text = list[0].KKFaizOran.ToString();
                txtKKSatis.Text = list[0].KrediSatisFiyat.ToString();
                txtMiktari.Text = list[0].StokBirimSayisi.ToString();
                comboBirim.Text = list[0].Birim;
                txtRenk.Text = list[0].Renk;
                txtSatisFiyatKarOran.Text = list[0].SatisFiyatKarOran.ToString();
                txtSatisFiyat_1.Text = list[0].SatisFiyat_1.ToString();
                txtSatisFiyat_2.Text = list[0].SatisFiyat_2.ToString();
                txtSatisFiyat_3.Text = list[0].SatisFiyat_3.ToString();
                comboTedarikci.Text = list[0].Tedarikci;
                txtUrunAdi.Text = list[0].StokAdi;
                dateBaslangic.Text = list[0].IndirimBaslangic.ToString();
                dateBitis.Text = list[0].IndirimBitis.ToString();
                numericKDVOran.Text = list[0].KDV.ToString();
                chckIndirim.Checked = list[0].IndirimControl;
                btnUrunSil.Enabled = true;
                btnUrunDuzenle.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void TextTemizle()
        {
            txtBarkod.Clear();
            txtAciklama.Clear();
            txtAlisFiyat.Clear();
            txtBeden_No.Clear();
            txtCinsi.Clear();
            txtKKFaizOran.Clear();
            txtKKSatis.Clear();
            txtMiktari.Clear();
            txtRenk.Clear();
            txtSatisFiyatKarOran.Clear();
            txtSatisFiyat_1.Clear();
            txtSatisFiyat_2.Clear();
            txtSatisFiyat_3.Clear();
            comboBirim.ResetText();
            comboKategori.ResetText();
            comboTedarikci.ResetText();
            txtUrunAdi.Clear();
            dateBaslangic.ResetText();
            dateBitis.ResetText();
            numericKDVOran.ResetText();

        }
        public void TextReadOnly(bool boolControl)
        {
            
            txtAciklama.ReadOnly = boolControl;
            txtAlisFiyat.ReadOnly = boolControl;
            txtBeden_No.ReadOnly = boolControl;
            txtCinsi.ReadOnly = boolControl;
            txtKKFaizOran.ReadOnly = boolControl;
            txtKKSatis.ReadOnly = boolControl;
            txtMiktari.ReadOnly = boolControl;
            txtRenk.ReadOnly = boolControl;
            txtSatisFiyatKarOran.ReadOnly = boolControl;
            txtSatisFiyat_1.ReadOnly = boolControl;
            txtSatisFiyat_2.ReadOnly = boolControl;
            txtSatisFiyat_3.ReadOnly = boolControl;
            txtUrunAdi.ReadOnly = boolControl;
            comboTedarikci.Enabled = !boolControl;
            comboKategori.Enabled = !boolControl;
            comboBirim.Enabled = !boolControl;
            dateBaslangic.Enabled = !boolControl;
            dateBitis.Enabled = !boolControl;
            numericKDVOran.Enabled = !boolControl;
            btnBarkodUret.Enabled = !boolControl;
            txtBarkod.ReadOnly = boolControl;
        }
        private void btnIslemIptal_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("İşlem İptal Edilsin Mi?", "", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                changeValueControl = false;
                TextTemizle();
                txtBarkod.Clear();
                txtAciklama.Clear();
                txtAlisFiyat.Clear();
                btnUrunuKaydet.Enabled = false;
                btnIslemIptal.Enabled = false;
                btnUrunDuzenle.Enabled = true;
                btnUrunEkle.Enabled = true;
                btnUrunSil.Enabled = true;
                control = false;
                UrunGetir();
                TextReadOnly(true);
            }
        }
        private void btnUrunDuzenle_Click(object sender, EventArgs e)
        {
            TextReadOnly(false);
            btnBarkodUret.Enabled = false;
            btnUrunuKaydet.Enabled = true;
            btnIslemIptal.Enabled = true;
            btnUrunDuzenle.Enabled = false;
            btnUrunEkle.Enabled = false;
            control = false;
            changeValueControl = true;
        }
        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            if (listeUrun.RowCount != 0)
            {
                if (MessageBox.Show("Ürünü SİLMEK İstediğinizden Emin Misiniz?", "", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    db.Delete_Product_Database(listeUrun.CurrentRow.Cells[0].Value.ToString());
                    listeUrun.Rows.RemoveAt(listeUrun.CurrentRow.Index);
                    function.ListDoldurStok(listeUrun);
                    ToplamSonuclar();
                }
            }
            else
            {
                MessageBox.Show("Listede Ürün Bulunmamaktadır!!!", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            function.Search_Stok(comboArama.SelectedIndex, listeUrun,
                txtArama.Text);
        }
        private void listeUrun_SelectionChanged(object sender, EventArgs e)
        {
            if (listeUrun.Rows.Count != 0)
            {
                TextReadOnly(true);
                UrunGetir();
            }
        }
        private void txtArama_Enter(object sender, EventArgs e)
        {
            txtArama.Text = "";
            txtArama.Font = new Font("Tahoma", 9.75F,
                FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
        }
        private void txtSatisFiyatKarOran_TextChanged(object sender, EventArgs e)
        {
            if (txtSatisFiyatKarOran.TextLength.Equals(0))
                txtSatisFiyatKarOran.Text = "0";
            if (changeValueControl)
                txtSatisFiyat_1.Text = (((Convert.ToDouble(txtSatisFiyatKarOran.Text) *
                    Convert.ToDouble(txtAlisFiyat.Text)) / 100) +
                    Convert.ToDouble(txtAlisFiyat.Text)).ToString();
        }
        private void txtKKFaizOran_TextChanged(object sender, EventArgs e)
        {
            if (txtKKFaizOran.TextLength.Equals(0))
                txtKKFaizOran.Text = "0";
            if (changeValueControl)
                txtKKSatis.Text = (((Convert.ToDouble(txtKKFaizOran.Text) *
                    Convert.ToDouble(txtSatisFiyat_1.Text)) / 100) +
                    Convert.ToDouble(txtSatisFiyat_1.Text)).ToString();
        }
        private void dateBitis_ValueChanged(object sender, EventArgs e)
        {
            if (dateBitis.Value < dateBaslangic.Value)
            {
                MessageBox.Show("Bitiş Tarihi Başlangıç Tarihinden Geride Olamaz!!!", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateBitis.Value = dateBaslangic.Value.AddDays(1);
            }
        }
        private void dateBaslangic_ValueChanged(object sender, EventArgs e)
        {
            if (dateBitis.Value < dateBaslangic.Value)
            {
                MessageBox.Show("Bitiş Tarihi Başlangıç Tarihinden Geride Olamaz!!!", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateBitis.Value = dateBaslangic.Value.AddDays(1);
            }
        }
        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            FrmKategoriIslemleri kategoriIslemleri = new FrmKategoriIslemleri();
            kategoriIslemleri.ShowDialog();
            comboDoldur();
        }
        public void comboDoldur()
        {
            int a = comboBirim.SelectedIndex,
                b = comboKategori.SelectedIndex,
                c = comboTedarikci.SelectedIndex;
            comboBirim.Items.Clear();
            comboKategori.Items.Clear();
            comboTedarikci.Items.Clear();
            List<TedarikciDB> tedarikciDBs = db.Info_Tedarikci_Database();
            foreach (var item in tedarikciDBs)
            {
                comboTedarikci.Items.Add(item.Tedarikci);
            }
            List<BirimDB> birimDBs = db.Info_Birim_Database();
            foreach (var item in birimDBs)
            {
                comboBirim.Items.Add(item.Birim);
            }
            List<KategoriDB> kategoriDBs = db.Info_Kategori_Database();
            foreach (var item in kategoriDBs)
            {
                comboKategori.Items.Add(item.Kategori);
            }
            comboBirim.SelectedIndex = a;
            comboKategori.SelectedIndex = b;
            comboTedarikci.SelectedIndex = c;
        }
        private void btnTedarikciEkle_Click(object sender, EventArgs e)
        {
            FrmTedarikciIslemleri tedarikciIslemleri = new FrmTedarikciIslemleri();
            tedarikciIslemleri.ShowDialog();
            comboDoldur();
        }
        private void btnBirimEkle_Click(object sender, EventArgs e)
        {
            FrmBirimIslemleri birimIslemleri = new FrmBirimIslemleri();
            birimIslemleri.ShowDialog();
            comboDoldur();
        }
        private void btnBarkodYaz_Click(object sender, EventArgs e)
        {
            if (listeUrun.RowCount != 0)
            {
                FrmBarcodeBas barcodeBas = new FrmBarcodeBas(listeUrun.CurrentRow.Cells[0].Value.ToString());
                barcodeBas.ShowDialog();
            }
            else
                MessageBox.Show("Listede Ürün Bulunmamaktadır!!!", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chckIndirim.Checked)
            {
                label17.Visible = true;
                label18.Visible = true;
                dateBaslangic.Visible = true;
                dateBitis.Visible = true;
            }
            else
            {
                label17.Visible = false;
                label18.Visible = false;
                dateBaslangic.Visible = false;
                dateBitis.Visible = false;
            }
        }
        private void txtAlisFiyat_TextChanged(object sender, EventArgs e)
        {
            if (txtAlisFiyat.TextLength.Equals(0))
                txtAlisFiyat.Text = "0";
            if (changeValueControl)
                txtSatisFiyat_1.Text = (((Convert.ToDouble(txtSatisFiyatKarOran.Text) *
                    Convert.ToDouble(txtAlisFiyat.Text)) / 100) +
                    Convert.ToDouble(txtAlisFiyat.Text)).ToString();
        }
        private void txtSatisFiyat_1_TextChanged(object sender, EventArgs e)
        {
            if (txtSatisFiyat_1.TextLength.Equals(0))
                txtSatisFiyat_1.Text = "0";
            if (changeValueControl)
                txtKKSatis.Text = (((Convert.ToDouble(txtKKFaizOran.Text) *
                    Convert.ToDouble(txtSatisFiyat_1.Text)) / 100) +
                    Convert.ToDouble(txtSatisFiyat_1.Text)).ToString();
        }
        private void listeUrun_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (listeUrun.RowCount != 0)
            {
                btnUrunDuzenle.Enabled = true;
                //btnUrunEkle.Enabled = true;
                btnUrunSil.Enabled = true;
            }
            else
            {
                btnUrunDuzenle.Enabled = false;
                //btnUrunEkle.Enabled = false;
                btnUrunSil.Enabled = false;
            }
        }
    }
}
