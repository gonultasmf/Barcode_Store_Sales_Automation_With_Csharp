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
    public partial class FrmUrunIade : Form
    {
        DataBase db = new DataBase();
        Function function = new Function();
        Theme theme;
        private static string personel, kasa;
        double miktar;
        public FrmUrunIade(string personelim, string Kasa)
        {
            personel = personelim;
            kasa = Kasa;
            InitializeComponent();
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
        private void FrmUrunIade_Load(object sender, EventArgs e)
        {
            List<SystemDB> list = db.Info_System_Database();
            theme = new Theme(list[0].IndexTheme);
            theme.backArray(this);
            theme.buttonArray(btnIadeAl, btnKapat);
            theme.comboArray(comboIadeSekli, comboArama);
            theme.labelArray(label1, label2, label3, label4, label5, label6);
            theme.richArray(txtAciklama);
            theme.textBoxArray(txtArama, txtTSatisMiktar, txtTSatisTutar,
                txtMiktar);
            theme.tableArray(listeIadeUrunler);
            theme.panelArray(panel2, panel1);
            comboArama.SelectedIndex = 0;
            comboIadeSekli.SelectedIndex = 0;
            aciklama.SetToolTip(btnKapat, "Kapat");
            aciklama.SetToolTip(txtArama, "Arama Yapmak İçin Yazınız...");
            txtMiktar.Text = "0";
            miktar = Convert.ToDouble(txtMiktar.Text);
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            function.IadeListeDoldur(comboArama.SelectedIndex,
                listeIadeUrunler, txtArama.Text, txtTSatisMiktar, txtTSatisTutar);
        }

        private void btnIadeAl_Click(object sender, EventArgs e)
        {
            if (listeIadeUrunler.Rows.Count.Equals(0))
            {
                MessageBox.Show("Ürün Bulunamadı!!!", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                db.Add_Iade_Database(listeIadeUrunler.CurrentRow.Cells[1].Value.ToString(),
                    listeIadeUrunler.CurrentRow.Cells[2].Value.ToString(),
                    listeIadeUrunler.CurrentRow.Cells[3].Value.ToString(), personel,
                    listeIadeUrunler.CurrentRow.Cells[5].Value.ToString(),
                    Convert.ToDouble(txtMiktar.Text),
                    Convert.ToDouble(listeIadeUrunler.CurrentRow.Cells[6].Value),
                    listeIadeUrunler.CurrentRow.Cells[7].Value.ToString(),
                    txtAciklama.Text);
                List<ProductDB> products = db.Info_Product_Database(listeIadeUrunler.CurrentRow.Cells[2].Value.ToString());
                db.Update_Product_Database(products[0].Id, products[0].Barkod,
                        products[0].StokGrup, products[0].StokAdi, products[0].Birim,
                        products[0].StokBirimSayisi - Convert.ToDouble(txtMiktar.Text), products[0].KDV,
                        products[0].AlisFiyat, products[0].SatisFiyat_1, products[0].SatisFiyat_2,
                        products[0].SatisFiyat_3, products[0].KrediSatisFiyat, products[0].UrunAciklama,
                        products[0].StokTuru, products[0].Renk, products[0].Beden_No,
                        products[0].IndirimBaslangic, products[0].IndirimBitis, products[0].Tedarikci,
                        products[0].KKFaizOran, products[0].SatisFiyatKarOran, products[0].IndirimControl,
                        products[0].KayitTarihi);
                List<SellDB> sells = db.Info_Sells_Database();
                foreach (var item in sells)
                {
                    if (item.Barkod.Equals(products[0].Barkod))
                    {
                        db.Add_Safe_Database(kasa, DateTime.Now, "Çıkan", FisIslemNo_Uret(), "Ürün İadesi Yapıldı",
                            comboIadeSekli.Text, 0.00, item.SatisFiyat * miktar, null, personel);
                        db.Delete_Sell_Barcode_Database(products[0].Barkod);
                    }
                }
                
                this.Close();
            }
        }

        private void txtMiktar_TextChanged(object sender, EventArgs e)
        {
            if (txtMiktar.TextLength.Equals(0))
                txtMiktar.Text = "1";
        }

        private void txtMiktar_Leave(object sender, EventArgs e)
        {
            double temp = Convert.ToDouble(listeIadeUrunler.CurrentRow.Cells[4].Value.ToString());
            if (listeIadeUrunler.RowCount != 0)
            {
                miktar = Convert.ToDouble(txtMiktar.Text);
                if (miktar > temp)
                {
                    txtMiktar.Text = temp.ToString();
                    miktar = Convert.ToDouble(txtMiktar.Text);
                }
            }
        }

        private void txtMiktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar) &&
                e.KeyChar != ',' && e.KeyChar != '.';
        }
    }
}
