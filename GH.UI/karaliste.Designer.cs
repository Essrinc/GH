
namespace GH.UI
{
    partial class karaliste
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(karaliste));
            this.lbl_karaliste = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_anasayfa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_karaliste
            // 
            this.lbl_karaliste.AutoSize = true;
            this.lbl_karaliste.Location = new System.Drawing.Point(116, 28);
            this.lbl_karaliste.Name = "lbl_karaliste";
            this.lbl_karaliste.Size = new System.Drawing.Size(163, 17);
            this.lbl_karaliste.TabIndex = 9;
            this.lbl_karaliste.Text = "Kara Listedeki Ürünlerim";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(346, 473);
            this.dataGridView1.TabIndex = 8;
            // 
            // btn_anasayfa
            // 
            this.btn_anasayfa.Image = ((System.Drawing.Image)(resources.GetObject("btn_anasayfa.Image")));
            this.btn_anasayfa.Location = new System.Drawing.Point(25, 555);
            this.btn_anasayfa.Name = "btn_anasayfa";
            this.btn_anasayfa.Size = new System.Drawing.Size(75, 56);
            this.btn_anasayfa.TabIndex = 11;
            this.btn_anasayfa.UseVisualStyleBackColor = true;
            this.btn_anasayfa.Click += new System.EventHandler(this.btn_anasayfa_Click);
            // 
            // karaliste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 623);
            this.Controls.Add(this.btn_anasayfa);
            this.Controls.Add(this.lbl_karaliste);
            this.Controls.Add(this.dataGridView1);
            this.IsMdiContainer = true;
            this.Name = "karaliste";
            this.Text = "karaliste";
            this.Load += new System.EventHandler(this.karaliste_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_karaliste;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_anasayfa;
    }
}