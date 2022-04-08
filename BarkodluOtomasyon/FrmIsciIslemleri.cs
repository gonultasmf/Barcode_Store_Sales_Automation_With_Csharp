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
    public partial class FrmIsciIslemleri : Form
    {
        DataBase db = new DataBase();
        Function function = new Function();
        Theme theme;
        public static int id;
        public static string ad;
        public FrmIsciIslemleri()
        {
            InitializeComponent();
        }

        private void FrmIsciIslemleri_Load(object sender, EventArgs e)
        {
            List<SystemDB> list = db.Info_System_Database();
            theme = new Theme(list[0].IndexTheme);
            theme.backArray(this);
            theme.buttonArray(btnEkle, btnKapat, btnIstenCikart);
            theme.tableArray(listeIsciler);
            theme.textBoxArray(txtIsci);
           // function.ListDoldurIsci(listeIsciler);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {/*
            if (txtIsci.TextLength.Equals(0))
                MessageBox.Show("İşçi Adı Boş Bırakılamaz!!!", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                List<IsciDB> list = db.Info_Isci_Database();
                bool control = false;
                foreach (var item in list)
                {
                    if (item.IsciAd.Equals(txtIsci.Text))
                    {
                        MessageBox.Show("Girilen İşçi Adı Zaten Bulunmaktadır!!!", "",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        control = true;
                        break;
                    }
                }
                if (!control)
                {
                    db.Add_Isci_Database(txtIsci.Text);
                    function.ListDoldurIsci(listeIsciler);
                    txtIsci.ResetText();
                }
            }*/
        }

        private void btnIstenCikart_Click(object sender, EventArgs e)
        {/*
            if (listeIsciler.Rows.Count.Equals(0))
                MessageBox.Show("İşçi Bulunmamaktadır!!!", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (MessageBox.Show("Seçili İşçiyi Silerseniz Onunla" +
                        " İlgili Bilgiler Tamamane SİLİNECEKTİR!!!\n" +
                        "***Tavsiye Edilen İşten Çıkarmanızdır.***\n" +
                        "Yine de SİLMEK İstiyor musunuz???", "",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                        == DialogResult.Yes)
                {
                    id = Convert.ToInt32(listeIsciler.CurrentRow.Cells[0].Value);
                    ad = listeIsciler.CurrentRow.Cells[1].Value.ToString();
                    db.Delete_Isci_Cikar_Database(ad, id);
                    function.ListDoldurIsci(listeIsciler);
                }
            }*/
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {/*
            if (listeIsciler.Rows.Count.Equals(0))
                MessageBox.Show("İşçi Bulunmamaktadır!!!", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                id = Convert.ToInt32(listeIsciler.CurrentRow.Cells[0].Value);
                ad = listeIsciler.CurrentRow.Cells[1].Value.ToString();
                FrmIsciSil ısciSil = new FrmIsciSil();
                ısciSil.ShowDialog();
                function.ListDoldurIsci(listeIsciler);
            }*/
        }
    }
}
