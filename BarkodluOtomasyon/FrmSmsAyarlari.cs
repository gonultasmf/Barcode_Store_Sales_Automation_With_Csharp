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
    public partial class FrmSmsAyarlari : Form
    {
        DataBase db = new DataBase();
        Theme theme;
        bool resim = true;
        public FrmSmsAyarlari()
        {
            InitializeComponent();
        }

        private void FrmSmsAyarlari_Load(object sender, EventArgs e)
        {
            List<SystemDB> list = db.Info_System_Database();
            theme = new Theme(list[0].IndexTheme);
            theme.backArray(this);
            theme.buttonArray(btnIptal, btnKaydet);
            theme.comboArray(comboSMS);
            theme.richArray(txtMesaj1, txtMesaj2);
            theme.textBoxArray(txtKAdi, txtParola);
            theme.labelArray(label1, label2, label3, label4, label5, label6);
            txtMesaj1.Text = list[0].Mesaj1;
            txtMesaj2.Text = list[0].Mesaj2;
            comboSMS.SelectedIndex = list[0].SMS;
            txtKAdi.Text = list[0].SmsKAdi;
            txtParola.Text = list[0].SmsSifre;
        }
        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            List<SystemDB> list = db.Info_System_Database();
            db.Update_System_Database(list[0].IndexTheme, list[0].Backup,
                list[0].MailHost, list[0].MailPort, list[0].MailSSL, list[0].Mail,
                list[0].MailPassword, list[0].AErtele, list[0].ZilSes, list[0].ZilSesim,
                list[0].ZilSesTekrar, list[0].FisAciklama, txtMesaj1.Text, txtMesaj2.Text,
                comboSMS.SelectedIndex, txtKAdi.Text, txtParola.Text, list[0].Yazici,
                list[0].Pos, list[0].Etiket, list[0].FirmaAdi, list[0].BackupPath,
                list[0].FirmaTelNo, list[0].Adres, list[0].FisGenislik, list[0].FisYaziBoyut);
            this.Close();
        }
        private void labelControl1_Click(object sender, EventArgs e)
        {
            if (resim)
            {
                labelControl1.Image = Properties.Resources.eye1;
                txtParola.UseSystemPasswordChar = true;
                resim = !resim;
            }
            else
            {
                labelControl1.Image = Properties.Resources.hide__1_;
                txtParola.UseSystemPasswordChar = false;
                resim = !resim;
            }
        }
    }
}
