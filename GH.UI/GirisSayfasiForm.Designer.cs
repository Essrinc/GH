
namespace GH.UI
{
    partial class GirisSayfasiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisSayfasiForm));
            this.btn_kayitOl = new System.Windows.Forms.Button();
            this.btn_girisYap = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txb_sifre = new System.Windows.Forms.TextBox();
            this.txb_kullaniciadi = new System.Windows.Forms.TextBox();
            this.lbl_sifre = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_yazi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_kayitOl
            // 
            this.btn_kayitOl.Location = new System.Drawing.Point(205, 544);
            this.btn_kayitOl.Name = "btn_kayitOl";
            this.btn_kayitOl.Size = new System.Drawing.Size(92, 35);
            this.btn_kayitOl.TabIndex = 15;
            this.btn_kayitOl.Text = "Kayıt Ol";
            this.btn_kayitOl.UseVisualStyleBackColor = true;
            this.btn_kayitOl.Click += new System.EventHandler(this.btn_kayitOl_Click);
            // 
            // btn_girisYap
            // 
            this.btn_girisYap.Location = new System.Drawing.Point(107, 544);
            this.btn_girisYap.Name = "btn_girisYap";
            this.btn_girisYap.Size = new System.Drawing.Size(92, 35);
            this.btn_girisYap.TabIndex = 14;
            this.btn_girisYap.Text = "Giriş Yap";
            this.btn_girisYap.UseVisualStyleBackColor = true;
            this.btn_girisYap.Click += new System.EventHandler(this.btn_girisYap_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(68, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(285, 295);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // txb_sifre
            // 
            this.txb_sifre.Location = new System.Drawing.Point(66, 491);
            this.txb_sifre.Name = "txb_sifre";
            this.txb_sifre.PasswordChar = '*';
            this.txb_sifre.Size = new System.Drawing.Size(287, 22);
            this.txb_sifre.TabIndex = 12;
            // 
            // txb_kullaniciadi
            // 
            this.txb_kullaniciadi.Location = new System.Drawing.Point(66, 420);
            this.txb_kullaniciadi.Name = "txb_kullaniciadi";
            this.txb_kullaniciadi.Size = new System.Drawing.Size(287, 22);
            this.txb_kullaniciadi.TabIndex = 11;
            // 
            // lbl_sifre
            // 
            this.lbl_sifre.AutoSize = true;
            this.lbl_sifre.Location = new System.Drawing.Point(44, 471);
            this.lbl_sifre.Name = "lbl_sifre";
            this.lbl_sifre.Size = new System.Drawing.Size(37, 17);
            this.lbl_sifre.TabIndex = 10;
            this.lbl_sifre.Text = "Şifre";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(44, 400);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(84, 17);
            this.lbl_email.TabIndex = 9;
            this.lbl_email.Text = "Kullanıcı Adı";
            // 
            // lbl_yazi
            // 
            this.lbl_yazi.AutoSize = true;
            this.lbl_yazi.Location = new System.Drawing.Point(169, 369);
            this.lbl_yazi.Name = "lbl_yazi";
            this.lbl_yazi.Size = new System.Drawing.Size(87, 17);
            this.lbl_yazi.TabIndex = 8;
            this.lbl_yazi.Text = "Giriş Yapınız";
            // 
            // GirisSayfasiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 623);
            this.Controls.Add(this.btn_kayitOl);
            this.Controls.Add(this.btn_girisYap);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txb_sifre);
            this.Controls.Add(this.txb_kullaniciadi);
            this.Controls.Add(this.lbl_sifre);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_yazi);
            this.IsMdiContainer = true;
            this.Name = "GirisSayfasiForm";
            this.Text = "GirisSayfasiForm";
            this.Load += new System.EventHandler(this.GirisSayfasiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_kayitOl;
        private System.Windows.Forms.Button btn_girisYap;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txb_sifre;
        private System.Windows.Forms.TextBox txb_kullaniciadi;
        private System.Windows.Forms.Label lbl_sifre;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_yazi;
    }
}