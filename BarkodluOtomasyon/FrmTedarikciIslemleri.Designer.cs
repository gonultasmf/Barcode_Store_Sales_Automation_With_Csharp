
namespace BarkodluOtomasyon
{
    partial class FrmTedarikciIslemleri
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
            this.listeTedarikci = new System.Windows.Forms.DataGridView();
            this.txtTedarikci = new System.Windows.Forms.TextBox();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listeTedarikci)).BeginInit();
            this.SuspendLayout();
            // 
            // listeTedarikci
            // 
            this.listeTedarikci.AllowUserToAddRows = false;
            this.listeTedarikci.AllowUserToDeleteRows = false;
            this.listeTedarikci.AllowUserToResizeRows = false;
            this.listeTedarikci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listeTedarikci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listeTedarikci.Location = new System.Drawing.Point(12, 57);
            this.listeTedarikci.MultiSelect = false;
            this.listeTedarikci.Name = "listeTedarikci";
            this.listeTedarikci.ReadOnly = true;
            this.listeTedarikci.RowHeadersVisible = false;
            this.listeTedarikci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listeTedarikci.Size = new System.Drawing.Size(301, 321);
            this.listeTedarikci.TabIndex = 16;
            // 
            // txtTedarikci
            // 
            this.txtTedarikci.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTedarikci.Location = new System.Drawing.Point(12, 14);
            this.txtTedarikci.Name = "txtTedarikci";
            this.txtTedarikci.Size = new System.Drawing.Size(212, 30);
            this.txtTedarikci.TabIndex = 12;
            // 
            // btnKapat
            // 
            this.btnKapat.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.Image = global::BarkodluOtomasyon.Properties.Resources.arrow__1_;
            this.btnKapat.Location = new System.Drawing.Point(259, 384);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(54, 41);
            this.btnKapat.TabIndex = 13;
            this.btnKapat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKapat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Image = global::BarkodluOtomasyon.Properties.Resources.delete__1_;
            this.btnSil.Location = new System.Drawing.Point(12, 384);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(225, 41);
            this.btnSil.TabIndex = 14;
            this.btnSil.Text = "SEÇİLİ KAYDI SİL";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Image = global::BarkodluOtomasyon.Properties.Resources.checkmark;
            this.btnEkle.Location = new System.Drawing.Point(230, 10);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(83, 41);
            this.btnEkle.TabIndex = 15;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // FrmTedarikciIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 435);
            this.Controls.Add(this.listeTedarikci);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtTedarikci);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmTedarikciIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tedarikçi İşlemleri";
            this.Load += new System.EventHandler(this.FrmTedarikciIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listeTedarikci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listeTedarikci;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtTedarikci;
    }
}