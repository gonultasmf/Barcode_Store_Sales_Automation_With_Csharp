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
using Microsoft.Office.Interop.Excel;
using System.Collections;

namespace BarkodluOtomasyon
{
    public partial class FrmMusteriIslemleri : Form
    {
        DataBase db = new DataBase();
        Function function = new Function();
        Theme theme;
        public static int musteriKod;
        StringFormat strFormat;
        ArrayList arrColumnLefts = new ArrayList();
        ArrayList arrColumnWidths = new ArrayList();
        int iCellHeight = 0;
        int iTotalWidth = 0;
        int iRow = 0;
        bool bFirstPage = false;
        bool bNewPage = false;
        int iHeaderHeight = 0;
        public FrmMusteriIslemleri()
        {
            InitializeComponent();
        }
        private void FrmHesapDefteri_Load(object sender, EventArgs e)
        {
            List<SystemDB> list = db.Info_System_Database();
            theme = new Theme(list[0].IndexTheme);
            theme.backArray(this);
            theme.buttonArray(btnKapat, btnListeExcelAktar,
                btnListeTopla, btnListeYazdir, btnMusteriAyrinti,
                btnMusteriEkle, btnMusteriSil);
            theme.labelArray(label2, label1);
            theme.comboArray(comboArama);
            theme.textBoxArray(txtArama);
            theme.panelArray(panel2, panel1);
            theme.tableArray(listeMusteri);
            comboArama.SelectedIndex = 0;
            function.ListDoldurCustomer(listeMusteri);
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            FrmMusteriEkle musteriEkle = new FrmMusteriEkle();
            musteriEkle.ShowDialog();
            function.ListDoldurCustomer(listeMusteri);
        }
        private void btnMusteriSil_Click(object sender, EventArgs e)
        {
            if (listeMusteri.Rows.Count.Equals(0))
            {
                MessageBox.Show("Müşteri Bulunmamaktadır!!!", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                musteriKod = Convert.ToInt32(listeMusteri.CurrentRow.Cells[1].Value);
                FrmMusteriSil musteriSil = new FrmMusteriSil();
                musteriSil.ShowDialog();
                function.ListDoldurCustomer(listeMusteri);
            }
        }
        private void btnMusteriAyrinti_Click(object sender, EventArgs e)
        {
            if (listeMusteri.Rows.Count.Equals(0))
            {
                MessageBox.Show("Müşteri Hesabı Bulunmamaktadır!!!", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                musteriKod = Convert.ToInt32(listeMusteri.CurrentRow.Cells[1].Value);
                FrmMusteriHesabı musteriHesabı = new  FrmMusteriHesabı();
                musteriHesabı.ShowDialog();
                function.ListDoldurCustomer(listeMusteri);
            }
        }
        private void listeMusteri_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (listeMusteri.Rows.Count.Equals(0))
            {
                MessageBox.Show("Müşteri Hesabı Bulunmamaktadır!!!", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                musteriKod = Convert.ToInt32(listeMusteri.CurrentRow.Cells[1].Value);
                FrmMusteriHesabı musteriHesabı = new FrmMusteriHesabı();
                musteriHesabı.ShowDialog();
                function.ListDoldurCustomer(listeMusteri);
            }
        }
        private void btnListeTopla_Click(object sender, EventArgs e)
        {
            FrmMusteriListeTopla listeTopla = new FrmMusteriListeTopla();
            listeTopla.ShowDialog();
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            function.Search_Customer(comboArama.SelectedIndex, listeMusteri, txtArama.Text);
        }
        private void btnListeExcelAktar_Click(object sender, EventArgs e)
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
                saveFile.FileName = "backup_veri_excel.xls";
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveFile.FileName, XlFileFormat.xlWorkbookNormal);
                }
                int StartCol = 1;
                int StartRow = 1;
                for (int i = 0; i < listeMusteri.Columns.Count; i++)
                {
                    Range myRange = (Range)sheet1.Cells[StartRow, StartCol + i];
                    myRange.Value2 = listeMusteri.Columns[i].HeaderText;
                }
                StartRow++;
                for (int i = 0; i < listeMusteri.Rows.Count; i++)
                {
                    for (int j = 0; j < listeMusteri.Columns.Count; j++)
                    {
                        Range myRange = (Range)sheet1.Cells[StartRow + i, StartCol + j];
                        myRange.Value2 = listeMusteri[j, i].Value == null ? "" : listeMusteri[j, i].Value;
                        myRange.Select();
                    }
                }
                workbook.Close(true);
                excel.Quit();
            }
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                int iLeftMargin = e.MarginBounds.Left;
                int iTopMargin = e.MarginBounds.Top;
                bool bMorePagesToPrint = false;
                int iTmpWidth = 0;
                bFirstPage = true;

