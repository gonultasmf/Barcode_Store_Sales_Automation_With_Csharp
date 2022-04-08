
namespace BarkodluOtomasyon
{
    partial class FrmSeriSatis
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
            this.btnKlavye = new System.Windows.Forms.Button();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.txtSatisFiyat = new System.Windows.Forms.TextBox();
            this.txtBirim = new System.Windows.Forms.TextBox();
            this.txtUrun = new System.Windows.Forms.TextBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTamam = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnKlavye);
            this.panel1.Controls.Add(this.txtBarkod);
            this.panel1.Controls.Add(this.txtSatisFiyat);
            this.panel1.Controls.Add(this.txtBirim);
            this.panel1.Controls.Add(this.txtUrun);
            this.panel1.Controls.Add(this.txtMiktar);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 180);
            this.panel1.TabIndex = 0;
            // 
            // btnKlavye
            // 
            this.btnKlavye.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKlavye.Image = global::BarkodluOtomasyon.Properties.Resources.dial__1_;
            this.btnKlavye.Location = new System.Drawing.Point(290, 2);
            this.btnKlavye.Name = "btnKlavye";
            this.btnKlavye.Size = new System.Drawing.Size(48, 40);
            this.btnKlavye.TabIndex = 17;
            this.btnKlavye.Tag = "";
            this.btnKlavye.UseVisualStyleBackColor = true;
            this.btnKlavye.Click += new System.EventHandler(this.btnKlavye_Click);
            // 
            // txtBarkod
            // 
            this.txtBarkod.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBarkod.Location = new System.Drawing.Point(103, 10);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(181, 26);
            this.txtBarkod.TabIndex = 6;
            this.txtBarkod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarkod_KeyDown);
            // 
            // txtSatisFiyat
            // 
            this.txtSatisFiyat.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSatisFiyat.Location = new System.Drawing.Point(103, 139);
            this.txtSatisFiyat.Name = "txtSatisFiyat";
            this.txtSatisFiyat.ReadOnly = true;
            this.txtSatisFiyat.Size = new System.Drawing.Size(181, 26);
            this.txtSatisFiyat.TabIndex = 6;
            // 
            // txtBirim
            // 
            this.txtBirim.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBirim.Location = new System.Drawing.Point(103, 107);
            this.txtBirim.Name = "txtBirim";
            this.txtBirim.ReadOnly = true;
            this.txtBirim.Size = new System.Drawing.Size(181, 26);
            this.txtBirim.TabIndex = 6;
            // 
            // txtUrun
            // 
            this.txtUrun.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrun.Location = new System.Drawing.Point(103, 43);
            this.txtUrun.Name = "txtUrun";
            this.txtUrun.ReadOnly = true;
            this.txtUrun.Size = new System.Drawing.Size(235, 26);
            this.txtUrun.TabIndex = 6;
            // 
            // txtMiktar
            // 
            this.txtMiktar.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMiktar.Location = new System.Drawing.Point(103, 75);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(181, 26);
            this.txtMiktar.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(14, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Birim Fiyat :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(49, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Birim :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(39, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Miktar :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(50, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ürün :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(35, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Barkod :";
            // 
            // btnTamam
            // 
            this.btnTamam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTamam.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTamam.Image = global::BarkodluOtomasyon.Properties.Resources._checked;
            this.btnTamam.Location = new System.Drawing.Point(133, 199);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(114, 43);
            this.btnTamam.TabIndex = 20;
            this.btnTamam.Text = "TAMAM";
            this.btnTamam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTamam.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // FrmSeriSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 244);
            this.Controls.Add(this.btnTamam);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimizeBox = false;
            this.Name = "FrmSeriSatis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seri Satış";
            this.Load += new System.EventHandler(this.FrmSeriSatis_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSatisFiyat;
        private System.Windows.Forms.TextBox txtBirim;
        private System.Windows.Forms.TextBox txtUrun;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Button btnKlavye;
        private System.Windows.Forms.Button btnTamam;
        private System.Windows.Forms.TextBox txtBarkod;
    }
}