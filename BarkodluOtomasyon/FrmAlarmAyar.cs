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
    public partial class FrmAlarmAyar : Form
    {
        DataBase db = new DataBase();
        Function function = new Function();
        Theme theme;
        public FrmAlarmAyar()
        {
            InitializeComponent();
        }

        private void FrmAlarmAyar_Load(object sender, EventArgs e)
        {
            List<SystemDB> list = db.Info_System_Database();
            theme = new Theme(list[0].IndexTheme);
            theme.backArray(this);
            theme.panelArray(panel1, panel3);
            theme.panelUstArray(panel4, panel2);
            theme.tableArray(listAlarm);
            theme.comboArray(comboErtele, comboTekrar, comboZilSesi);
            theme.chckArray(chckCalsin);
            theme.labelArray(label4, label3, label2, label1);
            theme.buttonArray(btnKaydet, btnIptal);
            function.ListDoldurAlarm(listAlarm);
            List<SystemDB> systems = db.Info_System_Database();
            comboErtele.SelectedIndex = systems[0].AErtele;
            comboTekrar.SelectedIndex = systems[0].ZilSesTekrar;
            comboZilSesi.SelectedIndex = systems[0].ZilSesim;
            chckCalsin.Checked = systems[0].ZilSes;
            panel4.Enabled = systems[0].ZilSes;
        }
        private void chckCalsin_CheckedChanged(object sender, EventArgs e)
        {
            panel4.Enabled = chckCalsin.Checked;
        }
        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            List<SystemDB> systems = db.Info_System_Database();
            db.Update_System_Database(systems[0].IndexTheme, systems[0].Backup,
                systems[0].MailHost, systems[0].MailPort, systems[0].MailSSL,
                systems[0].Mail, systems[0].MailPassword, systems[0].AErtele,
                systems[0].ZilSes, systems[0].ZilSesim, systems[0].ZilSesTekrar,
                systems[0].FisAciklama, systems[0].Mesaj1, systems[0].Mesaj2,
                systems[0].SMS, systems[0].SmsKAdi, systems[0].SmsSifre,
                systems[0].Yazici, systems[0].Pos, systems[0].Etiket,
                systems[0].FirmaAdi, systems[0].BackupPath,systems[0].FirmaTelNo,
                systems[0].Adres, systems[0].FisGenislik, systems[0].FisYaziBoyut);
            this.Close();
        }
    }
}
