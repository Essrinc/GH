
namespace GH.UI
{
    partial class AramaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AramaForm));
            this.btn_anasayfa = new System.Windows.Forms.Button();
            this.btn_urunara = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_urunara = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_anasayfa
            // 
            this.btn_anasayfa.Image = ((System.Drawing.Image)(resources.GetObject("btn_anasayfa.Image")));
            this.btn_anasayfa.Location = new System.Drawing.Point(12, 249);
            this.btn_anasayfa.Name = "btn_anasayfa";
            this.btn_anasayfa.Size = new System.Drawing.Size(75, 56);
            this.btn_anasayfa.TabIndex = 10;
            this.btn_anasayfa.UseVisualStyleBackColor = true;
            this.btn_anasayfa.Click += new System.EventHandler(this.btn_anasayfa_Click);
            // 
            // btn_urunara
            // 
            this.btn_urunara.Location = new System.Drawing.Point(138, 207);
            this.btn_urunara.Name = "btn_urunara";
            this.btn_urunara.Size = new System.Drawing.Size(75, 23);
            this.btn_urunara.TabIndex = 11;
            this.btn_urunara.Text = "Ara";
            this.btn_urunara.UseVisualStyleBackColor = true;
            this.btn_urunara.Click += new System.EventHandler(this.btn_urunara_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ürün Ara";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(150, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 60);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // txt_urunara
            // 
            this.txt_urunara.Location = new System.Drawing.Point(57, 167);
            this.txt_urunara.Name = "txt_urunara";
            this.txt_urunara.Size = new System.Drawing.Size(294, 22);
            this.txt_urunara.TabIndex = 15;
            this.txt_urunara.TextChanged += new System.EventHandler(this.txt_urunara_TextChanged);
            // 
            // AramaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 317);
            this.Controls.Add(this.txt_urunara);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_urunara);
            this.Controls.Add(this.btn_anasayfa);
            this.IsMdiContainer = true;
            this.Name = "AramaForm";
            this.Text = "AramaForm";
            this.Load += new System.EventHandler(this.AramaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_anasayfa;
        private System.Windows.Forms.Button btn_urunara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_urunara;
    }
}