
namespace BarkodluOtomasyon
{
    partial class FrmFiyatGör
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUrunAd = new System.Windows.Forms.TextBox();
            this.txtAlisFiyat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSatisFiyat1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSatisFiyat2 = new System.Windows.Forms.TextBox();
            this.txtSatisFiyat3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStokMiktar = new System.Windows.Forms.TextBox();
            this.txtKKSatisFiyat = new System.Windows.Forms.TextBox();
            this.btnKapat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BarkodluOtomasyon.Properties.Resources.barcode_reader_128x128_32;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 282);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtBarkod
            // 
            this.txtBarkod.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBarkod.Location = new System.Drawing.Point(150, 25);
            this.txtBarkod.MaxLength = 13;
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(253, 30);
            this.txtBarkod.TabIndex = 3;
            this.txtBarkod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBarkod.TextChanged += new System.EventHandler(this.txtBarkod_TextChanged);
            this.txtBarkod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarkod_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(213, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "ÜRÜN BARKODU";
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunAd.Location = new System.Drawing.Point(151, 62);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.ReadOnly = true;
            this.txtUrunAd.Size = new System.Drawing.Size(252, 27);
            this.txtUrunAd.TabIndex = 4;
            this.txtUrunAd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAlisFiyat
            // 
            this.txtAlisFiyat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAlisFiyat.Location = new System.Drawing.Point(151, 115);
            this.txtAlisFiyat.Name = "txtAlisFiyat";
            this.txtAlisFiyat.ReadOnly = true;
            this.txtAlisFiyat.Size = new System.Drawing.Size(123, 27);
            this.txtAlisFiyat.TabIndex = 4;
            this.txtAlisFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(170, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "ALIŞ FİYATI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(285, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "SATIŞ FİYAT-1";
            // 
            // txtSatisFiyat1
            // 
            this.txtSatisFiyat1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSatisFiyat1.Location = new System.Drawing.Point(280, 115);
            this.txtSatisFiyat1.Name = "txtSatisFiyat1";
            this.txtSatisFiyat1.ReadOnly = true;
            this.txtSatisFiyat1.Size = new System.Drawing.Size(123, 27);
            this.txtSatisFiyat1.TabIndex = 4;
            this.txtSatisFiyat1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(163, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 14);
            this.label4.TabIndex = 2;
            this.label4.Text = "SATIŞ FİYAT-2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(285, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 14);
            this.label5.TabIndex = 2;
            this.label5.Text = "SATIŞ FİYAT-3";
            // 
            // txtSatisFiyat2
            // 
            this.txtSatisFiyat2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSatisFiyat2.Location = new System.Drawing.Point(151, 167);
            this.txtSatisFiyat2.Name = "txtSatisFiyat2";
            this.txtSatisFiyat2.ReadOnly = true;
            this.txtSatisFiyat2.Size = new System.Drawing.Size(123, 27);
            this.txtSatisFiyat2.TabIndex = 4;
            this.txtSatisFiyat2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSatisFiyat3
            // 
            this.txtSatisFiyat3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSatisFiyat3.Location = new System.Drawing.Point(280, 167);
            this.txtSatisFiyat3.Name = "txtSatisFiyat3";
            this.txtSatisFiyat3.ReadOnly = true;
            this.txtSatisFiyat3.Size = new System.Drawing.Size(123, 27);
            this.txtSatisFiyat3.TabIndex = 4;
            this.txtSatisFiyat3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(165, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 14);
            this.label6.TabIndex = 2;
            this.label6.Text = "STOK MİKTARI";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(285, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 14);
            this.label7.TabIndex = 2;
            this.label7.Text = "TAKSİTLİ FİYAT";
            // 
            // txtStokMiktar
            // 
            this.txtStokMiktar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtStokMiktar.Location = new System.Drawing.Point(151, 218);
            this.txtStokMiktar.Name = "txtStokMiktar";
            this.txtStokMiktar.ReadOnly = true;
            this.txtStokMiktar.Size = new System.Drawing.Size(123, 27);
            this.txtStokMiktar.TabIndex = 4;
            this.txtStokMiktar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtKKSatisFiyat
            // 
            this.txtKKSatisFiyat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKKSatisFiyat.Location = new System.Drawing.Point(280, 218);
            this.txtKKSatisFiyat.Name = "txtKKSatisFiyat";
            this.txtKKSatisFiyat.ReadOnly = true;
            this.txtKKSatisFiyat.Size = new System.Drawing.Size(123, 27);
            this.txtKKSatisFiyat.TabIndex = 4;
            this.txtKKSatisFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnKapat
            // 
            this.btnKapat.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.Image = global::BarkodluOtomasyon.Properties.Resources.multiply;
            this.btnKapat.Location = new System.Drawing.Point(151, 251);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(252, 44);
            this.btnKapat.TabIndex = 5;
            this.btnKapat.Text = "KAPAT";
            this.btnKapat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKapat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // FrmFiyatGör
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 308);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.txtKKSatisFiyat);
            this.Controls.Add(this.txtStokMiktar);
            this.Controls.Add(this.txtSatisFiyat3);
            this.Controls.Add(this.txtSatisFiyat2);
            this.Controls.Add(this.txtSatisFiyat1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAlisFiyat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUrunAd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBarkod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmFiyatGör";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fiyat Gör";
            this.Load += new System.EventHandler(this.FrmFiyatGör_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUrunAd;
        private System.Windows.Forms.TextBox txtAlisFiyat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSatisFiyat1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSatisFiyat2;
        private System.Windows.Forms.TextBox txtSatisFiyat3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStokMiktar;
        private System.Windows.Forms.TextBox txtKKSatisFiyat;
        private System.Windows.Forms.Button btnKapat;
    }
}