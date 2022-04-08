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
    public partial class FrmPersonelRapor : Form
    {
        Function function = new Function();
        DataBase db = new DataBase();
        Theme theme;
        public FrmPersonelRapor()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPersonelRapor_Load(object sender, EventArgs e)
        {
            List<SystemDB> list = db.Info_System_Database();
            theme = new Theme(list[0].IndexTheme);
            theme.backArray(this);
            theme.buttonArray(btnKapat, btnListele);
            theme.labelArray(label1, label2, label3, label4, label5, label6, label7);
            theme.tableArray(listeSatisPersonel);
            theme.textBoxArray(txtTSatisTutari, txtTSatisMiktar, txtTKarTutar, txtTAlisTutar);
            theme.dateArray(dateBaslangic, dateSon);
            theme.comboArray(comboPersonel);
            comboPersonel.Items.Clear();
            List<UserDB> users = db.Info_Users_Database();
            foreach (var item in users)
            {
                comboPersonel.Items.Add(item.Name);
            }
            comboPersonel.SelectedIndex = 0;
            aciklama.SetToolTip(btnListele, "Arama Ölçütlerine Göre Listeleme...");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DateTime tarihB = new DateTime(dateBaslangic.Value.Year, dateBaslangic.Value.Month, dateBaslangic.Value.Day, 0, 0, 0);
            DateTime tarihS = new DateTime(dateSon.Value.Year, dateSon.Value.Month, dateSon.Value.Day, 0, 0, 0);
            function.ListDoldurSellReportPersonel(listeSatisPersonel,
                comboPersonel.Text,tarihB,tarihS, txtTSatisMiktar,txtTSatisTutari,txtTAlisTutar,txtTKarTutar);
        }
    }
}
