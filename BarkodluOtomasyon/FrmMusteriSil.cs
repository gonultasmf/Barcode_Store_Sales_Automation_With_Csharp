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
    public partial class FrmMusteriSil : Form
    {
        DataBase db = new DataBase();
        Theme theme;
        public FrmMusteriSil()
        {
            InitializeComponent();
        }
        private void FrmMusteriSil_Load(object sender, EventArgs e)
        {
            List<SystemDB> list = db.Info_System_Database();
            theme = new Theme(list[0].IndexTheme);
            theme.backArray(this);
            theme.buttonArray(btnIptal, btnKaydıSil);
            theme.panelArray(panel2, panel1);
            theme.labelArray(label1, label2, label3, label4, label5);
        }
        private void btnKaydıSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Müşteriyi SİLMEK İstediğinizden Emin misiniz???", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.Delete_Customer_Database(FrmMusteriIslemleri.musteriKod);
                this.Close();
            }
        }
        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
