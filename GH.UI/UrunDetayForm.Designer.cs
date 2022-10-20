
namespace GH.UI
{
    partial class UrunDetayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunDetayForm));
            this.btn_kisi = new System.Windows.Forms.Button();
            this.btn_menu = new System.Windows.Forms.Button();
            this.btn_anasayfa = new System.Windows.Forms.Button();
            this.Pcbox_urunresim = new System.Windows.Forms.PictureBox();
            this.txb_kategoriadi = new System.Windows.Forms.TextBox();
            this.txb_urunadi = new System.Windows.Forms.TextBox();
            this.lstbx_urunicerikleri = new System.Windows.Forms.ListBox();
            this.txb_riskSeviyesiadi = new System.Windows.Forms.TextBox();
            this.lbl_kategadi = new System.Windows.Forms.Label();
            this.lbl_urunAdi = new System.Windows.Forms.Label();
            this.lbl_urunriskseviye = new System.Windows.Forms.Label();
            this.lbl_urunicerik = new System.Windows.Forms.Label();
            this.lbl_uretici = new System.Windows.Forms.Label();
            this.txb_uretivi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pcbox_urunresim)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_kisi
            // 
            this.btn_kisi.Image = ((System.Drawing.Image)(resources.GetObject("btn_kisi.Image")));
            this.btn_kisi.Location = new System.Drawing.Point(325, 12);
            this.btn_kisi.Name = "btn_kisi";
            this.btn_kisi.Size = new System.Drawing.Size(50, 52);
            this.btn_kisi.TabIndex = 8;
            this.btn_kisi.UseVisualStyleBackColor = true;
            this.btn_kisi.Click += new System.EventHandler(this.btn_kisi_Click);
            // 
            // btn_menu
            // 
            this.btn_menu.Image = ((System.Drawing.Image)(resources.GetObject("btn_menu.Image")));
            this.btn_menu.Location = new System.Drawing.Point(12, 12);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(54, 49);
            this.btn_menu.TabIndex = 9;
            this.btn_menu.UseVisualStyleBackColor = true;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // btn_anasayfa
            // 
            this.btn_anasayfa.Image = ((System.Drawing.Image)(resources.GetObject("btn_anasayfa.Image")));
            this.btn_anasayfa.Location = new System.Drawing.Point(12, 555);
            this.btn_anasayfa.Name = "btn_anasayfa";
            this.btn_anasayfa.Size = new System.Drawing.Size(75, 56);
            this.btn_anasayfa.TabIndex = 10;
            this.btn_anasayfa.UseVisualStyleBackColor = true;
            this.btn_anasayfa.Click += new System.EventHandler(this.btn_anasayfa_Click);
            // 
            // Pcbox_urunresim
            // 
            this.Pcbox_urunresim.Location = new System.Drawing.Point(12, 87);
            this.Pcbox_urunresim.Name = "Pcbox_urunresim";
            this.Pcbox_urunresim.Size = new System.Drawing.Size(149, 160);
            this.Pcbox_urunresim.TabIndex = 11;
            this.Pcbox_urunresim.TabStop = false;
            // 
            // txb_kategoriadi
            // 
            this.txb_kategoriadi.Enabled = false;
            this.txb_kategoriadi.Location = new System.Drawing.Point(191, 87);
            this.txb_kategoriadi.Name = "txb_kategoriadi";
            this.txb_kategoriadi.Size = new System.Drawing.Size(184, 22);
            this.txb_kategoriadi.TabIndex = 12;
            // 
            // txb_urunadi
            // 
            this.txb_urunadi.Enabled = false;
            this.txb_urunadi.Location = new System.Drawing.Point(191, 132);
            this.txb_urunadi.Name = "txb_urunadi";
            this.txb_urunadi.Size = new System.Drawing.Size(184, 22);
            this.txb_urunadi.TabIndex = 13;
            this.txb_urunadi.TextChanged += new System.EventHandler(this.txb_urunadi_TextChanged);
            // 
            // lstbx_urunicerikleri
            // 
            this.lstbx_urunicerikleri.Enabled = false;
            this.lstbx_urunicerikleri.FormattingEnabled = true;
            this.lstbx_urunicerikleri.ItemHeight = 16;
            this.lstbx_urunicerikleri.Location = new System.Drawing.Point(12, 293);
            this.lstbx_urunicerikleri.Name = "lstbx_urunicerikleri";
            this.lstbx_urunicerikleri.Size = new System.Drawing.Size(363, 244);
            this.lstbx_urunicerikleri.TabIndex = 14;
            this.lstbx_urunicerikleri.SelectedIndexChanged += new System.EventHandler(this.lstbx_urunicerikleri_SelectedIndexChanged);
            // 
            // txb_riskSeviyesiadi
            // 
            this.txb_riskSeviyesiadi.Enabled = false;
            this.txb_riskSeviyesiadi.Location = new System.Drawing.Point(191, 177);
            this.txb_riskSeviyesiadi.Name = "txb_riskSeviyesiadi";
            this.txb_riskSeviyesiadi.Size = new System.Drawing.Size(184, 22);
            this.txb_riskSeviyesiadi.TabIndex = 15;
            // 
            // lbl_kategadi
            // 
            this.lbl_kategadi.AutoSize = true;
            this.lbl_kategadi.Location = new System.Drawing.Point(188, 67);
            this.lbl_kategadi.Name = "lbl_kategadi";
            this.lbl_kategadi.Size = new System.Drawing.Size(65, 17);
            this.lbl_kategadi.TabIndex = 16;
            this.lbl_kategadi.Text = "Kategori ";
            // 
            // lbl_urunAdi
            // 
            this.lbl_urunAdi.AutoSize = true;
            this.lbl_urunAdi.Location = new System.Drawing.Point(188, 112);
            this.lbl_urunAdi.Name = "lbl_urunAdi";
            this.lbl_urunAdi.Size = new System.Drawing.Size(63, 17);
            this.lbl_urunAdi.TabIndex = 17;
            this.lbl_urunAdi.Text = "Ürün Adı";
            // 
            // lbl_urunriskseviye
            // 
            this.lbl_urunriskseviye.AutoSize = true;
            this.lbl_urunriskseviye.Location = new System.Drawing.Point(188, 157);
            this.lbl_urunriskseviye.Name = "lbl_urunriskseviye";
            this.lbl_urunriskseviye.Size = new System.Drawing.Size(91, 17);
            this.lbl_urunriskseviye.TabIndex = 18;
            this.lbl_urunriskseviye.Text = "Risk Seviyesi";
            // 
            // lbl_urunicerik
            // 
            this.lbl_urunicerik.AutoSize = true;
            this.lbl_urunicerik.Location = new System.Drawing.Point(20, 273);
            this.lbl_urunicerik.Name = "lbl_urunicerik";
            this.lbl_urunicerik.Size = new System.Drawing.Size(95, 17);
            this.lbl_urunicerik.TabIndex = 19;
            this.lbl_urunicerik.Text = "Ürün İçerikleri";
            // 
            // lbl_uretici
            // 
            this.lbl_uretici.AutoSize = true;
            this.lbl_uretici.Location = new System.Drawing.Point(191, 206);
            this.lbl_uretici.Name = "lbl_uretici";
            this.lbl_uretici.Size = new System.Drawing.Size(48, 17);
            this.lbl_uretici.TabIndex = 20;
            this.lbl_uretici.Text = "Üretici";
            // 
            // txb_uretivi
            // 
            this.txb_uretivi.Enabled = false;
            this.txb_uretivi.Location = new System.Drawing.Point(194, 227);
            this.txb_uretivi.Name = "txb_uretivi";
            this.txb_uretivi.Size = new System.Drawing.Size(181, 22);
            this.txb_uretivi.TabIndex = 21;
            // 
            // UrunDetayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 623);
            this.Controls.Add(this.txb_uretivi);
            this.Controls.Add(this.lbl_uretici);
            this.Controls.Add(this.lbl_urunicerik);
            this.Controls.Add(this.lbl_urunriskseviye);
            this.Controls.Add(this.lbl_urunAdi);
            this.Controls.Add(this.lbl_kategadi);
            this.Controls.Add(this.txb_riskSeviyesiadi);
            this.Controls.Add(this.lstbx_urunicerikleri);
            this.Controls.Add(this.txb_urunadi);
            this.Controls.Add(this.txb_kategoriadi);
            this.Controls.Add(this.Pcbox_urunresim);
            this.Controls.Add(this.btn_anasayfa);
            this.Controls.Add(this.btn_menu);
            this.Controls.Add(this.btn_kisi);
            this.IsMdiContainer = true;
            this.Name = "UrunDetayForm";
            this.Text = "UrunDetayForm";
            this.Load += new System.EventHandler(this.UrunDetayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pcbox_urunresim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_kisi;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.Button btn_anasayfa;
        private System.Windows.Forms.PictureBox Pcbox_urunresim;
        private System.Windows.Forms.TextBox txb_kategoriadi;
        private System.Windows.Forms.TextBox txb_urunadi;
        private System.Windows.Forms.ListBox lstbx_urunicerikleri;
        private System.Windows.Forms.TextBox txb_riskSeviyesiadi;
        private System.Windows.Forms.Label lbl_kategadi;
        private System.Windows.Forms.Label lbl_urunAdi;
        private System.Windows.Forms.Label lbl_urunriskseviye;
        private System.Windows.Forms.Label lbl_urunicerik;
        private System.Windows.Forms.Label lbl_uretici;
        private System.Windows.Forms.TextBox txb_uretivi;
    }
}