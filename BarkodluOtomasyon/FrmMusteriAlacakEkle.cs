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
    public partial class FrmMusteriAlacakEkle : Form
    {
        DataBase db = new DataBase();
        Function function = new Function();
        Theme theme;
        public FrmMusteriAlacakEkle()
        {
            InitializeComponent();
        }

        private void FrmMusteriAlacakEkle_Load(object sender, EventArgs e)
        {
            List<SystemDB> list = db.Info_System_Database();
            theme = new Theme(list[0].IndexTheme);
            theme.backArray(this);
            theme.buttonArray(btnEkle, btnIptal, btnIslemNoVer);
            theme.textBoxArray(txtIslemNo, txtTarih, txtTutar);
            theme.richArray(txtAciklama);
            theme.panelArray(panel1);
            theme.labelArray(label4, label3, label2, label1);
            txtTarih.Text = DateTime.Now.ToString();
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) &&
                e.KeyChar != ',' && e.KeyChar != '.';
        }
        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    "Alacak Dekontu", txtAciklama.Text, 0, "", 0, 0,
                    Convert.ToDouble(txtTutar.Text), -1 * Convert.ToDouble(txtTutar.Text));
                db.Add_Sell_Database(txtIslemNo.Text, "", "", DateTime.MinValue,
                    0, "", 0, "", "", "", 0);
                this.Close();
            }
        }
        private void btnIslemNoVer_Click(object sender, EventArgs e)
        {
            txtIslemNo.Text = function.FisIslemNo_Uret();
        }
    }
}
