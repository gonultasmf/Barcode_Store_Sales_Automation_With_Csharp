
namespace BarkodluOtomasyon
{
    partial class FrmMusteriSec
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
            this.txtArama = new System.Windows.Forms.TextBox();
            this.comboArama = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnYeniMusteriEkle = new System.Windows.Forms.Button();
            this.btnSec = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listeMusteri = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listeMusteri)).BeginInit();
            this.SuspendLayout();
            // 
            // txtArama
            // 
            this.txtArama.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtArama.Location = new System.Drawing.Point(461, 13);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(180, 23);
            this.txtArama.TabIndex = 7;
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
            this.comboArama.Location = new System.Drawing.Point(157, 12);
            this.comboArama.Name = "comboArama";
            this.comboArama.Size = new System.Drawing.Size(180, 24);
            this.comboArama.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Aramak İçin Yaz :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "Arama Ölçütü :";
            // 
            // btnYeniMusteriEkle
            // 
            this.btnYeniMusteriEkle.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniMusteriEkle.Image = global::BarkodluOtomasyon.Properties.Resources.add_user;
            this.btnYeniMusteriEkle.Location = new System.Drawing.Point(13, 338);
            this.btnYeniMusteriEkle.Name = "btnYeniMusteriEkle";
            this.btnYeniMusteriEkle.Size = new System.Drawing.Size(214, 45);
            this.btnYeniMusteriEkle.TabIndex = 8;
            this.btnYeniMusteriEkle.Text = "YENİ MÜŞTERİ EKLE";
            this.btnYeniMusteriEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYeniMusteriEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnYeniMusteriEkle.UseVisualStyleBackColor = true;
            this.btnYeniMusteriEkle.Click += new System.EventHandler(this.btnYeniMusteriEkle_Click);
            // 
            // btnSec
            // 
            this.btnSec.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSec.Image = global::BarkodluOtomasyon.Properties.Resources._checked;
            this.btnSec.Location = new System.Drawing.Point(584, 338);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(107, 45);
            this.btnSec.TabIndex = 8;
            this.btnSec.Text = "SEÇ";
            this.btnSec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSec.UseVisualStyleBackColor = true;
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.Image = global::BarkodluOtomasyon.Properties.Resources.multiply;
            this.btnIptal.Location = new System.Drawing.Point(471, 338);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(107, 45);
            this.btnIptal.TabIndex = 8;
            this.btnIptal.Text = "İPTAL";
            this.btnIptal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIptal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listeMusteri);
            this.panel1.Location = new System.Drawing.Point(13, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(678, 290);
            this.panel1.TabIndex = 9;
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
            this.listeMusteri.Size = new System.Drawing.Size(678, 290);
            this.listeMusteri.TabIndex = 4;
            // 
            // FrmMusteriSec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 392);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnSec);
            this.Controls.Add(this.btnYeniMusteriEkle);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.comboArama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmMusteriSec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Musteri Seç";
            this.Load += new System.EventHandler(this.FrmMusteriSec_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listeMusteri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.ComboBox comboArama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnYeniMusteriEkle;
        private System.Windows.Forms.Button btnSec;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView listeMusteri;
    }
}