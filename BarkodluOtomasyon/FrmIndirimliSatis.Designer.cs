
namespace BarkodluOtomasyon
{
    partial class FrmIndirimliSatis
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
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnTamam = new System.Windows.Forms.Button();
            this.txtIskontu = new System.Windows.Forms.TextBox();
            this.txtGenelFiyat = new System.Windows.Forms.TextBox();
            this.txtToplamFiyat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboOdemeSekli = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIptal
            // 
            this.btnIptal.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.Image = global::BarkodluOtomasyon.Properties.Resources.multiply;
            this.btnIptal.Location = new System.Drawing.Point(72, 156);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(107, 48);
            this.btnIptal.TabIndex = 12;
            this.btnIptal.Text = "İPTAL";
            this.btnIptal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIptal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnTamam
            // 
            this.btnTamam.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTamam.Image = global::BarkodluOtomasyon.Properties.Resources._checked;
            this.btnTamam.Location = new System.Drawing.Point(217, 156);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(123, 48);
            this.btnTamam.TabIndex = 11;
            this.btnTamam.Text = "TAMAM";
            this.btnTamam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTamam.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // txtIskontu
            // 
            this.txtIskontu.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIskontu.Location = new System.Drawing.Point(117, 76);
            this.txtIskontu.Name = "txtIskontu";
            this.txtIskontu.Size = new System.Drawing.Size(223, 26);
            this.txtIskontu.TabIndex = 9;
            this.txtIskontu.TextChanged += new System.EventHandler(this.txtIskontu_TextChanged);
            this.txtIskontu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIskontu_KeyPress);
            // 
            // txtGenelFiyat
            // 
            this.txtGenelFiyat.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGenelFiyat.Location = new System.Drawing.Point(117, 108);
            this.txtGenelFiyat.Name = "txtGenelFiyat";
            this.txtGenelFiyat.ReadOnly = true;
            this.txtGenelFiyat.Size = new System.Drawing.Size(223, 26);
            this.txtGenelFiyat.TabIndex = 10;
            // 
            // txtToplamFiyat
            // 
            this.txtToplamFiyat.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtToplamFiyat.Location = new System.Drawing.Point(117, 12);
            this.txtToplamFiyat.Name = "txtToplamFiyat";
            this.txtToplamFiyat.ReadOnly = true;
            this.txtToplamFiyat.Size = new System.Drawing.Size(223, 26);
            this.txtToplamFiyat.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(20, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Genel Tutar :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(15, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "İskontu (%) :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(49, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Toplam :";
            // 
            // comboOdemeSekli
            // 
            this.comboOdemeSekli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboOdemeSekli.FormattingEnabled = true;
            this.comboOdemeSekli.Items.AddRange(new object[] {
            "Nakit",
            "POS"});
            this.comboOdemeSekli.Location = new System.Drawing.Point(117, 44);
            this.comboOdemeSekli.Name = "comboOdemeSekli";
            this.comboOdemeSekli.Size = new System.Drawing.Size(223, 26);
            this.comboOdemeSekli.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(17, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ödeme Şekli :";
            // 
            // FrmIndirimliSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 216);
            this.Controls.Add(this.comboOdemeSekli);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnTamam);
            this.Controls.Add(this.txtIskontu);
            this.Controls.Add(this.txtGenelFiyat);
            this.Controls.Add(this.txtToplamFiyat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmIndirimliSatis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İndirimli Satış";
            this.Load += new System.EventHandler(this.FrmIndirimliSatis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnTamam;
        private System.Windows.Forms.TextBox txtIskontu;
        private System.Windows.Forms.TextBox txtGenelFiyat;
        private System.Windows.Forms.TextBox txtToplamFiyat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboOdemeSekli;
        private System.Windows.Forms.Label label4;
    }
}