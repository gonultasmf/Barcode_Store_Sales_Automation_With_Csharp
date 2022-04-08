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
    public partial class FrmFiyatGör : Form
    {
        DataBase db = new DataBase();
        Function function = new Function();
        Theme theme;
        public FrmFiyatGör()
        {
            InitializeComponent();
        }
        private void FrmFiyatGör_Load(object sender, EventArgs e)
        {
            List<SystemDB> list = db.Info_System_Database();
            theme = new Theme(list[0].IndexTheme);
            theme.backArray(this);
            theme.buttonArray(btnKapat);
            theme.labelArray(label1, label2, label3, label4,
                label5, label6, label7);
            theme.textBoxArray(txtAlisFiyat, txtBarkod,
                txtKKSatisFiyat, txtSatisFiyat1, txtSatisFiyat2,
                txtSatisFiyat3, txtStokMiktar, txtUrunAd);
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtBarkod_TextChanged(object sender, EventArgs e)
        {
            List<ProductDB> list = db.Info_Product_Database(txtBarkod.Text);
            if (list.Count != 0)
            {
                txtUrunAd.Text = list[0].StokAdi;
                txtAlisFiyat.Text = list[0].AlisFiyat.ToString();
                txtSatisFiyat1.Text = list[0].SatisFiyat_1.ToString();
                txtSatisFiyat2.Text = list[0].SatisFiyat_2.ToString();
                txtSatisFiyat3.Text = list[0].SatisFiyat_3.ToString();
                txtStokMiktar.Text = list[0].StokBirimSayisi.ToString() +
                    " " + list[0].Birim;
                txtKKSatisFiyat.Text = list[0].KrediSatisFiyat.ToString();
            }
            else
            {
                txtUrunAd.ResetText();
                txtAlisFiyat.ResetText();
                txtSatisFiyat1.ResetText();
                txtSatisFiyat2.ResetText();
                txtSatisFiyat3.ResetText();
                txtStokMiktar.ResetText();
                txtKKSatisFiyat.ResetText();
            }
        }
        private void txtBarkod_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
