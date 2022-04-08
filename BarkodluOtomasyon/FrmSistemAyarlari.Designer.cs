
namespace BarkodluOtomasyon
{
    partial class FrmSistemAyarlari
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
            this.comboTema = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirmaAdi = new System.Windows.Forms.TextBox();
            this.txtFirmaTelNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.AutoSize = true;
            this.btnKaydet.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Image = global::BarkodluOtomasyon.Properties.Resources._checked;
            this.btnKaydet.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnKaydet.Location = new System.Drawing.Point(184, 114);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(123, 47);
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
            this.btnIptal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.Image = global::BarkodluOtomasyon.Properties.Resources.multiply;
            this.btnIptal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnIptal.Location = new System.Drawing.Point(72, 114);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(99, 47);
            this.btnIptal.TabIndex = 30;
            this.btnIptal.Text = "İPTAL";
            this.btnIptal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIptal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // comboTema
            // 
            this.comboTema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTema.FormattingEnabled = true;
            this.comboTema.Items.AddRange(new object[] {
            "Standart Tema",
            "Aydınlık Tema ",
            "Karanlık Tema",
            "Lacivert Tema",
            "Gri Tema",
            "Siyah Tema",
            "KoyuGri Tema"});
            this.comboTema.Location = new System.Drawing.Point(135, 76);
            this.comboTema.Name = "comboTema";
            this.comboTema.Size = new System.Drawing.Size(172, 22);
            this.comboTema.TabIndex = 28;
            this.comboTema.SelectedIndexChanged += new System.EventHandler(this.comboTema_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(10, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 14);
            this.label2.TabIndex = 26;
            this.label2.Text = "Sistem Teması :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(37, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 14);
            this.label1.TabIndex = 27;
            this.label1.Text = "Firma Adı :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFirmaAdi
            // 
            this.txtFirmaAdi.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFirmaAdi.Location = new System.Drawing.Point(135, 12);
            this.txtFirmaAdi.Name = "txtFirmaAdi";
            this.txtFirmaAdi.Size = new System.Drawing.Size(172, 26);
            this.txtFirmaAdi.TabIndex = 32;
            // 
            // txtFirmaTelNo
            // 
            this.txtFirmaTelNo.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFirmaTelNo.Location = new System.Drawing.Point(135, 44);
            this.txtFirmaTelNo.Name = "txtFirmaTelNo";
            this.txtFirmaTelNo.Size = new System.Drawing.Size(172, 26);
            this.txtFirmaTelNo.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(37, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 14);
            this.label3.TabIndex = 27;
            this.label3.Text = "Firma Tel. No :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmSistemAyarlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 177);
            this.Controls.Add(this.txtFirmaTelNo);
            this.Controls.Add(this.txtFirmaAdi);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.comboTema);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmSistemAyarlari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistem Ayarları";
            this.Load += new System.EventHandler(this.FrmSistemAyarlari_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.ComboBox comboTema;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirmaAdi;
        private System.Windows.Forms.TextBox txtFirmaTelNo;
        private System.Windows.Forms.Label label3;
    }
}