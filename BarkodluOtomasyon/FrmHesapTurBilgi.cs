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
    public partial class FrmHesapTurBilgi : Form
    {
        DataBase db = new DataBase();
        Theme theme;
        public FrmHesapTurBilgi()
        {
            InitializeComponent();
        }
        private void FrmHesapTurBilgi_Load(object sender, EventArgs e)
        {
            List<SystemDB> list = db.Info_System_Database();
            theme = new Theme(list[0].IndexTheme);
            theme.backArray(this);
            theme.panelArray(panel1);
            theme.buttonArray(btnKapat);
            theme.labelArray(label9, label8, label7, label6,
                label5, label4, label3, label2, label10, label1);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
