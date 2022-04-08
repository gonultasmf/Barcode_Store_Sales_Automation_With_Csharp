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
    public partial class FrmIndirimliSatis : Form
    {
        DataBase db = new DataBase();
        Theme theme;
        public static double indirim, genelFiyat, fiyat;
        public static bool sattiMi = false;
        public static string satisTürü;
        public FrmIndirimliSatis()
        {
            InitializeComponent();
        }
        private void FrmIndirimliSatis_Load(object sender, EventArgs e)
        {
            List<SystemDB> list = db.Info_System_Database();
            theme = new Theme(list[0].IndexTheme);
            theme.backArray(this);
            theme.buttonArray(btnIptal, btnTamam);
            theme.comboArray(comboOdemeSekli);
            theme.textBoxArray(txtGenelFiyat, txtIskontu, txtToplamFiyat);
            theme.labelArray(label1, label2, label3, label4);
            comboOdemeSekli.SelectedIndex = 0;
            satisTürü = comboOdemeSekli.Text;
            txtToplamFiyat.Text = fiyat.ToString();
        }
        private void btnIptal_Click(object sender, EventArgs e)
        {
            sattiMi = false;
            this.Close();
        }

        private void txtIskontu_TextChanged(object sender, EventArgs e)
        {
            if (txtIskontu.TextLength.Equals(0))
                txtIskontu.Text = "0";
            else if(Convert.ToDouble(txtIskontu.Text)>=100)
                txtIskontu.Text = "99.99";
            txtGenelFiyat.Text = (Convert.ToDouble(txtToplamFiyat.Text) -
                (Convert.ToDouble(txtIskontu.Text)* Convert.ToDouble(txtToplamFiyat.Text)) /
                100).ToString();
        }

        private void txtIskontu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar) &&
                e.KeyChar != ',' && e.KeyChar != '.';
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            if (txtIskontu.TextLength.Equals(0))
            {
                txtIskontu.Text = "0";
            }
            try
            {
                satisTürü = comboOdemeSekli.Text;
                indirim = Convert.ToDouble(txtGenelFiyat.Text);
                genelFiyat = Convert.ToDouble(txtGenelFiyat.Text);
                sattiMi = true;
                this.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
