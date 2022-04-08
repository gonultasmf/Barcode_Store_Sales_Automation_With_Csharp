
namespace BarkodluOtomasyon
{
    partial class FrmMusteriSatisEkle
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
            this.comboBirim = new System.Windows.Forms.ComboBox();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.RichTextBox();
            this.txtIslemNo = new System.Windows.Forms.TextBox();
            this.txtTarih = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnIslemNoVer = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBirimFiyat = new System.Windows.Forms.TextBox();
            this.btnUrunSec = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnUrunSec);
            this.panel1.Controls.Add(this.txtBirimFiyat);
            this.panel1.Controls.Add(this.txtMiktar);
            this.panel1.Controls.Add(this.comboBirim);
            this.panel1.Controls.Add(this.btnEkle);
            this.panel1.Controls.Add(this.btnIptal);
            this.panel1.Controls.Add(this.txtTutar);
            this.panel1.Controls.Add(this.txtAciklama);
            this.panel1.Controls.Add(this.btnIslemNoVer);
            this.panel1.Controls.Add(this.txtIslemNo);
            this.panel1.Controls.Add(this.txtTarih);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(235, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 349);
            this.panel1.TabIndex = 5;
            // 
            // comboBirim
            // 
            this.comboBirim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBirim.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBirim.FormattingEnabled = true;
            this.comboBirim.Items.AddRange(new object[] {
            "Nakit",
            "POS",
            "Çek",
            "Banka"});
            this.comboBirim.Location = new System.Drawing.Point(178, 231);
            this.comboBirim.Name = "comboBirim";
            this.comboBirim.Size = new System.Drawing.Size(74, 26);
            this.comboBirim.TabIndex = 22;
            // 
            // txtTutar
            // 
            this.txtTutar.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTutar.Location = new System.Drawing.Point(112, 263);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(220, 26);
            this.txtTutar.TabIndex = 18;
            this.txtTutar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMiktar_KeyPress);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAciklama.Location = new System.Drawing.Point(112, 166);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(220, 46);
            this.txtAciklama.TabIndex = 17;
            this.txtAciklama.Text = "";
            // 
            // txtIslemNo
            // 
            this.txtIslemNo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIslemNo.Location = new System.Drawing.Point(114, 46);
            this.txtIslemNo.Name = "txtIslemNo";
            this.txtIslemNo.ReadOnly = true;
            this.txtIslemNo.Size = new System.Drawing.Size(218, 27);
            this.txtIslemNo.TabIndex = 2;
            // 
            // txtTarih
            // 
            this.txtTarih.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTarih.Location = new System.Drawing.Point(114, 9);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.ReadOnly = true;
            this.txtTarih.Size = new System.Drawing.Size(218, 26);
            this.txtTarih.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(178, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Birim :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(67, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tutar :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(47, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Açıklama :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fiş / İşlem No :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tarih :";
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Image = global::BarkodluOtomasyon.Properties.Resources._checked;
            this.btnEkle.Location = new System.Drawing.Point(221, 295);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(111, 46);
            this.btnEkle.TabIndex = 20;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.Image = global::BarkodluOtomasyon.Properties.Resources.multiply;
            this.btnIptal.Location = new System.Drawing.Point(112, 295);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(103, 46);
            this.btnIptal.TabIndex = 21;
            this.btnIptal.Text = "İPTAL";
            this.btnIptal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIptal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnIslemNoVer
            // 
            this.btnIslemNoVer.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIslemNoVer.Image = global::BarkodluOtomasyon.Properties.Resources.shuffle;
            this.btnIslemNoVer.Location = new System.Drawing.Point(114, 79);
            this.btnIslemNoVer.Name = "btnIslemNoVer";
            this.btnIslemNoVer.Size = new System.Drawing.Size(218, 39);
            this.btnIslemNoVer.TabIndex = 16;
            this.btnIslemNoVer.Text = "İŞLEM/FİŞ NO VER";
            this.btnIslemNoVer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIslemNoVer.UseVisualStyleBackColor = true;
            this.btnIslemNoVer.Click += new System.EventHandler(this.btnIslemNoVer_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BarkodluOtomasyon.Properties.Resources.Address_Book_Oldschool_blue_icon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 350);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // txtMiktar
            // 
            this.txtMiktar.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMiktar.Location = new System.Drawing.Point(112, 231);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(60, 26);
            this.txtMiktar.TabIndex = 23;
            this.txtMiktar.TextChanged += new System.EventHandler(this.txtMiktar_TextChanged);
            this.txtMiktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMiktar_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(112, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Miktar :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(257, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Birim Fiyat :";
            // 
            // txtBirimFiyat
            // 
            this.txtBirimFiyat.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBirimFiyat.Location = new System.Drawing.Point(258, 231);
            this.txtBirimFiyat.Name = "txtBirimFiyat";
            this.txtBirimFiyat.Size = new System.Drawing.Size(74, 26);
            this.txtBirimFiyat.TabIndex = 23;
            this.txtBirimFiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMiktar_KeyPress);
            // 
            // btnUrunSec
            // 
            this.btnUrunSec.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunSec.Image = global::BarkodluOtomasyon.Properties.Resources.refinement;
            this.btnUrunSec.Location = new System.Drawing.Point(154, 121);
            this.btnUrunSec.Name = "btnUrunSec";
            this.btnUrunSec.Size = new System.Drawing.Size(135, 42);
            this.btnUrunSec.TabIndex = 24;
            this.btnUrunSec.Text = "ÜRÜN SEÇ";
            this.btnUrunSec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUrunSec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUrunSec.UseVisualStyleBackColor = true;
            this.btnUrunSec.Click += new System.EventHandler(this.btnUrunSec_Click);
            // 
            // FrmMusteriSatisEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 373);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmMusteriSatisEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış Ekle";
            this.Load += new System.EventHandler(this.FrmMusteriSatisEkle_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBirim;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.RichTextBox txtAciklama;
        private System.Windows.Forms.Button btnIslemNoVer;
        private System.Windows.Forms.TextBox txtIslemNo;
        private System.Windows.Forms.TextBox txtTarih;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnUrunSec;
        private System.Windows.Forms.TextBox txtBirimFiyat;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}