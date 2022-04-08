using BarkodluOtomasyon.Class;
using BarkodluOtomasyon.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarkodluOtomasyon
{
    public partial class FrmAktivasyon : Form
    {
        DataBase db = new DataBase();
        Theme theme;
        public static string serialKey;
        public FrmAktivasyon()
        {
            InitializeComponent();
        }

        private void FrmAktivasyon_Load(object sender, EventArgs e)
        {
            /////////////// CPU ID //////////////
            var cpuId = string.Empty;
            string sQuery = "SELECT ProcessorId FROM Win32_Processor";
            ManagementObjectSearcher oManagementObjectSearcher = new ManagementObjectSearcher(sQuery);
            ManagementObjectCollection oCollection = oManagementObjectSearcher.Get();
            foreach (ManagementObject oManagementObject in oCollection)
            {
                cpuId = (string)oManagementObject["ProcessorId"];
                break;
            }
            /////////////// Disk Serial //////////////
            var diskSerial = string.Empty;
            ManagementObject dsk = new ManagementObject(@"win32_logicaldisk.deviceid=""c:""");
            dsk.Get();
            diskSerial = dsk["VolumeSerialNumber"].ToString();
            /////////////// Anakart Serial //////////////
            var motherboardserial = string.Empty;
            ManagementObjectSearcher mos = new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard");
            ManagementObjectCollection moc = mos.Get();
            foreach (ManagementObject mo in moc)
            {
                motherboardserial = (string)mo["SerialNumber"];
                break;
            }
            /////////////// Anakart Serial //////////////
            var biosNo = string.Empty;
            ManagementObjectSearcher bios = new ManagementObjectSearcher("SELECT * FROM WIN32_BIOS");
            ManagementObjectCollection biosC = mos.Get();
            foreach (ManagementObject bioss in moc)
            {
                biosNo = (string)bioss["SerialNumber"];
                break;
            }
            string anahtar = cpuId.Trim() + " " + diskSerial.Trim() + " " +
                motherboardserial.Trim() + " " + biosNo.Trim();
            ///////////////////////// Sifrele ///////////////////////
            ///
            txtUrunKodu.Text = Md5Sifrele(anahtar);
        }
        private string Md5Sifrele(string anahtar)
        {
            string result = string.Empty;
            try
            {
                MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
                byte[] bytes = Encoding.ASCII.GetBytes(anahtar);
                byte[] array = mD5CryptoServiceProvider.ComputeHash(bytes);
                int capacity = (int)Math.Round((double)(array.Length * 3) + (double)array.Length / 8);
                StringBuilder stringBuilder = new StringBuilder(capacity);
                int num = array.Length - 1;
                for (int i = 0; i <= num; i++)
                {
                    stringBuilder.Append(BitConverter.ToString(array, i, 1));
                }
                result = stringBuilder.ToString().TrimEnd(new char[] { ' ' });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.ToUpper();
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox2.Text = textBox2.Text.ToUpper();
            textBox2.SelectionStart = textBox1.Text.Length;
            textBox3.Text = textBox3.Text.ToUpper();
            textBox3.SelectionStart = textBox1.Text.Length;
            textBox4.Text = textBox4.Text.ToUpper();
            textBox4.SelectionStart = textBox1.Text.Length;
            textBox5.Text = textBox5.Text.ToUpper();
            textBox5.SelectionStart = textBox1.Text.Length;
            if (textBox1.Text.Length == 5)
                textBox2.Focus();
            if (textBox2.Text.Length == 5)
                textBox3.Focus();
            if (textBox3.Text.Length == 5)
                textBox4.Focus();
            if (textBox4.Text.Length == 5)
                textBox5.Focus();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                 !char.IsControl(e.KeyChar);
        }

        private void txtUrunKodu_Click(object sender, EventArgs e)
        {
            txtUrunKodu.SelectAll();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAktifEt_Click(object sender, EventArgs e)
        {
            serialKey = textBox1.Text + "-" + textBox2.Text + "-" +
                textBox3.Text + "-" + textBox4.Text + "-" + textBox5.Text;
            MessageBox.Show(txtUrunKodu.Text + "\nSerial Key : \n" + serialKey,
                "SERIAL KEY", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.drahnasoft.com");
        }
    }
}
