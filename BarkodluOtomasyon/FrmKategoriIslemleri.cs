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
    public partial class FrmKategoriIslemleri : Form
    {
        DataBase db = new DataBase();
        Function function = new Function();
        Theme theme;
        public FrmKategoriIslemleri()
        {
            InitializeComponent();
        }

        private void FrmKategoriIslemleri_Load(object sender, EventArgs e)
        {
            List<SystemDB> list = db.Info_System_Database();
            theme = new Theme(list[0].IndexTheme);
            theme.backArray(this);
            theme.buttonArray(btnEkle, btnKapat, btnSil);
            theme.tableArray(listeKategori);
            theme.textBoxArray(txtKategori);
            function.ListDoldurKategori(listeKategori);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtKategori.TextLength.Equals(0))
                MessageBox.Show("Kategori Adı Boş Bırakılamaz!!!", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                List<KategoriDB> list = db.Info_Kategori_Database();
                bool control = false;
                foreach (var item in list)
                {
                    if (item.Kategori.Equals(txtKategori.Text))
                    {
                        MessageBox.Show("Girilen Kategori Zaten Bulunmaktadır!!!", "",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        control = true;
                        break;
                    }
                }
                if (!control)
                {
                    db.Add_Kategori_Database(txtKategori.Text);
                    function.ListDoldurKategori(listeKategori);
                    txtKategori.ResetText();
                } 
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (listeKategori.Rows.Count.Equals(0))
                MessageBox.Show("Kategori Bulunmamaktadır!!!", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (MessageBox.Show("Seçili Kategoriyi Silmek İstediğinizden Emin misiniz???", "",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    db.Delete_Kategori_Database(listeKategori.CurrentRow.Cells[1].Value.ToString());
                    function.ListDoldurKategori(listeKategori);
                }
            } 
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
