
namespace BarkodluOtomasyon
{
    partial class FrmBarcodeBas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBarkodEtiketTip = new System.Windows.Forms.ComboBox();
            this.comboBarkodTuru = new System.Windows.Forms.ComboBox();
            this.comboSatisFiyat = new System.Windows.Forms.ComboBox();
            this.txtT_KK_FiyatGoster = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBasilacakTur = new System.Windows.Forms.ComboBox();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.btnBarCodeGoster = new System.Windows.Forms.Button();
            this.pctrBarkod = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnYaziciSec = new System.Windows.Forms.Button();
            this.btnBarkodBas = new System.Windows.Forms.Button();
            this.btnKK_T_FiyatGoster = new System.Windows.Forms.Button();
            this.btnEtiketteFiyatGoster = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBarkod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Barkod Etiket Tipi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "Barkod Türü :";
            // 
            // comboBarkodEtiketTip
            // 
            this.comboBarkodEtiketTip.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBarkodEtiketTip.FormattingEnabled = true;
            this.comboBarkodEtiketTip.Items.AddRange(new object[] {
            "Ürün Raf Etiket 50 mm x 25 mm",
            "Ürün Raf Etiket 60 mm x 40 mm",
            "Ürün Etiket 145 mm x 210 mm (A5 Boyut)"});
            this.comboBarkodEtiketTip.Location = new System.Drawing.Point(209, 15);
            this.comboBarkodEtiketTip.Name = "comboBarkodEtiketTip";
            this.comboBarkodEtiketTip.Size = new System.Drawing.Size(379, 24);
            this.comboBarkodEtiketTip.TabIndex = 7;
            // 
            // comboBarkodTuru
            // 
            this.comboBarkodTuru.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBarkodTuru.FormattingEnabled = true;
            this.comboBarkodTuru.Items.AddRange(new object[] {
            "Code-93",
            "Code-128",
            "Code-39",
            "Code-11",
            "EAN-13"});
            this.comboBarkodTuru.Location = new System.Drawing.Point(209, 50);
            this.comboBarkodTuru.Name = "comboBarkodTuru";
            this.comboBarkodTuru.Size = new System.Drawing.Size(242, 24);
            this.comboBarkodTuru.TabIndex = 8;
            // 
            // comboSatisFiyat
            // 
            this.comboSatisFiyat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboSatisFiyat.FormattingEnabled = true;
            this.comboSatisFiyat.Items.AddRange(new object[] {
            "Satış Fiyatı 1",
            "Satış Fiyatı 2",
            "Satış Fiyatı 3"});
            this.comboSatisFiyat.Location = new System.Drawing.Point(247, 97);
            this.comboSatisFiyat.Name = "comboSatisFiyat";
            this.comboSatisFiyat.Size = new System.Drawing.Size(204, 24);
            this.comboSatisFiyat.TabIndex = 8;
            // 
            // txtT_KK_FiyatGoster
            // 
            this.txtT_KK_FiyatGoster.Enabled = false;
            this.txtT_KK_FiyatGoster.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtT_KK_FiyatGoster.Location = new System.Drawing.Point(247, 146);
            this.txtT_KK_FiyatGoster.Name = "txtT_KK_FiyatGoster";
            this.txtT_KK_FiyatGoster.Size = new System.Drawing.Size(204, 23);
            this.txtT_KK_FiyatGoster.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(12, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 53);
            this.button2.TabIndex = 6;
            this.button2.Text = "Basılacak Barkod >>";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBasilacakTur
            // 
            this.comboBasilacakTur.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBasilacakTur.FormattingEnabled = true;
            this.comboBasilacakTur.Items.AddRange(new object[] {
            "Ürün Kodu (Barkod)"});
            this.comboBasilacakTur.Location = new System.Drawing.Point(209, 185);
            this.comboBasilacakTur.Name = "comboBasilacakTur";
            this.comboBasilacakTur.Size = new System.Drawing.Size(182, 24);
            this.comboBasilacakTur.TabIndex = 8;
            // 
            // txtBarkod
            // 
            this.txtBarkod.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBarkod.Location = new System.Drawing.Point(209, 215);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(182, 23);
            this.txtBarkod.TabIndex = 9;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.AllowCurrentPage = true;
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // btnBarCodeGoster
            // 
            this.btnBarCodeGoster.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBarCodeGoster.Image = global::BarkodluOtomasyon.Properties.Resources.checkBos;
            this.btnBarCodeGoster.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBarCodeGoster.Location = new System.Drawing.Point(12, 262);
            this.btnBarCodeGoster.Name = "btnBarCodeGoster";
            this.btnBarCodeGoster.Size = new System.Drawing.Size(191, 43);
            this.btnBarCodeGoster.TabIndex = 12;
            this.btnBarCodeGoster.Text = "      BarCodeGöster";
            this.btnBarCodeGoster.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBarCodeGoster.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBarCodeGoster.UseVisualStyleBackColor = true;
            this.btnBarCodeGoster.Click += new System.EventHandler(this.btnBarCodeGoster_Click);
            // 
            // pctrBarkod
            // 
            this.pctrBarkod.Location = new System.Drawing.Point(83, 263);
            this.pctrBarkod.Name = "pctrBarkod";
            this.pctrBarkod.Size = new System.Drawing.Size(258, 46);
            this.pctrBarkod.TabIndex = 11;
            this.pctrBarkod.TabStop = false;
            this.pctrBarkod.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BarkodluOtomasyon.Properties.Resources.barcode_reader_128x128_32;
            this.pictureBox1.Location = new System.Drawing.Point(458, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnKapat
            // 
            this.btnKapat.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.Image = global::BarkodluOtomasyon.Properties.Resources.multiply;
            this.btnKapat.Location = new System.Drawing.Point(457, 256);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(131, 53);
            this.btnKapat.TabIndex = 6;
            this.btnKapat.Text = "KAPAT";
            this.btnKapat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKapat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnYaziciSec
            // 
            this.btnYaziciSec.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYaziciSec.Image = global::BarkodluOtomasyon.Properties.Resources.printersetting;
            this.btnYaziciSec.Location = new System.Drawing.Point(277, 256);
            this.btnYaziciSec.Name = "btnYaziciSec";
            this.btnYaziciSec.Size = new System.Drawing.Size(174, 53);
            this.btnYaziciSec.TabIndex = 6;
            this.btnYaziciSec.Text = "YAZICI SEÇ";
            this.btnYaziciSec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYaziciSec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnYaziciSec.UseVisualStyleBackColor = true;
            this.btnYaziciSec.Click += new System.EventHandler(this.btnYaziciSec_Click);
            // 
            // btnBarkodBas
            // 
            this.btnBarkodBas.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBarkodBas.Image = global::BarkodluOtomasyon.Properties.Resources.product_development;
            this.btnBarkodBas.Location = new System.Drawing.Point(397, 185);
            this.btnBarkodBas.Name = "btnBarkodBas";
            this.btnBarkodBas.Size = new System.Drawing.Size(191, 53);
            this.btnBarkodBas.TabIndex = 6;
            this.btnBarkodBas.Text = "ETİKET BAS";
            this.btnBarkodBas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBarkodBas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBarkodBas.UseVisualStyleBackColor = true;
            this.btnBarkodBas.Click += new System.EventHandler(this.btnBarkodBas_Click);
            // 
            // btnKK_T_FiyatGoster
            // 
            this.btnKK_T_FiyatGoster.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKK_T_FiyatGoster.Image = global::BarkodluOtomasyon.Properties.Resources.checkBos;
            this.btnKK_T_FiyatGoster.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKK_T_FiyatGoster.Location = new System.Drawing.Point(12, 136);
            this.btnKK_T_FiyatGoster.Name = "btnKK_T_FiyatGoster";
            this.btnKK_T_FiyatGoster.Size = new System.Drawing.Size(229, 43);
            this.btnKK_T_FiyatGoster.TabIndex = 6;
            this.btnKK_T_FiyatGoster.Text = "K.Kartı/Taksitli Fiyat Göster";
            this.btnKK_T_FiyatGoster.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKK_T_FiyatGoster.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKK_T_FiyatGoster.UseVisualStyleBackColor = true;
            this.btnKK_T_FiyatGoster.Click += new System.EventHandler(this.btnKK_T_FiyatGoster_Click);
            // 
            // btnEtiketteFiyatGoster
            // 
            this.btnEtiketteFiyatGoster.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEtiketteFiyatGoster.Image = global::BarkodluOtomasyon.Properties.Resources.checkBos;
            this.btnEtiketteFiyatGoster.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEtiketteFiyatGoster.Location = new System.Drawing.Point(12, 87);
            this.btnEtiketteFiyatGoster.Name = "btnEtiketteFiyatGoster";
            this.btnEtiketteFiyatGoster.Size = new System.Drawing.Size(229, 43);
            this.btnEtiketteFiyatGoster.TabIndex = 6;
            this.btnEtiketteFiyatGoster.Text = "Etikette Fiyat Göster";
            this.btnEtiketteFiyatGoster.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEtiketteFiyatGoster.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEtiketteFiyatGoster.UseVisualStyleBackColor = true;
            this.btnEtiketteFiyatGoster.Click += new System.EventHandler(this.btnEtiketteFiyatGoster_Click);
            // 
            // FrmBarcodeBas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 323);
            this.Controls.Add(this.btnBarCodeGoster);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtBarkod);
            this.Controls.Add(this.txtT_KK_FiyatGoster);
            this.Controls.Add(this.comboBasilacakTur);
            this.Controls.Add(this.comboSatisFiyat);
            this.Controls.Add(this.comboBarkodTuru);
            this.Controls.Add(this.comboBarkodEtiketTip);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnYaziciSec);
            this.Controls.Add(this.btnBarkodBas);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnKK_T_FiyatGoster);
            this.Controls.Add(this.btnEtiketteFiyatGoster);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pctrBarkod);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmBarcodeBas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barkod Bas";
            this.Load += new System.EventHandler(this.FrmBarcodeBas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctrBarkod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEtiketteFiyatGoster;
        private System.Windows.Forms.Button btnKK_T_FiyatGoster;
        private System.Windows.Forms.ComboBox comboBarkodEtiketTip;
        private System.Windows.Forms.ComboBox comboBarkodTuru;
        private System.Windows.Forms.ComboBox comboSatisFiyat;
        private System.Windows.Forms.TextBox txtT_KK_FiyatGoster;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBasilacakTur;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.Button btnBarkodBas;
        private System.Windows.Forms.Button btnYaziciSec;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pctrBarkod;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button btnBarCodeGoster;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}