using BarkodluOtomasyon.Database;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarkodluOtomasyon.Class
{
    class Theme
    {
        public DataBase ver = new DataBase();
        public int nowTheme;
        Color backColor;
        Color lblColor;
        Color buttonColor;
        Color buttonBackColor;
        Color buttonBorderColor;
        Color textColor;
        Color textBackColor;
        Color comboTextColor;
        Color comboBackColor;
        Color richTextColor;
        Color richBackColor;
        Color dateTextColor;
        Color dateBackColor;
        Color tableTextColor;
        Color tableBorderColor;
        Color tableBackColor;
        Color tableCellBackColor;
        Color tableAlterneBackColor;
        Color checkTextColor;
        Color menuTextColor;
        Color menuBackColor;
        Color rdBtnTextColor;
        Color maskTextColor;
        Color maskTextBackColor;
        Color panelBackColor;
        Color panelUstBackColor;
        public Theme(int index)
        {
            nowTheme = index;
            if (nowTheme.Equals(1))
            {
                backColor = Color.FromArgb(200, 255, 255);
                lblColor = ColorTranslator.FromHtml("Black");
                buttonColor = ColorTranslator.FromHtml("Black");
                buttonBackColor = Color.FromArgb(160, 255, 255);
                buttonBorderColor = Color.FromArgb(200, 255, 255);
                textColor = ColorTranslator.FromHtml("Black");
                textBackColor = Color.FromArgb(205, 255, 255);
                comboTextColor = ColorTranslator.FromHtml("Black");
                comboBackColor = Color.FromArgb(205, 255, 255);
                richTextColor = ColorTranslator.FromHtml("Black");
                richBackColor = Color.FromArgb(205, 255, 255);
                dateTextColor = ColorTranslator.FromHtml("White");
                dateBackColor = Color.FromArgb(200, 255, 255);
                tableTextColor = ColorTranslator.FromHtml("Black");
                tableBorderColor = ColorTranslator.FromHtml("Black");
                tableBackColor = Color.FromArgb(205, 255, 255);
                tableCellBackColor = Color.FromArgb(150, 255, 255);
                tableAlterneBackColor = Color.FromArgb(120, 255, 255);
                checkTextColor = ColorTranslator.FromHtml("Black");
                menuTextColor = ColorTranslator.FromHtml("Black");
                menuBackColor = Color.FromArgb(240, 255, 255);
                rdBtnTextColor = ColorTranslator.FromHtml("Black");
                maskTextColor = ColorTranslator.FromHtml("Black");
                maskTextBackColor = Color.FromArgb(205, 255, 255);
                panelBackColor = Color.FromArgb(218, 255, 255);
                panelUstBackColor = Color.FromArgb(230, 255, 255);
            }
            else if (nowTheme.Equals(5))
            {
                backColor = ColorTranslator.FromHtml("Black");
                lblColor = ColorTranslator.FromHtml("White");
                buttonColor = ColorTranslator.FromHtml("White");
                buttonBackColor = Color.FromArgb(65, 65, 65);
                buttonBorderColor = Color.FromArgb(50, 50, 50);
                textColor = ColorTranslator.FromHtml("White");
                textBackColor = Color.FromArgb(65, 65, 65);
                comboTextColor = ColorTranslator.FromHtml("White");
                comboBackColor = ColorTranslator.FromHtml("Black");
                richTextColor = ColorTranslator.FromHtml("White");
                richBackColor = Color.FromArgb(65, 65, 65);
                dateTextColor = ColorTranslator.FromHtml("Black");
                dateBackColor = ColorTranslator.FromHtml("Black");
                tableTextColor = ColorTranslator.FromHtml("White");
                tableBorderColor = ColorTranslator.FromHtml("White");
                tableBackColor = ColorTranslator.FromHtml("Black");
                tableCellBackColor = Color.FromArgb(80, 80, 80);
                tableAlterneBackColor = Color.FromArgb(60, 60, 60);
                checkTextColor = ColorTranslator.FromHtml("White");
                menuTextColor = ColorTranslator.FromHtml("White");
                menuBackColor = ColorTranslator.FromHtml("Black");
                rdBtnTextColor = ColorTranslator.FromHtml("White");
                maskTextColor = ColorTranslator.FromHtml("White");
                maskTextBackColor = Color.FromArgb(65, 65, 65);
                panelBackColor = Color.FromArgb(25, 25, 25);
                panelUstBackColor = Color.FromArgb(35, 35, 35);
            }
            else if (nowTheme.Equals(3))
            {
                backColor = Color.FromArgb(23, 23, 47);
                lblColor = ColorTranslator.FromHtml("White");
                buttonColor = ColorTranslator.FromHtml("White");
                buttonBackColor = Color.FromArgb(38, 38, 79);
                buttonBorderColor = Color.FromArgb(33, 33, 67);
                textColor = ColorTranslator.FromHtml("White");
                textBackColor = Color.FromArgb(23, 23, 47);
                comboTextColor = ColorTranslator.FromHtml("White");
                comboBackColor = Color.FromArgb(23, 23, 47);
                richTextColor = ColorTranslator.FromHtml("White");
                richBackColor = Color.FromArgb(23, 23, 47);
                dateTextColor = ColorTranslator.FromHtml("White");
                dateBackColor = Color.FromArgb(23, 23, 47);
                tableTextColor = ColorTranslator.FromHtml("White");
                tableBorderColor = Color.FromArgb(44, 0, 70);
                tableBackColor = Color.FromArgb(23, 23, 47);
                tableCellBackColor = Color.DarkGray;
                checkTextColor = ColorTranslator.FromHtml("White");
                menuTextColor = ColorTranslator.FromHtml("White");
                menuBackColor = Color.FromArgb(23, 23, 47);
                rdBtnTextColor = ColorTranslator.FromHtml("White");
                maskTextColor = ColorTranslator.FromHtml("White");
                maskTextBackColor = Color.FromArgb(23, 23, 47);
                panelBackColor = Color.FromArgb(30, 30, 60);
                panelUstBackColor = Color.FromArgb(43, 43, 70);
            }
            else if (nowTheme.Equals(2))
            {
                backColor = Color.FromArgb(0, 0, 0);
                lblColor = ColorTranslator.FromHtml("White");
                buttonColor = ColorTranslator.FromHtml("White");
                buttonBackColor = Color.FromArgb(0, 0, 0);
                buttonBorderColor = Color.FromArgb(70, 70, 70);
                textColor = ColorTranslator.FromHtml("White");
                textBackColor = Color.FromArgb(0, 0, 0);
                comboTextColor = ColorTranslator.FromHtml("White");
                comboBackColor = Color.FromArgb(0, 0, 0);
                richTextColor = ColorTranslator.FromHtml("White");
                richBackColor = Color.FromArgb(0, 0, 0);
                dateTextColor = ColorTranslator.FromHtml("White");
                dateBackColor = Color.FromArgb(0, 0, 0);
                tableTextColor = ColorTranslator.FromHtml("White");
                tableBorderColor = Color.FromArgb(91, 91, 91);
                tableBackColor = Color.FromArgb(0, 0, 0);
                tableCellBackColor = Color.DarkGray;
                tableAlterneBackColor = Color.FromArgb(50, 50, 50);
                checkTextColor = ColorTranslator.FromHtml("White");
                menuTextColor = ColorTranslator.FromHtml("White");
                menuBackColor = Color.FromArgb(0, 0, 0);
                rdBtnTextColor = ColorTranslator.FromHtml("White");
                maskTextColor = ColorTranslator.FromHtml("White");
                maskTextBackColor = Color.FromArgb(0, 0, 0);
                panelBackColor = Color.FromArgb(40, 40, 40);
                panelUstBackColor = Color.FromArgb(55, 55, 55);
            }
            else if (nowTheme.Equals(4))
            {
                backColor = Color.FromArgb(70, 73, 88);
                lblColor = Color.FromArgb(230, 232, 242);
                buttonColor = Color.FromArgb(230, 232, 242);
                buttonBackColor = Color.FromArgb(70, 73, 88);
                buttonBorderColor = Color.FromArgb(78, 81, 97);
                textColor = Color.FromArgb(230, 232, 242);
                textBackColor = Color.FromArgb(65, 65, 80);
                comboTextColor = Color.FromArgb(230, 232, 242);
                comboBackColor = Color.FromArgb(78, 81, 97);
                richTextColor = Color.FromArgb(230, 232, 242);
                richBackColor = Color.FromArgb(78, 81, 97);
                dateTextColor = Color.FromArgb(230, 232, 242);
                dateBackColor = Color.FromArgb(78, 81, 97);
                tableTextColor = Color.FromArgb(230, 232, 242);
                tableBorderColor = Color.FromArgb(100, 100, 100);
                tableBackColor = Color.FromArgb(78, 81, 97);
                tableCellBackColor = Color.DarkGray;
                tableAlterneBackColor = Color.FromArgb(50, 50, 50);
                checkTextColor = Color.FromArgb(230, 232, 242);
                menuTextColor = Color.FromArgb(230, 232, 242);
                menuBackColor = Color.FromArgb(78, 81, 97);
                rdBtnTextColor = Color.FromArgb(230, 232, 242);
                maskTextColor = Color.FromArgb(230, 232, 242);
                maskTextBackColor = Color.FromArgb(78, 81, 97);
                panelBackColor = Color.FromArgb(80, 80, 93);
                panelUstBackColor = Color.FromArgb(88, 88, 99);
            }
            else if (nowTheme.Equals(6))
            {
                backColor = Color.FromArgb(40, 40, 40);
                lblColor = Color.FromArgb(255, 255, 255);
                buttonColor = Color.FromArgb(255, 255, 255);
                buttonBackColor = Color.FromArgb(48, 48, 48);
                buttonBorderColor = Color.FromArgb(45, 45, 45);
                textColor = Color.FromArgb(255, 255, 255);
                textBackColor = Color.FromArgb(40, 40, 40);
                comboTextColor = Color.FromArgb(255, 255, 255);
                comboBackColor = Color.FromArgb(40, 40, 40);
                richTextColor = Color.FromArgb(255, 255, 255);
                richBackColor = Color.FromArgb(40, 40, 40);
                dateTextColor = Color.FromArgb(255, 255, 255);
                dateBackColor = Color.FromArgb(40, 40, 40);
                tableTextColor = Color.FromArgb(255, 255, 255);
                tableBorderColor = Color.FromArgb(45, 20, 62);
                tableBackColor = Color.FromArgb(40, 40, 40);
                tableCellBackColor = Color.DarkGray;
                tableAlterneBackColor = Color.FromArgb(50, 50, 50);
                checkTextColor = Color.FromArgb(255, 255, 255);
                menuTextColor = Color.FromArgb(255, 255, 255);
                menuBackColor = Color.FromArgb(40, 40, 40);
                rdBtnTextColor = Color.FromArgb(255, 255, 255);
                maskTextColor = Color.FromArgb(255, 255, 255);
                maskTextBackColor = Color.FromArgb(40, 40, 40);
                panelBackColor = Color.FromArgb(55, 55, 55);
                panelUstBackColor = Color.FromArgb(65, 65, 65);
            }
            else if (nowTheme.Equals(0))
            {
                backColor = Color.White;
                lblColor = Color.Black;
                buttonColor = Color.Black;
                buttonBackColor = Color.LightGray;
                buttonBorderColor = Color.FromArgb(250, 250, 250);
                textColor = Color.Black;
                textBackColor = Color.White;
                comboTextColor = Color.Black;
                comboBackColor = Color.White;
                richTextColor = Color.Black;
                richBackColor = Color.White;
                dateTextColor = Color.Black;
                dateBackColor = Color.White;
                tableTextColor = Color.Black;
                tableBorderColor = Color.LightGray;
                tableBackColor = Color.White;
                tableCellBackColor = Color.DarkGray;
                tableAlterneBackColor = Color.LightGray;
                checkTextColor = Color.Black;
                menuTextColor = Color.Black;
                menuBackColor = Color.White;
                rdBtnTextColor = Color.Black;
                maskTextColor = Color.Black;
                maskTextBackColor = Color.White;
                panelBackColor = Color.FromArgb(245, 245, 245);
                panelUstBackColor = Color.FromArgb(240, 240, 240);
            }
        }
        public void textBoxArray(params TextBox[] textBoxes)
        {
            foreach (TextBox textBox in textBoxes)
            {
                textBox.BackColor = textBackColor;
                textBox.ForeColor = textColor;
                textBox.BorderStyle = BorderStyle.Fixed3D;
            }
        }
        public void labelArray(params Label[] labels)
        {
            foreach (Label label in labels)
            {
                label.ForeColor = lblColor;
            }
        }
        public void buttonArray(params Button[] buttons)
        {
            foreach (Button button in buttons)
            {
                button.BackColor = buttonBackColor;
                button.ForeColor = buttonColor;
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 2;
                button.FlatAppearance.BorderColor = buttonBorderColor;
            }
        }
        public void backArray(params Form[] forms)
        {
            foreach (Form form in forms)
            {
                form.BackColor = backColor;
            }
        }
        public void comboArray(params ComboBox[] comboBoxes)
        {
            foreach (ComboBox comboBox in comboBoxes)
            {
                comboBox.BackColor = comboBackColor;
                comboBox.ForeColor = comboTextColor;
                comboBox.FlatStyle = FlatStyle.Flat;
            }
        }
        public void richArray(params RichTextBox[] richTextBoxes)
        {
            foreach (RichTextBox richText in richTextBoxes)
            {
                richText.BackColor = richBackColor;
                richText.ForeColor = richTextColor;
            }
        }
        public void dateArray(params DateTimePicker[] dateTimePickers)
        {
            foreach (DateTimePicker timePicker in dateTimePickers)
            {
                timePicker.CalendarTitleBackColor = dateBackColor;
                timePicker.CalendarTitleForeColor = dateTextColor;
                timePicker.CalendarForeColor = dateTextColor;
                timePicker.CalendarTrailingForeColor = dateTextColor;
                timePicker.CalendarMonthBackground = dateBackColor;
            }
        }
        public void tableArray(params DataGridView[] dataGridViews)
        {
            foreach (DataGridView dataGridView in dataGridViews)
            {
                dataGridView.BackgroundColor = tableBackColor;
                dataGridView.GridColor = tableBorderColor;
                dataGridView.ForeColor = tableTextColor;
                dataGridView.ColumnHeadersDefaultCellStyle.BackColor = tableBackColor;
                dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = tableTextColor;
                dataGridView.EnableHeadersVisualStyles = false;
                dataGridView.RowsDefaultCellStyle.BackColor = tableBackColor;
                dataGridView.RowHeadersDefaultCellStyle.BackColor = tableBackColor;
                dataGridView.Font = new System.Drawing.Font("Tahoma", 8F,
                                 FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                dataGridView.RowsDefaultCellStyle.SelectionBackColor = tableCellBackColor;
                dataGridView.RowsDefaultCellStyle.SelectionForeColor = tableTextColor;
                dataGridView.RowHeadersDefaultCellStyle.SelectionBackColor = tableCellBackColor;
                dataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = tableCellBackColor;
                dataGridView.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 9F,
                                 FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                dataGridView.AlternatingRowsDefaultCellStyle.BackColor = tableAlterneBackColor;
            }
        }
        public void chckArray(params CheckBox[] checkBoxes)
        {
            foreach (CheckBox checkBox in checkBoxes)
            {
                checkBox.ForeColor = checkTextColor;
            }
        }
        public void menuArray(params MenuStrip[] menuStrips)
        {
            foreach (MenuStrip menuStrip in menuStrips)
            {
                menuStrip.BackColor = menuBackColor;
                menuStrip.ForeColor = menuTextColor;
            }
        }
        public void menuItemArray(params ToolStripMenuItem[] menuStrips)
        {
            foreach (ToolStripMenuItem menuItemStrip in menuStrips)
            {
                menuItemStrip.BackColor = menuBackColor;
                menuItemStrip.ForeColor = menuTextColor;
            }
        }
        public void rdBtnArray(params RadioButton[] radioButtons)
        {
            foreach (RadioButton radioButton in radioButtons)
            {
                radioButton.ForeColor = rdBtnTextColor;
            }
        }
        /*public void maskTextArray(params MaskedTextBox[] maskedTextBoxes)
        {

            foreach (MaskedTextBox maskedText in maskedTextBoxes)
            {
                maskedText.BackColor = maskTextBackColor;
                maskedText.ForeColor = maskTextColor;
                maskedText.BorderStyle = BorderStyle.Fixed3D;
            }
        }*/
        public void panelArray(params Panel[] panels)
        {

            foreach (Panel panel in panels)
            {
                panel.BackColor = panelBackColor;
                panel.BorderStyle = BorderStyle.None;
            }
        }
        public void panelUstArray(params Panel[] panels)
        {

            foreach (Panel panel in panels)
            {
                panel.BackColor = panelUstBackColor;
                panel.BorderStyle = BorderStyle.None;
            }
        }
        public void tabControlArray(params TabControl[] tabControls)
        {
            foreach (TabControl tabControl in tabControls)
            {
                for (int i = 0; i < tabControl.TabCount; i++)
                {
                    tabControl.TabPages[i].BackColor = backColor;
                }
            }
        }
    }
}
