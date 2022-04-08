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
    public partial class FrmMailAyarlari : Form
    {
        DataBase db = new DataBase();
        Theme theme;
        public FrmMailAyarlari()
        {
            InitializeComponent();
        }

        private void FrmMailAyarlari_Load(object sender, EventArgs e)
        {
            List<SystemDB> list = db.Info_System_Database();
            theme = new Theme(list[0].IndexTheme);
            theme.labelArray(label1, label2, label3, label4, label6, label7);
            theme.textBoxArray(txtHost, txtPort, txtMail, txtMailSifre);
            theme.buttonArray(btnIptal, btnKaydet);
            theme.panelArray(panel1);
            theme.chckArray(chckSSL);
            theme.comboArray(comboMail);
            theme.backArray(this);
            txtHost.Text = list[0].MailHost;
            txtPort.Text = list[0].MailPort.ToString();
            chckSSL.Checked = list[0].MailSSL;
            txtMail.Text = list[0].Mail;
            txtMailSifre.Text = list[0].MailPassword;
            if (txtHost.Text == "smtp.gmail.com")
                comboMail.SelectedIndex = 1;
            else if (txtHost.Text == "smtp.live.com")
                comboMail.SelectedIndex = 0;
            else if (txtHost.Text == "smtp.mail.yahoo.com")
                comboMail.SelectedIndex = 2;
            else if (txtHost.Text == "smtp.mynet.com")
                comboMail.SelectedIndex = 4;
            else if (txtHost.Text == "smtp.yandex.ru")
                comboMail.SelectedIndex = 3;
            else if (txtHost.Text == "smtp.gmx.com")
                comboMail.SelectedIndex = 5;
            else if (txtHost.Text == "smtp.aol.com")
                comboMail.SelectedIndex = 6;
        }
        private void comboMail_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboMail.SelectedIndex == 0)
            {
                txtHost.Text = "smtp.live.com";
                txtPort.Text = "587";
            }
            else if (comboMail.SelectedIndex == 1)
            {
                txtHost.Text = "smtp.gmail.com";
                txtPort.Text = "587";
            }
            else if (comboMail.SelectedIndex == 2)
            {
                txtHost.Text = "smtp.mail.yahoo.com";
                txtPort.Text = "465";
            }
            else if (comboMail.SelectedIndex == 3)
            {
                txtHost.Text = "smtp.yandex.ru";
                txtPort.Text = "587";
            }
            else if (comboMail.SelectedIndex == 4)
            {
                txtHost.Text = "smtp.mynet.com";
                txtPort.Text = "25";
            }
            else if (comboMail.SelectedIndex == 5)
            {
                txtHost.Text = "smtp.gmx.com";
                txtPort.Text = "25";
            }
            else if (comboMail.SelectedIndex == 6)
            {
                txtHost.Text = "smtp.aol.com";
                txtPort.Text = "25";
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            List<SystemDB> list = db.Info_System_Database();
            db.Update_System_Database(list[0].IndexTheme, list[0].Backup,
                txtHost.Text, Convert.ToInt32(txtPort.Text), chckSSL.Checked, txtMail.Text,
                txtMailSifre.Text, list[0].AErtele, list[0].ZilSes, list[0].ZilSesim,
                list[0].ZilSesTekrar, list[0].FisAciklama, list[0].Mesaj1, list[0].Mesaj2,
                list[0].SMS, list[0].SmsKAdi, list[0].SmsSifre, list[0].Yazici, list[0].Pos,
                list[0].Etiket, list[0].FirmaAdi, list[0].BackupPath, list[0].FirmaTelNo,
                list[0].Adres, list[0].FisGenislik, list[0].FisYaziBoyut);
            this.Close();
        }
    }
}
