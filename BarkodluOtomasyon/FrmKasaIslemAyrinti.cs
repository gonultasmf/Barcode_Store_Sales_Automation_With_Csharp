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
    public partial class FrmKasaIslemAyrinti : Form
    {
        Function function = new Function();
        private string FisIslemNo;
        DataBase db = new DataBase();
        Theme theme;
        public FrmKasaIslemAyrinti(string islemNo)
        {
            FisIslemNo = islemNo;
            InitializeComponent();
        }
        private void FrmKasaIslemAyrinti_Load(object sender, EventArgs e)
        {
            List<SystemDB> list = db.Info_System_Database();
            theme = new Theme(list[0].IndexTheme);
            theme.backArray(this);
            theme.buttonArray(btnKapat);
            theme.tableArray(listeKasaIslemAyrinti);
            function.ListDoldurSell(listeKasaIslemAyrinti,FisIslemNo);
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
