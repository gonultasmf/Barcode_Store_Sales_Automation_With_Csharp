
namespace BarkodluOtomasyon
{
    partial class FrmKasaIslemAyrinti
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
            this.listeKasaIslemAyrinti = new System.Windows.Forms.DataGridView();
            this.btnKapat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listeKasaIslemAyrinti)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listeKasaIslemAyrinti);
            this.panel1.Location = new System.Drawing.Point(15, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 405);
            this.panel1.TabIndex = 0;
            // 
            // listeKasaIslemAyrinti
            // 
            this.listeKasaIslemAyrinti.AllowUserToAddRows = false;
            this.listeKasaIslemAyrinti.AllowUserToDeleteRows = false;
            this.listeKasaIslemAyrinti.AllowUserToResizeRows = false;
            this.listeKasaIslemAyrinti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listeKasaIslemAyrinti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listeKasaIslemAyrinti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listeKasaIslemAyrinti.Location = new System.Drawing.Point(0, 0);
            this.listeKasaIslemAyrinti.MultiSelect = false;
            this.listeKasaIslemAyrinti.Name = "listeKasaIslemAyrinti";
            this.listeKasaIslemAyrinti.ReadOnly = true;
            this.listeKasaIslemAyrinti.RowHeadersVisible = false;
            this.listeKasaIslemAyrinti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listeKasaIslemAyrinti.Size = new System.Drawing.Size(796, 405);
            this.listeKasaIslemAyrinti.TabIndex = 4;
            // 
            // btnKapat
            // 
            this.btnKapat.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.Image = global::BarkodluOtomasyon.Properties.Resources.arrow__1_;
            this.btnKapat.Location = new System.Drawing.Point(312, 425);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(181, 42);
            this.btnKapat.TabIndex = 1;
            this.btnKapat.Text = "KAPAT";
            this.btnKapat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKapat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // FrmKasaIslemAyrinti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 472);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmKasaIslemAyrinti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kasa İşlem Ayrıntı";
            this.Load += new System.EventHandler(this.FrmKasaIslemAyrinti_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listeKasaIslemAyrinti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView listeKasaIslemAyrinti;
        private System.Windows.Forms.Button btnKapat;
    }
}