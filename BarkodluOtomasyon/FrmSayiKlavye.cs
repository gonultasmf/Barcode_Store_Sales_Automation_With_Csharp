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
    public partial class FrmSayiKlavye : Form
    {
        public string txtBoxText;
        private int Mouse_X;
        private int Mouse_Y;
        private bool move = false;
        public FrmSayiKlavye()
        {
            InitializeComponent();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar) &&
                e.KeyChar != ',';
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            txtBox.Text += 1;
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            txtBox.Text += 2;
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            txtBox.Text += 3;
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            txtBox.Text += 4;
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            txtBox.Text += 5;
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            txtBox.Text += 6;
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            txtBox.Text += 7;
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            txtBox.Text += 8;
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            txtBox.Text += 9;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            txtBox.Text += "00";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            txtBox.Text += 0;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            txtBox.Text += ",";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if(txtBox.TextLength != 0)
                txtBox.Text = txtBox.Text.Substring(0, txtBox.Text.Length - 1);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            txtBox.ResetText();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            txtBoxText = txtBox.Text;
            this.Close();
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Mouse_X = e.X;
            Mouse_Y = e.Y;
            move = true;
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }
        private void FrmSayiKlavye_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button6_Click(null, null);
            else if (e.KeyCode == Keys.D0)
                button2_Click(null, null);
            else if (e.KeyCode == Keys.D1)
                btn1_Click(null, null);
            else if (e.KeyCode == Keys.D2)
                btn2_Click(null, null);
            else if (e.KeyCode == Keys.D3)
                btn3_Click(null, null);
            else if (e.KeyCode == Keys.D4)
                btn4_Click(null, null);
            else if (e.KeyCode == Keys.D5)
                btn5_Click(null, null);
            else if (e.KeyCode == Keys.D6)
                btn6_Click(null, null);
            else if (e.KeyCode == Keys.D7)
                btn7_Click(null, null);
            else if (e.KeyCode == Keys.D8)
                btn8_Click(null, null);
            else if (e.KeyCode == Keys.D9)
                btn9_Click(null, null);
            else if (e.KeyCode == Keys.Back)
                button4_Click(null, null);
            else if (e.KeyCode == Keys.Delete)
                button5_Click(null, null);
            else if (e.KeyCode == Keys.Escape)
                button7_Click(null, null);
        }
    }
}
