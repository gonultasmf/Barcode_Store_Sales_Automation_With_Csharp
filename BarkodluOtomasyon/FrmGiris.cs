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
    public partial class FrmGiris : Form
    {
        public static bool control = false;
        DataBase db = new DataBase();
        Theme theme;
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmGiris_Load(object sender, EventArgs e)
        {
            if (!Properties.Settings.Default.Control)
            {
                if (Properties.Settings.Default.deneme == 0)
                {
                    MessageBox.Show("Demo Süreniz Dolmuştur!!! Lütfen Ürün Anahtarı Giriniz!",
                    "", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    FrmAktivasyon aktivasyon = new FrmAktivasyon();
                    aktivasyon.ShowDialog();
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Şuanda Demo Sürümü Kullanmaktasınız. Kalan Kullanma Hakkınız : " + Properties.Settings.Default.deneme,
                       "", MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                    Properties.Settings.Default.deneme--;
                    Properties.Settings.Default.Save();
                }
            }
            List<SystemDB> list = db.Info_System_Database();
            theme = new Theme(list[0].IndexTheme);
            theme.backArray(this);
            theme.textBoxArray(txtKullaniciAdi, txtSifre);
            theme.labelArray(label1, label3, label4, label5);
            theme.comboArray(comboYetki);
            theme.panelArray(panel1);
            theme.buttonArray(btnCikis, btnGiris);
            theme.chckArray(checkBox1);
            comboYetki.SelectedIndex = 1;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                txtSifre.UseSystemPasswordChar = false;
            else
                txtSifre.UseSystemPasswordChar = true;
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            db.Login_Program(this, txtKullaniciAdi, txtSifre,
                lblHata, comboYetki);
        }
    }
}
