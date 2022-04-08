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
    public partial class FrmTedarikciIslemleri : Form
    {
        DataBase db = new DataBase();
        Function function = new Function();
        Theme theme;
        public FrmTedarikciIslemleri()
        {
            InitializeComponent();
        }
        private void FrmTedarikciIslemleri_Load(object sender, EventArgs e)
        {
            List<SystemDB> list = db.Info_System_Database();
            theme = new Theme(list[0].IndexTheme);
            theme.backArray(this);
            theme.buttonArray(btnEkle, btnKapat, btnSil);
            theme.tableArray(listeTedarikci);
            theme.textBoxArray(txtTedarikci);
            function.ListDoldurTedarikci(listeTedarikci);
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtTedarikci.TextLength.Equals(0))
                MessageBox.Show("Tedarikçi Adı Boş Bırakılamaz!!!", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                List<TedarikciDB> list = db.Info_Tedarikci_Database();
                bool control = false;
                foreach (var item in list)
                {
                    if (item.Tedarikci.Equals(txtTedarikci.Text))
                    {
                        MessageBox.Show("Girilen Tedarikçi Zaten Bulunmaktadır!!!", "",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        control = true;
                        break;
                    }
                }
                if (!control)
                {
                    db.Add_Tedarikci_Database(txtTedarikci.Text);
                    function.ListDoldurTedarikci(listeTedarikci);
                    txtTedarikci.ResetText();
                }
                    
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (listeTedarikci.Rows.Count.Equals(0))
                MessageBox.Show("Tedarikçi Bulunmamaktadır!!!", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (MessageBox.Show("Seçili Tedarikçiyi Silmek İstediğinizden Emin misiniz???", "",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    db.Delete_Tedarikci_Database(listeTedarikci.CurrentRow.Cells[1].Value.ToString());
                    function.ListDoldurTedarikci(listeTedarikci);
                }
            }
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
