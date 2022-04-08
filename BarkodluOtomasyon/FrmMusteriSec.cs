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
    public partial class FrmMusteriSec : Form
    {
        DataBase db = new DataBase();
        Function function = new Function();
        Theme theme;
        public static bool control = false;
        public static int musteriKod;
        public FrmMusteriSec()
        {
            InitializeComponent();
        }

        private void FrmMusteriSec_Load(object sender, EventArgs e)
        {
            List<SystemDB> list = db.Info_System_Database();
            theme = new Theme(list[0].IndexTheme);
            theme.backArray(this);
            theme.buttonArray(btnIptal,btnSec,
                btnYeniMusteriEkle);
            theme.labelArray(label2, label1);
            theme.comboArray(comboArama);
            theme.textBoxArray(txtArama);
            theme.panelArray(panel1);
            theme.tableArray(listeMusteri);
            comboArama.SelectedIndex = 0;
            function.ListDoldurCustomer(listeMusteri);
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            control = false;
            this.Close();
        }
        private void btnYeniMusteriEkle_Click(object sender, EventArgs e)
        {
            FrmMusteriEkle musteriEkle = new FrmMusteriEkle();
            musteriEkle.ShowDialog();
            function.ListDoldurCustomer(listeMusteri);
        }
        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            function.Search_Customer(comboArama.SelectedIndex, listeMusteri, txtArama.Text);
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            if (listeMusteri.Rows.Count.Equals(0))
            {
                MessageBox.Show("Müşteri Hesabı Bulunmamaktadır!!!", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                FrmAnaSayfaMudur.musteriKod = Convert.ToInt32(listeMusteri.CurrentRow.Cells[2].Value);
                control = true;
                this.Close();
            }
        }
    }
}
