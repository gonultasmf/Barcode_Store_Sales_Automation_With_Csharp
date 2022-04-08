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
    public partial class FrmAlarmKur : Form
    {
        DataBase db = new DataBase();
        Theme theme;
        public int musteriKod;
        public FrmAlarmKur(int musteriKOD)
        {
            musteriKod = musteriKOD;
            InitializeComponent();
        }
        private void FrmAlarmKur_Load(object sender, EventArgs e)
        {
            List<SystemDB> list = db.Info_System_Database();
            theme = new Theme(list[0].IndexTheme);
            theme.backArray(this);
            theme.buttonArray(btnAlarmKur, btnIptal);
            theme.labelArray(label5, label4, label3, label2, label1,
                label6, label7, label8);
            theme.textBoxArray(txtBakiye, txtHesapTur, txtMusteriAd,
                txtMusteriGrup, txtTelNo, txtMusteriKod);
            theme.panelArray(panel1);
            theme.panelUstArray(panel2);
            theme.richArray(txtAciklama);
            theme.dateArray(dateSaat, dateTarih);
            List<CustomerDB> alarms = db.Info_Customer_Database(musteriKod);
            txtMusteriAd.Text = alarms[0].MusteriAdi;
            txtMusteriKod.Text = alarms[0].MusteriKod.ToString();
            txtMusteriGrup.Text = alarms[0].MusteriGrup;
            txtTelNo.Text = alarms[0].TelNo;
            txtHesapTur.Text = alarms[0].HesapTuru;
            txtBakiye.Text = alarms[0].Bakiye.ToString();
        }
        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAlarmKur_Click(object sender, EventArgs e)
        {
            DateTime time = Convert.ToDateTime(dateTarih.Text + " " + dateSaat.Text);
            db.Add_Alarm_Database(Convert.ToInt32(txtMusteriKod.Text),
                txtMusteriAd.Text, txtHesapTur.Text, txtMusteriGrup.Text,
                txtTelNo.Text, txtBakiye.Text, time, txtAciklama.Text);
            this.Close();
        }
    }
}
