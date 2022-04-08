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
    public partial class FrmKullaniciIslemleri : Form
    {
        DataBase db = new DataBase();
        Function function = new Function();
        Theme theme;
        public FrmKullaniciIslemleri()
        {
            InitializeComponent();
        }

        private void FrmKullaniciIslemleri_Load(object sender, EventArgs e)
        {
            List<SystemDB> list = db.Info_System_Database();
            theme = new Theme(list[0].IndexTheme);
            theme.backArray(this);
            theme.panelArray(panel2, panel1);
            theme.textBoxArray(txtKullaniciAdi, txtSifre, txtIsim);
            theme.labelArray(label3, label2, label1);
            theme.comboArray(comboYetki);
            theme.buttonArray(btnEkle, btnKapat, btnSil, btnSifreGoster);
            theme.tableArray(listeKullanici);
            function.ListDoldurUser(listeKullanici);
            comboYetki.SelectedIndex = 0;
            txtSifre.UseSystemPasswordChar = true;
            btnSifreGoster.Image = Properties.Resources.eye1;
            aciklama.SetToolTip(txtIsim, "Burada Yazılacak İsim Ana Ekranda İşlem Yapan Kısımda Çıkacaktır...");
            aciklama.SetToolTip(txtKullaniciAdi, "Burada Yazılacak Kullanıcı Adı Programa Giriş Yapılırken Kullanılacaktır...");
            aciklama.SetToolTip(btnSifreGoster, "Şifreyi Görünür/Gizli Yapar...");
            aciklama.SetToolTip(btnSil, "Seçili Olan Kaydı Siler...");
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            bool control = false;
            List<UserDB> list = db.Info_Users_Database();
            if (txtKullaniciAdi.TextLength.Equals(0) || txtIsim.TextLength.Equals(0))
                MessageBox.Show("Kullanıcı Adı veya Kullanıcı İsmi Boş Bırakılamaz!!!", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                foreach (var item in list)
                    if (item.UserName.Equals(txtKullaniciAdi.Text))
                        control = true;
                if (!control)
                {
                    if(comboYetki.SelectedIndex.Equals(0))
                        db.Add_User_Database(txtIsim.Text, txtKullaniciAdi.Text,
                            txtSifre.Text, true);
                    else
                        db.Add_User_Database(txtIsim.Text, txtKullaniciAdi.Text,
                            txtSifre.Text, false);
                    function.ListDoldurUser(listeKullanici);
                    control = false;
                    txtIsim.ResetText();
                    txtKullaniciAdi.ResetText();
                    txtSifre.ResetText();
                }
            }
            
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Kullanıcıyı SİLMEK İstediğinizden Emin misiniz???",
                    "", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.Delete_User_Database(listeKullanici.CurrentRow.Cells[0].Value.ToString());
                function.ListDoldurUser(listeKullanici);
            }
            
        }

        private void btnSifreGoster_Click(object sender, EventArgs e)
        {
            if(btnSifreGoster.Image == Properties.Resources.eye1)
            {
                txtSifre.UseSystemPasswordChar = false;
                btnSifreGoster.Image = Properties.Resources.hide__1_;
            }
            else
            {
                txtSifre.UseSystemPasswordChar = true;
                btnSifreGoster.Image = Properties.Resources.eye1;
            }
        }
    }
}
