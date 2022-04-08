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
using System.Drawing.Printing;
using NetBarcode;
using Type = NetBarcode.Type;

namespace BarkodluOtomasyon
{
    public partial class FrmBarcodeBas : Form
    {
        DataBase db = new DataBase();
        Theme theme;
        string barkod;
        static bool kkControl = false;
        static bool fiyatControl = true;
        static bool barCodeControl = false;
        public FrmBarcodeBas(string barcode)
        {
            barkod = barcode;
            InitializeComponent();
        }

        private void FrmBarcodeBas_Load(object sender, EventArgs e)
        {
            List<SystemDB> list = db.Info_System_Database();
            theme = new Theme(list[0].IndexTheme);
            theme.backArray(this);
            theme.buttonArray(btnBarkodBas, btnEtiketteFiyatGoster,
                btnKapat, btnKK_T_FiyatGoster, btnYaziciSec,
                btnBarCodeGoster);
            theme.comboArray(comboSatisFiyat, comboBasilacakTur,
                comboBarkodTuru, comboBarkodEtiketTip);
            theme.textBoxArray(txtBarkod, txtT_KK_FiyatGoster);
            theme.labelArray(label2, label1);
            List<ProductDB> products = db.Info_Product_Database(barkod);
            txtBarkod.Text = products[0].Barkod;
            txtT_KK_FiyatGoster.Text = products[0].KrediSatisFiyat.ToString();
            comboBarkodTuru.SelectedIndex = 4;
            comboBarkodEtiketTip.SelectedIndex = 0;
            comboBasilacakTur.SelectedIndex = 0;
            comboSatisFiyat.SelectedIndex = 0;
            if (kkControl)
            {
                btnKK_T_FiyatGoster.Image = Properties.Resources.check;
                txtT_KK_FiyatGoster.Enabled = true;
            }
            else
            {
                btnKK_T_FiyatGoster.Image = Properties.Resources.checkBos;
                txtT_KK_FiyatGoster.Enabled = false;
            }
            if (fiyatControl)
            {
                btnEtiketteFiyatGoster.Image = Properties.Resources.check;
                comboSatisFiyat.Enabled = true;
            }
            else
            {
                btnEtiketteFiyatGoster.Image = Properties.Resources.checkBos;
                comboSatisFiyat.Enabled = true;
            }
            if (barCodeControl)
                btnBarCodeGoster.Image = Properties.Resources.check;
            else
                btnBarCodeGoster.Image = Properties.Resources.checkBos;
        }

