using BarkodluOtomasyon.Class;
using BarkodluOtomasyon.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarkodluOtomasyon
{
    public partial class FrmSms : Form
    {
        DataBase db = new DataBase();
        Theme theme;
        string telNo, mesajim;
        public FrmSms(string tel)
        {
            telNo = tel;
            InitializeComponent();
        }
        public void mesaj()
        {
            if (rdBtnMesaj1.Checked)
                mesajim = txtMesaj1.Text;
            else if (rdBtnMesaj2.Checked)
                mesajim = txtMesaj2.Text;
        }
        string XmlPost(string PostAddress, string xmlData)
        {
            using (System.Net.WebClient wUpload = new System.Net.WebClient())
            {
                wUpload.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
                Byte[] bPostArray = Encoding.UTF8.GetBytes(xmlData);
                Byte[] bResponse = wUpload.UploadData(PostAddress, "POST", bPostArray);
                Char[] sReturnChars = Encoding.UTF8.GetChars(bResponse);
                string sWebPage = new string(sReturnChars);
                return sWebPage;
            }

        }
        string XMLPOST(string PostAddress, string xmlData)
        {
            try
            {
                var res = "";
                byte[] bytes = Encoding.UTF8.GetBytes(xmlData);
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(PostAddress);

                request.Method = "POST";
                request.ContentLength = bytes.Length;
                request.ContentType = "text/xml";
                request.Timeout = 300000000;
                using (Stream requestStream = request.GetRequestStream())
                {
                    requestStream.Write(bytes, 0, bytes.Length);
                }
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        string message = String.Format(
                        "Mesaj Gönderme İşlemi Başarısız!!!" + " Received HTTP {0}",
                        response.StatusCode);
                        throw new ApplicationException(message);
                    }

                    Stream responseStream = response.GetResponseStream();
                    using (StreamReader rdr = new StreamReader(responseStream))
                    {
                        res = rdr.ReadToEnd();
                    }
                    return res;
                }
            }
            catch
            {
                return "İşlemizin Sırasında Bilinmeyen Bir Hata İle Karşılaşıldı. Bilgilerinizi Kontrol Ederek Tekrar deneyiniz...";
            }

        }
        private void btnSms_Click(object sender, EventArgs e)
        {
            mesaj();
            List<SystemDB> list = db.Info_System_Database();
            if (list[0].SMS == 0)
                using (WebClient client = new WebClient())
                {
                    try
                    {
                        string tur = "Normal";
                        string sms1N = "data=<sms>" +
                                "<kno>" + list[0].FirmaTelNo + "</kno>" +
                                "<kulad>" + list[0].SmsKAdi + "</kulad>" +
                                "<sifre>" + list[0].SmsSifre + "</sifre>" +
                                "<gonderen>" + "SMS TEST" + "</gonderen>" +
                                "<mesaj>" + mesajim + "</mesaj>" +
                                "<numaralar>" + txtTelNo.Text + "</numaralar>" +
                                "<tur>" + tur + "</tur>" +
                            "</sms>";
                        MessageBox.Show(XmlPost("http://panel.vatansms.com/panel/smsgonder1Npost.php", sms1N), "",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            else if (list[0].SMS == 1)
            {
                try
                {
                    SmtpClient smtp = new SmtpClient();
                    MailMessage message = new MailMessage();
                    smtp.Credentials = new NetworkCredential(list[0].SmsKAdi,
                        list[0].SmsSifre);
                    smtp.Host = "https://www.ipipi.com/";
                    message.From = new MailAddress(string.Format("{0}@ipipi.com", list[0].FirmaTelNo));
                    message.To.Add(string.Format("{0}@ipipi.com", txtTelNo.Text));
                    message.Subject = list[0].FirmaAdi;
                    message.Body = mesajim;
                    smtp.Send(message);
                    MessageBox.Show("Mesaj Gönderme İşlemi Başarılı...", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (list[0].SMS == 2)
            {
                try
                {
                    String testXml = "<request>";
                    testXml += "<authentication>";
                    testXml += "<username>" + list[0].SmsKAdi + "</username>";
                    testXml += "<password>" + list[0].SmsSifre + "</password>";
                    testXml += "</authentication>";
                    testXml += "<order>";
                    testXml += "<sender>APITEST</sender>";
                    testXml += "<sendDateTime></sendDateTime>";
                    testXml += "<message>";
                    testXml += "<text>" + mesajim + "</text>";
                    testXml += "<receipents>";
                    testXml += "<number>" + txtTelNo.Text + "</number>";
                    testXml += "</receipents>";
                    testXml += "</message>";
                    testXml += "</order>";
                    testXml += "</request>";
                    this.XMLPOST("http://api.iletimerkezi.com/v1/send-sms", testXml);
                    MessageBox.Show("Mesaj Gönderme İşlemi Başarılı...", "",
                            MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FrmSms_Load(object sender, EventArgs e)
        {
            List<SystemDB> list = db.Info_System_Database();
            theme = new Theme(list[0].IndexTheme);
            theme.backArray(this);
            theme.panelArray(panel1);
            theme.buttonArray(btnIptal, btnSms);
            theme.rdBtnArray(rdBtnMesaj1, rdBtnMesaj2);
            theme.labelArray(label2, label1);
            theme.richArray(txtMesaj1, txtMesaj2);
            theme.textBoxArray(txtTelNo);
            txtTelNo.Text = "90" + telNo;
            rdBtnMesaj1.Checked = true;
            txtMesaj1.Text = list[0].Mesaj1;
            txtMesaj2.Text = list[0].Mesaj2;
        }
    }
}
