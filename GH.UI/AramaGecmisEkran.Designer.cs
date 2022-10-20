
namespace GH.UI
{
    partial class AramaGecmisEkran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AramaGecmisEkran));
            this.lbl_aramagecmisi = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_karaliste = new System.Windows.Forms.Button();
            this.btn_favlis = new System.Windows.Forms.Button();
            this.btn_aramasil = new System.Windows.Forms.Button();
            this.btn_anasayfa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_aramagecmisi
            // 
            this.lbl_aramagecmisi.AutoSize = true;
            this.lbl_aramagecmisi.Location = new System.Drawing.Point(119, 32);
            this.lbl_aramagecmisi.Name = "lbl_aramagecmisi";
            this.lbl_aramagecmisi.Size = new System.Drawing.Size(103, 17);
            this.lbl_aramagecmisi.TabIndex = 6;
            this.lbl_aramagecmisi.Text = "Arama Geçmişi";
            this.lbl_aramagecmisi.Click += new System.EventHandler(this.lbl_urun_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(338, 449);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_karaliste
            // 
            this.btn_karaliste.Location = new System.Drawing.Point(112, 569);
            this.btn_karaliste.Name = "btn_karaliste";
            this.btn_karaliste.Size = new System.Drawing.Size(124, 23);
            this.btn_karaliste.TabIndex = 7;
            this.btn_karaliste.Text = "Kara Listem";
            this.btn_karaliste.UseVisualStyleBackColor = true;
            this.btn_karaliste.Click += new System.EventHandler(this.btn_karaliste_Click);
            // 
            // btn_favlis
            // 
            this.btn_favlis.Location = new System.Drawing.Point(112, 531);
            this.btn_favlis.Name = "btn_favlis";
            this.btn_favlis.Size = new System.Drawing.Size(124, 23);
            this.btn_favlis.TabIndex = 8;
            this.btn_favlis.Text = "Favori Listelerim";
            this.btn_favlis.UseVisualStyleBackColor = true;
            this.btn_favlis.Click += new System.EventHandler(this.btn_favlis_Click);
            // 
            // btn_aramasil
            // 
            this.btn_aramasil.Location = new System.Drawing.Point(242, 531);
            this.btn_aramasil.Name = "btn_aramasil";
            this.btn_aramasil.Size = new System.Drawing.Size(125, 61);
            this.btn_aramasil.TabIndex = 9;
            this.btn_aramasil.Text = "Arama Geçmişini Temilze";
            this.btn_aramasil.UseVisualStyleBackColor = true;
            this.btn_aramasil.Click += new System.EventHandler(this.btn_aramasil_Click);
            // 
            // btn_anasayfa
            // 
            this.btn_anasayfa.Image = ((System.Drawing.Image)(resources.GetObject("btn_anasayfa.Image")));
            this.btn_anasayfa.Location = new System.Drawing.Point(29, 536);
            this.btn_anasayfa.Name = "btn_anasayfa";
            this.btn_anasayfa.Size = new System.Drawing.Size(75, 56);
            this.btn_anasayfa.TabIndex = 10;
            this.btn_anasayfa.UseVisualStyleBackColor = true;
            this.btn_anasayfa.Click += new System.EventHandler(this.btn_anasayfa_Click);
            // 
            // AramaGecmisEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 623);
            this.Controls.Add(this.btn_anasayfa);
            this.Controls.Add(this.btn_aramasil);
            this.Controls.Add(this.btn_favlis);
            this.Controls.Add(this.btn_karaliste);
            this.Controls.Add(this.lbl_aramagecmisi);
            this.Controls.Add(this.dataGridView1);
            this.IsMdiContainer = true;
            this.Name = "AramaGecmisEkran";
            this.Text = "AramaGecmisEkran";
            this.Load += new System.EventHandler(this.AramaGecmisEkran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_aramagecmisi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_karaliste;
        private System.Windows.Forms.Button btn_favlis;
        private System.Windows.Forms.Button btn_aramasil;
        private System.Windows.Forms.Button btn_anasayfa;
    }
}