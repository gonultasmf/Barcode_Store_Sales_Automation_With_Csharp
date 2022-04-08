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
    public partial class FrmHizliStokEkle : Form
    {
        DataBase db = new DataBase();
        Theme theme;
        public static string barkod;
        public static bool control = false;
        public FrmHizliStokEkle(string barcode)
        {
            barkod = barcode;
            InitializeComponent();
        }
        private void FrmHizliStokEkle_Load(object sender, EventArgs e)
        {
            List<SystemDB> list = db.Info_System_Database();
            theme = new Theme(list[0].IndexTheme);
            theme.backArray(this);
            theme.buttonArray(btnBarkodUret, btnBirimEkle,
                btnIslemIptal, btnUrunEkle);
            theme.comboArray(comboBirim);
            theme.textBoxArray(txtBarkod, txtAlisFiyat,
                txtMiktari, txtSatisFiyat_1, txtUrunAdi);
            theme.labelArray(label2, label1, label3,
                label4, label5, label10, label11);
            txtBarkod.Text = barkod;
            txtMiktari.Text = "0";
            comboDoldur();
            //comboBirim.SelectedIndex = 0;
        }
        private void txtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) &&
                e.KeyChar != ',' && e.KeyChar != '.';
        }
        private void btnBirimEkle_Click(object sender, EventArgs e)
        {
            FrmBirimIslemleri birimIslemleri = new FrmBirimIslemleri();
            birimIslemleri.ShowDialog();
            comboDoldur();
        }
        public void comboDoldur()
        {
            comboBirim.Items.Clear();
            List<BirimDB> birimDBs = db.Info_Birim_Database();
            foreach (var item in birimDBs)
            {
                comboBirim.Items.Add(item.Birim);
            }
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

        private void FrmHizliStokEkle_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar);
        }

        private void btnIslemIptal_Click(object sender, EventArgs e)
        {
            control = false;
            this.Close();
        }
        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            db.Add_Product_Database(txtBarkod.Text, "", txtUrunAdi.Text,
                       comboBirim.Text, Convert.ToDouble(txtMiktari.Text),
                       Convert.ToDouble(numericKDVOran.Value), Convert.ToDouble(txtAlisFiyat.Text),
                       Convert.ToDouble(txtSatisFiyat_1.Text), 0,
                       0, 0, "", "", "", "", DateTime.Now, DateTime.Now,
                       "", 0, 0, false);
            control = true;
            this.Close();
        }
        private void txtMiktari_Leave(object sender, EventArgs e)
        {
            if (txtMiktari.TextLength.Equals(0))
                txtMiktari.Text = "0";
        }
    }
}
