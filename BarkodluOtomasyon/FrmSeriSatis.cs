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
    public partial class FrmSeriSatis : Form
    {
        DataBase db = new DataBase();
        Theme theme;
        public static int miktar = 1;
        public bool control = false;
        public string barkod;
        public FrmSeriSatis()
        {
            InitializeComponent();
        }
        private void btnKlavye_Click(object sender, EventArgs e)
        {
            FrmSayiKlavye sayiKlavye = new FrmSayiKlavye();
            sayiKlavye.ShowDialog();
            txtBarkod.Text = sayiKlavye.txtBoxText;
        }
        private void btnTamam_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMiktar.TextLength.Equals(0))
                {
                    MessageBox.Show("Ürün Okutun!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (txtMiktar.TextLength.Equals(0))
                    {
                        txtMiktar.Text = "1";
                    }
                    miktar = Convert.ToInt32(txtMiktar.Text);
                    control = true;
                    barkod = txtBarkod.Text;
                    this.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FrmSeriSatis_Load(object sender, EventArgs e)
        {
            List<SystemDB> list = db.Info_System_Database();
            theme = new Theme(list[0].IndexTheme);
            theme.backArray(this);
            theme.buttonArray(btnKlavye, btnTamam);
            theme.textBoxArray(txtMiktar, txtBirim, txtBarkod,
                txtSatisFiyat, txtUrun);
            theme.labelArray(label1, label2, label3, label4, label5);
        }
        private void txtBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                List<ProductDB> list = db.Info_Product_Database(txtBarkod.Text);
                if (list.Count.Equals(0))
                {
                    if (MessageBox.Show("Girdiğiniz BARKOD'a Ait Bir Ürün Bulıunamadı!!! \n" +
                        "Bu Barkod'la Ürün Eklemek İstiyor Musunuz???",
                        "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        FrmHizliStokEkle hizliStokEkle = new FrmHizliStokEkle(txtBarkod.Text);
                        hizliStokEkle.ShowDialog();
                        if (FrmHizliStokEkle.control)
                        {
                            List<ProductDB> liste = db.Info_Product_Database(txtBarkod.Text);
                            txtBirim.Text = liste[0].Birim;
                            txtSatisFiyat.Text = liste[0].SatisFiyat_1.ToString();
                            txtUrun.Text = liste[0].StokAdi;
                        }
                    }
                }
                else
                {
                    txtBirim.Text = list[0].Birim;
                    txtSatisFiyat.Text = list[0].SatisFiyat_1.ToString();
                    txtUrun.Text = list[0].StokAdi;
                }
            }
        }
    }
}
