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
    public partial class FrmNot : Form
    {
        DataBase db = new DataBase();
        Theme theme;
        public FrmNot()
        {
            InitializeComponent();
        }
        private void FrmNot_Load(object sender, EventArgs e)
        {
            List<SystemDB> list = db.Info_System_Database();
            theme = new Theme(list[0].IndexTheme);
            theme.backArray(this);
            theme.buttonArray(btnKaydet, btnTemizle, btnKapat);
            List<CustomerDB> customers = db.Info_Customer_Database(FrmMusteriIslemleri.musteriKod);
            txtNot.Text = customers[0].Not;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            List<CustomerDB> customers = db.Info_Customer_Database(FrmMusteriIslemleri.musteriKod);
            db.Update_Customer_Database(customers[0].Id, customers[0].MusteriKod,
                customers[0].HesapTuru, customers[0].MusteriGrup, customers[0].MusteriAdi,
                customers[0].İlgili, customers[0].TelNo, customers[0].FaxNo,
                customers[0].GsmNo, customers[0].Adres, customers[0].VergiDairesi,
                customers[0].VergiNo, customers[0].Eposta, customers[0].ParaTuru,
                customers[0].ImagePath, customers[0].Bakiye, txtNot.Text,
                customers[0].HesapAyrinti, customers[0].KayitTarih);
            this.Close();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtNot.Text = "";
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
