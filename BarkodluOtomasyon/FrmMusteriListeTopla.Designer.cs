
namespace BarkodluOtomasyon
{
    partial class FrmMusteriListeTopla
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTBakiye = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTMusteriSayisi = new System.Windows.Forms.TextBox();
            this.btnKapat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnKapat);
            this.panel1.Controls.Add(this.txtTMusteriSayisi);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtTBakiye);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 150);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listedeki Toplam Bakiye :";
            // 
            // txtTBakiye
            // 
            this.txtTBakiye.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTBakiye.Location = new System.Drawing.Point(169, 13);
            this.txtTBakiye.Name = "txtTBakiye";
            this.txtTBakiye.ReadOnly = true;
            this.txtTBakiye.Size = new System.Drawing.Size(203, 26);
            this.txtTBakiye.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "Listedeki Toplam Müşteri :";
            // 
            // txtTMusteriSayisi
            // 
            this.txtTMusteriSayisi.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTMusteriSayisi.Location = new System.Drawing.Point(169, 54);
            this.txtTMusteriSayisi.Name = "txtTMusteriSayisi";
            this.txtTMusteriSayisi.ReadOnly = true;
            this.txtTMusteriSayisi.Size = new System.Drawing.Size(203, 26);
            this.txtTMusteriSayisi.TabIndex = 1;
            // 
            // btnKapat
            // 
            this.btnKapat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.Image = global::BarkodluOtomasyon.Properties.Resources.arrow__1_;
            this.btnKapat.Location = new System.Drawing.Point(169, 86);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(203, 45);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "KAPAT";
            this.btnKapat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKapat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // FrmMusteriListeTopla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 175);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmMusteriListeTopla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liste Topla";
            this.Load += new System.EventHandler(this.FrmMusteriListeTopla_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.TextBox txtTMusteriSayisi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTBakiye;
        private System.Windows.Forms.Label label1;
    }
}