
namespace BarkodluOtomasyon
{
    partial class FrmMusteriHesabı
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboHesapTur = new System.Windows.Forms.ComboBox();
            this.txtKayitTarih = new System.Windows.Forms.TextBox();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.txtGsmNo = new System.Windows.Forms.TextBox();
            this.txtTelNo = new System.Windows.Forms.TextBox();
            this.txtIlgili = new System.Windows.Forms.TextBox();
            this.txtMusteriAd = new System.Windows.Forms.TextBox();
            this.txtMusteriKod = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listeHesapHareketleri = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateBitis = new System.Windows.Forms.DateTimePicker();
            this.dateBaslangic = new System.Windows.Forms.DateTimePicker();
            this.txtTBakiye = new System.Windows.Forms.TextBox();
            this.txtTOdenen = new System.Windows.Forms.TextBox();
            this.txtTBorc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSatisEkle = new System.Windows.Forms.Button();
            this.btnOdemeYap = new System.Windows.Forms.Button();
            this.btnIslemSil = new System.Windows.Forms.Button();
            this.btnAlacakEkle = new System.Windows.Forms.Button();
            this.btnIslemDuzenle = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnNotEkle = new System.Windows.Forms.Button();
            this.btnAlarm = new System.Windows.Forms.Button();
            this.btnHesapMakinesi = new System.Windows.Forms.Button();
            this.btnIslemAyrıntı = new System.Windows.Forms.Button();
            this.btnMesajGonder = new System.Windows.Forms.Button();
            this.btnMailGonder = new System.Windows.Forms.Button();
            this.btnSmsGonder = new System.Windows.Forms.Button();
            this.btnProfilDuzenle = new System.Windows.Forms.Button();
            this.pctrProfil = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listeHesapHareketleri)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrProfil)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnProfilDuzenle);
            this.panel1.Controls.Add(this.comboHesapTur);
            this.panel1.Controls.Add(this.txtKayitTarih);
            this.panel1.Controls.Add(this.txtEposta);
            this.panel1.Controls.Add(this.txtGsmNo);
            this.panel1.Controls.Add(this.txtTelNo);
            this.panel1.Controls.Add(this.txtIlgili);
            this.panel1.Controls.Add(this.txtMusteriAd);
            this.panel1.Controls.Add(this.txtMusteriKod);
            this.panel1.Controls.Add(this.pctrProfil);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 227);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(130, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "E-Posta :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(131, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "GSM No :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(136, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tel. No :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(131, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kayıt T. :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(149, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "İlgili :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(130, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Müşteri :";
            // 
            // comboHesapTur
            // 
            this.comboHesapTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboHesapTur.Enabled = false;
            this.comboHesapTur.FormattingEnabled = true;
            this.comboHesapTur.Items.AddRange(new object[] {
            "Alıcı",
            "Satıcı",
            "Alıcı/Satıcı",
            "Bayi",
            "Personel"});
            this.comboHesapTur.Location = new System.Drawing.Point(251, 15);
            this.comboHesapTur.Name = "comboHesapTur";
            this.comboHesapTur.Size = new System.Drawing.Size(111, 22);
            this.comboHesapTur.TabIndex = 2;
            // 
            // txtKayitTarih
            // 
            this.txtKayitTarih.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKayitTarih.Location = new System.Drawing.Point(186, 101);
            this.txtKayitTarih.Name = "txtKayitTarih";
            this.txtKayitTarih.ReadOnly = true;
            this.txtKayitTarih.Size = new System.Drawing.Size(176, 23);
            this.txtKayitTarih.TabIndex = 1;
            // 
            // txtEposta
            // 
            this.txtEposta.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEposta.Location = new System.Drawing.Point(186, 188);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.ReadOnly = true;
            this.txtEposta.Size = new System.Drawing.Size(176, 23);
            this.txtEposta.TabIndex = 1;
            // 
            // txtGsmNo
            // 
            this.txtGsmNo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGsmNo.Location = new System.Drawing.Point(186, 159);
            this.txtGsmNo.Name = "txtGsmNo";
            this.txtGsmNo.ReadOnly = true;
            this.txtGsmNo.Size = new System.Drawing.Size(176, 23);
            this.txtGsmNo.TabIndex = 1;
            // 
            // txtTelNo
            // 
            this.txtTelNo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTelNo.Location = new System.Drawing.Point(186, 130);
            this.txtTelNo.Name = "txtTelNo";
            this.txtTelNo.ReadOnly = true;
            this.txtTelNo.Size = new System.Drawing.Size(176, 23);
            this.txtTelNo.TabIndex = 1;
            // 
            // txtIlgili
            // 
            this.txtIlgili.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIlgili.Location = new System.Drawing.Point(186, 72);
            this.txtIlgili.Name = "txtIlgili";
            this.txtIlgili.ReadOnly = true;
            this.txtIlgili.Size = new System.Drawing.Size(176, 23);
            this.txtIlgili.TabIndex = 1;
            // 
            // txtMusteriAd
            // 
            this.txtMusteriAd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriAd.Location = new System.Drawing.Point(186, 43);
            this.txtMusteriAd.Name = "txtMusteriAd";
            this.txtMusteriAd.ReadOnly = true;
            this.txtMusteriAd.Size = new System.Drawing.Size(176, 23);
            this.txtMusteriAd.TabIndex = 1;
            // 
            // txtMusteriKod
            // 
            this.txtMusteriKod.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriKod.Location = new System.Drawing.Point(136, 14);
            this.txtMusteriKod.Name = "txtMusteriKod";
            this.txtMusteriKod.ReadOnly = true;
            this.txtMusteriKod.Size = new System.Drawing.Size(109, 23);
            this.txtMusteriKod.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.listeHesapHareketleri);
            this.groupBox1.Location = new System.Drawing.Point(13, 246);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(903, 285);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hesap Hareketleri";
            // 
            // listeHesapHareketleri
            // 
            this.listeHesapHareketleri.AllowUserToAddRows = false;
            this.listeHesapHareketleri.AllowUserToDeleteRows = false;
            this.listeHesapHareketleri.AllowUserToResizeRows = false;
            this.listeHesapHareketleri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listeHesapHareketleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listeHesapHareketleri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listeHesapHareketleri.Location = new System.Drawing.Point(3, 18);
            this.listeHesapHareketleri.MultiSelect = false;
            this.listeHesapHareketleri.Name = "listeHesapHareketleri";
            this.listeHesapHareketleri.ReadOnly = true;
            this.listeHesapHareketleri.RowHeadersVisible = false;
            this.listeHesapHareketleri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listeHesapHareketleri.Size = new System.Drawing.Size(897, 264);
            this.listeHesapHareketleri.TabIndex = 3;
            this.listeHesapHareketleri.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listeHesapHareketleri_CellContentDoubleClick);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dateBitis);
            this.panel2.Controls.Add(this.dateBaslangic);
            this.panel2.Controls.Add(this.txtTBakiye);
            this.panel2.Controls.Add(this.txtTOdenen);
            this.panel2.Controls.Add(this.txtTBorc);
            this.panel2.Controls.Add(this.btnSatisEkle);
            this.panel2.Controls.Add(this.btnOdemeYap);
            this.panel2.Controls.Add(this.btnIslemSil);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btnAlacakEkle);
            this.panel2.Controls.Add(this.btnIslemDuzenle);
            this.panel2.Controls.Add(this.btnListele);
            this.panel2.Controls.Add(this.btnNotEkle);
            this.panel2.Controls.Add(this.btnAlarm);
            this.panel2.Controls.Add(this.btnHesapMakinesi);
            this.panel2.Controls.Add(this.btnIslemAyrıntı);
            this.panel2.Controls.Add(this.btnMesajGonder);
            this.panel2.Controls.Add(this.btnMailGonder);
            this.panel2.Controls.Add(this.btnSmsGonder);
            this.panel2.Location = new System.Drawing.Point(388, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(528, 227);
            this.panel2.TabIndex = 2;
            // 
            // dateBitis
            // 
            this.dateBitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateBitis.Location = new System.Drawing.Point(111, 164);
            this.dateBitis.Name = "dateBitis";
            this.dateBitis.Size = new System.Drawing.Size(107, 22);
            this.dateBitis.TabIndex = 8;
            // 
            // dateBaslangic
            // 
            this.dateBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateBaslangic.Location = new System.Drawing.Point(111, 141);
            this.dateBaslangic.Name = "dateBaslangic";
            this.dateBaslangic.Size = new System.Drawing.Size(107, 22);
            this.dateBaslangic.TabIndex = 8;
            // 
            // txtTBakiye
            // 
            this.txtTBakiye.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTBakiye.Location = new System.Drawing.Point(372, 191);
            this.txtTBakiye.Name = "txtTBakiye";
            this.txtTBakiye.ReadOnly = true;
            this.txtTBakiye.Size = new System.Drawing.Size(143, 26);
            this.txtTBakiye.TabIndex = 7;
            // 
            // txtTOdenen
            // 
            this.txtTOdenen.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTOdenen.Location = new System.Drawing.Point(111, 191);
            this.txtTOdenen.Name = "txtTOdenen";
            this.txtTOdenen.ReadOnly = true;
            this.txtTOdenen.Size = new System.Drawing.Size(155, 26);
            this.txtTOdenen.TabIndex = 6;
            // 
            // txtTBorc
            // 
            this.txtTBorc.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTBorc.Location = new System.Drawing.Point(372, 156);
            this.txtTBorc.Name = "txtTBorc";
            this.txtTBorc.ReadOnly = true;
            this.txtTBorc.Size = new System.Drawing.Size(143, 26);
            this.txtTBorc.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(272, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 14);
            this.label9.TabIndex = 4;
            this.label9.Text = "Toplam Bakiye : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(32, 170);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 14);
            this.label11.TabIndex = 4;
            this.label11.Text = "Bitiş Tarihi :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(2, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 14);
            this.label10.TabIndex = 4;
            this.label10.Text = "Başlangıç Tarihi :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(3, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 14);
            this.label8.TabIndex = 4;
            this.label8.Text = "Toplam Ödenen : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(284, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 14);
            this.label7.TabIndex = 4;
            this.label7.Text = "Toplam Borç : ";
            // 
            // btnSatisEkle
            // 
            this.btnSatisEkle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatisEkle.Image = global::BarkodluOtomasyon.Properties.Resources.cash;
            this.btnSatisEkle.Location = new System.Drawing.Point(317, 95);
            this.btnSatisEkle.Name = "btnSatisEkle";
            this.btnSatisEkle.Size = new System.Drawing.Size(150, 40);
            this.btnSatisEkle.TabIndex = 3;
            this.btnSatisEkle.Text = "SATIŞ EKLE";
            this.btnSatisEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSatisEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSatisEkle.UseVisualStyleBackColor = true;
            this.btnSatisEkle.Click += new System.EventHandler(this.btnSatisEkle_Click);
            // 
            // btnOdemeYap
            // 
            this.btnOdemeYap.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdemeYap.Image = global::BarkodluOtomasyon.Properties.Resources.pay;
            this.btnOdemeYap.Location = new System.Drawing.Point(317, 49);
            this.btnOdemeYap.Name = "btnOdemeYap";
            this.btnOdemeYap.Size = new System.Drawing.Size(150, 40);
            this.btnOdemeYap.TabIndex = 3;
            this.btnOdemeYap.Text = "ÖDEME YAP";
            this.btnOdemeYap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOdemeYap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOdemeYap.UseVisualStyleBackColor = true;
            this.btnOdemeYap.Click += new System.EventHandler(this.btnOdemeYap_Click);
            // 
            // btnIslemSil
            // 
            this.btnIslemSil.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIslemSil.Image = global::BarkodluOtomasyon.Properties.Resources.delete__1_;
            this.btnIslemSil.Location = new System.Drawing.Point(161, 49);
            this.btnIslemSil.Name = "btnIslemSil";
            this.btnIslemSil.Size = new System.Drawing.Size(150, 40);
            this.btnIslemSil.TabIndex = 3;
            this.btnIslemSil.Text = "İŞLEM SİL";
            this.btnIslemSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIslemSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIslemSil.UseVisualStyleBackColor = true;
            this.btnIslemSil.Click += new System.EventHandler(this.btnIslemSil_Click);
            // 
            // btnAlacakEkle
            // 
            this.btnAlacakEkle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAlacakEkle.Image = global::BarkodluOtomasyon.Properties.Resources.wallet__1_;
            this.btnAlacakEkle.Location = new System.Drawing.Point(317, 3);
            this.btnAlacakEkle.Name = "btnAlacakEkle";
            this.btnAlacakEkle.Size = new System.Drawing.Size(150, 40);
            this.btnAlacakEkle.TabIndex = 3;
            this.btnAlacakEkle.Text = "ALACAK EKLE";
            this.btnAlacakEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlacakEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlacakEkle.UseVisualStyleBackColor = true;
            this.btnAlacakEkle.Click += new System.EventHandler(this.btnAlacakEkle_Click);
            // 
            // btnIslemDuzenle
            // 
            this.btnIslemDuzenle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIslemDuzenle.Image = global::BarkodluOtomasyon.Properties.Resources.inventory1;
            this.btnIslemDuzenle.Location = new System.Drawing.Point(161, 3);
            this.btnIslemDuzenle.Name = "btnIslemDuzenle";
            this.btnIslemDuzenle.Size = new System.Drawing.Size(150, 40);
            this.btnIslemDuzenle.TabIndex = 3;
            this.btnIslemDuzenle.Text = "İŞLEM DÜZENLE";
            this.btnIslemDuzenle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIslemDuzenle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIslemDuzenle.UseVisualStyleBackColor = true;
            this.btnIslemDuzenle.Click += new System.EventHandler(this.btnIslemDuzenle_Click);
            // 
            // btnListele
            // 
            this.btnListele.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.Image = global::BarkodluOtomasyon.Properties.Resources.refinement;
            this.btnListele.Location = new System.Drawing.Point(224, 141);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(42, 45);
            this.btnListele.TabIndex = 3;
            this.btnListele.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListele.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnNotEkle
            // 
            this.btnNotEkle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNotEkle.Image = global::BarkodluOtomasyon.Properties.Resources.notes;
            this.btnNotEkle.Location = new System.Drawing.Point(473, 95);
            this.btnNotEkle.Name = "btnNotEkle";
            this.btnNotEkle.Size = new System.Drawing.Size(42, 40);
            this.btnNotEkle.TabIndex = 3;
            this.btnNotEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNotEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNotEkle.UseVisualStyleBackColor = true;
            this.btnNotEkle.Click += new System.EventHandler(this.btnNotEkle_Click);
            // 
            // btnAlarm
            // 
            this.btnAlarm.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAlarm.Image = global::BarkodluOtomasyon.Properties.Resources.alarm_clock;
            this.btnAlarm.Location = new System.Drawing.Point(473, 49);
            this.btnAlarm.Name = "btnAlarm";
            this.btnAlarm.Size = new System.Drawing.Size(42, 40);
            this.btnAlarm.TabIndex = 3;
            this.btnAlarm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlarm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlarm.UseVisualStyleBackColor = true;
            this.btnAlarm.Click += new System.EventHandler(this.btnAlarm_Click);
            // 
            // btnHesapMakinesi
            // 
            this.btnHesapMakinesi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapMakinesi.Image = global::BarkodluOtomasyon.Properties.Resources.calculator;
            this.btnHesapMakinesi.Location = new System.Drawing.Point(473, 3);
            this.btnHesapMakinesi.Name = "btnHesapMakinesi";
            this.btnHesapMakinesi.Size = new System.Drawing.Size(42, 40);
            this.btnHesapMakinesi.TabIndex = 3;
            this.btnHesapMakinesi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHesapMakinesi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHesapMakinesi.UseVisualStyleBackColor = true;
            this.btnHesapMakinesi.Click += new System.EventHandler(this.btnHesapMakinesi_Click);
            // 
            // btnIslemAyrıntı
            // 
            this.btnIslemAyrıntı.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIslemAyrıntı.Image = global::BarkodluOtomasyon.Properties.Resources.eye;
            this.btnIslemAyrıntı.Location = new System.Drawing.Point(161, 95);
            this.btnIslemAyrıntı.Name = "btnIslemAyrıntı";
            this.btnIslemAyrıntı.Size = new System.Drawing.Size(150, 40);
            this.btnIslemAyrıntı.TabIndex = 3;
            this.btnIslemAyrıntı.Text = "İŞLEM AYRINTI";
            this.btnIslemAyrıntı.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIslemAyrıntı.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIslemAyrıntı.UseVisualStyleBackColor = true;
            this.btnIslemAyrıntı.Click += new System.EventHandler(this.btnIslemAyrıntı_Click);
            // 
            // btnMesajGonder
            // 
            this.btnMesajGonder.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMesajGonder.Image = global::BarkodluOtomasyon.Properties.Resources.whatsapp;
            this.btnMesajGonder.Location = new System.Drawing.Point(5, 95);
            this.btnMesajGonder.Name = "btnMesajGonder";
            this.btnMesajGonder.Size = new System.Drawing.Size(150, 40);
            this.btnMesajGonder.TabIndex = 3;
            this.btnMesajGonder.Text = "MESAJ GÖNDER";
            this.btnMesajGonder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMesajGonder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMesajGonder.UseVisualStyleBackColor = true;
            this.btnMesajGonder.Click += new System.EventHandler(this.btnMesajGonder_Click);
            // 
            // btnMailGonder
            // 
            this.btnMailGonder.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMailGonder.Image = global::BarkodluOtomasyon.Properties.Resources.send;
            this.btnMailGonder.Location = new System.Drawing.Point(5, 49);
            this.btnMailGonder.Name = "btnMailGonder";
            this.btnMailGonder.Size = new System.Drawing.Size(150, 40);
            this.btnMailGonder.TabIndex = 3;
            this.btnMailGonder.Text = "MAİL GÖNDER";
            this.btnMailGonder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMailGonder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMailGonder.UseVisualStyleBackColor = true;
            this.btnMailGonder.Click += new System.EventHandler(this.btnMailGonder_Click);
            // 
            // btnSmsGonder
            // 
            this.btnSmsGonder.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSmsGonder.Image = global::BarkodluOtomasyon.Properties.Resources.smartphone;
            this.btnSmsGonder.Location = new System.Drawing.Point(5, 3);
            this.btnSmsGonder.Name = "btnSmsGonder";
            this.btnSmsGonder.Size = new System.Drawing.Size(150, 40);
            this.btnSmsGonder.TabIndex = 3;
            this.btnSmsGonder.Text = "SMS GÖNDER";
            this.btnSmsGonder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSmsGonder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSmsGonder.UseVisualStyleBackColor = true;
            this.btnSmsGonder.Click += new System.EventHandler(this.btnSmsGonder_Click);
            // 
            // btnProfilDuzenle
            // 
            this.btnProfilDuzenle.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProfilDuzenle.Image = global::BarkodluOtomasyon.Properties.Resources.notebook;
            this.btnProfilDuzenle.Location = new System.Drawing.Point(3, 162);
            this.btnProfilDuzenle.Name = "btnProfilDuzenle";
            this.btnProfilDuzenle.Size = new System.Drawing.Size(126, 50);
            this.btnProfilDuzenle.TabIndex = 3;
            this.btnProfilDuzenle.Text = "DÜZENLE";
            this.btnProfilDuzenle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProfilDuzenle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProfilDuzenle.UseVisualStyleBackColor = true;
            this.btnProfilDuzenle.Click += new System.EventHandler(this.btnProfilDuzenle_Click);
            // 
            // pctrProfil
            // 
            this.pctrProfil.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pctrProfil.Location = new System.Drawing.Point(4, 14);
            this.pctrProfil.Name = "pctrProfil";
            this.pctrProfil.Size = new System.Drawing.Size(126, 142);
            this.pctrProfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrProfil.TabIndex = 0;
            this.pctrProfil.TabStop = false;
            // 
            // FrmMusteriHesabı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 543);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmMusteriHesabı";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Hesabı";
            this.Load += new System.EventHandler(this.FrmMusteriHesabı_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listeHesapHareketleri)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrProfil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnProfilDuzenle;
        private System.Windows.Forms.ComboBox comboHesapTur;
        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.TextBox txtKayitTarih;
        private System.Windows.Forms.TextBox txtGsmNo;
        private System.Windows.Forms.TextBox txtTelNo;
        private System.Windows.Forms.TextBox txtIlgili;
        private System.Windows.Forms.TextBox txtMusteriAd;
        private System.Windows.Forms.TextBox txtMusteriKod;
        private System.Windows.Forms.PictureBox pctrProfil;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView listeHesapHareketleri;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnOdemeYap;
        private System.Windows.Forms.Button btnIslemSil;
        private System.Windows.Forms.Button btnIslemDuzenle;
        private System.Windows.Forms.Button btnMesajGonder;
        private System.Windows.Forms.Button btnMailGonder;
        private System.Windows.Forms.Button btnSmsGonder;
        private System.Windows.Forms.Button btnSatisEkle;
        private System.Windows.Forms.Button btnAlacakEkle;
        private System.Windows.Forms.Button btnHesapMakinesi;
        private System.Windows.Forms.Button btnAlarm;
        private System.Windows.Forms.Button btnNotEkle;
        private System.Windows.Forms.TextBox txtTBakiye;
        private System.Windows.Forms.TextBox txtTOdenen;
        private System.Windows.Forms.TextBox txtTBorc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnIslemAyrıntı;
        private System.Windows.Forms.DateTimePicker dateBitis;
        private System.Windows.Forms.DateTimePicker dateBaslangic;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnListele;
    }
}