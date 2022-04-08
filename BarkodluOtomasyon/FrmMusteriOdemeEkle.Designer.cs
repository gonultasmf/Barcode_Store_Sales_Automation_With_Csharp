
namespace BarkodluOtomasyon
{
    partial class FrmMusteriOdemeEkle
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.RichTextBox();
            this.btnIslemNoVer = new System.Windows.Forms.Button();
            this.txtIslemNo = new System.Windows.Forms.TextBox();
            this.txtTarih = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboOdemeSekli = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboOdemeSekli);
            this.panel1.Controls.Add(this.btnEkle);
            this.panel1.Controls.Add(this.btnIptal);
            this.panel1.Controls.Add(this.txtTutar);
            this.panel1.Controls.Add(this.txtAciklama);
            this.panel1.Controls.Add(this.btnIslemNoVer);
            this.panel1.Controls.Add(this.txtIslemNo);
            this.panel1.Controls.Add(this.txtTarih);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(177, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 300);
            this.panel1.TabIndex = 3;
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Image = global::BarkodluOtomasyon.Properties.Resources._checked;
            this.btnEkle.Location = new System.Drawing.Point(209, 247);
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
            this.btnIptal.Location = new System.Drawing.Point(70, 247);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(111, 46);
            this.btnIptal.TabIndex = 21;
            this.btnIptal.Text = "İPTAL";
            this.btnIptal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIptal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // txtTutar
            // 
            this.txtTutar.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTutar.Location = new System.Drawing.Point(114, 215);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(206, 26);
            this.txtTutar.TabIndex = 18;
            this.txtTutar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTutar_KeyPress);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAciklama.Location = new System.Drawing.Point(114, 125);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(206, 52);
            this.txtAciklama.TabIndex = 17;
            this.txtAciklama.Text = "ÖDEME YAPILDI";
            // 
            // btnIslemNoVer
            // 
            this.btnIslemNoVer.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIslemNoVer.Image = global::BarkodluOtomasyon.Properties.Resources.shuffle;
            this.btnIslemNoVer.Location = new System.Drawing.Point(114, 79);
            this.btnIslemNoVer.Name = "btnIslemNoVer";
            this.btnIslemNoVer.Size = new System.Drawing.Size(206, 39);
            this.btnIslemNoVer.TabIndex = 16;
            this.btnIslemNoVer.Text = "İŞLEM/FİŞ NO VER";
            this.btnIslemNoVer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIslemNoVer.UseVisualStyleBackColor = true;
            this.btnIslemNoVer.Click += new System.EventHandler(this.btnIslemNoVer_Click);
            // 
            // txtIslemNo
            // 
            this.txtIslemNo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIslemNo.Location = new System.Drawing.Point(114, 46);
            this.txtIslemNo.Name = "txtIslemNo";
            this.txtIslemNo.ReadOnly = true;
            this.txtIslemNo.Size = new System.Drawing.Size(206, 27);
            this.txtIslemNo.TabIndex = 2;
            // 
            // txtTarih
            // 
            this.txtTarih.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTarih.Location = new System.Drawing.Point(114, 9);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.ReadOnly = true;
            this.txtTarih.Size = new System.Drawing.Size(206, 26);
            this.txtTarih.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 14);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tutar :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 14);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BarkodluOtomasyon.Properties.Resources.money_wallet_icon;
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 301);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 14);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ödeme Şekli :";
            // 
            // comboOdemeSekli
            // 
            this.comboOdemeSekli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboOdemeSekli.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboOdemeSekli.FormattingEnabled = true;
            this.comboOdemeSekli.Items.AddRange(new object[] {
            "Nakit",
            "POS",
            "Çek",
            "Banka"});
            this.comboOdemeSekli.Location = new System.Drawing.Point(114, 183);
            this.comboOdemeSekli.Name = "comboOdemeSekli";
            this.comboOdemeSekli.Size = new System.Drawing.Size(206, 26);
            this.comboOdemeSekli.TabIndex = 22;
            // 
            // FrmMusteriOdemeEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 325);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmMusteriOdemeEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödeme Ekle";
            this.Load += new System.EventHandler(this.FrmMusteriOdemeEkle_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.RichTextBox txtAciklama;
        private System.Windows.Forms.Button btnIslemNoVer;
        private System.Windows.Forms.TextBox txtIslemNo;
        private System.Windows.Forms.TextBox txtTarih;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboOdemeSekli;
        private System.Windows.Forms.Label label5;
    }
}