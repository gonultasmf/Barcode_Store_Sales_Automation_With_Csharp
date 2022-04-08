
namespace BarkodluOtomasyon
{
    partial class FrmSms
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
            this.btnSms = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdBtnMesaj2 = new System.Windows.Forms.RadioButton();
            this.rdBtnMesaj1 = new System.Windows.Forms.RadioButton();
            this.txtMesaj2 = new System.Windows.Forms.RichTextBox();
            this.txtMesaj1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTelNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIptal
            // 
            this.btnIptal.AutoSize = true;
            this.btnIptal.Image = global::BarkodluOtomasyon.Properties.Resources.multiply;
            this.btnIptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIptal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnIptal.Location = new System.Drawing.Point(170, 166);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(77, 42);
            this.btnIptal.TabIndex = 27;
            this.btnIptal.Text = "İPTAL";
            this.btnIptal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIptal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIptal.UseVisualStyleBackColor = true;
            // 
            // btnSms
            // 
            this.btnSms.AutoSize = true;
            this.btnSms.Image = global::BarkodluOtomasyon.Properties.Resources.smartphone;
            this.btnSms.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSms.Location = new System.Drawing.Point(253, 166);
            this.btnSms.Name = "btnSms";
            this.btnSms.Size = new System.Drawing.Size(144, 42);
            this.btnSms.TabIndex = 26;
            this.btnSms.Text = "SMS GÖNDER";
            this.btnSms.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSms.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSms.UseVisualStyleBackColor = true;
            this.btnSms.Click += new System.EventHandler(this.btnSms_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdBtnMesaj2);
            this.panel1.Controls.Add(this.rdBtnMesaj1);
            this.panel1.Controls.Add(this.txtMesaj2);
            this.panel1.Controls.Add(this.txtMesaj1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 10);
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
            // txtTelNo
            // 
            this.txtTelNo.Location = new System.Drawing.Point(163, 138);
            this.txtTelNo.Name = "txtTelNo";
            this.txtTelNo.Size = new System.Drawing.Size(234, 22);
            this.txtTelNo.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(49, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 14);
            this.label2.TabIndex = 24;
            this.label2.Text = "Alıcı Telefon No :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmSms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 219);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnSms);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtTelNo);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmSms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMS Gönder";
            this.Load += new System.EventHandler(this.FrmSms_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnSms;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdBtnMesaj2;
        private System.Windows.Forms.RadioButton rdBtnMesaj1;
        private System.Windows.Forms.RichTextBox txtMesaj2;
        private System.Windows.Forms.RichTextBox txtMesaj1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTelNo;
        private System.Windows.Forms.Label label2;
    }
}