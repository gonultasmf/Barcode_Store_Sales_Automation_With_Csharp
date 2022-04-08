
namespace BarkodluOtomasyon
{
    partial class FrmAlarmAyar
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
            this.chckCalsin = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboErtele = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboTekrar = new System.Windows.Forms.ComboBox();
            this.comboZilSesi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.listAlarm = new System.Windows.Forms.DataGridView();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listAlarm)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnIptal);
            this.panel1.Controls.Add(this.btnKaydet);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.chckCalsin);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboErtele);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 155);
            this.panel1.TabIndex = 0;
            // 
            // chckCalsin
            // 
            this.chckCalsin.AutoSize = true;
            this.chckCalsin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chckCalsin.Location = new System.Drawing.Point(152, 46);
            this.chckCalsin.Name = "chckCalsin";
            this.chckCalsin.Size = new System.Drawing.Size(61, 18);
            this.chckCalsin.TabIndex = 9;
            this.chckCalsin.Text = "Çalsın";
            this.chckCalsin.UseVisualStyleBackColor = true;
            this.chckCalsin.CheckedChanged += new System.EventHandler(this.chckCalsin_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(76, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 14);
            this.label2.TabIndex = 8;
            this.label2.Text = "Zil Sesi :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // comboErtele
            // 
            this.comboErtele.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboErtele.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboErtele.FormattingEnabled = true;
            this.comboErtele.Items.AddRange(new object[] {
            "1 Saat",
            "2 Saat",
            "3 Saat",
            "4 Saat ",
            "5 Saat"});
            this.comboErtele.Location = new System.Drawing.Point(138, 13);
            this.comboErtele.Name = "comboErtele";
            this.comboErtele.Size = new System.Drawing.Size(182, 24);
            this.comboErtele.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ertelenme Zamanı :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // comboTekrar
            // 
            this.comboTekrar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTekrar.FormattingEnabled = true;
            this.comboTekrar.Items.AddRange(new object[] {
            "1 Defa",
            "Alarm Kapanana Kadar"});
            this.comboTekrar.Location = new System.Drawing.Point(116, 43);
            this.comboTekrar.Name = "comboTekrar";
            this.comboTekrar.Size = new System.Drawing.Size(182, 22);
            this.comboTekrar.TabIndex = 13;
            // 
            // comboZilSesi
            // 
            this.comboZilSesi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboZilSesi.FormattingEnabled = true;
            this.comboZilSesi.Items.AddRange(new object[] {
            "Agile",
            "Bip",
            "Carnation",
            "Peach",
            "Triumph",
            "Vermilion",
            "Watsonia"});
            this.comboZilSesi.Location = new System.Drawing.Point(116, 9);
            this.comboZilSesi.Name = "comboZilSesi";
            this.comboZilSesi.Size = new System.Drawing.Size(182, 22);
            this.comboZilSesi.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(54, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 14);
            this.label3.TabIndex = 11;
            this.label3.Text = "Zil Sesi :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(12, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 14);
            this.label4.TabIndex = 10;
            this.label4.Text = "Zil Sesi Tekrar :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(334, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(199, 98);
            this.panel2.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::BarkodluOtomasyon.Properties.Resources.tenor;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.listAlarm);
            this.panel3.Location = new System.Drawing.Point(13, 174);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(536, 220);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.comboTekrar);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.comboZilSesi);
            this.panel4.Location = new System.Drawing.Point(22, 70);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(305, 74);
            this.panel4.TabIndex = 0;
            // 
            // listAlarm
            // 
            this.listAlarm.AllowUserToAddRows = false;
            this.listAlarm.AllowUserToResizeRows = false;
            this.listAlarm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listAlarm.ColumnHeadersHeight = 40;
            this.listAlarm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listAlarm.Location = new System.Drawing.Point(0, 0);
            this.listAlarm.MultiSelect = false;
            this.listAlarm.Name = "listAlarm";
            this.listAlarm.ReadOnly = true;
            this.listAlarm.RowHeadersVisible = false;
            this.listAlarm.RowHeadersWidth = 20;
            this.listAlarm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listAlarm.Size = new System.Drawing.Size(536, 220);
            this.listAlarm.TabIndex = 9;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Image = global::BarkodluOtomasyon.Properties.Resources._checked;
            this.btnKaydet.Location = new System.Drawing.Point(427, 108);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(106, 44);
            this.btnKaydet.TabIndex = 15;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKaydet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.Image = global::BarkodluOtomasyon.Properties.Resources.multiply;
            this.btnIptal.Location = new System.Drawing.Point(334, 108);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(87, 44);
            this.btnIptal.TabIndex = 16;
            this.btnIptal.Text = "İPTAL";
            this.btnIptal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIptal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // FrmAlarmAyar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 406);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmAlarmAyar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alarm Ayarları";
            this.Load += new System.EventHandler(this.FrmAlarmAyar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listAlarm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chckCalsin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboErtele;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboTekrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboZilSesi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DataGridView listAlarm;
    }
}