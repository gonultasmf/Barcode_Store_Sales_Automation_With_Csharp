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
    public partial class FrmUrunIadeIslem : Form
    {
        DataBase db = new DataBase();
        Function function = new Function();
        Theme theme;
        public FrmUrunIadeIslem()
        {
            InitializeComponent();
        }
        private void FrmUrunIadeIslem_Load(object sender, EventArgs e)
        {
            List<SystemDB> list = db.Info_System_Database();
            theme = new Theme(list[0].IndexTheme);
            theme.backArray(this);
            theme.buttonArray(btnKapat);
            theme.labelArray(label1, label2);
            theme.textBoxArray(txtTIEUSayisi, txtTIEUFiyat);
            theme.tableArray(listeIadeUrunler);
            function.ListDoldurIade(listeIadeUrunler, txtTIEUFiyat, txtTIEUSayisi);
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
