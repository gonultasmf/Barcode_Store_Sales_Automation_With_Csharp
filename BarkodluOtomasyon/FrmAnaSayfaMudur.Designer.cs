
using System.ComponentModel;
using System.Resources;
using System.Windows.Forms;

namespace BarkodluOtomasyon
{
    partial class FrmAnaSayfaMudur
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
            this.components = new System.ComponentModel.Container();
            this.kullanımKılavuzuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aktivasyonToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKasaFiyat = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnUrunBul = new System.Windows.Forms.Button();
            this.btnKlavye = new System.Windows.Forms.Button();
            this.txtEldenBarkod = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblSirketAdi = new System.Windows.Forms.Label();
            this.comboKasaNo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboIslemYapan = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listSatis = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pctrFisYaz = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIndirimliSatis = new System.Windows.Forms.Button();
            this.btnVeresiyeSatis = new System.Windows.Forms.Button();
            this.btnNakitKrediSatis = new System.Windows.Forms.Button();
            this.btnKrediSatis = new System.Windows.Forms.Button();
            this.btnNakitSatis = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnFiyatEkle = new System.Windows.Forms.Button();
            this.txtParaUstu = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnSeriSatis = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn20 = new System.Windows.Forms.Button();
            this.btn50 = new System.Windows.Forms.Button();
            this.btn100 = new System.Windows.Forms.Button();
            this.btn200 = new System.Windows.Forms.Button();
            this.comboUygulanacakFiyat = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnIslemIptal = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblZaman = new System.Windows.Forms.Label();
            this.btnUrunIade = new System.Windows.Forms.Button();
            this.btnFiyatGor = new System.Windows.Forms.Button();
            this.btnMusteriSec = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAlinanPara = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mÜŞTERİİŞLEMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sTOKİŞLEMToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.kASAİŞLEMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rAPORLARToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.stokRaporuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelRaporuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satışRaporuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iadeİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sEÇENEKLERToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.kategoriİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.birimİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tedarikçiİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriGrupİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.işçiİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aYARLARToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.alarmAyarlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemAyarlarıToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.yazıcıAyarlarıToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sMSAyarlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mailAyarlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veriTabanıAyarlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dilAyarlarıToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.yARDIMToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.geriBildirimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.aciklama = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listSatis)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrFisYaz)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kullanımKılavuzuToolStripMenuItem1
            // 
            this.kullanımKılavuzuToolStripMenuItem1.Image = global::BarkodluOtomasyon.Properties.Resources.info;
            this.kullanımKılavuzuToolStripMenuItem1.Name = "kullanımKılavuzuToolStripMenuItem1";
            this.kullanımKılavuzuToolStripMenuItem1.Size = new System.Drawing.Size(179, 22);
            this.kullanımKılavuzuToolStripMenuItem1.Text = "Kullanım Kılavuzu";
            this.kullanımKılavuzuToolStripMenuItem1.Click += new System.EventHandler(this.kullanımKılavuzuToolStripMenuItem1_Click);
            // 
            // aktivasyonToolStripMenuItem1
            // 
            this.aktivasyonToolStripMenuItem1.Image = global::BarkodluOtomasyon.Properties.Resources.key;
            this.aktivasyonToolStripMenuItem1.Name = "aktivasyonToolStripMenuItem1";
            this.aktivasyonToolStripMenuItem1.Size = new System.Drawing.Size(179, 22);
            this.aktivasyonToolStripMenuItem1.Text = "Aktivasyon";
            this.aktivasyonToolStripMenuItem1.Click += new System.EventHandler(this.aktivasyonToolStripMenuItem1_Click);
            // 
            // hakkındaToolStripMenuItem1
            // 
            this.hakkındaToolStripMenuItem1.Image = global::BarkodluOtomasyon.Properties.Resources.info__1_;
            this.hakkındaToolStripMenuItem1.Name = "hakkındaToolStripMenuItem1";
            this.hakkındaToolStripMenuItem1.Size = new System.Drawing.Size(179, 22);
            this.hakkındaToolStripMenuItem1.Text = "Hakkında";
            this.hakkındaToolStripMenuItem1.Click += new System.EventHandler(this.hakkındaToolStripMenuItem1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(728, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "   KASA  TOPLAM ";
            // 
            // txtKasaFiyat
            // 
            this.txtKasaFiyat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKasaFiyat.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtKasaFiyat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKasaFiyat.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKasaFiyat.ForeColor = System.Drawing.Color.Lime;
            this.txtKasaFiyat.Location = new System.Drawing.Point(814, 5);
            this.txtKasaFiyat.Name = "txtKasaFiyat";
            this.txtKasaFiyat.ReadOnly = true;
            this.txtKasaFiyat.Size = new System.Drawing.Size(194, 52);
            this.txtKasaFiyat.TabIndex = 2;
            this.txtKasaFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtKasaFiyat.TextChanged += new System.EventHandler(this.txtKasaFiyat_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnEkle);
            this.panel1.Controls.Add(this.btnUrunBul);
            this.panel1.Controls.Add(this.btnKlavye);
            this.panel1.Controls.Add(this.txtEldenBarkod);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.comboKasaNo);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.comboIslemYapan);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(12, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 66);
            this.panel1.TabIndex = 3;
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Image = global::BarkodluOtomasyon.Properties.Resources.checkmark;
            this.btnEkle.Location = new System.Drawing.Point(48, 35);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(161, 28);
            this.btnEkle.TabIndex = 18;
            this.btnEkle.Text = "EKLE (ENTER)";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnUrunBul
            // 
            this.btnUrunBul.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUrunBul.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunBul.Image = global::BarkodluOtomasyon.Properties.Resources.refinement;
            this.btnUrunBul.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUrunBul.Location = new System.Drawing.Point(381, 8);
            this.btnUrunBul.Name = "btnUrunBul";
            this.btnUrunBul.Size = new System.Drawing.Size(41, 50);
            this.btnUrunBul.TabIndex = 17;
            this.btnUrunBul.Tag = "";
            this.btnUrunBul.UseVisualStyleBackColor = true;
            this.btnUrunBul.Click += new System.EventHandler(this.btnUrunBul_Click);
            // 
            // btnKlavye
            // 
            this.btnKlavye.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKlavye.Image = global::BarkodluOtomasyon.Properties.Resources.dial__1_;
            this.btnKlavye.Location = new System.Drawing.Point(3, 4);
            this.btnKlavye.Name = "btnKlavye";
            this.btnKlavye.Size = new System.Drawing.Size(43, 59);
            this.btnKlavye.TabIndex = 16;
            this.btnKlavye.Tag = "";
            this.btnKlavye.UseVisualStyleBackColor = true;
            this.btnKlavye.Click += new System.EventHandler(this.btnKlavye_Click);
            // 
            // txtEldenBarkod
            // 
            this.txtEldenBarkod.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEldenBarkod.Location = new System.Drawing.Point(48, 4);
            this.txtEldenBarkod.MaxLength = 13;
            this.txtEldenBarkod.Name = "txtEldenBarkod";
            this.txtEldenBarkod.Size = new System.Drawing.Size(161, 28);
            this.txtEldenBarkod.TabIndex = 14;
            this.txtEldenBarkod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEldenBarkod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEldenBarkod_KeyDown);
            this.txtEldenBarkod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEldenBarkod_KeyPress);
            this.txtEldenBarkod.Leave += new System.EventHandler(this.txtEldenBarkod_Leave);
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.Controls.Add(this.lblSirketAdi);
            this.panel7.Location = new System.Drawing.Point(213, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(165, 59);
            this.panel7.TabIndex = 13;
            // 
            // lblSirketAdi
            // 
            this.lblSirketAdi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSirketAdi.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSirketAdi.Location = new System.Drawing.Point(2, 4);
            this.lblSirketAdi.Name = "lblSirketAdi";
            this.lblSirketAdi.Size = new System.Drawing.Size(160, 52);
            this.lblSirketAdi.TabIndex = 3;
            this.lblSirketAdi.Text = "DRAHNASOFT";
            this.lblSirketAdi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboKasaNo
            // 
            this.comboKasaNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboKasaNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboKasaNo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboKasaNo.FormattingEnabled = true;
            this.comboKasaNo.Items.AddRange(new object[] {
            "Kasa-1",
            "Kasa-2"});
            this.comboKasaNo.Location = new System.Drawing.Point(511, 36);
            this.comboKasaNo.Name = "comboKasaNo";
            this.comboKasaNo.Size = new System.Drawing.Size(155, 24);
            this.comboKasaNo.TabIndex = 12;
            this.comboKasaNo.Click += new System.EventHandler(this.comboKasaNo_Click);
            this.comboKasaNo.Leave += new System.EventHandler(this.comboIslemYapan_Leave);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(450, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "KASA NO :";
            // 
            // comboIslemYapan
            // 
            this.comboIslemYapan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboIslemYapan.Enabled = false;
            this.comboIslemYapan.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboIslemYapan.FormattingEnabled = true;
            this.comboIslemYapan.Items.AddRange(new object[] {
            "Müdür"});
            this.comboIslemYapan.Location = new System.Drawing.Point(511, 5);
            this.comboIslemYapan.Name = "comboIslemYapan";
            this.comboIslemYapan.Size = new System.Drawing.Size(155, 24);
            this.comboIslemYapan.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(424, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "İŞLEM YAPAN :";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.listSatis);
            this.panel2.Location = new System.Drawing.Point(13, 134);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(670, 374);
            this.panel2.TabIndex = 4;
            // 
            // listSatis
            // 
            this.listSatis.AllowUserToAddRows = false;
            this.listSatis.AllowUserToResizeRows = false;
            this.listSatis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listSatis.ColumnHeadersHeight = 40;
            this.listSatis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listSatis.Location = new System.Drawing.Point(0, 0);
            this.listSatis.MultiSelect = false;
            this.listSatis.Name = "listSatis";
            this.listSatis.ReadOnly = true;
            this.listSatis.RowHeadersVisible = false;
            this.listSatis.RowHeadersWidth = 20;
            this.listSatis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listSatis.Size = new System.Drawing.Size(670, 374);
            this.listSatis.TabIndex = 8;
            this.listSatis.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.listSatis_CellMouseDoubleClick);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.btnIndirimliSatis);
            this.panel3.Controls.Add(this.btnVeresiyeSatis);
            this.panel3.Controls.Add(this.btnNakitKrediSatis);
            this.panel3.Controls.Add(this.btnKrediSatis);
            this.panel3.Controls.Add(this.btnNakitSatis);
            this.panel3.Location = new System.Drawing.Point(14, 520);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(670, 110);
            this.panel3.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(470, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 16);
            this.label12.TabIndex = 27;
            this.label12.Text = "F6";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(353, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 16);
            this.label11.TabIndex = 27;
            this.label11.Text = "F8";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(238, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "F10";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(122, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "F12";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(7, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "F11";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.pctrFisYaz);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(582, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(79, 100);
            this.panel4.TabIndex = 28;
            // 
            // pctrFisYaz
            // 
            this.pctrFisYaz.Image = global::BarkodluOtomasyon.Properties.Resources.controlson;
            this.pctrFisYaz.Location = new System.Drawing.Point(4, 43);
            this.pctrFisYaz.Name = "pctrFisYaz";
            this.pctrFisYaz.Size = new System.Drawing.Size(72, 40);
            this.pctrFisYaz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrFisYaz.TabIndex = 3;
            this.pctrFisYaz.TabStop = false;
            this.pctrFisYaz.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(20, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "FİŞ";
            // 
            // btnIndirimliSatis
            // 
            this.btnIndirimliSatis.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIndirimliSatis.Image = global::BarkodluOtomasyon.Properties.Resources.offer;
            this.btnIndirimliSatis.Location = new System.Drawing.Point(467, 6);
            this.btnIndirimliSatis.Name = "btnIndirimliSatis";
            this.btnIndirimliSatis.Size = new System.Drawing.Size(110, 100);
            this.btnIndirimliSatis.TabIndex = 0;
            this.btnIndirimliSatis.Text = "İndirimli Satış";
            this.btnIndirimliSatis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnIndirimliSatis.UseVisualStyleBackColor = true;
            this.btnIndirimliSatis.Click += new System.EventHandler(this.btnIndirimliSatis_Click);
            // 
            // btnVeresiyeSatis
            // 
            this.btnVeresiyeSatis.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVeresiyeSatis.Image = global::BarkodluOtomasyon.Properties.Resources.list;
            this.btnVeresiyeSatis.Location = new System.Drawing.Point(351, 6);
            this.btnVeresiyeSatis.Name = "btnVeresiyeSatis";
            this.btnVeresiyeSatis.Size = new System.Drawing.Size(110, 100);
            this.btnVeresiyeSatis.TabIndex = 0;
            this.btnVeresiyeSatis.Text = "Veresiye Satış";
            this.btnVeresiyeSatis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVeresiyeSatis.UseVisualStyleBackColor = true;
            this.btnVeresiyeSatis.Click += new System.EventHandler(this.btnVeresiyeSatis_Click);
            // 
            // btnNakitKrediSatis
            // 
            this.btnNakitKrediSatis.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNakitKrediSatis.Image = global::BarkodluOtomasyon.Properties.Resources.money;
            this.btnNakitKrediSatis.Location = new System.Drawing.Point(235, 6);
            this.btnNakitKrediSatis.Name = "btnNakitKrediSatis";
            this.btnNakitKrediSatis.Size = new System.Drawing.Size(110, 100);
            this.btnNakitKrediSatis.TabIndex = 0;
            this.btnNakitKrediSatis.Text = "Nakit ve POS Satış";
            this.btnNakitKrediSatis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNakitKrediSatis.UseVisualStyleBackColor = true;
            this.btnNakitKrediSatis.Click += new System.EventHandler(this.btnNakitKrediSatis_Click);
            // 
            // btnKrediSatis
            // 
            this.btnKrediSatis.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKrediSatis.Image = global::BarkodluOtomasyon.Properties.Resources.credit_card_machine;
            this.btnKrediSatis.Location = new System.Drawing.Point(119, 6);
            this.btnKrediSatis.Name = "btnKrediSatis";
            this.btnKrediSatis.Size = new System.Drawing.Size(110, 100);
            this.btnKrediSatis.TabIndex = 0;
            this.btnKrediSatis.Text = "Kredi Kartı Satış";
            this.btnKrediSatis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnKrediSatis.UseVisualStyleBackColor = true;
            this.btnKrediSatis.Click += new System.EventHandler(this.btnKrediSatis_Click);
            // 
            // btnNakitSatis
            // 
            this.btnNakitSatis.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNakitSatis.Image = global::BarkodluOtomasyon.Properties.Resources.payment__1_;
            this.btnNakitSatis.Location = new System.Drawing.Point(3, 6);
            this.btnNakitSatis.Name = "btnNakitSatis";
            this.btnNakitSatis.Size = new System.Drawing.Size(110, 100);
            this.btnNakitSatis.TabIndex = 0;
            this.btnNakitSatis.Text = "Nakit Satış";
            this.btnNakitSatis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNakitSatis.UseVisualStyleBackColor = true;
            this.btnNakitSatis.Click += new System.EventHandler(this.btnNakitSatis_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.btnFiyatEkle);
            this.panel5.Controls.Add(this.txtParaUstu);
            this.panel5.Controls.Add(this.label16);
            this.panel5.Controls.Add(this.btnSeriSatis);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.comboUygulanacakFiyat);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.btnIslemIptal);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.btnUrunIade);
            this.panel5.Controls.Add(this.btnFiyatGor);
            this.panel5.Controls.Add(this.btnMusteriSec);
            this.panel5.Controls.Add(this.btnTemizle);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.txtAlinanPara);
            this.panel5.Location = new System.Drawing.Point(690, 61);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(318, 569);
            this.panel5.TabIndex = 6;
            // 
            // btnFiyatEkle
            // 
            this.btnFiyatEkle.Image = global::BarkodluOtomasyon.Properties.Resources.income;
            this.btnFiyatEkle.Location = new System.Drawing.Point(1, 37);
            this.btnFiyatEkle.Name = "btnFiyatEkle";
            this.btnFiyatEkle.Size = new System.Drawing.Size(64, 90);
            this.btnFiyatEkle.TabIndex = 36;
            this.btnFiyatEkle.Text = "FİYAT EKLE (SHİFT)";
            this.btnFiyatEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFiyatEkle.UseVisualStyleBackColor = true;
            this.btnFiyatEkle.Click += new System.EventHandler(this.btnFiyatEkle_Click);
            // 
            // txtParaUstu
            // 
            this.txtParaUstu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtParaUstu.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtParaUstu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtParaUstu.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtParaUstu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtParaUstu.Location = new System.Drawing.Point(151, 94);
            this.txtParaUstu.Name = "txtParaUstu";
            this.txtParaUstu.ReadOnly = true;
            this.txtParaUstu.Size = new System.Drawing.Size(161, 43);
            this.txtParaUstu.TabIndex = 26;
            this.txtParaUstu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(291, 148);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(22, 16);
            this.label16.TabIndex = 35;
            this.label16.Text = "F5";
            // 
            // btnSeriSatis
            // 
            this.btnSeriSatis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSeriSatis.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSeriSatis.Image = global::BarkodluOtomasyon.Properties.Resources.web_browser;
            this.btnSeriSatis.Location = new System.Drawing.Point(153, 146);
            this.btnSeriSatis.Name = "btnSeriSatis";
            this.btnSeriSatis.Size = new System.Drawing.Size(162, 43);
            this.btnSeriSatis.TabIndex = 34;
            this.btnSeriSatis.Text = "SERİ SATIŞ";
            this.btnSeriSatis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSeriSatis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSeriSatis.UseVisualStyleBackColor = true;
            this.btnSeriSatis.Click += new System.EventHandler(this.btnSeriSatis_Click);
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.Controls.Add(this.btn5);
            this.panel8.Controls.Add(this.btn10);
            this.panel8.Controls.Add(this.btn20);
            this.panel8.Controls.Add(this.btn50);
            this.panel8.Controls.Add(this.btn100);
            this.panel8.Controls.Add(this.btn200);
            this.panel8.Location = new System.Drawing.Point(3, 130);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(147, 435);
            this.panel8.TabIndex = 33;
            // 
            // btn5
            // 
            this.btn5.FlatAppearance.BorderSize = 3;
            this.btn5.Image = global::BarkodluOtomasyon.Properties.Resources.Webp_net_resizeimage__8_;
            this.btn5.Location = new System.Drawing.Point(2, 5);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(143, 71);
            this.btn5.TabIndex = 1;
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            this.btn5.MouseLeave += new System.EventHandler(this.btn5_MouseLeave);
            this.btn5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn5_MouseMove);
            // 
            // btn10
            // 
            this.btn10.FlatAppearance.BorderSize = 3;
            this.btn10.Image = global::BarkodluOtomasyon.Properties.Resources.Webp_net_resizeimage__5_;
            this.btn10.Location = new System.Drawing.Point(2, 76);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(143, 71);
            this.btn10.TabIndex = 1;
            this.btn10.UseVisualStyleBackColor = true;
            this.btn10.Click += new System.EventHandler(this.btn10_Click);
            this.btn10.MouseLeave += new System.EventHandler(this.btn10_MouseLeave);
            this.btn10.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn10_MouseMove);
            // 
            // btn20
            // 
            this.btn20.FlatAppearance.BorderSize = 3;
            this.btn20.Image = global::BarkodluOtomasyon.Properties.Resources.Webp_net_resizeimage__4_;
            this.btn20.Location = new System.Drawing.Point(2, 147);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(143, 71);
            this.btn20.TabIndex = 1;
            this.btn20.UseVisualStyleBackColor = true;
            this.btn20.Click += new System.EventHandler(this.btn20_Click);
            this.btn20.MouseLeave += new System.EventHandler(this.btn20_MouseLeave);
            this.btn20.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn20_MouseMove);
            // 
            // btn50
            // 
            this.btn50.FlatAppearance.BorderSize = 3;
            this.btn50.Image = global::BarkodluOtomasyon.Properties.Resources.Webp_net_resizeimage__1_;
            this.btn50.Location = new System.Drawing.Point(2, 218);
            this.btn50.Name = "btn50";
            this.btn50.Size = new System.Drawing.Size(143, 71);
            this.btn50.TabIndex = 1;
            this.btn50.UseVisualStyleBackColor = true;
            this.btn50.Click += new System.EventHandler(this.btn50_Click);
            this.btn50.MouseLeave += new System.EventHandler(this.btn50_MouseLeave);
            this.btn50.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn50_MouseMove);
            // 
            // btn100
            // 
            this.btn100.FlatAppearance.BorderSize = 3;
            this.btn100.Image = global::BarkodluOtomasyon.Properties.Resources.slayt10;
            this.btn100.Location = new System.Drawing.Point(3, 289);
            this.btn100.Name = "btn100";
            this.btn100.Size = new System.Drawing.Size(143, 71);
            this.btn100.TabIndex = 1;
            this.btn100.UseVisualStyleBackColor = true;
            this.btn100.Click += new System.EventHandler(this.btn100_Click);
            this.btn100.MouseLeave += new System.EventHandler(this.btn100_MouseLeave);
            this.btn100.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn100_MouseMove);
            // 
            // btn200
            // 
            this.btn200.FlatAppearance.BorderSize = 3;
            this.btn200.Image = global::BarkodluOtomasyon.Properties.Resources.slayt11;
            this.btn200.Location = new System.Drawing.Point(3, 360);
            this.btn200.Name = "btn200";
            this.btn200.Size = new System.Drawing.Size(143, 71);
            this.btn200.TabIndex = 1;
            this.btn200.UseVisualStyleBackColor = true;
            this.btn200.Click += new System.EventHandler(this.btn200_Click);
            this.btn200.MouseLeave += new System.EventHandler(this.btn200_MouseLeave);
            this.btn200.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn200_MouseMove);
            // 
            // comboUygulanacakFiyat
            // 
            this.comboUygulanacakFiyat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboUygulanacakFiyat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboUygulanacakFiyat.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboUygulanacakFiyat.FormattingEnabled = true;
            this.comboUygulanacakFiyat.Items.AddRange(new object[] {
            "Satış Fiyatı 1",
            "Satış Fiyatı 2",
            "İndirimli Fiyat",
            "Kredi Kart Fiyat"});
            this.comboUygulanacakFiyat.Location = new System.Drawing.Point(151, 8);
            this.comboUygulanacakFiyat.Name = "comboUygulanacakFiyat";
            this.comboUygulanacakFiyat.Size = new System.Drawing.Size(161, 26);
            this.comboUygulanacakFiyat.TabIndex = 32;
            this.comboUygulanacakFiyat.Click += new System.EventHandler(this.comboUygulanacakFiyat_Click);
            this.comboUygulanacakFiyat.Leave += new System.EventHandler(this.comboIslemYapan_Leave);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(22, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "UYGULANACAK FİYAT :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(290, 303);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(22, 16);
            this.label14.TabIndex = 29;
            this.label14.Text = "F7";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(291, 354);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(22, 16);
            this.label13.TabIndex = 28;
            this.label13.Text = "F9";
            // 
            // btnIslemIptal
            // 
            this.btnIslemIptal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIslemIptal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIslemIptal.Image = global::BarkodluOtomasyon.Properties.Resources.multiply;
            this.btnIslemIptal.Location = new System.Drawing.Point(153, 404);
            this.btnIslemIptal.Name = "btnIslemIptal";
            this.btnIslemIptal.Size = new System.Drawing.Size(162, 43);
            this.btnIslemIptal.TabIndex = 27;
            this.btnIslemIptal.Text = "İŞLEM İPTAL";
            this.btnIslemIptal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIslemIptal.UseVisualStyleBackColor = true;
            this.btnIslemIptal.Click += new System.EventHandler(this.btnIslemIptal_Click);
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Controls.Add(this.lblTarih);
            this.panel6.Controls.Add(this.lblZaman);
            this.panel6.Location = new System.Drawing.Point(151, 459);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(161, 107);
            this.panel6.TabIndex = 25;
            // 
            // lblTarih
            // 
            this.lblTarih.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.Location = new System.Drawing.Point(5, 33);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(152, 32);
            this.lblTarih.TabIndex = 14;
            this.lblTarih.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblZaman
            // 
            this.lblZaman.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblZaman.Location = new System.Drawing.Point(5, 4);
            this.lblZaman.Name = "lblZaman";
            this.lblZaman.Size = new System.Drawing.Size(152, 35);
            this.lblZaman.TabIndex = 15;
            this.lblZaman.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUrunIade
            // 
            this.btnUrunIade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUrunIade.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunIade.Image = global::BarkodluOtomasyon.Properties.Resources.product;
            this.btnUrunIade.Location = new System.Drawing.Point(153, 352);
            this.btnUrunIade.Name = "btnUrunIade";
            this.btnUrunIade.Size = new System.Drawing.Size(162, 43);
            this.btnUrunIade.TabIndex = 24;
            this.btnUrunIade.Text = "ÜRÜN İADE";
            this.btnUrunIade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUrunIade.UseVisualStyleBackColor = true;
            this.btnUrunIade.Click += new System.EventHandler(this.btnUrunIade_Click);
            // 
            // btnFiyatGor
            // 
            this.btnFiyatGor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiyatGor.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFiyatGor.Image = global::BarkodluOtomasyon.Properties.Resources.best_price;
            this.btnFiyatGor.Location = new System.Drawing.Point(153, 300);
            this.btnFiyatGor.Name = "btnFiyatGor";
            this.btnFiyatGor.Size = new System.Drawing.Size(162, 43);
            this.btnFiyatGor.TabIndex = 23;
            this.btnFiyatGor.Text = "FİYAT GÖR";
            this.btnFiyatGor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFiyatGor.UseVisualStyleBackColor = true;
            this.btnFiyatGor.Click += new System.EventHandler(this.btnFiyatGor_Click);
            // 
            // btnMusteriSec
            // 
            this.btnMusteriSec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMusteriSec.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriSec.Image = global::BarkodluOtomasyon.Properties.Resources.target;
            this.btnMusteriSec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMusteriSec.Location = new System.Drawing.Point(153, 251);
            this.btnMusteriSec.Name = "btnMusteriSec";
            this.btnMusteriSec.Size = new System.Drawing.Size(162, 43);
            this.btnMusteriSec.TabIndex = 22;
            this.btnMusteriSec.Text = "MÜŞTERİ SEÇ";
            this.btnMusteriSec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMusteriSec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMusteriSec.UseVisualStyleBackColor = true;
            this.btnMusteriSec.Click += new System.EventHandler(this.btnMusteriSec_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTemizle.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Image = global::BarkodluOtomasyon.Properties.Resources.delete__1_;
            this.btnTemizle.Location = new System.Drawing.Point(153, 198);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(162, 43);
            this.btnTemizle.TabIndex = 19;
            this.btnTemizle.Text = " TEMİZLE";
            this.btnTemizle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(74, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "PARA ÜSTÜ :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(63, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "ALINAN PARA :";
            // 
            // txtAlinanPara
            // 
            this.txtAlinanPara.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAlinanPara.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtAlinanPara.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAlinanPara.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAlinanPara.ForeColor = System.Drawing.Color.Yellow;
            this.txtAlinanPara.Location = new System.Drawing.Point(151, 45);
            this.txtAlinanPara.Name = "txtAlinanPara";
            this.txtAlinanPara.ReadOnly = true;
            this.txtAlinanPara.Size = new System.Drawing.Size(161, 43);
            this.txtAlinanPara.TabIndex = 16;
            this.txtAlinanPara.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAlinanPara.Click += new System.EventHandler(this.txtAlinanPara_Click);
            this.txtAlinanPara.TextChanged += new System.EventHandler(this.txtAlinanPara_TextChanged);
            this.txtAlinanPara.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAlinanPara_KeyPress);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mÜŞTERİİŞLEMToolStripMenuItem,
            this.sTOKİŞLEMToolStripMenuItem2,
            this.kASAİŞLEMToolStripMenuItem,
            this.rAPORLARToolStripMenuItem3,
            this.sEÇENEKLERToolStripMenuItem4,
            this.aYARLARToolStripMenuItem4,
            this.yARDIMToolStripMenuItem3});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1014, 56);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mÜŞTERİİŞLEMToolStripMenuItem
            // 
            this.mÜŞTERİİŞLEMToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mÜŞTERİİŞLEMToolStripMenuItem.Image = global::BarkodluOtomasyon.Properties.Resources.inventory;
            this.mÜŞTERİİŞLEMToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mÜŞTERİİŞLEMToolStripMenuItem.Name = "mÜŞTERİİŞLEMToolStripMenuItem";
            this.mÜŞTERİİŞLEMToolStripMenuItem.Size = new System.Drawing.Size(117, 52);
            this.mÜŞTERİİŞLEMToolStripMenuItem.Text = "MÜŞTERİ İŞLEM";
            this.mÜŞTERİİŞLEMToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mÜŞTERİİŞLEMToolStripMenuItem.Click += new System.EventHandler(this.mÜŞTERİİŞLEMToolStripMenuItem_Click);
            // 
            // sTOKİŞLEMToolStripMenuItem2
            // 
            this.sTOKİŞLEMToolStripMenuItem2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sTOKİŞLEMToolStripMenuItem2.Image = global::BarkodluOtomasyon.Properties.Resources.packages;
            this.sTOKİŞLEMToolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sTOKİŞLEMToolStripMenuItem2.Name = "sTOKİŞLEMToolStripMenuItem2";
            this.sTOKİŞLEMToolStripMenuItem2.Size = new System.Drawing.Size(93, 52);
            this.sTOKİŞLEMToolStripMenuItem2.Text = "STOK İŞLEM";
            this.sTOKİŞLEMToolStripMenuItem2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.sTOKİŞLEMToolStripMenuItem2.Click += new System.EventHandler(this.sTOKİŞLEMToolStripMenuItem2_Click);
            // 
            // kASAİŞLEMToolStripMenuItem
            // 
            this.kASAİŞLEMToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kASAİŞLEMToolStripMenuItem.Image = global::BarkodluOtomasyon.Properties.Resources.cash_machine;
            this.kASAİŞLEMToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.kASAİŞLEMToolStripMenuItem.Name = "kASAİŞLEMToolStripMenuItem";
            this.kASAİŞLEMToolStripMenuItem.Size = new System.Drawing.Size(95, 52);
            this.kASAİŞLEMToolStripMenuItem.Text = "KASA İŞLEM";
            this.kASAİŞLEMToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.kASAİŞLEMToolStripMenuItem.Click += new System.EventHandler(this.kASAİŞLEMToolStripMenuItem_Click);
            // 
            // rAPORLARToolStripMenuItem3
            // 
            this.rAPORLARToolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stokRaporuToolStripMenuItem,
            this.personelRaporuToolStripMenuItem,
            this.satışRaporuToolStripMenuItem,
            this.iadeİşlemleriToolStripMenuItem});
            this.rAPORLARToolStripMenuItem3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rAPORLARToolStripMenuItem3.Image = global::BarkodluOtomasyon.Properties.Resources.trend;
            this.rAPORLARToolStripMenuItem3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.rAPORLARToolStripMenuItem3.Name = "rAPORLARToolStripMenuItem3";
            this.rAPORLARToolStripMenuItem3.Size = new System.Drawing.Size(88, 52);
            this.rAPORLARToolStripMenuItem3.Text = "RAPORLAR";
            this.rAPORLARToolStripMenuItem3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // stokRaporuToolStripMenuItem
            // 
            this.stokRaporuToolStripMenuItem.Image = global::BarkodluOtomasyon.Properties.Resources.inventory1;
            this.stokRaporuToolStripMenuItem.Name = "stokRaporuToolStripMenuItem";
            this.stokRaporuToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.stokRaporuToolStripMenuItem.Text = "Stok Raporu";
            this.stokRaporuToolStripMenuItem.Click += new System.EventHandler(this.stokRaporuToolStripMenuItem_Click);
            // 
            // personelRaporuToolStripMenuItem
            // 
            this.personelRaporuToolStripMenuItem.Image = global::BarkodluOtomasyon.Properties.Resources.seminar;
            this.personelRaporuToolStripMenuItem.Name = "personelRaporuToolStripMenuItem";
            this.personelRaporuToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.personelRaporuToolStripMenuItem.Text = "Personel Raporu";
            this.personelRaporuToolStripMenuItem.Click += new System.EventHandler(this.personelRaporuToolStripMenuItem_Click);
            // 
            // satışRaporuToolStripMenuItem
            // 
            this.satışRaporuToolStripMenuItem.Image = global::BarkodluOtomasyon.Properties.Resources.diagram;
            this.satışRaporuToolStripMenuItem.Name = "satışRaporuToolStripMenuItem";
            this.satışRaporuToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.satışRaporuToolStripMenuItem.Text = "Satış Raporu";
            this.satışRaporuToolStripMenuItem.Click += new System.EventHandler(this.satışRaporuToolStripMenuItem_Click);
            // 
            // iadeİşlemleriToolStripMenuItem
            // 
            this.iadeİşlemleriToolStripMenuItem.Image = global::BarkodluOtomasyon.Properties.Resources.product;
            this.iadeİşlemleriToolStripMenuItem.Name = "iadeİşlemleriToolStripMenuItem";
            this.iadeİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.iadeİşlemleriToolStripMenuItem.Text = "İade Raporu";
            this.iadeİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.iadeİşlemleriToolStripMenuItem_Click);
            // 
            // sEÇENEKLERToolStripMenuItem4
            // 
            this.sEÇENEKLERToolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kategoriİşlemleriToolStripMenuItem,
            this.birimİşlemleriToolStripMenuItem,
            this.tedarikçiİşlemleriToolStripMenuItem,
            this.kullanıcıİşlemleriToolStripMenuItem,
            this.müşteriGrupİşlemleriToolStripMenuItem,
            this.işçiİşlemleriToolStripMenuItem});
            this.sEÇENEKLERToolStripMenuItem4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sEÇENEKLERToolStripMenuItem4.Image = global::BarkodluOtomasyon.Properties.Resources.options;
            this.sEÇENEKLERToolStripMenuItem4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sEÇENEKLERToolStripMenuItem4.Name = "sEÇENEKLERToolStripMenuItem4";
            this.sEÇENEKLERToolStripMenuItem4.Size = new System.Drawing.Size(95, 52);
            this.sEÇENEKLERToolStripMenuItem4.Text = "SEÇENEKLER";
            this.sEÇENEKLERToolStripMenuItem4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // kategoriİşlemleriToolStripMenuItem
            // 
            this.kategoriİşlemleriToolStripMenuItem.Name = "kategoriİşlemleriToolStripMenuItem";
            this.kategoriİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.kategoriİşlemleriToolStripMenuItem.Text = "Kategori İşlemleri";
            this.kategoriİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.kategoriİşlemleriToolStripMenuItem_Click);
            // 
            // birimİşlemleriToolStripMenuItem
            // 
            this.birimİşlemleriToolStripMenuItem.Name = "birimİşlemleriToolStripMenuItem";
            this.birimİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.birimİşlemleriToolStripMenuItem.Text = "Birim İşlemleri";
            this.birimİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.birimİşlemleriToolStripMenuItem_Click);
            // 
            // tedarikçiİşlemleriToolStripMenuItem
            // 
            this.tedarikçiİşlemleriToolStripMenuItem.Name = "tedarikçiİşlemleriToolStripMenuItem";
            this.tedarikçiİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.tedarikçiİşlemleriToolStripMenuItem.Text = "Tedarikçi İşlemleri";
            this.tedarikçiİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.tedarikçiİşlemleriToolStripMenuItem_Click);
            // 
            // kullanıcıİşlemleriToolStripMenuItem
            // 
            this.kullanıcıİşlemleriToolStripMenuItem.Name = "kullanıcıİşlemleriToolStripMenuItem";
            this.kullanıcıİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.kullanıcıİşlemleriToolStripMenuItem.Text = "Kullanıcı İşlemleri";
            this.kullanıcıİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıEkleToolStripMenuItem_Click);
            // 
            // müşteriGrupİşlemleriToolStripMenuItem
            // 
            this.müşteriGrupİşlemleriToolStripMenuItem.Name = "müşteriGrupİşlemleriToolStripMenuItem";
            this.müşteriGrupİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.müşteriGrupİşlemleriToolStripMenuItem.Text = "Müşteri Grup İşlemleri";
            this.müşteriGrupİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.müşteriGrupİşlemleriToolStripMenuItem_Click);
            // 
            // işçiİşlemleriToolStripMenuItem
            // 
            this.işçiİşlemleriToolStripMenuItem.Name = "işçiİşlemleriToolStripMenuItem";
            this.işçiİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.işçiİşlemleriToolStripMenuItem.Text = "İşçi İşlemleri";
            this.işçiİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.pERSONELToolStripMenuItem2_Click);
            // 
            // aYARLARToolStripMenuItem4
            // 
            this.aYARLARToolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alarmAyarlarıToolStripMenuItem,
            this.sistemAyarlarıToolStripMenuItem1,
            this.yazıcıAyarlarıToolStripMenuItem1,
            this.sMSAyarlarıToolStripMenuItem,
            this.mailAyarlarıToolStripMenuItem,
            this.veriTabanıAyarlarıToolStripMenuItem,
            this.dilAyarlarıToolStripMenuItem1});
            this.aYARLARToolStripMenuItem4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aYARLARToolStripMenuItem4.Image = global::BarkodluOtomasyon.Properties.Resources.settings;
            this.aYARLARToolStripMenuItem4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.aYARLARToolStripMenuItem4.Name = "aYARLARToolStripMenuItem4";
            this.aYARLARToolStripMenuItem4.Size = new System.Drawing.Size(78, 52);
            this.aYARLARToolStripMenuItem4.Text = "AYARLAR";
            this.aYARLARToolStripMenuItem4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // alarmAyarlarıToolStripMenuItem
            // 
            this.alarmAyarlarıToolStripMenuItem.Image = global::BarkodluOtomasyon.Properties.Resources.clocks;
            this.alarmAyarlarıToolStripMenuItem.Name = "alarmAyarlarıToolStripMenuItem";
            this.alarmAyarlarıToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.alarmAyarlarıToolStripMenuItem.Text = "Alarm Ayarları";
            this.alarmAyarlarıToolStripMenuItem.Click += new System.EventHandler(this.alarmAyarlarıToolStripMenuItem_Click);
            // 
            // sistemAyarlarıToolStripMenuItem1
            // 
            this.sistemAyarlarıToolStripMenuItem1.Image = global::BarkodluOtomasyon.Properties.Resources.Apps_system_software_update_icon;
            this.sistemAyarlarıToolStripMenuItem1.Name = "sistemAyarlarıToolStripMenuItem1";
            this.sistemAyarlarıToolStripMenuItem1.Size = new System.Drawing.Size(187, 22);
            this.sistemAyarlarıToolStripMenuItem1.Text = "Sistem Ayarları";
            this.sistemAyarlarıToolStripMenuItem1.Click += new System.EventHandler(this.sistemAyarlarıToolStripMenuItem1_Click);
            // 
            // yazıcıAyarlarıToolStripMenuItem1
            // 
            this.yazıcıAyarlarıToolStripMenuItem1.Image = global::BarkodluOtomasyon.Properties.Resources.printer;
            this.yazıcıAyarlarıToolStripMenuItem1.Name = "yazıcıAyarlarıToolStripMenuItem1";
            this.yazıcıAyarlarıToolStripMenuItem1.Size = new System.Drawing.Size(187, 22);
            this.yazıcıAyarlarıToolStripMenuItem1.Text = "Yazıcı Ayarları";
            this.yazıcıAyarlarıToolStripMenuItem1.Click += new System.EventHandler(this.yazıcıAyarlarıToolStripMenuItem1_Click);
            // 
            // sMSAyarlarıToolStripMenuItem
            // 
            this.sMSAyarlarıToolStripMenuItem.Image = global::BarkodluOtomasyon.Properties.Resources.sms;
            this.sMSAyarlarıToolStripMenuItem.Name = "sMSAyarlarıToolStripMenuItem";
            this.sMSAyarlarıToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.sMSAyarlarıToolStripMenuItem.Text = "SMS Ayarları";
            this.sMSAyarlarıToolStripMenuItem.Click += new System.EventHandler(this.sMSAyarlarıToolStripMenuItem_Click);
            // 
            // mailAyarlarıToolStripMenuItem
            // 
            this.mailAyarlarıToolStripMenuItem.Image = global::BarkodluOtomasyon.Properties.Resources.mail;
            this.mailAyarlarıToolStripMenuItem.Name = "mailAyarlarıToolStripMenuItem";
            this.mailAyarlarıToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.mailAyarlarıToolStripMenuItem.Text = "Mail Ayarları";
            this.mailAyarlarıToolStripMenuItem.Click += new System.EventHandler(this.mailAyarlarıToolStripMenuItem_Click);
            // 
            // veriTabanıAyarlarıToolStripMenuItem
            // 
            this.veriTabanıAyarlarıToolStripMenuItem.Image = global::BarkodluOtomasyon.Properties.Resources.database;
            this.veriTabanıAyarlarıToolStripMenuItem.Name = "veriTabanıAyarlarıToolStripMenuItem";
            this.veriTabanıAyarlarıToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.veriTabanıAyarlarıToolStripMenuItem.Text = "VeriTabanı Ayarları";
            this.veriTabanıAyarlarıToolStripMenuItem.Click += new System.EventHandler(this.veriTabanıAyarlarıToolStripMenuItem_Click);
            // 
            // dilAyarlarıToolStripMenuItem1
            // 
            this.dilAyarlarıToolStripMenuItem1.Image = global::BarkodluOtomasyon.Properties.Resources.languages;
            this.dilAyarlarıToolStripMenuItem1.Name = "dilAyarlarıToolStripMenuItem1";
            this.dilAyarlarıToolStripMenuItem1.Size = new System.Drawing.Size(187, 22);
            this.dilAyarlarıToolStripMenuItem1.Text = "Dil Ayarları";
            // 
            // yARDIMToolStripMenuItem3
            // 
            this.yARDIMToolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanımKılavuzuToolStripMenuItem1,
            this.aktivasyonToolStripMenuItem1,
            this.geriBildirimToolStripMenuItem,
            this.hakkındaToolStripMenuItem1});
            this.yARDIMToolStripMenuItem3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yARDIMToolStripMenuItem3.Image = global::BarkodluOtomasyon.Properties.Resources.question__1_;
            this.yARDIMToolStripMenuItem3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.yARDIMToolStripMenuItem3.Name = "yARDIMToolStripMenuItem3";
            this.yARDIMToolStripMenuItem3.Size = new System.Drawing.Size(69, 52);
            this.yARDIMToolStripMenuItem3.Text = "YARDIM";
            this.yARDIMToolStripMenuItem3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // geriBildirimToolStripMenuItem
            // 
            this.geriBildirimToolStripMenuItem.Image = global::BarkodluOtomasyon.Properties.Resources.feedback;
            this.geriBildirimToolStripMenuItem.Name = "geriBildirimToolStripMenuItem";
            this.geriBildirimToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.geriBildirimToolStripMenuItem.Text = "Geri Bildirim";
            this.geriBildirimToolStripMenuItem.Click += new System.EventHandler(this.geriBildirimToolStripMenuItem_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // aciklama
            // 
            this.aciklama.IsBalloon = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BarkodluOtomasyon.Properties.Resources.Adsız;
            this.pictureBox1.Location = new System.Drawing.Point(2, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // FrmAnaSayfaMudur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 638);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtKasaFiyat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1030, 677);
            this.Name = "FrmAnaSayfaMudur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REMIT-PRO";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAnaSayfaMudur_FormClosing);
            this.Load += new System.EventHandler(this.FrmMainPageM_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listSatis)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrFisYaz)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private TextBox txtKasaFiyat;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button btnIndirimliSatis;
        private Button btnVeresiyeSatis;
        private Button btnNakitKrediSatis;
        private Button btnKrediSatis;
        private Button btnNakitSatis;
        private Label label3;
        private Panel panel4;
        private Timer timer1;
        private Label label8;
        private Label label7;
        private Label label6;
        private ComboBox comboIslemYapan;
        private Label label10;
        private ComboBox comboKasaNo;
        private Label label9;
        private Panel panel5;
        private TextBox txtParaUstu;
        private Panel panel6;
        private Label lblTarih;
        private Label lblZaman;
        private Button btnUrunIade;
        private Button btnFiyatGor;
        private Button btnMusteriSec;
        private Button btnTemizle;
        private Label label4;
        private Label label2;
        private TextBox txtAlinanPara;
        private TextBox txtEldenBarkod;
        private Panel panel7;
        private Label lblSirketAdi;
        private Label label12;
        private Label label11;
        private Button btnIslemIptal;
        private Label label14;
        private Label label13;
        private Button btnKlavye;
        private ComboBox comboUygulanacakFiyat;
        private Label label5;
        private Panel panel8;
        private Button btn200;
        private Button btn5;
        private Button btn10;
        private Button btn20;
        private Button btn50;
        private Button btn100;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem sEÇENEKLERToolStripMenuItem4;
        private ToolStripMenuItem sTOKİŞLEMToolStripMenuItem2;
        private ToolStripMenuItem rAPORLARToolStripMenuItem3;
        private ToolStripMenuItem aYARLARToolStripMenuItem4;
        private ToolStripMenuItem yARDIMToolStripMenuItem3;
        private ToolStripMenuItem kASAİŞLEMToolStripMenuItem;
        private ToolStripMenuItem stokRaporuToolStripMenuItem;
        private ToolStripMenuItem personelRaporuToolStripMenuItem;
        private ToolStripMenuItem satışRaporuToolStripMenuItem;
        private Label label16;
        private Button btnSeriSatis;
        private DataGridView listSatis;
        private ToolStripMenuItem kategoriİşlemleriToolStripMenuItem;
        private ToolStripMenuItem birimİşlemleriToolStripMenuItem;
        private ToolStripMenuItem tedarikçiİşlemleriToolStripMenuItem;
        private ToolStripMenuItem kullanıcıİşlemleriToolStripMenuItem;
        private ToolStripMenuItem mÜŞTERİİŞLEMToolStripMenuItem;
        private ToolStripMenuItem müşteriGrupİşlemleriToolStripMenuItem;
        private ToolStripMenuItem alarmAyarlarıToolStripMenuItem;
        private ToolStripMenuItem sistemAyarlarıToolStripMenuItem1;
        private ToolStripMenuItem yazıcıAyarlarıToolStripMenuItem1;
        private ToolStripMenuItem sMSAyarlarıToolStripMenuItem;
        private ToolStripMenuItem mailAyarlarıToolStripMenuItem;
        private ToolStripMenuItem veriTabanıAyarlarıToolStripMenuItem;
        private ToolStripMenuItem dilAyarlarıToolStripMenuItem1;
        private ToolStripMenuItem iadeİşlemleriToolStripMenuItem;
        private ToolStripMenuItem işçiİşlemleriToolStripMenuItem;
        private ToolStripMenuItem kullanımKılavuzuToolStripMenuItem1;
        private ToolStripMenuItem aktivasyonToolStripMenuItem1;
        private ToolStripMenuItem geriBildirimToolStripMenuItem;
        private ToolStripMenuItem hakkındaToolStripMenuItem1;
        private Button btnUrunBul;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintDialog printDialog1;
        private PictureBox pctrFisYaz;
        private Button btnEkle;
        private Button btnFiyatEkle;
        private ToolTip aciklama;
        private PictureBox pictureBox1;
    }
}