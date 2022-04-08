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
    public partial class FrmNakitPosSatis : Form
    {
        DataBase db = new DataBase();
        Theme theme;
        public static double nakitFiyat, posFİyat, fiyat;
        public static bool sattiMi = false;
        public FrmNakitPosSatis()
        {
            InitializeComponent();
        }

        private void FrmNakitPosSatis_Load(object sender, EventArgs e)
        {
            List<SystemDB> list = db.Info_System_Database();
            theme = new Theme(list[0].IndexTheme);
            theme.backArray(this);
            theme.buttonArray(btnIptal, btnTamam);
            theme.textBoxArray(txtPOSFiyat, txtNakitFiyat, txtToplamFiyat);
            theme.labelArray(label1, label2, label3);
            txtToplamFiyat.Text = fiyat.ToString();
        }
        private void txtNakitFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar) &&
                e.KeyChar != ',' && e.KeyChar != '.';
        }
        private void txtNakitFiyat_TextChanged(object sender, EventArgs e)
        {
            if (txtNakitFiyat.TextLength.Equals(0))
                txtNakitFiyat.Text = "0";
            txtPOSFiyat.Text = (Convert.ToDouble(txtToplamFiyat.Text) - 
                Convert.ToDouble(txtNakitFiyat.Text)).ToString();
        }
        private void btnIptal_Click(object sender, EventArgs e)
        {
            sattiMi = false;
            this.Close();
        }
        private void btnTamam_Click(object sender, EventArgs e)
        {
            if (txtNakitFiyat.TextLength.Equals(0))
            {
                txtNakitFiyat.Text = "0";
                nakitFiyat = Convert.ToDouble(txtNakitFiyat.Text);
                posFİyat = Convert.ToDouble(txtPOSFiyat.Text);
            }
            else
            {
                nakitFiyat = Convert.ToDouble(txtNakitFiyat.Text);
                posFİyat = Convert.ToDouble(txtPOSFiyat.Text);
            }
            sattiMi = true;
            this.Close();
        }
    }
}
