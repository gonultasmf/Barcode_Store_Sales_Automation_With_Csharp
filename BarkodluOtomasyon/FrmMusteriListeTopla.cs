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
    public partial class FrmMusteriListeTopla : Form
    {
        DataBase db = new DataBase();
        Theme theme;
        public FrmMusteriListeTopla()
        {
            InitializeComponent();
        }

        private void FrmMusteriListeTopla_Load(object sender, EventArgs e)
        {
            List<SystemDB> list = db.Info_System_Database();
            theme = new Theme(list[0].IndexTheme);
            theme.backArray(this);
            theme.buttonArray(btnKapat);
            theme.textBoxArray(txtTBakiye, txtTMusteriSayisi);
            theme.labelArray(label2, label1);
            double bakiye = 0;
            int sayi = 0;
            List<CustomerDB> customers = db.Info_Customers_Database();
            if (customers.Count.Equals(0))
            {
                txtTBakiye.Text = "0,00";
                txtTMusteriSayisi.Text = "0";
            }
            else
            {

                foreach (var item in customers)
                {
                    bakiye += Convert.ToDouble(item.Bakiye);
                    sayi++;
                }
                txtTBakiye.Text = bakiye.ToString();
                txtTMusteriSayisi.Text = sayi.ToString();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
