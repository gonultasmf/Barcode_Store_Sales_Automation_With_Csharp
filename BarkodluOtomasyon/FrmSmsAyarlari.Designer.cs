
namespace BarkodluOtomasyon
{
    partial class FrmSmsAyarlari
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
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMesaj2 = new System.Windows.Forms.RichTextBox();
            this.txtMesaj1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboSMS = new System.Windows.Forms.ComboBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelControl1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.labelControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.AutoSize = true;
            this.btnKaydet.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnKaydet.Image = global::BarkodluOtomasyon.Properties.Resources._checked;
            this.btnKaydet.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnKaydet.Location = new System.Drawing.Point(289, 223);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(109, 42);
            this.btnKaydet.TabIndex = 31;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKaydet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.AutoSize = true;
            this.btnIptal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnIptal.Image = global::BarkodluOtomasyon.Properties.Resources.multiply;
            this.btnIptal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnIptal.Location = new System.Drawing.Point(195, 223);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(88, 42);
            this.btnIptal.TabIndex = 30;
            this.btnIptal.Text = "İPTAL";
            this.btnIptal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIptal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtMesaj2);
            this.panel1.Controls.Add(this.txtMesaj1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 122);
            this.panel1.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(284, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 14);
            this.label6.TabIndex = 29;
            this.label6.Text = "Mesaj-2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(131, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 14);
            this.label5.TabIndex = 28;
            this.label5.Text = "Mesaj-1";
            // 
            // txtMesaj2
            // 
            this.txtMesaj2.Location = new System.Drawing.Point(233, 25);
            this.txtMesaj2.Name = "txtMesaj2";
            this.txtMesaj2.Size = new System.Drawing.Size(143, 89);
            this.txtMesaj2.TabIndex = 24;
            this.txtMesaj2.Text = "";
            // 
            // txtMesaj1
            // 
            this.txtMesaj1.Location = new System.Drawing.Point(88, 25);
            this.txtMesaj1.Name = "txtMesaj1";
            this.txtMesaj1.Size = new System.Drawing.Size(139, 89);
            this.txtMesaj1.TabIndex = 25;
            this.txtMesaj1.Text = "";
            // 
            // label1
            // 
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mesaj İçerik :";
            // 
            // comboSMS
            // 
            this.comboSMS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSMS.FormattingEnabled = true;
            this.comboSMS.Items.AddRange(new object[] {
            "www.vatansms.com",
            "www.ipipi.com",
            "www.iletimerkezi.com"});
            this.comboSMS.Location = new System.Drawing.Point(188, 12);
            this.comboSMS.Name = "comboSMS";
            this.comboSMS.Size = new System.Drawing.Size(210, 22);
            this.comboSMS.TabIndex = 28;
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(187, 68);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(185, 22);
            this.txtParola.TabIndex = 26;
            this.txtParola.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(4, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 14);
            this.label4.TabIndex = 23;
            this.label4.Text = "SMS Paketi Şifre :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtKAdi
            // 
            this.txtKAdi.Location = new System.Drawing.Point(187, 40);
            this.txtKAdi.Name = "txtKAdi";
            this.txtKAdi.Size = new System.Drawing.Size(211, 22);
            this.txtKAdi.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(4, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 14);
            this.label3.TabIndex = 24;
            this.label3.Text = "SMS Paketi Kullanıcı Adı :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(3, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 14);
            this.label2.TabIndex = 25;
            this.label2.Text = "SMS Paket Sitesi :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelControl1
            // 
            this.labelControl1.Image = global::BarkodluOtomasyon.Properties.Resources.eye1;
            this.labelControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelControl1.Location = new System.Drawing.Point(374, 67);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 25);
            this.labelControl1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.labelControl1.TabIndex = 32;
            this.labelControl1.TabStop = false;
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // FrmSmsAyarlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 277);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboSMS);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmSmsAyarlari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMS Ayarları";
            this.Load += new System.EventHandler(this.FrmSmsAyarlari_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.labelControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox labelControl1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txtMesaj2;
        private System.Windows.Forms.RichTextBox txtMesaj1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboSMS;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}