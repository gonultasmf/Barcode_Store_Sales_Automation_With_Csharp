using BarkodluOtomasyon.Class;
using BarkodluOtomasyon.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarkodluOtomasyon
{
    public partial class FrmMail : Form
    {
        DataBase db = new DataBase();
        Theme theme;
        string mail, mesajim;
        public FrmMail(string maili)
        {
            mail = maili;
            InitializeComponent();
        }
        private void FrmMail_Load(object sender, EventArgs e)
        {
            List<SystemDB> list = db.Info_System_Database();
            theme = new Theme(list[0].IndexTheme);
            theme.backArray(this);
            theme.panelArray(panel1);
            theme.buttonArray(btnIptal, btnMail);
            theme.rdBtnArray(rdBtnMesaj1, rdBtnMesaj2);
            theme.labelArray(label2, label1, label3);
            theme.richArray(txtMesaj1, txtMesaj2);
            theme.textBoxArray(txtMail, txtKonu);
            rdBtnMesaj1.Checked = true;
            txtMail.Text = mail;
            txtMesaj1.Text = list[0].Mesaj1;
            txtMesaj2.Text = list[0].Mesaj2;
        }

        private void btnMail_Click(object sender, EventArgs e)
        {
            try
            {
                if (NetworkInterface.GetIsNetworkAvailable() == true)
                {
                    List<SystemDB> list = db.Info_System_Database();
                    if (list[0].Mail == "" || list[0].MailPassword == "")
                    {
                        MessageBox.Show("Mail Bilgileri Eksik. Lütfen Kontrol Ediniz!!!",
                        "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MailMessage mail = new MailMessage();
                        mail.From = new MailAddress(list[0].Mail, list[0].FirmaAdi);
                        mail.To.Add(txtMail.Text);
                        mail.Subject = txtKonu.Text;
                        if (rdBtnMesaj1.Checked)
                            mail.Body = txtMesaj1.Text;
                        else if (rdBtnMesaj2.Checked)
                            mail.Body = txtMesaj2.Text;
                        SmtpClient smtp = new SmtpClient();
                        smtp.Credentials = new System.Net.NetworkCredential(list[0].Mail,
                            list[0].MailPassword);
                        smtp.Port = list[0].MailPort;
                        smtp.Host = list[0].MailHost;
                        smtp.EnableSsl = list[0].MailSSL;
                        smtp.SendAsync(mail, (object)mail);
                        MessageBox.Show("Mail Gönderme İşlemi Başarılı...", "",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("İnternet Bağlantısı Yoktur!!!", "",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SmtpException ex)
            {
                MessageBox.Show(ex.Message, "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void mesaj()
        {
            if (rdBtnMesaj1.Checked)
                mesajim = txtMesaj1.Text;
            else if (rdBtnMesaj2.Checked)
                mesajim = txtMesaj2.Text;
        }
    }
}
