
namespace BarkodluOtomasyon
{
    partial class FrmUrunIade
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
            this.btnKapat = new System.Windows.Forms.Button();
            this.txtTSatisTutar = new System.Windows.Forms.TextBox();
            this.txtTSatisMiktar = new System.Windows.Forms.TextBox();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.comboArama = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboIadeSekli = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listeIadeUrunler = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.RichTextBox();
            this.btnIadeAl = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.aciklama = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listeIadeUrunler)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnKapat);
            this.panel1.Controls.Add(this.txtTSatisTutar);
            this.panel1.Controls.Add(this.txtTSatisMiktar);
            this.panel1.Controls.Add(this.txtArama);
            this.panel1.Controls.Add(this.comboArama);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 61);
            this.panel1.TabIndex = 0;
            // 
            // btnKapat
            // 
            this.btnKapat.Image = global::BarkodluOtomasyon.Properties.Resources.arrow__1_;
            this.btnKapat.Location = new System.Drawing.Point(764, 8);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(40, 44);
            this.btnKapat.TabIndex = 5;
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // txtTSatisTutar
            // 
            this.txtTSatisTutar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTSatisTutar.Location = new System.Drawing.Point(645, 32);
            this.txtTSatisTutar.Name = "txtTSatisTutar";
            this.txtTSatisTutar.ReadOnly = true;
            this.txtTSatisTutar.Size = new System.Drawing.Size(108, 23);
            this.txtTSatisTutar.TabIndex = 4;
            this.txtTSatisTutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTSatisMiktar
            // 
            this.txtTSatisMiktar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTSatisMiktar.Location = new System.Drawing.Point(645, 5);
            this.txtTSatisMiktar.Name = "txtTSatisMiktar";
            this.txtTSatisMiktar.ReadOnly = true;
            this.txtTSatisMiktar.Size = new System.Drawing.Size(108, 23);
            this.txtTSatisMiktar.TabIndex = 3;
            this.txtTSatisMiktar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtArama
            // 
            this.txtArama.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtArama.Location = new System.Drawing.Point(274, 16);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(214, 27);
            this.txtArama.TabIndex = 2;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            this.txtArama.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMiktar_KeyPress);
            // 
            // comboArama
            // 
            this.comboArama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboArama.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboArama.FormattingEnabled = true;
            this.comboArama.Items.AddRange(new object[] {
            "Fiş No\'ya Göre",
            "Barkod\'a Göre"});
            this.comboArama.Location = new System.Drawing.Point(116, 17);
            this.comboArama.Name = "comboArama";
            this.comboArama.Size = new System.Drawing.Size(152, 26);
            this.comboArama.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arama Ölçütü :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(506, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 14);
            this.label5.TabIndex = 0;
            this.label5.Text = "Toplam Satış Tutarı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(500, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 14);
            this.label4.TabIndex = 0;
            this.label4.Text = "Toplam Satış Miktarı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "İade Açıklama :";
            // 
            // comboIadeSekli
            // 
            this.comboIadeSekli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboIadeSekli.FormattingEnabled = true;
            this.comboIadeSekli.Items.AddRange(new object[] {
            "Nakit ",
            "POS"});
            this.comboIadeSekli.Location = new System.Drawing.Point(450, 36);
            this.comboIadeSekli.Name = "comboIadeSekli";
            this.comboIadeSekli.Size = new System.Drawing.Size(128, 22);
            this.comboIadeSekli.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "Geri Ödeme Şekli :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.listeIadeUrunler);
            this.groupBox1.Location = new System.Drawing.Point(13, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(810, 281);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "7 Gün İçerisinde Satılan Ürünler Listesi";
            // 
            // listeIadeUrunler
            // 
            this.listeIadeUrunler.AllowUserToAddRows = false;
            this.listeIadeUrunler.AllowUserToDeleteRows = false;
            this.listeIadeUrunler.AllowUserToResizeRows = false;
            this.listeIadeUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listeIadeUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listeIadeUrunler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listeIadeUrunler.Location = new System.Drawing.Point(3, 18);
            this.listeIadeUrunler.MultiSelect = false;
            this.listeIadeUrunler.Name = "listeIadeUrunler";
            this.listeIadeUrunler.ReadOnly = true;
            this.listeIadeUrunler.RowHeadersVisible = false;
            this.listeIadeUrunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listeIadeUrunler.Size = new System.Drawing.Size(804, 260);
            this.listeIadeUrunler.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtMiktar);
            this.panel2.Controls.Add(this.txtAciklama);
            this.panel2.Controls.Add(this.btnIadeAl);
            this.panel2.Controls.Add(this.comboIadeSekli);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(13, 368);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(807, 64);
            this.panel2.TabIndex = 1;
            // 
            // txtMiktar
            // 
            this.txtMiktar.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMiktar.Location = new System.Drawing.Point(450, 6);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(128, 26);
            this.txtMiktar.TabIndex = 7;
            this.txtMiktar.TextChanged += new System.EventHandler(this.txtMiktar_TextChanged);
            this.txtMiktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMiktar_KeyPress);
            this.txtMiktar.Leave += new System.EventHandler(this.txtMiktar_Leave);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(111, 3);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(211, 58);
            this.txtAciklama.TabIndex = 6;
            this.txtAciklama.Text = "";
            // 
            // btnIadeAl
            // 
            this.btnIadeAl.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIadeAl.Image = global::BarkodluOtomasyon.Properties.Resources.product;
            this.btnIadeAl.Location = new System.Drawing.Point(613, 6);
            this.btnIadeAl.Name = "btnIadeAl";
            this.btnIadeAl.Size = new System.Drawing.Size(194, 52);
            this.btnIadeAl.TabIndex = 5;
            this.btnIadeAl.Text = "ÜRÜNÜ İADE AL";
            this.btnIadeAl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIadeAl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIadeAl.UseVisualStyleBackColor = true;
            this.btnIadeAl.Click += new System.EventHandler(this.btnIadeAl_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(328, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 14);
            this.label6.TabIndex = 0;
            this.label6.Text = "Geri Alınan Miktar :";
            // 
            // aciklama
            // 
            this.aciklama.IsBalloon = true;
            // 
            // FrmUrunIade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 446);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmUrunIade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün İade";
            this.Load += new System.EventHandler(this.FrmUrunIade_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listeIadeUrunler)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnIadeAl;
        private System.Windows.Forms.ComboBox comboIadeSekli;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.ComboBox comboArama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTSatisTutar;
        private System.Windows.Forms.TextBox txtTSatisMiktar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox txtAciklama;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.DataGridView listeIadeUrunler;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip aciklama;
    }
}