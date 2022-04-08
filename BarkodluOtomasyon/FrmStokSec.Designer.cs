
namespace BarkodluOtomasyon
{
    partial class FrmStokSec
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
            this.listeUrun = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboArama = new System.Windows.Forms.ComboBox();
            this.btnSec = new System.Windows.Forms.Button();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listeUrun)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listeUrun);
            this.panel1.Location = new System.Drawing.Point(15, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 326);
            this.panel1.TabIndex = 0;
            // 
            // listeUrun
            // 
            this.listeUrun.AllowUserToAddRows = false;
            this.listeUrun.AllowUserToDeleteRows = false;
            this.listeUrun.AllowUserToResizeRows = false;
            this.listeUrun.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listeUrun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listeUrun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listeUrun.Location = new System.Drawing.Point(0, 0);
            this.listeUrun.MultiSelect = false;
            this.listeUrun.Name = "listeUrun";
            this.listeUrun.ReadOnly = true;
            this.listeUrun.RowHeadersVisible = false;
            this.listeUrun.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listeUrun.Size = new System.Drawing.Size(732, 326);
            this.listeUrun.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboArama);
            this.panel2.Controls.Add(this.btnSec);
            this.panel2.Controls.Add(this.txtBarkod);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(15, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(732, 48);
            this.panel2.TabIndex = 1;
            // 
            // comboArama
            // 
            this.comboArama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboArama.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboArama.FormattingEnabled = true;
            this.comboArama.Items.AddRange(new object[] {
            "Ürün Koduna Göre",
            "Ürün Adına Göre "});
            this.comboArama.Location = new System.Drawing.Point(102, 13);
            this.comboArama.Name = "comboArama";
            this.comboArama.Size = new System.Drawing.Size(207, 26);
            this.comboArama.TabIndex = 3;
            // 
            // btnSec
            // 
            this.btnSec.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSec.Image = global::BarkodluOtomasyon.Properties.Resources.refinement;
            this.btnSec.Location = new System.Drawing.Point(557, 3);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(172, 42);
            this.btnSec.TabIndex = 2;
            this.btnSec.Text = "ÜRÜNÜ SEÇ";
            this.btnSec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSec.UseVisualStyleBackColor = true;
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // txtBarkod
            // 
            this.txtBarkod.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBarkod.Location = new System.Drawing.Point(315, 15);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(236, 23);
            this.txtBarkod.TabIndex = 1;
            this.txtBarkod.Text = "Aramak İçin Yazınız...";
            this.txtBarkod.TextChanged += new System.EventHandler(this.txtBarkod_TextChanged);
            this.txtBarkod.Enter += new System.EventHandler(this.txtBarkod_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arama Ölçütü : ";
            // 
            // FrmStokSec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 406);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmStokSec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Seç";
            this.Load += new System.EventHandler(this.FrmStokSec_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listeUrun)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSec;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView listeUrun;
        private System.Windows.Forms.ComboBox comboArama;
    }
}