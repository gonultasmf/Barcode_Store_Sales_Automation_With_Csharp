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
    public partial class FrmIsciSil : Form
    {
        DataBase db = new DataBase();
        Function function = new Function();
        Theme theme;
        public FrmIsciSil()
        {
            InitializeComponent();
        }

        private void FrmIsciSil_Load(object sender, EventArgs e)
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
            if (MessageBox.Show("Seçili İşçiyi Silerseniz Onunla" +
                    " İlgili Bilgiler Tamamane SİLİNECEKTİR!!!\n+" +
                    "***Tavsiye Edilen İşten Çıkarmanızdır.***\n" +
                    "Yine de SİLMEK İstiyor musunuz???", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                function.IsciSilmeBilgiSil(FrmIsciIslemleri.ad);
                //db.Delete_Isci_Database(FrmIsciIslemleri.id);
                this.Close();
            }
        }
        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
