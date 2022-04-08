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
    public partial class FrmFeedback : Form
    {
        DataBase db = new DataBase();
        Theme theme;
        public FrmFeedback()
        {
            InitializeComponent();
        }
        private void FrmFeedback_Load(object sender, EventArgs e)
        {
            List<SystemDB> list = db.Info_System_Database();
            theme = new Theme(list[0].IndexTheme);
            theme.backArray(this);
            theme.labelArray(label1, label2, label3);
            theme.richArray(txtMesaj);
            theme.textBoxArray(txtKonu, textBox1);
            theme.buttonArray(btnIptal, btnMail);
        }
        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnMail_Click(object sender, EventArgs e)
        {

        }
    }
}
