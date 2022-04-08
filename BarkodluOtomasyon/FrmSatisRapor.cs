using BarkodluOtomasyon.Class;
using BarkodluOtomasyon.Database;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections;
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
    public partial class FrmSatisRapor : Form
    {
        DataBase db = new DataBase();
        Function function = new Function();
        Theme theme;
        
        public FrmSatisRapor()
        {
            InitializeComponent();
        }
        private void btnListeGoruntule_Click(object sender, EventArgs e)
        {
            DateTime tarihB = new DateTime(dateBaslangic.Value.Year, dateBaslangic.Value.Month, dateBaslangic.Value.Day, 0, 0, 0);
            DateTime tarihS = new DateTime(dateBitis.Value.Year, dateBitis.Value.Month, dateBitis.Value.Day, 0, 0, 0);
            function.ListDoldurSellReport(listeSatisAyrinti, tarihB, tarihS);
            listeAnaliz(listeSatisAyrinti);
        }
        private void btnListeGoruntule1_Click(object sender, EventArgs e)
        {
            function.ListDoldurSellReportKategori(listeSatisAyrinti_1, comboKategori.Text);
            listeAnaliz(listeSatisAyrinti_1);
        }
        private void btnListeGoruntule2_Click(object sender, EventArgs e)
        {
            if (txtUrun.TextLength.Equals(0))
                MessageBox.Show("Bi Ürün Seçiniz!!!", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                function.ListDoldurSellReportUrun(listeSatisAyrinti_2, txtUrun.Text);
                listeAnaliz(listeSatisAyrinti_2);
            }
        }
        public void listeAnaliz(DataGridView list)
        {
            double toplam = 0, toplam1 = 0, toplam2 = 0;
            for(int i = 0; i<list.Rows.Count; i++)
            {
                toplam += Convert.ToDouble(list.Rows[i].Cells[6].Value);
                toplam1 += Convert.ToDouble(list.Rows[i].Cells[7].Value);
                toplam2 += Convert.ToDouble(list.Rows[i].Cells[7].Value) -
                    Convert.ToDouble(list.Rows[i].Cells[6].Value);
            }
            if (tabControl1.SelectedIndex.Equals(0))
            {
                txtTAlisTutar.Text = toplam.ToString("0.00") + " ₺";
                txtTSatisTutar1.Text = toplam1.ToString("0.00") + " ₺";
                txtTKar.Text = toplam2.ToString("0.00") + " ₺";
                txtTKayitSayisi.Text = list.Rows.Count.ToString();
            }
            else if (tabControl1.SelectedIndex.Equals(1))
            {
                txtTAlisTutar_1.Text = toplam.ToString("0.00") + " ₺";
                txtTSatisTutar1_1.Text = toplam1.ToString("0.00") + " ₺";
                txtTKar_1.Text = toplam2.ToString("0.00") + " ₺";
                txtTKayitSayisi_1.Text = list.Rows.Count.ToString();
            }
            else if (tabControl1.SelectedIndex.Equals(2))
            {
                txtTAlisTutar_2.Text = toplam.ToString("0.00") + " ₺";
                txtTSatisTutar1_2.Text = toplam1.ToString("0.00") + " ₺";
                txtTKar_2.Text = toplam2.ToString("0.00") + " ₺";
                txtTKayitSayisi_2.Text = list.Rows.Count.ToString();
            }
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FrmSatisRapor_Load(object sender, EventArgs e)
        {
            List<SystemDB> list = db.Info_System_Database();
            theme = new Theme(list[0].IndexTheme);
            theme.backArray(this);
            theme.panelArray(panel1, panel2, panel3, panel4,
                panel5, panel6, panel7, panel8, panel9);
            theme.buttonArray(btnKapat, btnKapat1, btnKapat2,
                btnListeGoruntule, btnListeGoruntule1,
                btnListeGoruntule2, btnSec, btnYazdir,
                btnYazdir1, btnYazdir2, btnExcel, btnExcel1, btnExcel2);
            theme.tableArray(listeSatisAyrinti, listeSatisAyrinti_1,
                listeSatisAyrinti_2);
            theme.labelArray(label1, label10, label11, label12,
                label13, label14, label15, label16, label17, label2,
                label3, label4, label5, label6, label7, label8, label9);
            theme.textBoxArray(txtTAlisTutar, txtTAlisTutar_1,
                txtTAlisTutar_2, txtTKar, txtTKar_1, txtTKar_2, txtUrun,
                txtTKayitSayisi, txtTKayitSayisi_1, txtTKayitSayisi_2,
                txtTSatisTutar1, txtTSatisTutar1_1, txtTSatisTutar1_2);
            theme.dateArray(dateBaslangic, dateBitis);
            theme.comboArray(comboKategori);
            theme.tabControlArray(tabControl1);
            listeAnaliz(listeSatisAyrinti);
            List<KategoriDB> kategoriDBs = db.Info_Kategori_Database();
            comboKategori.Items.Clear();
            foreach (var item in kategoriDBs)
                comboKategori.Items.Add(item.Kategori);
            aciklama.SetToolTip(btnExcel, "Listeyi EXCEL'e Aktar...");
            aciklama.SetToolTip(btnExcel1, "Listeyi EXCEL'e Aktar...");
            aciklama.SetToolTip(btnExcel2, "Listeyi EXCEL'e Aktar...");
            aciklama.SetToolTip(btnKapat, "Kapat");
            aciklama.SetToolTip(btnKapat1, "Kapat");
            aciklama.SetToolTip(btnKapat2, "Kapat");
        }
        private void btnSec_Click(object sender, EventArgs e)
        {
            FrmStokSec stokSec = new FrmStokSec();
            stokSec.ShowDialog();
            txtUrun.Text = stokSec.urunAdi;
        }
        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Verilerin Excel'e Aktarmak İstediğinizden Emin misiniz???", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                object Missing = Type.Missing;
                Workbook workbook = excel.Workbooks.Add(Missing);
                Worksheet sheet1 = (Worksheet)workbook.Sheets[1];
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.DefaultExt = "xls";
                saveFile.Filter = "xls files (*.xls)|*.xls|All files (*.*)|*.*";
                saveFile.FileName = "backup_SatışRapor_excel.xls";
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveFile.FileName, XlFileFormat.xlWorkbookNormal);
                }
                int StartCol = 1;
                int StartRow = 1;
                for (int i = 0; i < listeSatisAyrinti.Columns.Count; i++)
                {
                    Range myRange = (Range)sheet1.Cells[StartRow, StartCol + i];
                    myRange.Value2 = listeSatisAyrinti.Columns[i].HeaderText;
                }
                StartRow++;
                for (int i = 0; i < listeSatisAyrinti.Rows.Count; i++)
                {
                    for (int j = 0; j < listeSatisAyrinti.Columns.Count; j++)
                    {
                        Range myRange = (Range)sheet1.Cells[StartRow + i, StartCol + j];
                        myRange.Value2 = listeSatisAyrinti[j, i].Value == null ? "" : listeSatisAyrinti[j, i].Value;
                        myRange.Select();
                    }
                }
                workbook.Close(true);
                excel.Quit();
            }
        }
        private void btnExcel1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Verilerin Excel'e Aktarmak İstediğinizden Emin misiniz???", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                object Missing = Type.Missing;
                Workbook workbook = excel.Workbooks.Add(Missing);
                Worksheet sheet1 = (Worksheet)workbook.Sheets[1];
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.DefaultExt = "xls";
                saveFile.Filter = "xls files (*.xls)|*.xls|All files (*.*)|*.*";
                saveFile.FileName = "backup_SatışRapor_excel.xls";
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveFile.FileName, XlFileFormat.xlWorkbookNormal);
                }
                int StartCol = 1;
                int StartRow = 1;
                for (int i = 0; i < listeSatisAyrinti_1.Columns.Count; i++)
                {
                    Range myRange = (Range)sheet1.Cells[StartRow, StartCol + i];
                    myRange.Value2 = listeSatisAyrinti_1.Columns[i].HeaderText;
                }
                StartRow++;
                for (int i = 0; i < listeSatisAyrinti_1.Rows.Count; i++)
                {
                    for (int j = 0; j < listeSatisAyrinti_1.Columns.Count; j++)
                    {
                        Range myRange = (Range)sheet1.Cells[StartRow + i, StartCol + j];
                        myRange.Value2 = listeSatisAyrinti_1[j, i].Value == null ? "" : listeSatisAyrinti_1[j, i].Value;
                        myRange.Select();
                    }
                }
                workbook.Close(true);
                excel.Quit();
            }
        }
        private void btnExcel2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Verilerin Excel'e Aktarmak İstediğinizden Emin misiniz???", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                object Missing = Type.Missing;
                Workbook workbook = excel.Workbooks.Add(Missing);
                Worksheet sheet1 = (Worksheet)workbook.Sheets[1];
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.DefaultExt = "xls";
                saveFile.Filter = "xls files (*.xls)|*.xls|All files (*.*)|*.*";
                saveFile.FileName = "backup_SatışRapor_excel.xls";
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveFile.FileName, XlFileFormat.xlWorkbookNormal);
                }
                int StartCol = 1;
                int StartRow = 1;
                for (int i = 0; i < listeSatisAyrinti_2.Columns.Count; i++)
                {
                    Range myRange = (Range)sheet1.Cells[StartRow, StartCol + i];
                    myRange.Value2 = listeSatisAyrinti_2.Columns[i].HeaderText;
                }
                StartRow++;
                for (int i = 0; i < listeSatisAyrinti_2.Rows.Count; i++)
                {
                    for (int j = 0; j < listeSatisAyrinti_2.Columns.Count; j++)
                    {
                        Range myRange = (Range)sheet1.Cells[StartRow + i, StartCol + j];
                        myRange.Value2 = listeSatisAyrinti_2[j, i].Value == null ? "" : listeSatisAyrinti_2[j, i].Value;
                        myRange.Select();
                    }
                }
                workbook.Close(true);
                excel.Quit();
            }
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            function.ListeYazdır(sender, e, listeSatisAyrinti, "Satış");
        }
        private void btnYazdir_Click(object sender, EventArgs e)
        {
            try
            {
                List<SystemDB> list = db.Info_System_Database();
                PrintPreviewDialog onizleme = new PrintPreviewDialog();
                onizleme.Document = printDocument1;
                printDialog1.PrinterSettings.PrinterName = FrmYaziciAyarlari.yazici;
                onizleme.ShowDialog(); 
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            /*
            PrintDialog yazdir = new PrintDialog();
            yazdir.Document = printDocument1;
            yazdir.UseEXDialog = true;
            if (yazdir.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }*/
        }
        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            function.ListeYazdır(sender, e, listeSatisAyrinti_1, "Satış");
        }
        private void btnYazdir1_Click(object sender, EventArgs e)
        {
            try
            {
                List<SystemDB> list = db.Info_System_Database();
                PrintPreviewDialog onizleme = new PrintPreviewDialog();
                onizleme.Document = printDocument2;
                printDialog2.PrinterSettings.PrinterName = FrmYaziciAyarlari.yazici;
                onizleme.ShowDialog();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            /*
            PrintDialog yazdir = new PrintDialog();
            yazdir.Document = printDocument1;
            yazdir.UseEXDialog = true;
            if (yazdir.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }*/
        }
        private void printDocument3_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            function.ListeYazdır(sender, e, listeSatisAyrinti_2, "Satış");
        }
        private void btnYazdir2_Click(object sender, EventArgs e)
        {
            try
            {
                List<SystemDB> list = db.Info_System_Database();
                PrintPreviewDialog onizleme = new PrintPreviewDialog();
                onizleme.Document = printDocument3;
                printDialog3.PrinterSettings.PrinterName = FrmYaziciAyarlari.yazici;
                onizleme.ShowDialog();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            /*
            PrintDialog yazdir = new PrintDialog();
            yazdir.Document = printDocument1;
            yazdir.UseEXDialog = true;
            if (yazdir.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }*/
        }
    }
}
