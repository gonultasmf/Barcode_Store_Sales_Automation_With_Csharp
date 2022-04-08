
namespace BarkodluOtomasyon
{
    partial class FrmMusteriGrupIslemleri
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
            this.txtMusteriGrup = new System.Windows.Forms.TextBox();
            this.listeMusteriGrup = new System.Windows.Forms.DataGridView();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listeMusteriGrup)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMusteriGrup
            // 
            this.txtMusteriGrup.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriGrup.Location = new System.Drawing.Point(12, 12);
            this.txtMusteriGrup.Name = "txtMusteriGrup";
            this.txtMusteriGrup.Size = new System.Drawing.Size(212, 30);
            this.txtMusteriGrup.TabIndex = 0;
            // 
            // listeMusteriGrup
            // 
            this.listeMusteriGrup.AllowUserToAddRows = false;
            this.listeMusteriGrup.AllowUserToDeleteRows = false;
            this.listeMusteriGrup.AllowUserToResizeRows = false;
            this.listeMusteriGrup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listeMusteriGrup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listeMusteriGrup.Location = new System.Drawing.Point(12, 55);
            this.listeMusteriGrup.MultiSelect = false;
            this.listeMusteriGrup.Name = "listeMusteriGrup";
            this.listeMusteriGrup.ReadOnly = true;
            this.listeMusteriGrup.RowHeadersVisible = false;
            this.listeMusteriGrup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listeMusteriGrup.Size = new System.Drawing.Size(301, 321);
            this.listeMusteriGrup.TabIndex = 6;
            // 
            // btnKapat
            // 
            this.btnKapat.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.Image = global::BarkodluOtomasyon.Properties.Resources.arrow__1_;
            this.btnKapat.Location = new System.Drawing.Point(259, 382);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(54, 41);
            this.btnKapat.TabIndex = 1;
            this.btnKapat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKapat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Image = global::BarkodluOtomasyon.Properties.Resources.checkmark;
            this.btnEkle.Location = new System.Drawing.Point(230, 8);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(83, 41);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Image = global::BarkodluOtomasyon.Properties.Resources.delete__1_;
            this.btnSil.Location = new System.Drawing.Point(12, 382);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(225, 41);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "SEÇİLİ KAYDI SİL";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // FrmMusteriGrupIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 435);
            this.Controls.Add(this.listeMusteriGrup);
            this.Controls.Add(this.txtMusteriGrup);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnSil);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmMusteriGrupIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Grup İşlemleri";
            this.Load += new System.EventHandler(this.FrmMusteriGrupIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listeMusteriGrup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMusteriGrup;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.DataGridView listeMusteriGrup;
    }
}