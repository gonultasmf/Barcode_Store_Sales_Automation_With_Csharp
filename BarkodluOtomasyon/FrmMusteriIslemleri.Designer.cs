
namespace BarkodluOtomasyon
{
    partial class FrmMusteriIslemleri
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
            this.btnMusteriAyrinti = new System.Windows.Forms.Button();
            this.btnListeYazdir = new System.Windows.Forms.Button();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.comboArama = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnListeExcelAktar = new System.Windows.Forms.Button();
            this.btnListeTopla = new System.Windows.Forms.Button();
            this.btnMusteriSil = new System.Windows.Forms.Button();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listeMusteri = new System.Windows.Forms.DataGridView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listeMusteri)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMusteriAyrinti);
            this.panel1.Controls.Add(this.btnListeYazdir);
            this.panel1.Controls.Add(this.txtArama);
            this.panel1.Controls.Add(this.comboArama);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnKapat);
            this.panel1.Controls.Add(this.btnListeExcelAktar);
            this.panel1.Controls.Add(this.btnListeTopla);
            this.panel1.Controls.Add(this.btnMusteriSil);
            this.panel1.Controls.Add(this.btnMusteriEkle);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(919, 100);
            this.panel1.TabIndex = 0;
            // 
            // btnMusteriAyrinti
            // 
            this.btnMusteriAyrinti.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriAyrinti.Image = global::BarkodluOtomasyon.Properties.Resources.eye;
            this.btnMusteriAyrinti.Location = new System.Drawing.Point(484, 7);
            this.btnMusteriAyrinti.Name = "btnMusteriAyrinti";
            this.btnMusteriAyrinti.Size = new System.Drawing.Size(90, 85);
            this.btnMusteriAyrinti.TabIndex = 0;
            this.btnMusteriAyrinti.Text = "MÜŞTERİ AYRINTI";
            this.btnMusteriAyrinti.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMusteriAyrinti.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMusteriAyrinti.UseVisualStyleBackColor = true;
            this.btnMusteriAyrinti.Click += new System.EventHandler(this.btnMusteriAyrinti_Click);
            // 
            // btnListeYazdir
            // 
            this.btnListeYazdir.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListeYazdir.Image = global::BarkodluOtomasyon.Properties.Resources.printer;
            this.btnListeYazdir.Location = new System.Drawing.Point(292, 7);
            this.btnListeYazdir.Name = "btnListeYazdir";
            this.btnListeYazdir.Size = new System.Drawing.Size(90, 85);
            this.btnListeYazdir.TabIndex = 0;
            this.btnListeYazdir.Text = "LİSTEYİ YAZDIR";
            this.btnListeYazdir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnListeYazdir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnListeYazdir.UseVisualStyleBackColor = true;
            this.btnListeYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // txtArama
            // 
            this.txtArama.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtArama.Location = new System.Drawing.Point(684, 55);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(180, 23);
            this.txtArama.TabIndex = 3;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // comboArama
            // 
            this.comboArama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboArama.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboArama.FormattingEnabled = true;
            this.comboArama.Items.AddRange(new object[] {
            "Müşteri No\'ya Göre",
            "Müşteri Adına Göre",
            "Hesap Türüne Göre"});
            this.comboArama.Location = new System.Drawing.Point(684, 19);
            this.comboArama.Name = "comboArama";
            this.comboArama.Size = new System.Drawing.Size(180, 24);
            this.comboArama.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(574, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Aramak İçin Yaz :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(587, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Arama Ölçütü :";
            // 
            // btnKapat
            // 
            this.btnKapat.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.Image = global::BarkodluOtomasyon.Properties.Resources.arrow__1_;
            this.btnKapat.Location = new System.Drawing.Point(870, 19);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(44, 59);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKapat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnListeExcelAktar
            // 
            this.btnListeExcelAktar.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListeExcelAktar.Image = global::BarkodluOtomasyon.Properties.Resources.excel;
            this.btnListeExcelAktar.Location = new System.Drawing.Point(388, 7);
            this.btnListeExcelAktar.Name = "btnListeExcelAktar";
            this.btnListeExcelAktar.Size = new System.Drawing.Size(90, 85);
            this.btnListeExcelAktar.TabIndex = 0;
            this.btnListeExcelAktar.Text = "EXCEL\'E AKTAR";
            this.btnListeExcelAktar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnListeExcelAktar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnListeExcelAktar.UseVisualStyleBackColor = true;
            this.btnListeExcelAktar.Click += new System.EventHandler(this.btnListeExcelAktar_Click);
            // 
            // btnListeTopla
            // 
            this.btnListeTopla.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListeTopla.Image = global::BarkodluOtomasyon.Properties.Resources.calculations;
            this.btnListeTopla.Location = new System.Drawing.Point(196, 7);
            this.btnListeTopla.Name = "btnListeTopla";
            this.btnListeTopla.Size = new System.Drawing.Size(90, 85);
            this.btnListeTopla.TabIndex = 0;
            this.btnListeTopla.Text = "LİSTEYİ TOPLA";
            this.btnListeTopla.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnListeTopla.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnListeTopla.UseVisualStyleBackColor = true;
            this.btnListeTopla.Click += new System.EventHandler(this.btnListeTopla_Click);
            // 
            // btnMusteriSil
            // 
            this.btnMusteriSil.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriSil.Image = global::BarkodluOtomasyon.Properties.Resources.delete__1_;
            this.btnMusteriSil.Location = new System.Drawing.Point(100, 7);
            this.btnMusteriSil.Name = "btnMusteriSil";
            this.btnMusteriSil.Size = new System.Drawing.Size(90, 85);
            this.btnMusteriSil.TabIndex = 0;
            this.btnMusteriSil.Text = "MÜŞTERİ SİL";
            this.btnMusteriSil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMusteriSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMusteriSil.UseVisualStyleBackColor = true;
            this.btnMusteriSil.Click += new System.EventHandler(this.btnMusteriSil_Click);
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriEkle.Image = global::BarkodluOtomasyon.Properties.Resources.add_user;
            this.btnMusteriEkle.Location = new System.Drawing.Point(4, 7);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(90, 85);
            this.btnMusteriEkle.TabIndex = 0;
            this.btnMusteriEkle.Text = "MÜŞTERİ EKLE";
            this.btnMusteriEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMusteriEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMusteriEkle.UseVisualStyleBackColor = true;
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listeMusteri);
            this.panel2.Location = new System.Drawing.Point(13, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(919, 372);
            this.panel2.TabIndex = 1;
            // 
            // listeMusteri
            // 
            this.listeMusteri.AllowUserToAddRows = false;
            this.listeMusteri.AllowUserToDeleteRows = false;
            this.listeMusteri.AllowUserToResizeRows = false;
            this.listeMusteri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listeMusteri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listeMusteri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listeMusteri.Location = new System.Drawing.Point(0, 0);
            this.listeMusteri.MultiSelect = false;
            this.listeMusteri.Name = "listeMusteri";
            this.listeMusteri.ReadOnly = true;
            this.listeMusteri.RowHeadersVisible = false;
            this.listeMusteri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listeMusteri.Size = new System.Drawing.Size(919, 372);
            this.listeMusteri.TabIndex = 3;
            this.listeMusteri.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listeMusteri_CellContentDoubleClick);
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
            // FrmMusteriIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 504);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmMusteriIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri İşlemleri";
            this.Load += new System.EventHandler(this.FrmHesapDefteri_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listeMusteri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnListeTopla;
        private System.Windows.Forms.Button btnMusteriSil;
        private System.Windows.Forms.Button btnListeYazdir;
        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.Button btnMusteriAyrinti;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.ComboBox comboArama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnListeExcelAktar;
        private System.Windows.Forms.DataGridView listeMusteri;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}