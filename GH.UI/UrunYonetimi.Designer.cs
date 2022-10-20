
namespace GH.UI
{
    partial class UrunYonetimi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunYonetimi));
            this.btn_ekle = new System.Windows.Forms.Button();
            this.lbl_urun = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_anasayfa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(282, 524);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(85, 46);
            this.btn_ekle.TabIndex = 5;
            this.btn_ekle.Text = "Ürün Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // lbl_urun
            // 
            this.lbl_urun.AutoSize = true;
            this.lbl_urun.Location = new System.Drawing.Point(166, 27);
            this.lbl_urun.Name = "lbl_urun";
            this.lbl_urun.Size = new System.Drawing.Size(55, 17);
            this.lbl_urun.TabIndex = 4;
            this.lbl_urun.Text = "Ürünler";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(338, 449);
            this.dataGridView1.TabIndex = 3;
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(282, 576);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(85, 46);
            this.btn_sil.TabIndex = 5;
            this.btn_sil.Text = "Ürün Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Visible = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(139, 547);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(107, 46);
            this.btn_edit.TabIndex = 5;
            this.btn_edit.Text = "Ürün Düzenle";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Visible = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_anasayfa
            // 
            this.btn_anasayfa.Image = ((System.Drawing.Image)(resources.GetObject("btn_anasayfa.Image")));
            this.btn_anasayfa.Location = new System.Drawing.Point(29, 542);
            this.btn_anasayfa.Name = "btn_anasayfa";
            this.btn_anasayfa.Size = new System.Drawing.Size(75, 56);
            this.btn_anasayfa.TabIndex = 11;
            this.btn_anasayfa.UseVisualStyleBackColor = true;
            this.btn_anasayfa.Click += new System.EventHandler(this.btn_anasayfa_Click);
            // 
            // UrunYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 623);
            this.Controls.Add(this.btn_anasayfa);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.lbl_urun);
            this.Controls.Add(this.dataGridView1);
            this.IsMdiContainer = true;
            this.Name = "UrunYonetimi";
            this.Text = "UrunYonetimi";
            this.Load += new System.EventHandler(this.UrunYonetimi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Label lbl_urun;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_anasayfa;
    }
}