
namespace GH.UI
{
    partial class AramaSonucUrun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AramaSonucUrun));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_urun = new System.Windows.Forms.Label();
            this.btn_urunegit = new System.Windows.Forms.Button();
            this.btn_anasayfa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(338, 449);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lbl_urun
            // 
            this.lbl_urun.AutoSize = true;
            this.lbl_urun.Location = new System.Drawing.Point(165, 27);
            this.lbl_urun.Name = "lbl_urun";
            this.lbl_urun.Size = new System.Drawing.Size(55, 17);
            this.lbl_urun.TabIndex = 1;
            this.lbl_urun.Text = "Ürünler";
            // 
            // btn_urunegit
            // 
            this.btn_urunegit.Location = new System.Drawing.Point(145, 540);
            this.btn_urunegit.Name = "btn_urunegit";
            this.btn_urunegit.Size = new System.Drawing.Size(75, 56);
            this.btn_urunegit.TabIndex = 2;
            this.btn_urunegit.Text = "Ürüne Git";
            this.btn_urunegit.UseVisualStyleBackColor = true;
            this.btn_urunegit.Click += new System.EventHandler(this.btn_urunegit_Click);
            // 
            // btn_anasayfa
            // 
            this.btn_anasayfa.Image = ((System.Drawing.Image)(resources.GetObject("btn_anasayfa.Image")));
            this.btn_anasayfa.Location = new System.Drawing.Point(28, 540);
            this.btn_anasayfa.Name = "btn_anasayfa";
            this.btn_anasayfa.Size = new System.Drawing.Size(75, 56);
            this.btn_anasayfa.TabIndex = 10;
            this.btn_anasayfa.UseVisualStyleBackColor = true;
            this.btn_anasayfa.Click += new System.EventHandler(this.btn_anasayfa_Click);
            // 
            // AramaSonucUrun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 623);
            this.Controls.Add(this.btn_anasayfa);
            this.Controls.Add(this.btn_urunegit);
            this.Controls.Add(this.lbl_urun);
            this.Controls.Add(this.dataGridView1);
            this.IsMdiContainer = true;
            this.Name = "AramaSonucUrun";
            this.Text = "aramasonucurun";
            this.Load += new System.EventHandler(this.AramaSonucUrun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_urun;
        private System.Windows.Forms.Button btn_urunegit;
        private System.Windows.Forms.Button btn_anasayfa;
    }
}