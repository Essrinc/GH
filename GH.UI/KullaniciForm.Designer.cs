
namespace GH.UI
{
    partial class KullaniciForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciForm));
            this.btn_cikisyap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_anasayfa = new System.Windows.Forms.Button();
            this.btn_sosyalmedya = new System.Windows.Forms.Button();
            this.btn_sifredegistir = new System.Windows.Forms.Button();
            this.btn_aragecmisinitemizle = new System.Windows.Forms.Button();
            this.btn_karaliste = new System.Windows.Forms.Button();
            this.btn_epostadegistir = new System.Windows.Forms.Button();
            this.btn_profilguncelle = new System.Windows.Forms.Button();
            this.btn_favoriler = new System.Windows.Forms.Button();
            this.btn_premiumuye = new System.Windows.Forms.Button();
            this.txb_kayıtTarih = new System.Windows.Forms.TextBox();
            this.txb_urunsayi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_cikisyap
            // 
            this.btn_cikisyap.Location = new System.Drawing.Point(12, 524);
            this.btn_cikisyap.Name = "btn_cikisyap";
            this.btn_cikisyap.Size = new System.Drawing.Size(237, 35);
            this.btn_cikisyap.TabIndex = 27;
            this.btn_cikisyap.Text = "Çıkış Yap";
            this.btn_cikisyap.UseVisualStyleBackColor = true;
            this.btn_cikisyap.Click += new System.EventHandler(this.btn_cikisyap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "KULLANICI";
            // 
            // btn_anasayfa
            // 
            this.btn_anasayfa.Image = ((System.Drawing.Image)(resources.GetObject("btn_anasayfa.Image")));
            this.btn_anasayfa.Location = new System.Drawing.Point(310, 542);
            this.btn_anasayfa.Name = "btn_anasayfa";
            this.btn_anasayfa.Size = new System.Drawing.Size(75, 56);
            this.btn_anasayfa.TabIndex = 23;
            this.btn_anasayfa.UseVisualStyleBackColor = true;
            this.btn_anasayfa.Click += new System.EventHandler(this.btn_anasayfa_Click);
            // 
            // btn_sosyalmedya
            // 
            this.btn_sosyalmedya.Location = new System.Drawing.Point(12, 260);
            this.btn_sosyalmedya.Name = "btn_sosyalmedya";
            this.btn_sosyalmedya.Size = new System.Drawing.Size(237, 35);
            this.btn_sosyalmedya.TabIndex = 18;
            this.btn_sosyalmedya.Text = "Sosyal Medya Hesabı ile Birleştir";
            this.btn_sosyalmedya.UseVisualStyleBackColor = true;
            // 
            // btn_sifredegistir
            // 
            this.btn_sifredegistir.Location = new System.Drawing.Point(12, 212);
            this.btn_sifredegistir.Name = "btn_sifredegistir";
            this.btn_sifredegistir.Size = new System.Drawing.Size(237, 30);
            this.btn_sifredegistir.TabIndex = 19;
            this.btn_sifredegistir.Text = "Şifre Değiştir";
            this.btn_sifredegistir.UseVisualStyleBackColor = true;
            this.btn_sifredegistir.Click += new System.EventHandler(this.btn_sifredegistir_Click);
            // 
            // btn_aragecmisinitemizle
            // 
            this.btn_aragecmisinitemizle.Location = new System.Drawing.Point(12, 471);
            this.btn_aragecmisinitemizle.Name = "btn_aragecmisinitemizle";
            this.btn_aragecmisinitemizle.Size = new System.Drawing.Size(237, 35);
            this.btn_aragecmisinitemizle.TabIndex = 20;
            this.btn_aragecmisinitemizle.Text = "Arama Geçmişini Temizle";
            this.btn_aragecmisinitemizle.UseVisualStyleBackColor = true;
            this.btn_aragecmisinitemizle.Click += new System.EventHandler(this.btn_aragecmisinitemizle_Click);
            // 
            // btn_karaliste
            // 
            this.btn_karaliste.Location = new System.Drawing.Point(12, 421);
            this.btn_karaliste.Name = "btn_karaliste";
            this.btn_karaliste.Size = new System.Drawing.Size(237, 35);
            this.btn_karaliste.TabIndex = 21;
            this.btn_karaliste.Text = "Kara Liste";
            this.btn_karaliste.UseVisualStyleBackColor = true;
            this.btn_karaliste.Click += new System.EventHandler(this.btn_karaliste_Click);
            // 
            // btn_epostadegistir
            // 
            this.btn_epostadegistir.Location = new System.Drawing.Point(12, 176);
            this.btn_epostadegistir.Name = "btn_epostadegistir";
            this.btn_epostadegistir.Size = new System.Drawing.Size(237, 30);
            this.btn_epostadegistir.TabIndex = 22;
            this.btn_epostadegistir.Text = "E-Posta Adresini Değiştir";
            this.btn_epostadegistir.UseVisualStyleBackColor = true;
            this.btn_epostadegistir.Click += new System.EventHandler(this.btn_epostadegistir_Click);
            // 
            // btn_profilguncelle
            // 
            this.btn_profilguncelle.Location = new System.Drawing.Point(12, 312);
            this.btn_profilguncelle.Name = "btn_profilguncelle";
            this.btn_profilguncelle.Size = new System.Drawing.Size(237, 35);
            this.btn_profilguncelle.TabIndex = 15;
            this.btn_profilguncelle.Text = "Profil Bilgilerini Güncelle";
            this.btn_profilguncelle.UseVisualStyleBackColor = true;
            this.btn_profilguncelle.Click += new System.EventHandler(this.btn_profilguncelle_Click);
            // 
            // btn_favoriler
            // 
            this.btn_favoriler.Location = new System.Drawing.Point(12, 366);
            this.btn_favoriler.Name = "btn_favoriler";
            this.btn_favoriler.Size = new System.Drawing.Size(237, 35);
            this.btn_favoriler.TabIndex = 16;
            this.btn_favoriler.Text = "Favoriler";
            this.btn_favoriler.UseVisualStyleBackColor = true;
            this.btn_favoriler.Click += new System.EventHandler(this.btn_favoriler_Click);
            // 
            // btn_premiumuye
            // 
            this.btn_premiumuye.Location = new System.Drawing.Point(12, 130);
            this.btn_premiumuye.Name = "btn_premiumuye";
            this.btn_premiumuye.Size = new System.Drawing.Size(237, 30);
            this.btn_premiumuye.TabIndex = 33;
            this.btn_premiumuye.Text = "Premium Üye Ol";
            this.btn_premiumuye.UseVisualStyleBackColor = true;
            // 
            // txb_kayıtTarih
            // 
            this.txb_kayıtTarih.Location = new System.Drawing.Point(92, 54);
            this.txb_kayıtTarih.Name = "txb_kayıtTarih";
            this.txb_kayıtTarih.Size = new System.Drawing.Size(172, 22);
            this.txb_kayıtTarih.TabIndex = 35;
            // 
            // txb_urunsayi
            // 
            this.txb_urunsayi.Location = new System.Drawing.Point(92, 82);
            this.txb_urunsayi.Name = "txb_urunsayi";
            this.txb_urunsayi.Size = new System.Drawing.Size(172, 22);
            this.txb_urunsayi.TabIndex = 36;
            // 
            // KullaniciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 623);
            this.Controls.Add(this.txb_urunsayi);
            this.Controls.Add(this.txb_kayıtTarih);
            this.Controls.Add(this.btn_premiumuye);
            this.Controls.Add(this.btn_cikisyap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_anasayfa);
            this.Controls.Add(this.btn_sosyalmedya);
            this.Controls.Add(this.btn_sifredegistir);
            this.Controls.Add(this.btn_aragecmisinitemizle);
            this.Controls.Add(this.btn_karaliste);
            this.Controls.Add(this.btn_epostadegistir);
            this.Controls.Add(this.btn_profilguncelle);
            this.Controls.Add(this.btn_favoriler);
            this.IsMdiContainer = true;
            this.Name = "KullaniciForm";
            this.Text = "KullaniciForm";
            this.Load += new System.EventHandler(this.KullaniciForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cikisyap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_anasayfa;
        private System.Windows.Forms.Button btn_sosyalmedya;
        private System.Windows.Forms.Button btn_sifredegistir;
        private System.Windows.Forms.Button btn_aragecmisinitemizle;
        private System.Windows.Forms.Button btn_karaliste;
        private System.Windows.Forms.Button btn_epostadegistir;
        private System.Windows.Forms.Button btn_profilguncelle;
        private System.Windows.Forms.Button btn_favoriler;
        private System.Windows.Forms.Button btn_premiumuye;
        private System.Windows.Forms.TextBox txb_kayıtTarih;
        private System.Windows.Forms.TextBox txb_urunsayi;
    }
}