
namespace BarkodluOtomasyon
{
    partial class FrmNakitPosSatis
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtToplamFiyat = new System.Windows.Forms.TextBox();
            this.txtPOSFiyat = new System.Windows.Forms.TextBox();
            this.txtNakitFiyat = new System.Windows.Forms.TextBox();
            this.btnTamam = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Toplam :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nakit Miktar :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "POS Miktar :";
            // 
            // txtToplamFiyat
            // 
            this.txtToplamFiyat.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtToplamFiyat.Location = new System.Drawing.Point(121, 20);
            this.txtToplamFiyat.Name = "txtToplamFiyat";
            this.txtToplamFiyat.ReadOnly = true;
            this.txtToplamFiyat.Size = new System.Drawing.Size(223, 26);
            this.txtToplamFiyat.TabIndex = 1;
            // 
            // txtPOSFiyat
            // 
            this.txtPOSFiyat.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPOSFiyat.Location = new System.Drawing.Point(121, 103);
            this.txtPOSFiyat.Name = "txtPOSFiyat";
            this.txtPOSFiyat.ReadOnly = true;
            this.txtPOSFiyat.Size = new System.Drawing.Size(223, 26);
            this.txtPOSFiyat.TabIndex = 2;
            // 
            // txtNakitFiyat
            // 
            this.txtNakitFiyat.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNakitFiyat.Location = new System.Drawing.Point(121, 61);
            this.txtNakitFiyat.Name = "txtNakitFiyat";
            this.txtNakitFiyat.Size = new System.Drawing.Size(223, 26);
            this.txtNakitFiyat.TabIndex = 2;
            this.txtNakitFiyat.TextChanged += new System.EventHandler(this.txtNakitFiyat_TextChanged);
            this.txtNakitFiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNakitFiyat_KeyPress);
            // 
            // btnTamam
            // 
            this.btnTamam.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTamam.Image = global::BarkodluOtomasyon.Properties.Resources._checked;
            this.btnTamam.Location = new System.Drawing.Point(221, 156);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(123, 48);
            this.btnTamam.TabIndex = 3;
            this.btnTamam.Text = "TAMAM";
            this.btnTamam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTamam.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.Image = global::BarkodluOtomasyon.Properties.Resources.multiply;
            this.btnIptal.Location = new System.Drawing.Point(76, 156);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(107, 48);
            this.btnIptal.TabIndex = 4;
            this.btnIptal.Text = "İPTAL";
            this.btnIptal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIptal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // FrmNakitPosSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 216);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnTamam);
            this.Controls.Add(this.txtNakitFiyat);
            this.Controls.Add(this.txtPOSFiyat);
            this.Controls.Add(this.txtToplamFiyat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmNakitPosSatis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nakit&Pos Satış";
            this.Load += new System.EventHandler(this.FrmNakitPosSatis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtToplamFiyat;
        private System.Windows.Forms.TextBox txtPOSFiyat;
        private System.Windows.Forms.TextBox txtNakitFiyat;
        private System.Windows.Forms.Button btnTamam;
        private System.Windows.Forms.Button btnIptal;
    }
}