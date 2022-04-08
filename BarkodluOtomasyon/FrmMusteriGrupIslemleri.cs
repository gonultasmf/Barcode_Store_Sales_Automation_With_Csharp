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
    public partial class FrmMusteriGrupIslemleri : Form
    {
        DataBase db = new DataBase();
        Function function = new Function();
        Theme theme;
        public FrmMusteriGrupIslemleri()
        {
            InitializeComponent();
        }
        private void FrmMusteriGrupIslemleri_Load(object sender, EventArgs e)
        {
            List<SystemDB> list = db.Info_System_Database();
            theme = new Theme(list[0].IndexTheme);
            theme.backArray(this);
            theme.buttonArray(btnEkle, btnKapat, btnSil);
            theme.tableArray(listeMusteriGrup);
            theme.textBoxArray(txtMusteriGrup);
            function. ListDoldurMusteriGrup(listeMusteriGrup);
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtMusteriGrup.TextLength.Equals(0))
                MessageBox.Show("Müşteri Grubu Adı Boş Bırakılamaz!!!", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                List<KategoriDB> list = db.Info_Kategori_Database();
                bool control = false;
                foreach (var item in list)
                {
                    if (item.Kategori.Equals(txtMusteriGrup.Text))
                    {
                        MessageBox.Show("Girilen Müşteri Grubu Zaten Bulunmaktadır!!!", "",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        control = true;
                        break;
                    }
                }
                if (!control)
                {
                    db.Add_MusteriGrup_Database(txtMusteriGrup.Text);
                    function. ListDoldurMusteriGrup(listeMusteriGrup);
                    txtMusteriGrup.ResetText();
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (listeMusteriGrup.Rows.Count.Equals(0))
                MessageBox.Show("Müşteri Grubu Bulunmamaktadır!!!", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (MessageBox.Show("Seçili Müşteri Grubunu Silmek İstediğinizden Emin misiniz???", "",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    db.Delete_MusteriGrup_Database(listeMusteriGrup.CurrentRow.Cells[1].Value.ToString());
                    function.ListDoldurMusteriGrup(listeMusteriGrup);
                }
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
