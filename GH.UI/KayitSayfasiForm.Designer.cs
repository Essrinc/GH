
namespace GH.UI
{
    partial class KayitSayfasiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KayitSayfasiForm));
            this.btn_kayitOl = new System.Windows.Forms.Button();
            this.txb_sifre = new System.Windows.Forms.TextBox();
            this.txb_kullaniciadi = new System.Windows.Forms.TextBox();
            this.lbl_sifre = new System.Windows.Forms.Label();
            this.lbl_kullaniciAdi = new System.Windows.Forms.Label();
            this.lbl_yazi = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txb_email = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_kayitOl
            // 
            this.btn_kayitOl.Location = new System.Drawing.Point(142, 552);
            this.btn_kayitOl.Name = "btn_kayitOl";
            this.btn_kayitOl.Size = new System.Drawing.Size(92, 35);
            this.btn_kayitOl.TabIndex = 23;
            this.btn_kayitOl.Text = "Kayıt Ol";
            this.btn_kayitOl.UseVisualStyleBackColor = true;
            this.btn_kayitOl.Click += new System.EventHandler(this.btn_kayitOl_Click);
            // 
            // txb_sifre
            // 
            this.txb_sifre.Location = new System.Drawing.Point(66, 454);
            this.txb_sifre.Name = "txb_sifre";
            this.txb_sifre.Size = new System.Drawing.Size(287, 22);
            this.txb_sifre.TabIndex = 20;
            // 
            // txb_kullaniciadi
            // 
            this.txb_kullaniciadi.Location = new System.Drawing.Point(66, 397);
            this.txb_kullaniciadi.Name = "txb_kullaniciadi";
            this.txb_kullaniciadi.Size = new System.Drawing.Size(287, 22);
            this.txb_kullaniciadi.TabIndex = 19;
            // 
            // lbl_sifre
            // 
            this.lbl_sifre.AutoSize = true;
            this.lbl_sifre.Location = new System.Drawing.Point(40, 434);
            this.lbl_sifre.Name = "lbl_sifre";
            this.lbl_sifre.Size = new System.Drawing.Size(37, 17);
            this.lbl_sifre.TabIndex = 18;
            this.lbl_sifre.Text = "Şifre";
            // 
            // lbl_kullaniciAdi
            // 
            this.lbl_kullaniciAdi.AutoSize = true;
            this.lbl_kullaniciAdi.Location = new System.Drawing.Point(35, 377);
            this.lbl_kullaniciAdi.Name = "lbl_kullaniciAdi";
            this.lbl_kullaniciAdi.Size = new System.Drawing.Size(84, 17);
            this.lbl_kullaniciAdi.TabIndex = 17;
            this.lbl_kullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // lbl_yazi
            // 
            this.lbl_yazi.AutoSize = true;
            this.lbl_yazi.Location = new System.Drawing.Point(139, 337);
            this.lbl_yazi.Name = "lbl_yazi";
            this.lbl_yazi.Size = new System.Drawing.Size(89, 17);
            this.lbl_yazi.TabIndex = 16;
            this.lbl_yazi.Text = "Kayıt Sayfası";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(55, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 281);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(35, 491);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(42, 17);
            this.lbl_email.TabIndex = 18;
            this.lbl_email.Text = "Email";
            // 
            // txb_email
            // 
            this.txb_email.Location = new System.Drawing.Point(66, 511);
            this.txb_email.Name = "txb_email";
            this.txb_email.Size = new System.Drawing.Size(287, 22);
            this.txb_email.TabIndex = 20;
            // 
            // KayitSayfasiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 623);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_kayitOl);
            this.Controls.Add(this.txb_email);
            this.Controls.Add(this.txb_sifre);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.txb_kullaniciadi);
            this.Controls.Add(this.lbl_sifre);
            this.Controls.Add(this.lbl_kullaniciAdi);
            this.Controls.Add(this.lbl_yazi);
            this.IsMdiContainer = true;
            this.Name = "KayitSayfasiForm";
            this.Text = "KayitSayfasiForm";
            this.Load += new System.EventHandler(this.KayitSayfasiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_kayitOl;
        private System.Windows.Forms.TextBox txb_sifre;
        private System.Windows.Forms.TextBox txb_kullaniciadi;
        private System.Windows.Forms.Label lbl_sifre;
        private System.Windows.Forms.Label lbl_kullaniciAdi;
        private System.Windows.Forms.Label lbl_yazi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txb_email;
    }
}