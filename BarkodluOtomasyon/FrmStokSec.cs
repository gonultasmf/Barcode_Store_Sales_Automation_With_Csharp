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
    public partial class FrmStokSec : Form
    {
        Function function = new Function();
        DataBase db = new DataBase();
        Theme theme;
        public string urunAdi;
        public static string barkod; 
        public FrmStokSec()
        {
            InitializeComponent();
        }

        private void txtBarkod_Enter(object sender, EventArgs e)
        {
            txtBarkod.Text = "";
            txtBarkod.Font = new Font("Tahoma", 9.75F,
                FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
        }

        private void txtBarkod_TextChanged(object sender, EventArgs e)
        {
            function.Search_Stok(comboArama.SelectedIndex, listeUrun, txtBarkod.Text);
        }
        private void FrmStokSec_Load(object sender, EventArgs e)
        {
            List<SystemDB> list = db.Info_System_Database();
            theme = new Theme(list[0].IndexTheme);
            theme.backArray(this);
            theme.buttonArray(btnSec);
            theme.labelArray(label1);
            theme.textBoxArray(txtBarkod);
            theme.tableArray(listeUrun);
            theme.panelArray(panel1, panel2);
            theme.comboArray(comboArama);
            function.ListDoldurStok(listeUrun);
        }
        private void btnSec_Click(object sender, EventArgs e)
        {
            if (listeUrun.RowCount > 0)
            {
                barkod = listeUrun.CurrentRow.Cells[0].Value.ToString();
                urunAdi = listeUrun.CurrentRow.Cells[1].Value.ToString();
                this.Close();
            }
            else
                MessageBox.Show("Ürün Seçilemedi!!!", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
