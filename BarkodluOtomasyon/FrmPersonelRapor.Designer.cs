
namespace BarkodluOtomasyon
{
    partial class FrmPersonelRapor
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnListele = new System.Windows.Forms.Button();
            this.dateSon = new System.Windows.Forms.DateTimePicker();
            this.comboPersonel = new System.Windows.Forms.ComboBox();
            this.dateBaslangic = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listeSatisPersonel = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnKapat = new System.Windows.Forms.Button();
            this.txtTKarTutar = new System.Windows.Forms.TextBox();
            this.txtTAlisTutar = new System.Windows.Forms.TextBox();
            this.txtTSatisTutari = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTSatisMiktar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.aciklama = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listeSatisPersonel)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnListele);
            this.panel1.Controls.Add(this.dateSon);
            this.panel1.Controls.Add(this.comboPersonel);
            this.panel1.Controls.Add(this.dateBaslangic);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(751, 51);
            this.panel1.TabIndex = 0;
            // 
            // btnListele
            // 
            this.btnListele.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.Image = global::BarkodluOtomasyon.Properties.Resources.refinement;
            this.btnListele.Location = new System.Drawing.Point(707, 3);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(37, 45);
            this.btnListele.TabIndex = 2;
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateSon
            // 
            this.dateSon.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateSon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateSon.Location = new System.Drawing.Point(591, 11);
            this.dateSon.Name = "dateSon";
            this.dateSon.Size = new System.Drawing.Size(105, 23);
            this.dateSon.TabIndex = 2;
            // 
            // comboPersonel
            // 
            this.comboPersonel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboPersonel.FormattingEnabled = true;
            this.comboPersonel.Items.AddRange(new object[] {
            "Müdür"});
            this.comboPersonel.Location = new System.Drawing.Point(76, 13);
            this.comboPersonel.Name = "comboPersonel";
            this.comboPersonel.Size = new System.Drawing.Size(200, 24);
            this.comboPersonel.TabIndex = 1;
            // 
            // dateBaslangic
            // 
            this.dateBaslangic.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack;
            this.dateBaslangic.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateBaslangic.Location = new System.Drawing.Point(396, 11);
            this.dateBaslangic.Name = "dateBaslangic";
            this.dateBaslangic.Size = new System.Drawing.Size(105, 23);
            this.dateBaslangic.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(507, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "Bitiş Tarihi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(282, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "Başlangıç Tarihi :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listeSatisPersonel);
            this.panel2.Location = new System.Drawing.Point(13, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(751, 333);
            this.panel2.TabIndex = 1;
            // 
            // listeSatisPersonel
            // 
            this.listeSatisPersonel.AllowUserToAddRows = false;
            this.listeSatisPersonel.AllowUserToDeleteRows = false;
            this.listeSatisPersonel.AllowUserToResizeRows = false;
            this.listeSatisPersonel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listeSatisPersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listeSatisPersonel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listeSatisPersonel.Location = new System.Drawing.Point(0, 0);
            this.listeSatisPersonel.MultiSelect = false;
            this.listeSatisPersonel.Name = "listeSatisPersonel";
            this.listeSatisPersonel.ReadOnly = true;
            this.listeSatisPersonel.RowHeadersVisible = false;
            this.listeSatisPersonel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listeSatisPersonel.Size = new System.Drawing.Size(751, 333);
            this.listeSatisPersonel.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnKapat);
            this.panel3.Controls.Add(this.txtTKarTutar);
            this.panel3.Controls.Add(this.txtTAlisTutar);
            this.panel3.Controls.Add(this.txtTSatisTutari);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtTSatisMiktar);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(13, 409);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(752, 77);
            this.panel3.TabIndex = 2;
            // 
            // btnKapat
            // 
            this.btnKapat.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.Image = global::BarkodluOtomasyon.Properties.Resources.arrow__1_;
            this.btnKapat.Location = new System.Drawing.Point(691, 17);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(43, 46);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // txtTKarTutar
            // 
            this.txtTKarTutar.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTKarTutar.Location = new System.Drawing.Point(482, 43);
            this.txtTKarTutar.Name = "txtTKarTutar";
            this.txtTKarTutar.ReadOnly = true;
            this.txtTKarTutar.Size = new System.Drawing.Size(165, 26);
            this.txtTKarTutar.TabIndex = 1;
            this.txtTKarTutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTAlisTutar
            // 
            this.txtTAlisTutar.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTAlisTutar.Location = new System.Drawing.Point(162, 43);
            this.txtTAlisTutar.Name = "txtTAlisTutar";
            this.txtTAlisTutar.ReadOnly = true;
            this.txtTAlisTutar.Size = new System.Drawing.Size(165, 26);
            this.txtTAlisTutar.TabIndex = 1;
            this.txtTAlisTutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTSatisTutari
            // 
            this.txtTSatisTutari.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTSatisTutari.Location = new System.Drawing.Point(482, 11);
            this.txtTSatisTutari.Name = "txtTSatisTutari";
            this.txtTSatisTutari.ReadOnly = true;
            this.txtTSatisTutari.Size = new System.Drawing.Size(165, 26);
            this.txtTSatisTutari.TabIndex = 1;
            this.txtTSatisTutari.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(353, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 14);
            this.label7.TabIndex = 0;
            this.label7.Text = "Toplam Kar Tutarı :";
            // 
            // txtTSatisMiktar
            // 
            this.txtTSatisMiktar.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTSatisMiktar.Location = new System.Drawing.Point(162, 11);
            this.txtTSatisMiktar.Name = "txtTSatisMiktar";
            this.txtTSatisMiktar.ReadOnly = true;
            this.txtTSatisMiktar.Size = new System.Drawing.Size(165, 26);
            this.txtTSatisMiktar.TabIndex = 1;
            this.txtTSatisMiktar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(32, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 14);
            this.label6.TabIndex = 0;
            this.label6.Text = "Toplam Alış Tutarı :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(343, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 14);
            this.label5.TabIndex = 0;
            this.label5.Text = "Toplam Satış Tutarı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(17, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 14);
            this.label4.TabIndex = 0;
            this.label4.Text = "Toplam Satış Miktarı :";
            // 
            // aciklama
            // 
            this.aciklama.IsBalloon = true;
            // 
            // FrmPersonelRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 498);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmPersonelRapor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Rapor";
            this.Load += new System.EventHandler(this.FrmPersonelRapor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listeSatisPersonel)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboPersonel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateSon;
        private System.Windows.Forms.DateTimePicker dateBaslangic;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtTSatisTutari;
        private System.Windows.Forms.TextBox txtTSatisMiktar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.DataGridView listeSatisPersonel;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.TextBox txtTKarTutar;
        private System.Windows.Forms.TextBox txtTAlisTutar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip aciklama;
    }
}