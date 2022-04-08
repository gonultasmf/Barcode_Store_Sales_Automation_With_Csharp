using BarkodluOtomasyon.Class;
using BarkodluOtomasyon.Database;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarkodluOtomasyon
{
    public partial class FrmKasaIslemleri : Form
    {
        public static string kasa;
        public static string fis_islemNo;
        Theme theme;
        DataBase db = new DataBase();
        Function function = new Function();
        StringFormat strFormat;
        ArrayList arrColumnLefts = new ArrayList();
        ArrayList arrColumnWidths = new ArrayList();
        int iCellHeight = 0;
        int iTotalWidth = 0;
        int iRow = 0;
        bool bFirstPage = false;
        bool bNewPage = false;
        int iHeaderHeight = 0;
        public FrmKasaIslemleri()
        {
            InitializeComponent();
        }
        private void FrmKasaIslemleri_Load(object sender, EventArgs e)
        {
            List<SystemDB> list = db.Info_System_Database();
            theme = new Theme(list[0].IndexTheme);
            theme.backArray(this);
            theme.buttonArray(btnAyrintiGör, btnKaydiSil,
                btnListeYazdir, btnParaCikis, btnParaGiris,
                btnTarihAra);
            theme.comboArray(comboAramaOlcut, comboKasa, comboListeTur);
            theme.dateArray(dateBaslangic, dateSon);
            theme.tableArray(listeKasaIslem);
            theme.textBoxArray(txtArama, txtKasaDevirTutar);
            theme.labelArray(label1, label2, label3, label4, label5, label6);
            theme.panelArray(panel1, panel2);
            function.ListDoldurSafe(listeKasaIslem);
            txtKasaDevirTutar.Text = function.toplamDevirTutar.ToString("0.00") + " ₺";
            comboAramaOlcut.SelectedIndex = 0;
            comboKasa.SelectedIndex = 0;
            comboListeTur.SelectedIndex = 0;

        }
        private void btnParaGiris_Click(object sender, EventArgs e)
        {
            kasa = comboKasa.Text;
            FrmParaGiris paraGiris = new FrmParaGiris();
            paraGiris.ShowDialog();
            function.ListDoldurSafe(listeKasaIslem);
            txtKasaDevirTutar.Text = function.toplamDevirTutar.ToString("0.00") + " ₺";
        }
        private void btnParaCikis_Click(object sender, EventArgs e)
        {
            kasa = comboKasa.Text;
            FrmParaCikis paraCikis = new FrmParaCikis();
            paraCikis.ShowDialog();
            function.ListDoldurSafe(listeKasaIslem);
            txtKasaDevirTutar.Text = function.toplamDevirTutar.ToString("0.00") + " ₺";
        }
        private void btnKaydiSil_Click(object sender, EventArgs e)
        {
            fis_islemNo = listeKasaIslem.CurrentRow.Cells[2].Value.ToString();
            FrmKayitSil kayitSil = new FrmKayitSil();
            kayitSil.ShowDialog();
            function.ListDoldurSafe(listeKasaIslem);
            txtKasaDevirTutar.Text = function.toplamDevirTutar.ToString("0.00") + " ₺";
        }
        private void btnAyrintiGör_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in listeKasaIslem.SelectedRows)
            {
                if (row.Cells[0].Value != null)
                {
                    FrmKasaIslemAyrinti ms = new FrmKasaIslemAyrinti(row.Cells[2].Value.ToString());
                    ms.ShowDialog();
                }
            }
        }
        private void listeKasaIslem_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var currentMouseOverRow = listeKasaIslem.HitTest(e.X, e.Y).RowIndex;
            if (currentMouseOverRow >= 0)
            {
                foreach (DataGridViewRow row in listeKasaIslem.SelectedRows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        FrmKasaIslemAyrinti ms = new FrmKasaIslemAyrinti(row.Cells[2].Value.ToString());
                        ms.ShowDialog();
                    }
                }
            }
            else
                MessageBox.Show("Lütfen Bir Satır Seçiniz!!!", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void comboKasa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboKasa.SelectedIndex.Equals(0))
                function.Search_Safe(3, listeKasaIslem, "Kasa-1");
            else if(comboKasa.SelectedIndex.Equals(1))
                function.Search_Safe(3, listeKasaIslem, "Kasa-2");
        }
        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            function.Search_Safe(comboAramaOlcut.SelectedIndex, listeKasaIslem, txtArama.Text);
        }
        private void comboListeTur_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboListeTur.SelectedIndex.Equals(0))
                function.Search_Safe(4, listeKasaIslem, "");
            else if(comboListeTur.SelectedIndex.Equals(1))
                function.Search_Safe(4, listeKasaIslem, "Giren");
            else if(comboListeTur.SelectedIndex.Equals(2))
                function.Search_Safe(4, listeKasaIslem, "Çıkan");
            else if(comboListeTur.SelectedIndex.Equals(3))
                function.Search_Safe(2, listeKasaIslem, "Nakit");
            else if(comboListeTur.SelectedIndex.Equals(4))
                function.Search_Safe(4, listeKasaIslem, "POS");
        }
        private void txtArama_Enter(object sender, EventArgs e)
        {
            txtArama.Text = "";
            txtArama.Font = new Font("Tahoma", 9.75F,
                FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
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
                    foreach (DataGridViewColumn GridCol in listeKasaIslem.Columns)
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

                while (iRow <= listeKasaIslem.Rows.Count - 1)
                {
                    DataGridViewRow GridRow = listeKasaIslem.Rows[iRow];

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

                            e.Graphics.DrawString("Satış Raporu", new System.Drawing.Font(listeKasaIslem.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Satış Raporu", new System.Drawing.Font(listeKasaIslem.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Height - 10);

                            String strDate = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();

                            e.Graphics.DrawString(strDate, new System.Drawing.Font(listeKasaIslem.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width -
                                    e.Graphics.MeasureString(strDate, new System.Drawing.Font(listeKasaIslem.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Width), e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Satış Raporu", new System.Drawing.Font(new System.Drawing.Font(listeKasaIslem.Font,
                                    FontStyle.Bold), FontStyle.Bold), e.MarginBounds.Width).Height - 10);


                            iTopMargin = e.MarginBounds.Top;
                            foreach (DataGridViewColumn GridCol in listeKasaIslem.Columns)
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
        private void printDocument1_BeginPrint(object sender, PrintEventArgs e)
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
                foreach (DataGridViewColumn dgvGridCol in listeKasaIslem.Columns)
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
        }
        private void btnTarihAra_Click(object sender, EventArgs e)
        {
            DateTime tarihB = new DateTime(dateBaslangic.Value.Year, dateBaslangic.Value.Month, dateBaslangic.Value.Day, 0, 0, 0);
            DateTime tarihS = new DateTime(dateSon.Value.Year, dateSon.Value.Month, dateSon.Value.Day, 0, 0, 0);
            function.ListAramaTarihSafe(listeKasaIslem, tarihB, tarihS);
            txtKasaDevirTutar.Text = function.toplamDevirTutar.ToString("0.00") + " ₺";
        }
    }
}
