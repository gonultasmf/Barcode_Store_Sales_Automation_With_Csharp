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
    public partial class FrmBirimIslemleri : Form
    {
        DataBase db = new DataBase();
        Function function = new Function();
        Theme theme;
        public FrmBirimIslemleri()
        {
            InitializeComponent();
        }
        private void FrmBirimIslemleri_Load(object sender, EventArgs e)
        {
            List<SystemDB> list = db.Info_System_Database();
            theme = new Theme(list[0].IndexTheme);
            theme.backArray(this);
            theme.buttonArray(btnEkle, btnKapat, btnSil);
            theme.tableArray(listeBirim);
            theme.textBoxArray(txtBirim);
            function.ListDoldurBirim(listeBirim);
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtBirim.TextLength.Equals(0))
                MessageBox.Show("Birim Adı Boş Bırakılamaz!!!", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                List<BirimDB> list = db.Info_Birim_Database();
                bool control = false;
                foreach (var item in list)
                {
                    if (item.Birim.Equals(txtBirim.Text))
                    {
                        MessageBox.Show("Girilen Birim Zaten Bulunmaktadır!!!", "",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        control = true;
                        break;
                    }
                }
                if (!control)
                {
                    db.Add_Birim_Database(txtBirim.Text);
                    function.ListDoldurBirim(listeBirim);
                    txtBirim.ResetText();
                }
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (listeBirim.Rows.Count.Equals(0))
                MessageBox.Show("Birim Bulunmamaktadır!!!", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if(MessageBox.Show("Seçili Birimi Silmek İstediğinizden Emin misiniz???","",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    db.Delete_Birim_Database(listeBirim.CurrentRow.Cells[1].Value.ToString());
                    function.ListDoldurBirim(listeBirim);
                }
            }
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
