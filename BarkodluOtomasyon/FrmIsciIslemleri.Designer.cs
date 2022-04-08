
namespace BarkodluOtomasyon
{
    partial class FrmIsciIslemleri
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
            this.listeIsciler = new System.Windows.Forms.DataGridView();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnIstenCikart = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtIsci = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listeIsciler)).BeginInit();
            this.SuspendLayout();
            // 
            // listeIsciler
            // 
            this.listeIsciler.AllowUserToAddRows = false;
            this.listeIsciler.AllowUserToDeleteRows = false;
            this.listeIsciler.AllowUserToResizeRows = false;
            this.listeIsciler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listeIsciler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listeIsciler.Location = new System.Drawing.Point(12, 55);
            this.listeIsciler.MultiSelect = false;
            this.listeIsciler.Name = "listeIsciler";
            this.listeIsciler.ReadOnly = true;
            this.listeIsciler.RowHeadersVisible = false;
            this.listeIsciler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listeIsciler.Size = new System.Drawing.Size(301, 321);
            this.listeIsciler.TabIndex = 11;
            // 
            // btnKapat
            // 
            this.btnKapat.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.Image = global::BarkodluOtomasyon.Properties.Resources.arrow__1_;
            this.btnKapat.Location = new System.Drawing.Point(281, 382);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(32, 41);
            this.btnKapat.TabIndex = 8;
            this.btnKapat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKapat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnIstenCikart
            // 
            this.btnIstenCikart.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIstenCikart.Image = global::BarkodluOtomasyon.Properties.Resources.multiply;
            this.btnIstenCikart.Location = new System.Drawing.Point(54, 382);
            this.btnIstenCikart.Name = "btnIstenCikart";
            this.btnIstenCikart.Size = new System.Drawing.Size(221, 41);
            this.btnIstenCikart.TabIndex = 9;
            this.btnIstenCikart.Text = "SEÇİLİ İŞÇİYİ ÇIKART";
            this.btnIstenCikart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIstenCikart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIstenCikart.UseVisualStyleBackColor = true;
            this.btnIstenCikart.Click += new System.EventHandler(this.btnIstenCikart_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Image = global::BarkodluOtomasyon.Properties.Resources.checkmark;
            this.btnEkle.Location = new System.Drawing.Point(230, 8);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(83, 41);
            this.btnEkle.TabIndex = 10;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtIsci
            // 
            this.txtIsci.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIsci.Location = new System.Drawing.Point(12, 12);
            this.txtIsci.Name = "txtIsci";
            this.txtIsci.Size = new System.Drawing.Size(212, 30);
            this.txtIsci.TabIndex = 7;
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Image = global::BarkodluOtomasyon.Properties.Resources.delete__1_;
            this.btnSil.Location = new System.Drawing.Point(12, 382);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(36, 41);
            this.btnSil.TabIndex = 8;
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // FrmIsciIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 435);
            this.Controls.Add(this.listeIsciler);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnIstenCikart);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtIsci);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmIsciIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmIsciIslemleri";
            this.Load += new System.EventHandler(this.FrmIsciIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listeIsciler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listeIsciler;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnIstenCikart;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtIsci;
        private System.Windows.Forms.Button btnSil;
    }
}