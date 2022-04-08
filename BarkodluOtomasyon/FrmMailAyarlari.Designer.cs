
namespace BarkodluOtomasyon
{
    partial class FrmMailAyarlari
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
            this.comboMail = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMailSifre = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.chckSSL = new System.Windows.Forms.CheckBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboMail);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtMailSifre);
            this.panel1.Controls.Add(this.txtMail);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnKaydet);
            this.panel1.Controls.Add(this.btnIptal);
            this.panel1.Controls.Add(this.chckSSL);
            this.panel1.Controls.Add(this.txtPort);
            this.panel1.Controls.Add(this.txtHost);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 267);
            this.panel1.TabIndex = 1;
            // 
            // comboMail
            // 
            this.comboMail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMail.FormattingEnabled = true;
            this.comboMail.Items.AddRange(new object[] {
            "HOTMAIL ",
            "GMAIL ",
            "YAHOO ",
            "YANDEX ",
            "MYNET ",
            "GMX ",
            "AOL "});
            this.comboMail.Location = new System.Drawing.Point(102, 11);
            this.comboMail.Name = "comboMail";
            this.comboMail.Size = new System.Drawing.Size(215, 22);
            this.comboMail.TabIndex = 77;
            this.comboMail.SelectedIndexChanged += new System.EventHandler(this.comboMail_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(25, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 14);
            this.label7.TabIndex = 74;
            this.label7.Text = "Mail Şifre :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(25, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 14);
            this.label4.TabIndex = 73;
            this.label4.Text = "Mail Türü :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(21, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 14);
            this.label6.TabIndex = 73;
            this.label6.Text = "Firma Mail :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMailSifre
            // 
            this.txtMailSifre.Location = new System.Drawing.Point(102, 83);
            this.txtMailSifre.Name = "txtMailSifre";
            this.txtMailSifre.Size = new System.Drawing.Size(215, 22);
            this.txtMailSifre.TabIndex = 76;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(102, 46);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(215, 22);
            this.txtMail.TabIndex = 75;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(16, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "SMTP Güvenlik :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(16, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "SMTP Port :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(14, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "SMTP Host :";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKaydet.AutoSize = true;
            this.btnKaydet.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnKaydet.Image = global::BarkodluOtomasyon.Properties.Resources._checked;
            this.btnKaydet.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnKaydet.Location = new System.Drawing.Point(211, 217);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(106, 40);
            this.btnKaydet.TabIndex = 40;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKaydet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIptal.AutoSize = true;
            this.btnIptal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnIptal.Image = global::BarkodluOtomasyon.Properties.Resources.multiply;
            this.btnIptal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnIptal.Location = new System.Drawing.Point(116, 217);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(89, 40);
            this.btnIptal.TabIndex = 39;
            this.btnIptal.Text = "İPTAL";
            this.btnIptal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIptal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIptal.UseVisualStyleBackColor = true;
            // 
            // chckSSL
            // 
            this.chckSSL.AutoSize = true;
            this.chckSSL.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chckSSL.Location = new System.Drawing.Point(142, 193);
            this.chckSSL.Name = "chckSSL";
            this.chckSSL.Size = new System.Drawing.Size(53, 18);
            this.chckSSL.TabIndex = 2;
            this.chckSSL.Text = "SSL ";
            this.chckSSL.UseVisualStyleBackColor = true;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(102, 155);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(215, 22);
            this.txtPort.TabIndex = 1;
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(102, 119);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(215, 22);
            this.txtHost.TabIndex = 1;
            // 
            // FrmMailAyarlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 292);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmMailAyarlari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mail Ayarları";
            this.Load += new System.EventHandler(this.FrmMailAyarlari_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboMail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMailSifre;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.CheckBox chckSSL;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtHost;
    }
}