        private void btnBarkodBas_Click(object sender, EventArgs e)
        {
            if (comboBarkodTuru.SelectedIndex.Equals(0))
            {
                Barcode barcode93 = new Barcode(txtBarkod.Text, Type.Code93);
                pctrBarkod.Image = barcode93.GetImage();
                
            }
            else if(comboBarkodTuru.SelectedIndex.Equals(1))
            {
                Barcode barcode128 = new Barcode(txtBarkod.Text, Type.Code128);
                pctrBarkod.Image = barcode128.GetImage();
            }
            else if (comboBarkodTuru.SelectedIndex.Equals(2))
            {
                Barcode barcode39 = new Barcode(txtBarkod.Text, Type.Code39);
                pctrBarkod.Image = barcode39.GetImage();
            }
            else if (comboBarkodTuru.SelectedIndex.Equals(3))
            {
                Barcode barcode11 = new Barcode(txtBarkod.Text, Type.Code11);
                pctrBarkod.Image = barcode11.GetImage();
            }
            else if (comboBarkodTuru.SelectedIndex.Equals(4))
            {
                Barcode barcodeEAN13 = new Barcode(txtBarkod.Text.Substring(0,12), Type.EAN13);
                pctrBarkod.Image = barcodeEAN13.GetImage();
            }
            PrintPreviewDialog onizleme = new PrintPreviewDialog();
            onizleme.Document = printDocument1;
            printDialog1.PrinterSettings.PrinterName = FrmYaziciAyarlari.yazici;
            onizleme.ShowDialog();
        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            List<ProductDB> product = db.Info_Product_Database(txtBarkod.Text);
            List<SystemDB> system = db.Info_System_Database();
            try
            {
                if (comboBarkodEtiketTip.SelectedIndex.Equals(0))
                {
                    Pen pen = new Pen(Brushes.Black, 1.5F);
                    Font fontBuyuk = new Font("Verdana", system[0].FisYaziBoyut + 7, FontStyle.Bold);
                    Font fontKucuk = new Font("Verdana", system[0].FisYaziBoyut + 6, FontStyle.Bold);
                    Font fontBaslik = new Font("Verdana", system[0].FisYaziBoyut + 7, FontStyle.Bold);
                    StringFormat format = new StringFormat();
                    format.FormatFlags = StringFormatFlags.DirectionRightToLeft;
                    StringFormat sf = new StringFormat();
                    sf.Alignment = StringAlignment.Center;
                    int yPozisyon = 3;
                    float leftMargin = e.MarginBounds.Left;
                    for (int g = yPozisyon; g <= yPozisyon + 15; g++)
                        e.Graphics.DrawLine(pen, 3, g, 200, g);
                    e.Graphics.DrawString(system[0].FirmaAdi, fontBaslik, Brushes.White, leftMargin + 10, yPozisyon, sf);
                    yPozisyon += 16;
                    e.Graphics.DrawString(product[0].StokAdi, fontBuyuk, Brushes.Black, leftMargin, yPozisyon, sf);
                    yPozisyon += (int)fontBaslik.GetHeight(e.Graphics);
                    if (fiyatControl)
                    {
                        for (int k = 3; k <= 200; k++)
                        {
                            if (k == 120 || k == 119)
                                continue;
                            e.Graphics.DrawLine(pen, k, yPozisyon, k, yPozisyon + 15);
                        }
                        e.Graphics.DrawString("Satış Fiyatı:", fontKucuk, Brushes.White, leftMargin - 95, yPozisyon);
                        e.Graphics.DrawString(product[0].SatisFiyat_1.ToString(), fontBuyuk, Brushes.White,
                            leftMargin + 70, yPozisyon, format);
                        e.Graphics.DrawString("₺", fontBuyuk, Brushes.White,
                                leftMargin + 80, yPozisyon, format);
                        yPozisyon += 16;
                        if (kkControl)
                        {
                            for (int j = 3; j <= 200; j++)
                            {
                                if (j == 120 || j == 119)
                                    continue;
                                e.Graphics.DrawLine(pen, j, yPozisyon, j, yPozisyon + 15);
                            }
                            e.Graphics.DrawString("KK. Satış Fiyatı:", fontKucuk, Brushes.White, leftMargin - 95, yPozisyon);
                            e.Graphics.DrawString(product[0].KrediSatisFiyat.ToString(), fontBuyuk, Brushes.White,
                                leftMargin + 70, yPozisyon, format);
                            e.Graphics.DrawString("₺", fontBuyuk, Brushes.White,
                                leftMargin + 80, yPozisyon, format);
                            yPozisyon += (int)fontBaslik.GetHeight(e.Graphics);
                        }

                    }
                    if (barCodeControl)
                    {
                        Image i = pctrBarkod.Image;
                        float newWidth = i.Width * 50 / i.HorizontalResolution;
                        float newHeight = i.Height * 50 / i.VerticalResolution;
                        float widthFactor = newWidth / e.MarginBounds.Width;
                        float heightFactor = newHeight / e.MarginBounds.Height;
                        if (widthFactor > 1 || heightFactor > 1)
                        {
                            if (widthFactor > heightFactor)
                            {
                                newWidth = newWidth / widthFactor;
                                newHeight = newHeight / widthFactor;
                            }
                            else
                            {
                                newWidth = newWidth / heightFactor;
                                newHeight = newHeight / heightFactor;
                            }
                        }
                        e.Graphics.DrawImage(pctrBarkod.Image, leftMargin - 95, yPozisyon + 3, (int)newWidth, (int)newHeight);
                    }
                }
                else if (comboBarkodEtiketTip.SelectedIndex.Equals(1))
                {
                    Pen pen = new Pen(Brushes.Black, 1.5F);
                    Font fontBuyuk = new Font("Verdana", system[0].FisYaziBoyut + 7, FontStyle.Bold);
                    Font fontKucuk = new Font("Verdana", system[0].FisYaziBoyut + 6, FontStyle.Bold);
                    Font fontBaslik = new Font("Verdana", system[0].FisYaziBoyut + 7, FontStyle.Bold);
                    StringFormat format = new StringFormat();
                    format.FormatFlags = StringFormatFlags.DirectionRightToLeft;
                    int yPozisyon = 3;
                    float leftMargin = e.MarginBounds.Left;
                    StringFormat sf = new StringFormat();
                    sf.Alignment = StringAlignment.Center;
                    for (int g = yPozisyon; g <= yPozisyon + 15; g++)
                        e.Graphics.DrawLine(pen, 3, g, 250, g);
                    e.Graphics.DrawString(system[0].FirmaAdi, fontBaslik, Brushes.White, leftMargin + 20, yPozisyon, sf);
                    yPozisyon += 18;
                    e.Graphics.DrawString(product[0].StokAdi, fontBuyuk, Brushes.Black, leftMargin, yPozisyon, sf);
                    yPozisyon += (int)fontBaslik.GetHeight(e.Graphics)+2;
                    if (fiyatControl)
                    {
                        for (int k = 3; k <= 250; k++)
                        {
                            if (k == 140 || k == 139)
                                continue;
                            e.Graphics.DrawLine(pen, k, yPozisyon, k, yPozisyon + 15);
                        }
                        e.Graphics.DrawString("Satış Fiyatı:", fontKucuk, Brushes.White, leftMargin - 95, yPozisyon);
                        e.Graphics.DrawString(product[0].SatisFiyat_1.ToString(), fontBuyuk, Brushes.White,
                            leftMargin + 110, yPozisyon, format);
                        e.Graphics.DrawString("₺", fontBuyuk, Brushes.White,
                                leftMargin + 120, yPozisyon, format);
                        yPozisyon += 17;
                        if (kkControl)
                        {
                            for (int j = 3; j <= 250; j++)
                            {
                                if (j == 140 || j == 139)
                                    continue;
                                e.Graphics.DrawLine(pen, j, yPozisyon, j, yPozisyon + 15);
                            }
                            e.Graphics.DrawString("KK. Satış Fiyatı:", fontKucuk, Brushes.White, leftMargin - 95, yPozisyon);
                            e.Graphics.DrawString(product[0].KrediSatisFiyat.ToString(), fontBuyuk, Brushes.White,
                                leftMargin + 110, yPozisyon, format);
                            e.Graphics.DrawString("₺", fontBuyuk, Brushes.White,
                                leftMargin + 120, yPozisyon, format);
                            yPozisyon += (int)fontBaslik.GetHeight(e.Graphics) + 2;
                        }

                    }
                    if (barCodeControl)
                    {
                        Image i = pctrBarkod.Image;
                        float newWidth = i.Width * 70 / i.HorizontalResolution;
                        float newHeight = i.Height * 60 / i.VerticalResolution;
                        float widthFactor = newWidth / e.MarginBounds.Width;
                        float heightFactor = newHeight / e.MarginBounds.Height;
                        if (widthFactor > 1 || heightFactor > 1)
                        {
                            if (widthFactor > heightFactor)
                            {
                                newWidth = newWidth / widthFactor;
                                newHeight = newHeight / widthFactor;
                            }
                            else
                            {
                                newWidth = newWidth / heightFactor;
                                newHeight = newHeight / heightFactor;
                            }
                        }
                        e.Graphics.DrawImage(pctrBarkod.Image, leftMargin - 95, yPozisyon + 3, (int)newWidth, (int)newHeight);
                    }
                }
                else if (comboBarkodEtiketTip.SelectedIndex.Equals(2))
                {
                    Pen pen = new Pen(Brushes.Black, 1.5F);
                    Font fontBuyuk = new Font("Verdana", system[0].FisYaziBoyut + 54, FontStyle.Bold);
                    Font fontKucuk = new Font("Verdana", system[0].FisYaziBoyut + 13, FontStyle.Regular);
                    Font fontBaslik = new Font("Verdana", system[0].FisYaziBoyut + 24, FontStyle.Bold);
                    Font fontUrun = new Font("Verdana", system[0].FisYaziBoyut + 34, FontStyle.Bold);
                    StringFormat format = new StringFormat();
                    format.FormatFlags = StringFormatFlags.DirectionRightToLeft;
                    int yPozisyon = 50;
                    float leftMargin = e.MarginBounds.Left;
                    StringFormat sf = new StringFormat();
                    sf.Alignment = StringAlignment.Center;
                    for (int g = yPozisyon; g <= yPozisyon + 70; g++)
                        e.Graphics.DrawLine(pen, 10, g, 500, g);
                    e.Graphics.DrawString(system[0].FirmaAdi, fontBaslik, Brushes.White, leftMargin + 150, yPozisyon + 10, sf);
                    yPozisyon += 110;
                    //e.Graphics.DrawString(product[0].StokAdi, fontUrun, Brushes.Black, leftMargin + 120, yPozisyon, sf);
                    string urunAd = product[0].StokAdi;
                    double x = (double)urunAd.Length / 15;
                    int uzunluk = (int)Math.Ceiling(x);
                    for (int i = 0; i < uzunluk; i++)
                    {
                        int y = urunAd.Length - (15 * i);
                        if (y < 0)
                            y = 15 - y;
                        if (y >= 15)
                        {
                            e.Graphics.DrawString(urunAd.Substring(i * 15, 15), fontUrun, Brushes.Black, leftMargin + 150, yPozisyon, sf);
                        }
                        else if (y < 15 && y > 0)
                        {
                            e.Graphics.DrawString(urunAd.Substring(i * 15, y), fontUrun, Brushes.Black, leftMargin + 150, yPozisyon, sf);
                        }
                        else
                            Console.WriteLine("Al sana hataaa!");
                        yPozisyon += (int)fontUrun.GetHeight(e.Graphics);
                    }
                    yPozisyon += 15;
                    for (int k = 10; k <= 500; k++)
                    {
                        e.Graphics.DrawLine(pen, k, yPozisyon, k, yPozisyon + 160);
                    }
                    e.Graphics.DrawString(product[0].SatisFiyat_1.ToString() + "  ₺", fontBuyuk, Brushes.White,
                        leftMargin + 150, yPozisyon + 25, sf);
                    //e.Graphics.DrawString("₺", fontKucuk, Brushes.White,
                    //        leftMargin + 260, yPozisyon + 60, format);
                    yPozisyon += 180;
                    e.Graphics.DrawString(txtBarkod.Text, fontKucuk, Brushes.Black,
                            leftMargin - 50, yPozisyon + 10);
                    e.Graphics.DrawString(DateTime.Now.ToShortDateString(), fontKucuk, Brushes.Black,
                            leftMargin + 350, yPozisyon + 20, format);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKK_T_FiyatGoster_Click(object sender, EventArgs e)
        {
            if (kkControl)
            {
                btnKK_T_FiyatGoster.Image = Properties.Resources.checkBos;
                kkControl = false;
                txtT_KK_FiyatGoster.Enabled = false;
            }
            else
            {
                btnKK_T_FiyatGoster.Image = Properties.Resources.check;
                kkControl = true;
                txtT_KK_FiyatGoster.Enabled = true;
            }
        }

        private void btnEtiketteFiyatGoster_Click(object sender, EventArgs e)
        {
            if (fiyatControl)
            {
                btnEtiketteFiyatGoster.Image = Properties.Resources.checkBos;
                fiyatControl = false;
                comboSatisFiyat.Enabled = false;
            }
            else
            {
                btnEtiketteFiyatGoster.Image = Properties.Resources.check;
                fiyatControl = true;
                comboSatisFiyat.Enabled = true;
            }
        }

        private void btnBarCodeGoster_Click(object sender, EventArgs e)
        {
            if (barCodeControl)
            {
                btnBarCodeGoster.Image = Properties.Resources.checkBos;
                barCodeControl = false;
            }
            else
            {
                btnBarCodeGoster.Image = Properties.Resources.check;
                barCodeControl = true;
            }
        }
        private void btnYaziciSec_Click(object sender, EventArgs e)
        {
            FrmYaziciAyarlari yaziciAyarlari = new FrmYaziciAyarlari();
            yaziciAyarlari.ShowDialog();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
