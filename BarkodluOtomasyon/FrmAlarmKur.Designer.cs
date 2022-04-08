
namespace BarkodluOtomasyon
{
    partial class FrmAlarmKur
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
            this.txtAciklama = new System.Windows.Forms.RichTextBox();
            this.txtMusteriKod = new System.Windows.Forms.TextBox();
            this.txtBakiye = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMusteriGrup = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHesapTur = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMusteriAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAlarmKur = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dateSaat = new System.Windows.Forms.DateTimePicker();
            this.dateTarih = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTarih);
            this.panel1.Controls.Add(this.dateSaat);
            this.panel1.Controls.Add(this.btnIptal);
            this.panel1.Controls.Add(this.btnAlarmKur);
            this.panel1.Controls.Add(this.txtAciklama);
            this.panel1.Controls.Add(this.txtMusteriKod);
            this.panel1.Controls.Add(this.txtBakiye);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtTelNo);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtMusteriGrup);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtHesapTur);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtMusteriAd);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 332);
            this.panel1.TabIndex = 0;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(285, 231);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(202, 48);
            this.txtAciklama.TabIndex = 38;
            this.txtAciklama.Text = "";
            // 
            // txtMusteriKod
            // 
            this.txtMusteriKod.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriKod.Location = new System.Drawing.Point(285, 10);
            this.txtMusteriKod.Name = "txtMusteriKod";
            this.txtMusteriKod.ReadOnly = true;
            this.txtMusteriKod.Size = new System.Drawing.Size(202, 26);
            this.txtMusteriKod.TabIndex = 32;
            // 
            // txtBakiye
            // 
            this.txtBakiye.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBakiye.Location = new System.Drawing.Point(285, 170);
            this.txtBakiye.Name = "txtBakiye";
            this.txtBakiye.ReadOnly = true;
            this.txtBakiye.Size = new System.Drawing.Size(202, 26);
            this.txtBakiye.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(204, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 14);
            this.label6.TabIndex = 24;
            this.label6.Text = "Müşteri No :";
            // 
            // txtTelNo
            // 
            this.txtTelNo.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTelNo.Location = new System.Drawing.Point(285, 138);
            this.txtTelNo.Name = "txtTelNo";
            this.txtTelNo.ReadOnly = true;
            this.txtTelNo.Size = new System.Drawing.Size(202, 26);
            this.txtTelNo.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(217, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 14);
            this.label7.TabIndex = 25;
            this.label7.Text = "Açıklama :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(231, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 14);
            this.label5.TabIndex = 26;
            this.label5.Text = "Bakiye :";
            // 
            // txtMusteriGrup
            // 
            this.txtMusteriGrup.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriGrup.Location = new System.Drawing.Point(285, 106);
            this.txtMusteriGrup.Name = "txtMusteriGrup";
            this.txtMusteriGrup.ReadOnly = true;
            this.txtMusteriGrup.Size = new System.Drawing.Size(202, 26);
            this.txtMusteriGrup.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 14);
            this.label4.TabIndex = 27;
            this.label4.Text = "Telefon No :";
            // 
            // txtHesapTur
            // 
            this.txtHesapTur.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHesapTur.Location = new System.Drawing.Point(285, 74);
            this.txtHesapTur.Name = "txtHesapTur";
            this.txtHesapTur.ReadOnly = true;
            this.txtHesapTur.Size = new System.Drawing.Size(202, 26);
            this.txtHesapTur.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 14);
            this.label3.TabIndex = 28;
            this.label3.Text = "Müşteri Grup :";
            // 
            // txtMusteriAd
            // 
            this.txtMusteriAd.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriAd.Location = new System.Drawing.Point(285, 42);
            this.txtMusteriAd.Name = "txtMusteriAd";
            this.txtMusteriAd.ReadOnly = true;
            this.txtMusteriAd.Size = new System.Drawing.Size(202, 26);
            this.txtMusteriAd.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 14);
            this.label2.TabIndex = 29;
            this.label2.Text = "Hesap Türü :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 326);
            this.panel2.TabIndex = 31;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BarkodluOtomasyon.Properties.Resources.tenor;
            this.pictureBox1.Location = new System.Drawing.Point(3, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 227);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 14);
            this.label1.TabIndex = 30;
            this.label1.Text = "Müşteri :";
            // 
            // btnAlarmKur
            // 
            this.btnAlarmKur.AutoSize = true;
            this.btnAlarmKur.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnAlarmKur.Image = global::BarkodluOtomasyon.Properties.Resources.alarm_clock;
            this.btnAlarmKur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlarmKur.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAlarmKur.Location = new System.Drawing.Point(334, 285);
            this.btnAlarmKur.Name = "btnAlarmKur";
            this.btnAlarmKur.Size = new System.Drawing.Size(153, 42);
            this.btnAlarmKur.TabIndex = 39;
            this.btnAlarmKur.Text = "ALARM KUR";
            this.btnAlarmKur.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlarmKur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlarmKur.UseVisualStyleBackColor = true;
            this.btnAlarmKur.Click += new System.EventHandler(this.btnAlarmKur_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.Image = global::BarkodluOtomasyon.Properties.Resources.multiply;
            this.btnIptal.Location = new System.Drawing.Point(220, 285);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(108, 42);
            this.btnIptal.TabIndex = 40;
            this.btnIptal.Text = "İPTAL";
            this.btnIptal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIptal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(198, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 14);
            this.label8.TabIndex = 26;
            this.label8.Text = "Alarm Tarihi :";
            // 
            // dateSaat
            // 
            this.dateSaat.CalendarFont = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateSaat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateSaat.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateSaat.Location = new System.Drawing.Point(388, 202);
            this.dateSaat.Name = "dateSaat";
            this.dateSaat.Size = new System.Drawing.Size(99, 23);
            this.dateSaat.TabIndex = 41;
            // 
            // dateTarih
            // 
            this.dateTarih.CalendarFont = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTarih.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTarih.Location = new System.Drawing.Point(285, 202);
            this.dateTarih.Name = "dateTarih";
            this.dateTarih.Size = new System.Drawing.Size(99, 23);
            this.dateTarih.TabIndex = 41;
            // 
            // FrmAlarmKur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 357);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmAlarmKur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alarm Kur";
            this.Load += new System.EventHandler(this.FrmAlarmKur_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox txtAciklama;
        private System.Windows.Forms.TextBox txtMusteriKod;
        private System.Windows.Forms.TextBox txtBakiye;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTelNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMusteriGrup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHesapTur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMusteriAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAlarmKur;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.DateTimePicker dateTarih;
        private System.Windows.Forms.DateTimePicker dateSaat;
        private System.Windows.Forms.Label label8;
    }
}