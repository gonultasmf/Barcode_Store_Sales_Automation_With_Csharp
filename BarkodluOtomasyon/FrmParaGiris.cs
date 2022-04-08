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
    public partial class FrmParaGiris : Form
    {
        DataBase db = new DataBase();
        Function function = new Function();
        Theme theme;
        static double fiyat = 0.00;
        public FrmParaGiris()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FrmParaGiris_Load(object sender, EventArgs e)
        {
            List<SystemDB> list = db.Info_System_Database();
            theme = new Theme(list[0].IndexTheme);
            theme.backArray(this);
            theme.buttonArray(btnIptal, btnEkle, btnIslemNoVer);
            theme.comboArray(comboAciklama);
            theme.labelArray(label1, label2, label3, label4);
            theme.textBoxArray(txtIslemNo, txtGirenMiktar);
            theme.panelArray(panel2);
        }
        private void btnIslemNoVer_Click(object sender, EventArgs e)
        {
           
            txtIslemNo.Text = function.FisIslemNo_Uret();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtIslemNo.TextLength.Equals(0) || txtGirenMiktar.TextLength.Equals(0))
                MessageBox.Show("İşlem/Fiş No veya Giren Miktar Boş Bırakılamaz!!!", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                db.Add_Safe_Database(FrmKasaIslemleri.kasa, DateTime.Now,
                    "Giren", txtIslemNo.Text, comboAciklama.Text, "",
                    Convert.ToDouble(txtGirenMiktar.Text), 0, null,"Müdür");
                this.Close();
            }
        }
        private void txtGirenMiktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) &&
                e.KeyChar != ',' && e.KeyChar != '.';
        }
        private void txtGirenMiktar_Leave(object sender, EventArgs e)
        {
            fiyat = Convert.ToDouble(txtGirenMiktar.Text);
            fiyat = Convert.ToDouble(fiyat.ToString("0.00"));
        }
    }
}
