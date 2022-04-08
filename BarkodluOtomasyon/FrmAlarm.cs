using BarkodluOtomasyon.Class;
using BarkodluOtomasyon.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarkodluOtomasyon
{
    public partial class FrmAlarm : Form
    {
        DataBase db = new DataBase();
        SoundPlayer sound = new SoundPlayer();
        Theme theme;
        public int musteriKod;
        public FrmAlarm(int musteriKOD)
        {
            musteriKod = musteriKOD;
            InitializeComponent();
        }
        private void FrmAlarm_Load(object sender, EventArgs e)
        {
            List<SystemDB> list = db.Info_System_Database();
            theme = new Theme(list[0].IndexTheme);
            theme.backArray(this);
            theme.buttonArray(btnAlarmKapat, btnErtele);
            theme.labelArray(label5, label4, label3, label2, label1, 
                label6);
            theme.textBoxArray(txtBakiye, txtHesapTur, txtMusteriAd,
                txtMusteriGrup, txtTelNo, txtMusteriKod);
            theme.panelArray(panel1);
            theme.panelUstArray(panel2);
            theme.richArray(txtAciklama);
            List<AlarmDB> alarms = db.Info_Alarm_Database(musteriKod);
            txtMusteriAd.Text = alarms[0].MusteriAd;
            txtMusteriKod.Text = alarms[0].MusteriKod.ToString();
            txtMusteriGrup.Text = alarms[0].MusteriGrup;
            txtTelNo.Text = alarms[0].TelefonNo;
            txtHesapTur.Text = alarms[0].HesapTur;
            txtBakiye.Text = alarms[0].Bakiye;
            txtAciklama.Text = alarms[0].Aciklama;
            if (list[0].ZilSes)
            {
                if (list[0].ZilSesim == 0)
                {
                    System.IO.Stream str = Properties.Resources.Agile;
                    sound = new System.Media.SoundPlayer(str);
                    sound.Play();
                }
                else if (list[0].ZilSesim == 1)
                {
                    System.IO.Stream str = Properties.Resources.bip;
                    sound = new System.Media.SoundPlayer(str);
                    sound.Play();
                }
                else if (list[0].ZilSesim == 2)
                {
                    System.IO.Stream str = Properties.Resources.Carnation;
                    sound = new System.Media.SoundPlayer(str);
                    sound.Play();
                }
                else if (list[0].ZilSesim == 3)
                {
                    System.IO.Stream str = Properties.Resources.Peach;
                    sound = new System.Media.SoundPlayer(str);
                    sound.Play();
                }
                else if (list[0].ZilSesim == 4)
                {
                    System.IO.Stream str = Properties.Resources.Triumph;
                    sound = new System.Media.SoundPlayer(str);
                    sound.Play();
                }
                else if (list[0].ZilSesim == 5)
                {
                    System.IO.Stream str = Properties.Resources.Vermillion;
                    sound = new System.Media.SoundPlayer(str);
                    sound.Play();
                }
                else if (list[0].ZilSesim == 6)
                {
                    System.IO.Stream str = Properties.Resources.Watsonia;
                    sound = new System.Media.SoundPlayer(str);
                    sound.Play();
                }
                if (list[0].ZilSesTekrar == 1)
                {
                    sound.PlayLooping();
                }
            }
        }
        private void btnAlarmKapat_Click(object sender, EventArgs e)
        {
            db.Delete_Alarm_Database(musteriKod);
            this.Close();
        }
        private void btnErtele_Click(object sender, EventArgs e)
        {
            List<AlarmDB> alarms = db.Info_Alarm_Database(musteriKod);
            db.Update_Alarm_Database(alarms[0].Id, alarms[0].MusteriKod,
                alarms[0].MusteriAd, alarms[0].HesapTur, alarms[0].MusteriGrup,
                alarms[0].TelefonNo, alarms[0].Bakiye, alarms[0].AlarmTarihi.AddHours(1),
                alarms[0].Aciklama);
            this.Close();
        }
    }
}
