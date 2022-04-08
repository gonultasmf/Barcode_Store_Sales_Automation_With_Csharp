
namespace BarkodluOtomasyon
{
    partial class FrmUrunIadeIslem
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
            this.listeIadeUrunler = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTIEUSayisi = new System.Windows.Forms.TextBox();
            this.btnKapat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTIEUFiyat = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listeIadeUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listeIadeUrunler);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 354);
            this.panel1.TabIndex = 0;
            // 
            // listeIadeUrunler
            // 
            this.listeIadeUrunler.AllowUserToAddRows = false;
            this.listeIadeUrunler.AllowUserToDeleteRows = false;
            this.listeIadeUrunler.AllowUserToResizeRows = false;
            this.listeIadeUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listeIadeUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listeIadeUrunler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listeIadeUrunler.Location = new System.Drawing.Point(0, 0);
            this.listeIadeUrunler.MultiSelect = false;
            this.listeIadeUrunler.Name = "listeIadeUrunler";
            this.listeIadeUrunler.ReadOnly = true;
            this.listeIadeUrunler.RowHeadersVisible = false;
            this.listeIadeUrunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listeIadeUrunler.Size = new System.Drawing.Size(806, 354);
            this.listeIadeUrunler.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Toplam İade Edilen Ürün Sayısı :";
            // 
            // txtTIEUSayisi
            // 
            this.txtTIEUSayisi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTIEUSayisi.Location = new System.Drawing.Point(219, 375);
            this.txtTIEUSayisi.Name = "txtTIEUSayisi";
            this.txtTIEUSayisi.ReadOnly = true;
            this.txtTIEUSayisi.Size = new System.Drawing.Size(168, 27);
            this.txtTIEUSayisi.TabIndex = 2;
            // 
            // btnKapat
            // 
            this.btnKapat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.Image = global::BarkodluOtomasyon.Properties.Resources.arrow__1_;
            this.btnKapat.Location = new System.Drawing.Point(774, 370);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(45, 38);
            this.btnKapat.TabIndex = 3;
            this.btnKapat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKapat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(398, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Toplam İade Edilen Ürün Fiyat :";
            // 
            // txtTIEUFiyat
            // 
            this.txtTIEUFiyat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTIEUFiyat.Location = new System.Drawing.Point(600, 375);
            this.txtTIEUFiyat.Name = "txtTIEUFiyat";
            this.txtTIEUFiyat.ReadOnly = true;
            this.txtTIEUFiyat.Size = new System.Drawing.Size(168, 27);
            this.txtTIEUFiyat.TabIndex = 2;
            // 
            // FrmUrunIadeIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 414);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.txtTIEUFiyat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTIEUSayisi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmUrunIadeIslem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün İade İşlem";
            this.Load += new System.EventHandler(this.FrmUrunIadeIslem_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listeIadeUrunler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView listeIadeUrunler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTIEUSayisi;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTIEUFiyat;
    }
}