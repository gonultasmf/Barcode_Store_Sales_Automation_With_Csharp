
namespace BarkodluOtomasyon
{
    partial class FrmHizliStokEkle
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
            this.txtSatisFiyat_1 = new System.Windows.Forms.TextBox();
            this.txtAlisFiyat = new System.Windows.Forms.TextBox();
            this.numericKDVOran = new System.Windows.Forms.NumericUpDown();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.btnBarkodUret = new System.Windows.Forms.Button();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMiktari = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnBirimEkle = new System.Windows.Forms.Button();
            this.comboBirim = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnIslemIptal = new System.Windows.Forms.Button();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericKDVOran)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSatisFiyat_1
            // 
            this.txtSatisFiyat_1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSatisFiyat_1.Location = new System.Drawing.Point(125, 132);
            this.txtSatisFiyat_1.Name = "txtSatisFiyat_1";
            this.txtSatisFiyat_1.Size = new System.Drawing.Size(207, 23);
            this.txtSatisFiyat_1.TabIndex = 20;
            this.txtSatisFiyat_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // txtAlisFiyat
            // 
            this.txtAlisFiyat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAlisFiyat.Location = new System.Drawing.Point(125, 102);
            this.txtAlisFiyat.Name = "txtAlisFiyat";
            this.txtAlisFiyat.Size = new System.Drawing.Size(207, 23);
            this.txtAlisFiyat.TabIndex = 19;
            this.txtAlisFiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // numericKDVOran
            // 
            this.numericKDVOran.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericKDVOran.Location = new System.Drawing.Point(125, 73);
            this.numericKDVOran.Name = "numericKDVOran";
            this.numericKDVOran.Size = new System.Drawing.Size(208, 23);
            this.numericKDVOran.TabIndex = 18;
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunAdi.Location = new System.Drawing.Point(125, 42);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(208, 23);
            this.txtUrunAdi.TabIndex = 17;
            // 
            // btnBarkodUret
            // 
            this.btnBarkodUret.Image = global::BarkodluOtomasyon.Properties.Resources.product_barcode;
            this.btnBarkodUret.Location = new System.Drawing.Point(292, 9);
            this.btnBarkodUret.Name = "btnBarkodUret";
            this.btnBarkodUret.Size = new System.Drawing.Size(41, 28);
            this.btnBarkodUret.TabIndex = 16;
            this.btnBarkodUret.UseVisualStyleBackColor = true;
            this.btnBarkodUret.Click += new System.EventHandler(this.btnBarkodUret_Click);
            // 
            // txtBarkod
            // 
            this.txtBarkod.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBarkod.Location = new System.Drawing.Point(125, 12);
            this.txtBarkod.MaxLength = 13;
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(165, 23);
            this.txtBarkod.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 14);
            this.label5.TabIndex = 10;
            this.label5.Text = "Satış Fiyat-1 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 14);
            this.label4.TabIndex = 11;
            this.label4.Text = "Birim Alış Fiyat :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 14);
            this.label3.TabIndex = 12;
            this.label3.Text = "KDV (%) :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 14);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ürün Adı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 14);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ürün Barkodu :";
            // 
            // txtMiktari
            // 
            this.txtMiktari.Location = new System.Drawing.Point(125, 161);
            this.txtMiktari.Name = "txtMiktari";
            this.txtMiktari.Size = new System.Drawing.Size(207, 22);
            this.txtMiktari.TabIndex = 23;
            this.txtMiktari.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            this.txtMiktari.Leave += new System.EventHandler(this.txtMiktari_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 14);
            this.label10.TabIndex = 22;
            this.label10.Text = "Stok Miktarı :";
            // 
            // btnBirimEkle
            // 
            this.btnBirimEkle.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBirimEkle.Image = global::BarkodluOtomasyon.Properties.Resources.add_button;
            this.btnBirimEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBirimEkle.Location = new System.Drawing.Point(297, 184);
            this.btnBirimEkle.Name = "btnBirimEkle";
            this.btnBirimEkle.Size = new System.Drawing.Size(35, 32);
            this.btnBirimEkle.TabIndex = 32;
            this.btnBirimEkle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBirimEkle.UseVisualStyleBackColor = true;
            this.btnBirimEkle.Click += new System.EventHandler(this.btnBirimEkle_Click);
            // 
            // comboBirim
            // 
            this.comboBirim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBirim.FormattingEnabled = true;
            this.comboBirim.Location = new System.Drawing.Point(125, 189);
            this.comboBirim.Name = "comboBirim";
            this.comboBirim.Size = new System.Drawing.Size(166, 22);
            this.comboBirim.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(41, 192);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 14);
            this.label11.TabIndex = 30;
            this.label11.Text = "Ölçü Birimi :";
            // 
            // btnIslemIptal
            // 
            this.btnIslemIptal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIslemIptal.Image = global::BarkodluOtomasyon.Properties.Resources.multiply;
            this.btnIslemIptal.Location = new System.Drawing.Point(12, 222);
            this.btnIslemIptal.Name = "btnIslemIptal";
            this.btnIslemIptal.Size = new System.Drawing.Size(129, 46);
            this.btnIslemIptal.TabIndex = 33;
            this.btnIslemIptal.Text = "İPTAL";
            this.btnIslemIptal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIslemIptal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIslemIptal.UseVisualStyleBackColor = true;
            this.btnIslemIptal.Click += new System.EventHandler(this.btnIslemIptal_Click);
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunEkle.Image = global::BarkodluOtomasyon.Properties.Resources.box;
            this.btnUrunEkle.Location = new System.Drawing.Point(147, 222);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(186, 46);
            this.btnUrunEkle.TabIndex = 34;
            this.btnUrunEkle.Text = "ÜRÜN EKLE";
            this.btnUrunEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUrunEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // FrmHizliStokEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 282);
            this.Controls.Add(this.btnIslemIptal);
            this.Controls.Add(this.btnUrunEkle);
            this.Controls.Add(this.btnBirimEkle);
            this.Controls.Add(this.comboBirim);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtMiktari);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtSatisFiyat_1);
            this.Controls.Add(this.txtAlisFiyat);
            this.Controls.Add(this.numericKDVOran);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.btnBarkodUret);
            this.Controls.Add(this.txtBarkod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmHizliStokEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hızlı Stok Ekle";
            this.Load += new System.EventHandler(this.FrmHizliStokEkle_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmHizliStokEkle_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.numericKDVOran)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSatisFiyat_1;
        private System.Windows.Forms.TextBox txtAlisFiyat;
        private System.Windows.Forms.NumericUpDown numericKDVOran;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Button btnBarkodUret;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMiktari;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnBirimEkle;
        private System.Windows.Forms.ComboBox comboBirim;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnIslemIptal;
        private System.Windows.Forms.Button btnUrunEkle;
    }
}