                if (bFirstPage)
                {
                    foreach (DataGridViewColumn GridCol in listeMusteri.Columns)
                    {
                        iTmpWidth = (int)(Math.Floor((double)((double)GridCol.Width /
                                       (double)iTotalWidth * (double)iTotalWidth *
                                       ((double)e.MarginBounds.Width / (double)iTotalWidth))));

                        iHeaderHeight = (int)(e.Graphics.MeasureString(GridCol.HeaderText,
                                    GridCol.InheritedStyle.Font, iTmpWidth).Height) + 11;


                        arrColumnLefts.Add(iLeftMargin);
                        arrColumnWidths.Add(iTmpWidth);
                        iLeftMargin += iTmpWidth;
                    }
                }

                while (iRow <= listeMusteri.Rows.Count - 1)
                {
                    DataGridViewRow GridRow = listeMusteri.Rows[iRow];

                    iCellHeight = GridRow.Height + 5;
                    int iCount = 0;

                    if (iTopMargin + iCellHeight >= e.MarginBounds.Height + e.MarginBounds.Top)
                    {
                        bNewPage = true;
                        bFirstPage = false;
                        bMorePagesToPrint = true;
                        break;
                    }
                    else
                    {
                        if (bNewPage)
                        {

                            e.Graphics.DrawString("Satış Raporu", new System.Drawing.Font(listeMusteri.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Satış Raporu", new System.Drawing.Font(listeMusteri.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                            String strDate = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();

                            e.Graphics.DrawString(strDate, new System.Drawing.Font(listeMusteri.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width -
                                    e.Graphics.MeasureString(strDate, new System.Drawing.Font(listeMusteri.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Width), e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Satış Raporu", new System.Drawing.Font(new System.Drawing.Font(listeMusteri.Font,
                                    FontStyle.Bold), FontStyle.Bold), e.MarginBounds.Width).Height - 13);


                            iTopMargin = e.MarginBounds.Top;
                            foreach (DataGridViewColumn GridCol in listeMusteri.Columns)
                            {
                                e.Graphics.FillRectangle(new SolidBrush(Color.LightGray),
                                    new System.Drawing.Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawRectangle(Pens.Black,
                                    new System.Drawing.Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawString(GridCol.HeaderText, GridCol.InheritedStyle.Font,
                                    new SolidBrush(GridCol.InheritedStyle.ForeColor),
                                    new System.Drawing.RectangleF((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight), strFormat);
                                iCount++;
                            }
                            bNewPage = false;
                            iTopMargin += iHeaderHeight;
                        }
                        iCount = 0;

                        foreach (DataGridViewCell Cel in GridRow.Cells)
                        {
                            if (Cel.Value != null)
                            {
                                e.Graphics.DrawString(Cel.Value.ToString(), Cel.InheritedStyle.Font,
                                            new SolidBrush(Cel.InheritedStyle.ForeColor),
                                            new System.Drawing.RectangleF((int)arrColumnLefts[iCount], (float)iTopMargin,
                                            (int)arrColumnWidths[iCount], (float)iCellHeight), strFormat);
                            }

                            e.Graphics.DrawRectangle(Pens.Black, new System.Drawing.Rectangle((int)arrColumnLefts[iCount],
                                    iTopMargin, (int)arrColumnWidths[iCount], iCellHeight));

                            iCount++;
                        }
                    }
                    iRow++;
                    iTopMargin += iCellHeight;
                }


                if (bMorePagesToPrint)
                    e.HasMorePages = true;
                else
                    e.HasMorePages = false;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                strFormat = new StringFormat();
                strFormat.Alignment = StringAlignment.Near;
                strFormat.LineAlignment = StringAlignment.Center;
                strFormat.Trimming = StringTrimming.EllipsisCharacter;

                arrColumnLefts.Clear();
                arrColumnWidths.Clear();
                iCellHeight = 0;
                iRow = 0;
                bFirstPage = true;
                bNewPage = true;

                iTotalWidth = 0;
                foreach (DataGridViewColumn dgvGridCol in listeMusteri.Columns)
                {
                    iTotalWidth += dgvGridCol.Width;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
    }
}
