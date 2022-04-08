
namespace BarkodluOtomasyon
{
    partial class FrmKasaIslemleri
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboKasa = new System.Windows.Forms.ComboBox();
            this.txtKasaDevirTutar = new System.Windows.Forms.TextBox();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.comboAramaOlcut = new System.Windows.Forms.ComboBox();
            this.comboListeTur = new System.Windows.Forms.ComboBox();
            this.dateSon = new System.Windows.Forms.DateTimePicker();
            this.dateBaslangic = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listeKasaIslem = new System.Windows.Forms.DataGridView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.btnListeYazdir = new System.Windows.Forms.Button();
            this.btnAyrintiGör = new System.Windows.Forms.Button();
            this.btnKaydiSil = new System.Windows.Forms.Button();
            this.btnParaCikis = new System.Windows.Forms.Button();
            this.btnParaGiris = new System.Windows.Forms.Button();
            this.btnTarihAra = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listeKasaIslem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Başlangıç Tarih :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTarihAra);
            this.panel1.Controls.Add(this.comboKasa);
            this.panel1.Controls.Add(this.txtKasaDevirTutar);
            this.panel1.Controls.Add(this.txtArama);
            this.panel1.Controls.Add(this.comboAramaOlcut);
            this.panel1.Controls.Add(this.comboListeTur);
            this.panel1.Controls.Add(this.dateSon);
            this.panel1.Controls.Add(this.dateBaslangic);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(842, 100);
            this.panel1.TabIndex = 1;
            // 
            // comboKasa
            // 
            this.comboKasa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboKasa.FormattingEnabled = true;
            this.comboKasa.Items.AddRange(new object[] {
            "Kasa-1",
            "Kasa-2"});
            this.comboKasa.Location = new System.Drawing.Point(127, 67);
            this.comboKasa.Name = "comboKasa";
            this.comboKasa.Size = new System.Drawing.Size(105, 22);
            this.comboKasa.TabIndex = 5;
            this.comboKasa.SelectedIndexChanged += new System.EventHandler(this.comboKasa_SelectedIndexChanged);
            // 
            // txtKasaDevirTutar
            // 
            this.txtKasaDevirTutar.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKasaDevirTutar.Location = new System.Drawing.Point(623, 42);
            this.txtKasaDevirTutar.Name = "txtKasaDevirTutar";
            this.txtKasaDevirTutar.ReadOnly = true;
            this.txtKasaDevirTutar.Size = new System.Drawing.Size(201, 36);
            this.txtKasaDevirTutar.TabIndex = 4;
            this.txtKasaDevirTutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtArama
            // 
            this.txtArama.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtArama.Location = new System.Drawing.Point(342, 66);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(246, 23);
            this.txtArama.TabIndex = 3;
            this.txtArama.Text = "Aramak İçin Yazınız...";
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            this.txtArama.Enter += new System.EventHandler(this.txtArama_Enter);
            // 
            // comboAramaOlcut
            // 
            this.comboAramaOlcut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAramaOlcut.FormattingEnabled = true;
            this.comboAramaOlcut.Items.AddRange(new object[] {
            "Fiş/İşlem No\'ya Göre ",
            "Açıklamaya Göre "});
            this.comboAramaOlcut.Location = new System.Drawing.Point(401, 38);
            this.comboAramaOlcut.Name = "comboAramaOlcut";
            this.comboAramaOlcut.Size = new System.Drawing.Size(187, 22);
            this.comboAramaOlcut.TabIndex = 2;
            // 
            // comboListeTur
            // 
            this.comboListeTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboListeTur.FormattingEnabled = true;
            this.comboListeTur.Items.AddRange(new object[] {
            "Tüm Kayıtlar ",
            "Giren Kayıtlar",
            "Çıkan Kayıtlar",
            "Nakit Satışlar",
            "POS Satışlar"});
            this.comboListeTur.Location = new System.Drawing.Point(401, 10);
            this.comboListeTur.Name = "comboListeTur";
            this.comboListeTur.Size = new System.Drawing.Size(187, 22);
            this.comboListeTur.TabIndex = 2;
            this.comboListeTur.SelectedIndexChanged += new System.EventHandler(this.comboListeTur_SelectedIndexChanged);
            // 
            // dateSon
            // 
            this.dateSon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateSon.Location = new System.Drawing.Point(127, 38);
            this.dateSon.Name = "dateSon";
            this.dateSon.Size = new System.Drawing.Size(105, 22);
            this.dateSon.TabIndex = 1;
            // 
            // dateBaslangic
            // 
            this.dateBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateBaslangic.Location = new System.Drawing.Point(127, 7);
            this.dateBaslangic.Name = "dateBaslangic";
            this.dateBaslangic.Size = new System.Drawing.Size(105, 22);
            this.dateBaslangic.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 14);
            this.label6.TabIndex = 0;
            this.label6.Text = "Kasa :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "Son Tarih :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(641, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "KASA DEVİR TUTARI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(297, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 14);
            this.label4.TabIndex = 0;
            this.label4.Text = "Arama Ölçütü :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "Liste Türü :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listeKasaIslem);
            this.panel2.Location = new System.Drawing.Point(13, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(842, 297);
            this.panel2.TabIndex = 2;
            // 
            // listeKasaIslem
            // 
            this.listeKasaIslem.AllowUserToAddRows = false;
            this.listeKasaIslem.AllowUserToDeleteRows = false;
            this.listeKasaIslem.AllowUserToResizeRows = false;
            this.listeKasaIslem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listeKasaIslem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listeKasaIslem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listeKasaIslem.Location = new System.Drawing.Point(0, 0);
            this.listeKasaIslem.MultiSelect = false;
            this.listeKasaIslem.Name = "listeKasaIslem";
            this.listeKasaIslem.ReadOnly = true;
            this.listeKasaIslem.RowHeadersVisible = false;
            this.listeKasaIslem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listeKasaIslem.Size = new System.Drawing.Size(842, 297);
            this.listeKasaIslem.TabIndex = 3;
            this.listeKasaIslem.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listeKasaIslem_MouseDoubleClick);
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // btnListeYazdir
            // 
            this.btnListeYazdir.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListeYazdir.Image = global::BarkodluOtomasyon.Properties.Resources.printer;
            this.btnListeYazdir.Location = new System.Drawing.Point(677, 423);
            this.btnListeYazdir.Name = "btnListeYazdir";
            this.btnListeYazdir.Size = new System.Drawing.Size(178, 42);
            this.btnListeYazdir.TabIndex = 3;
            this.btnListeYazdir.Text = "LİSTEYİ YAZDIR";
            this.btnListeYazdir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListeYazdir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListeYazdir.UseVisualStyleBackColor = true;
            this.btnListeYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // btnAyrintiGör
            // 
            this.btnAyrintiGör.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAyrintiGör.Image = global::BarkodluOtomasyon.Properties.Resources.refinement;
            this.btnAyrintiGör.Location = new System.Drawing.Point(511, 423);
            this.btnAyrintiGör.Name = "btnAyrintiGör";
            this.btnAyrintiGör.Size = new System.Drawing.Size(160, 42);
            this.btnAyrintiGör.TabIndex = 3;
            this.btnAyrintiGör.Text = "AYRINTI GÖR";
            this.btnAyrintiGör.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAyrintiGör.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAyrintiGör.UseVisualStyleBackColor = true;
            this.btnAyrintiGör.Click += new System.EventHandler(this.btnAyrintiGör_Click);
            // 
            // btnKaydiSil
            // 
            this.btnKaydiSil.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydiSil.Image = global::BarkodluOtomasyon.Properties.Resources.delete__1_;
            this.btnKaydiSil.Location = new System.Drawing.Point(345, 423);
            this.btnKaydiSil.Name = "btnKaydiSil";
            this.btnKaydiSil.Size = new System.Drawing.Size(160, 42);
            this.btnKaydiSil.TabIndex = 3;
            this.btnKaydiSil.Text = "KAYDI SİL";
            this.btnKaydiSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKaydiSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKaydiSil.UseVisualStyleBackColor = true;
            this.btnKaydiSil.Click += new System.EventHandler(this.btnKaydiSil_Click);
            // 
            // btnParaCikis
            // 
            this.btnParaCikis.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnParaCikis.Image = global::BarkodluOtomasyon.Properties.Resources.outcome;
            this.btnParaCikis.Location = new System.Drawing.Point(179, 423);
            this.btnParaCikis.Name = "btnParaCikis";
            this.btnParaCikis.Size = new System.Drawing.Size(160, 42);
            this.btnParaCikis.TabIndex = 3;
            this.btnParaCikis.Text = "PARA ÇIKIŞI";
            this.btnParaCikis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnParaCikis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnParaCikis.UseVisualStyleBackColor = true;
            this.btnParaCikis.Click += new System.EventHandler(this.btnParaCikis_Click);
            // 
            // btnParaGiris
            // 
            this.btnParaGiris.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnParaGiris.Image = global::BarkodluOtomasyon.Properties.Resources.income;
            this.btnParaGiris.Location = new System.Drawing.Point(13, 423);
            this.btnParaGiris.Name = "btnParaGiris";
            this.btnParaGiris.Size = new System.Drawing.Size(160, 42);
            this.btnParaGiris.TabIndex = 3;
            this.btnParaGiris.Text = "PARA GİRİŞİ";
            this.btnParaGiris.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnParaGiris.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnParaGiris.UseVisualStyleBackColor = true;
            this.btnParaGiris.Click += new System.EventHandler(this.btnParaGiris_Click);
            // 
            // btnTarihAra
            // 
            this.btnTarihAra.Image = global::BarkodluOtomasyon.Properties.Resources.magnifying_glass__1_;
            this.btnTarihAra.Location = new System.Drawing.Point(236, 7);
            this.btnTarihAra.Name = "btnTarihAra";
            this.btnTarihAra.Size = new System.Drawing.Size(39, 53);
            this.btnTarihAra.TabIndex = 6;
            this.btnTarihAra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTarihAra.UseVisualStyleBackColor = true;
            this.btnTarihAra.Click += new System.EventHandler(this.btnTarihAra_Click);
            // 
            // FrmKasaIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 474);
            this.Controls.Add(this.btnListeYazdir);
            this.Controls.Add(this.btnAyrintiGör);
            this.Controls.Add(this.btnKaydiSil);
            this.Controls.Add(this.btnParaCikis);
            this.Controls.Add(this.btnParaGiris);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmKasaIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kasa İşlemleri";
            this.Load += new System.EventHandler(this.FrmKasaIslemleri_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listeKasaIslem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboKasa;
        private System.Windows.Forms.TextBox txtKasaDevirTutar;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.ComboBox comboAramaOlcut;
        private System.Windows.Forms.ComboBox comboListeTur;
        private System.Windows.Forms.DateTimePicker dateSon;
        private System.Windows.Forms.DateTimePicker dateBaslangic;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnParaGiris;
        private System.Windows.Forms.Button btnParaCikis;
        private System.Windows.Forms.Button btnKaydiSil;
        private System.Windows.Forms.Button btnAyrintiGör;
        private System.Windows.Forms.Button btnListeYazdir;
        private System.Windows.Forms.DataGridView listeKasaIslem;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button btnTarihAra;
    }
}