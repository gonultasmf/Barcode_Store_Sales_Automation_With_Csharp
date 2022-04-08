
namespace BarkodluOtomasyon
{
    partial class FrmMail
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
            this.rdBtnMesaj2 = new System.Windows.Forms.RadioButton();
            this.rdBtnMesaj1 = new System.Windows.Forms.RadioButton();
            this.txtMesaj2 = new System.Windows.Forms.RichTextBox();
            this.txtMesaj1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnMail = new System.Windows.Forms.Button();
            this.txtKonu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdBtnMesaj2);
            this.panel1.Controls.Add(this.rdBtnMesaj1);
            this.panel1.Controls.Add(this.txtMesaj2);
            this.panel1.Controls.Add(this.txtMesaj1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 122);
            this.panel1.TabIndex = 23;
            // 
            // rdBtnMesaj2
            // 
            this.rdBtnMesaj2.AutoSize = true;
            this.rdBtnMesaj2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.rdBtnMesaj2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdBtnMesaj2.Location = new System.Drawing.Point(266, 2);
            this.rdBtnMesaj2.Name = "rdBtnMesaj2";
            this.rdBtnMesaj2.Size = new System.Drawing.Size(73, 18);
            this.rdBtnMesaj2.TabIndex = 26;
            this.rdBtnMesaj2.TabStop = true;
            this.rdBtnMesaj2.Text = "Mesaj-2";
            this.rdBtnMesaj2.UseVisualStyleBackColor = true;
            // 
            // rdBtnMesaj1
            // 
            this.rdBtnMesaj1.AutoSize = true;
            this.rdBtnMesaj1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.rdBtnMesaj1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdBtnMesaj1.Location = new System.Drawing.Point(118, 2);
            this.rdBtnMesaj1.Name = "rdBtnMesaj1";
            this.rdBtnMesaj1.Size = new System.Drawing.Size(73, 18);
            this.rdBtnMesaj1.TabIndex = 27;
            this.rdBtnMesaj1.TabStop = true;
            this.rdBtnMesaj1.Text = "Mesaj-1";
            this.rdBtnMesaj1.UseVisualStyleBackColor = true;
            // 
            // txtMesaj2
            // 
            this.txtMesaj2.Location = new System.Drawing.Point(233, 25);
            this.txtMesaj2.Name = "txtMesaj2";
            this.txtMesaj2.Size = new System.Drawing.Size(143, 89);
            this.txtMesaj2.TabIndex = 24;
            this.txtMesaj2.Text = "";
            // 
            // txtMesaj1
            // 
            this.txtMesaj1.Location = new System.Drawing.Point(88, 25);
            this.txtMesaj1.Name = "txtMesaj1";
            this.txtMesaj1.Size = new System.Drawing.Size(139, 89);
            this.txtMesaj1.TabIndex = 25;
            this.txtMesaj1.Text = "";
            // 
            // label1
            // 
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mesaj İçerik :";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(163, 175);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(234, 22);
            this.txtMail.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(90, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 14);
            this.label2.TabIndex = 24;
            this.label2.Text = "Alıcı Mail :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnIptal
            // 
            this.btnIptal.AutoSize = true;
            this.btnIptal.Image = global::BarkodluOtomasyon.Properties.Resources.multiply;
            this.btnIptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIptal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnIptal.Location = new System.Drawing.Point(170, 203);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(77, 42);
            this.btnIptal.TabIndex = 27;
            this.btnIptal.Text = "İPTAL";
            this.btnIptal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIptal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIptal.UseVisualStyleBackColor = true;
            // 
            // btnMail
            // 
            this.btnMail.AutoSize = true;
            this.btnMail.Image = global::BarkodluOtomasyon.Properties.Resources.send;
            this.btnMail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnMail.Location = new System.Drawing.Point(253, 203);
            this.btnMail.Name = "btnMail";
            this.btnMail.Size = new System.Drawing.Size(144, 42);
            this.btnMail.TabIndex = 26;
            this.btnMail.Text = "MAİL GÖNDER";
            this.btnMail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMail.UseVisualStyleBackColor = true;
            this.btnMail.Click += new System.EventHandler(this.btnMail_Click);
            // 
            // txtKonu
            // 
            this.txtKonu.Location = new System.Drawing.Point(154, 19);
            this.txtKonu.Name = "txtKonu";
            this.txtKonu.Size = new System.Drawing.Size(243, 22);
            this.txtKonu.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(73, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 14);
            this.label3.TabIndex = 28;
            this.label3.Text = "Mail Konu :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 257);
            this.Controls.Add(this.txtKonu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnMail);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmMail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mail At";
            this.Load += new System.EventHandler(this.FrmMail_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnMail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdBtnMesaj2;
        private System.Windows.Forms.RadioButton rdBtnMesaj1;
        private System.Windows.Forms.RichTextBox txtMesaj2;
        private System.Windows.Forms.RichTextBox txtMesaj1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKonu;
        private System.Windows.Forms.Label label3;
    }
}