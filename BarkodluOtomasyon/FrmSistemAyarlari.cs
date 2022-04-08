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
    public partial class FrmSistemAyarlari : Form
    {
        DataBase db = new DataBase();
        Theme theme;
        public FrmSistemAyarlari()
        {
            InitializeComponent();
        }
        private void FrmSistemAyarlari_Load(object sender, EventArgs e)
        {
            List<SystemDB> list = db.Info_System_Database();
            theme = new Theme(list[0].IndexTheme);
            theme.backArray(this);
            theme.buttonArray(btnIptal, btnKaydet);
            theme.comboArray(comboTema);
            theme.textBoxArray(txtFirmaAdi, txtFirmaTelNo);
            theme.labelArray(label2, label1, label3);
            comboTema.SelectedIndex = list[0].IndexTheme;
            txtFirmaAdi.Text = list[0].FirmaAdi;
            txtFirmaTelNo.Text = list[0].FirmaTelNo;
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            List<SystemDB> list = db.Info_System_Database();
            db.Update_System_Database(comboTema.SelectedIndex, list[0].Backup,
                    list[0].MailHost, list[0].MailPort, list[0].MailSSL, list[0].Mail,
                    list[0].MailPassword, list[0].AErtele, list[0].ZilSes, list[0].ZilSesim,
                    list[0].ZilSesTekrar, list[0].FisAciklama, list[0].Mesaj1, list[0].Mesaj2,
                    list[0].SMS, list[0].SmsKAdi, list[0].SmsSifre, list[0].Yazici,
                    list[0].Pos, list[0].Etiket, txtFirmaAdi.Text, list[0].BackupPath,
                    txtFirmaTelNo.Text, list[0].Adres, list[0].FisGenislik, list[0].FisYaziBoyut);
            this.Close();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void comboTema_SelectedIndexChanged(object sender, EventArgs e)
        {
            Theme newTheme = new Theme(comboTema.SelectedIndex);
            newTheme.backArray(this);
            newTheme.buttonArray(btnIptal, btnKaydet);
            newTheme.labelArray(label2, label1, label3);
            newTheme.comboArray(comboTema);
            newTheme.textBoxArray(txtFirmaAdi, txtFirmaTelNo);
            this.Refresh();
        }
    }
}
