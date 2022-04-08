
namespace BarkodluOtomasyon
{
    partial class FrmParaCikis
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGirenMiktar = new System.Windows.Forms.TextBox();
            this.comboAciklama = new System.Windows.Forms.ComboBox();
            this.txtIslemNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnIslemNoVer = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(294, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 48);
            this.panel2.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(25, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "KASA PARA ÇIKIŞI";
            // 
            // txtGirenMiktar
            // 
            this.txtGirenMiktar.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGirenMiktar.Location = new System.Drawing.Point(371, 203);
            this.txtGirenMiktar.Name = "txtGirenMiktar";
            this.txtGirenMiktar.Size = new System.Drawing.Size(206, 26);
            this.txtGirenMiktar.TabIndex = 29;
            this.txtGirenMiktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGirenMiktar_KeyPress);
            this.txtGirenMiktar.Leave += new System.EventHandler(this.txtGirenMiktar_Leave);
            // 
            // comboAciklama
            // 
            this.comboAciklama.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboAciklama.FormattingEnabled = true;
            this.comboAciklama.Items.AddRange(new object[] {
            "Kira ",
            "Elektrik ",
            "Su ",
            "Doğalgaz",
            "Telefon",
            "Personel Maaşı",
            "Personel Avans",
            "Muhasebe Aidatı",
            "Vergi ",
            "Dekor Gideri"});
            this.comboAciklama.Location = new System.Drawing.Point(371, 161);
            this.comboAciklama.Name = "comboAciklama";
            this.comboAciklama.Size = new System.Drawing.Size(206, 24);
            this.comboAciklama.TabIndex = 28;
            // 
            // txtIslemNo
            // 
            this.txtIslemNo.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIslemNo.Location = new System.Drawing.Point(371, 77);
            this.txtIslemNo.Name = "txtIslemNo";
            this.txtIslemNo.ReadOnly = true;
            this.txtIslemNo.Size = new System.Drawing.Size(206, 26);
            this.txtIslemNo.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 14);
            this.label3.TabIndex = 23;
            this.label3.Text = "Çıkan Miktar :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 14);
            this.label2.TabIndex = 24;
            this.label2.Text = "Açıklama :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 14);
            this.label1.TabIndex = 25;
            this.label1.Text = "İşlem No / Fiş No :";
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Image = global::BarkodluOtomasyon.Properties.Resources._checked;
            this.btnEkle.Location = new System.Drawing.Point(466, 255);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(111, 49);
            this.btnEkle.TabIndex = 30;
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
            this.btnIptal.Location = new System.Drawing.Point(329, 255);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(111, 49);
            this.btnIptal.TabIndex = 31;
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
            this.btnIslemNoVer.Location = new System.Drawing.Point(371, 109);
            this.btnIslemNoVer.Name = "btnIslemNoVer";
            this.btnIslemNoVer.Size = new System.Drawing.Size(206, 39);
            this.btnIslemNoVer.TabIndex = 27;
            this.btnIslemNoVer.Text = "İŞLEM/FİŞ NO VER";
            this.btnIslemNoVer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIslemNoVer.UseVisualStyleBackColor = true;
            this.btnIslemNoVer.Click += new System.EventHandler(this.btnIslemNoVer_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::BarkodluOtomasyon.Properties.Resources.minus;
            this.pictureBox2.Location = new System.Drawing.Point(206, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 71);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::BarkodluOtomasyon.Properties.Resources.wallet;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 316);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // FrmParaCikis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 318);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.txtGirenMiktar);
            this.Controls.Add(this.comboAciklama);
            this.Controls.Add(this.btnIslemNoVer);
            this.Controls.Add(this.txtIslemNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmParaCikis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmParaCikis";
            this.Load += new System.EventHandler(this.FrmParaCikis_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.TextBox txtGirenMiktar;
        private System.Windows.Forms.ComboBox comboAciklama;
        private System.Windows.Forms.Button btnIslemNoVer;
        private System.Windows.Forms.TextBox txtIslemNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}