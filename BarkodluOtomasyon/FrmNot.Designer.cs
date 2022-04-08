
namespace BarkodluOtomasyon
{
    partial class FrmNot
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
            this.txtNot = new System.Windows.Forms.RichTextBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtNot);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 165);
            this.panel1.TabIndex = 0;
            // 
            // txtNot
            // 
            this.txtNot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(157)))));
            this.txtNot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNot.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNot.Location = new System.Drawing.Point(0, 0);
            this.txtNot.Name = "txtNot";
            this.txtNot.Size = new System.Drawing.Size(312, 165);
            this.txtNot.TabIndex = 0;
            this.txtNot.Text = "";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Image = global::BarkodluOtomasyon.Properties.Resources.eraser;
            this.btnTemizle.Location = new System.Drawing.Point(55, 184);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(131, 47);
            this.btnTemizle.TabIndex = 1;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTemizle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Image = global::BarkodluOtomasyon.Properties.Resources.diskette;
            this.btnKaydet.Location = new System.Drawing.Point(192, 184);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(133, 47);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKaydet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.Image = global::BarkodluOtomasyon.Properties.Resources.arrow__1_;
            this.btnKapat.Location = new System.Drawing.Point(13, 184);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(36, 47);
            this.btnKapat.TabIndex = 1;
            this.btnKapat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKapat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // FrmNot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 243);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmNot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Not Ekle";
            this.Load += new System.EventHandler(this.FrmNot_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox txtNot;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnKapat;
    }
}