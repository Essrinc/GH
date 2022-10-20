
namespace GH.UI
{
    partial class UrunEkleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunEkleForm));
            this.txt_barkod = new System.Windows.Forms.TextBox();
            this.btn_kisi = new System.Windows.Forms.Button();
            this.btn_menu = new System.Windows.Forms.Button();
            this.btn_anasayfa = new System.Windows.Forms.Button();
            this.cmb_uretici = new System.Windows.Forms.ComboBox();
            this.txt_urunadi = new System.Windows.Forms.TextBox();
            this.cmb_Kategori = new System.Windows.Forms.ComboBox();
            this.txt_urunicerik = new System.Windows.Forms.TextBox();
            this.btn_gonder = new System.Windows.Forms.Button();
            this.lbl_barkod = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_urunadi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_icerik = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_barkod
            // 
            this.txt_barkod.Location = new System.Drawing.Point(68, 130);
            this.txt_barkod.Name = "txt_barkod";
            this.txt_barkod.Size = new System.Drawing.Size(266, 22);
            this.txt_barkod.TabIndex = 5;
            // 
            // btn_kisi
            // 
            this.btn_kisi.Image = ((System.Drawing.Image)(resources.GetObject("btn_kisi.Image")));
            this.btn_kisi.Location = new System.Drawing.Point(340, 28);
            this.btn_kisi.Name = "btn_kisi";
            this.btn_kisi.Size = new System.Drawing.Size(45, 45);
            this.btn_kisi.TabIndex = 6;
            this.btn_kisi.UseVisualStyleBackColor = true;
            this.btn_kisi.Click += new System.EventHandler(this.btn_kisi_Click);
            // 
            // btn_menu
            // 
            this.btn_menu.Image = ((System.Drawing.Image)(resources.GetObject("btn_menu.Image")));
            this.btn_menu.Location = new System.Drawing.Point(12, 28);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(48, 38);
            this.btn_menu.TabIndex = 7;
            this.btn_menu.UseVisualStyleBackColor = true;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // btn_anasayfa
            // 
            this.btn_anasayfa.Image = ((System.Drawing.Image)(resources.GetObject("btn_anasayfa.Image")));
            this.btn_anasayfa.Location = new System.Drawing.Point(23, 555);
            this.btn_anasayfa.Name = "btn_anasayfa";
            this.btn_anasayfa.Size = new System.Drawing.Size(75, 56);
            this.btn_anasayfa.TabIndex = 8;
            this.btn_anasayfa.UseVisualStyleBackColor = true;
            this.btn_anasayfa.Click += new System.EventHandler(this.btn_anasayfa_Click);
            // 
            // cmb_uretici
            // 
            this.cmb_uretici.FormattingEnabled = true;
            this.cmb_uretici.Location = new System.Drawing.Point(68, 180);
            this.cmb_uretici.Name = "cmb_uretici";
            this.cmb_uretici.Size = new System.Drawing.Size(266, 24);
            this.cmb_uretici.TabIndex = 9;
            this.cmb_uretici.SelectedIndexChanged += new System.EventHandler(this.cmb_uretici_SelectedIndexChanged);
            // 
            // txt_urunadi
            // 
            this.txt_urunadi.Location = new System.Drawing.Point(68, 233);
            this.txt_urunadi.Name = "txt_urunadi";
            this.txt_urunadi.Size = new System.Drawing.Size(266, 22);
            this.txt_urunadi.TabIndex = 10;
            // 
            // cmb_Kategori
            // 
            this.cmb_Kategori.FormattingEnabled = true;
            this.cmb_Kategori.Location = new System.Drawing.Point(68, 288);
            this.cmb_Kategori.Name = "cmb_Kategori";
            this.cmb_Kategori.Size = new System.Drawing.Size(266, 24);
            this.cmb_Kategori.TabIndex = 11;
            // 
            // txt_urunicerik
            // 
            this.txt_urunicerik.Location = new System.Drawing.Point(68, 347);
            this.txt_urunicerik.Multiline = true;
            this.txt_urunicerik.Name = "txt_urunicerik";
            this.txt_urunicerik.Size = new System.Drawing.Size(266, 81);
            this.txt_urunicerik.TabIndex = 12;
            // 
            // btn_gonder
            // 
            this.btn_gonder.Location = new System.Drawing.Point(146, 456);
            this.btn_gonder.Name = "btn_gonder";
            this.btn_gonder.Size = new System.Drawing.Size(121, 49);
            this.btn_gonder.TabIndex = 13;
            this.btn_gonder.Text = "Kaydet";
            this.btn_gonder.UseVisualStyleBackColor = true;
            this.btn_gonder.Click += new System.EventHandler(this.btn_gonder_Click);
            // 
            // lbl_barkod
            // 
            this.lbl_barkod.AutoSize = true;
            this.lbl_barkod.Location = new System.Drawing.Point(68, 107);
            this.lbl_barkod.Name = "lbl_barkod";
            this.lbl_barkod.Size = new System.Drawing.Size(115, 17);
            this.lbl_barkod.TabIndex = 16;
            this.lbl_barkod.Text = "Barkod numarası";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Üretici Seçiniz";
            // 
            // lbl_urunadi
            // 
            this.lbl_urunadi.AutoSize = true;
            this.lbl_urunadi.Location = new System.Drawing.Point(71, 213);
            this.lbl_urunadi.Name = "lbl_urunadi";
            this.lbl_urunadi.Size = new System.Drawing.Size(63, 17);
            this.lbl_urunadi.TabIndex = 18;
            this.lbl_urunadi.Text = "Ürün Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Kategori Seçiniz";
            // 
            // lbl_icerik
            // 
            this.lbl_icerik.AutoSize = true;
            this.lbl_icerik.Location = new System.Drawing.Point(74, 324);
            this.lbl_icerik.Name = "lbl_icerik";
            this.lbl_icerik.Size = new System.Drawing.Size(144, 17);
            this.lbl_icerik.TabIndex = 20;
            this.lbl_icerik.Text = "Ürün içeriğini giriniz...";
            // 
            // UrunEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 623);
            this.Controls.Add(this.lbl_icerik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_urunadi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_barkod);
            this.Controls.Add(this.btn_gonder);
            this.Controls.Add(this.txt_urunicerik);
            this.Controls.Add(this.cmb_Kategori);
            this.Controls.Add(this.txt_urunadi);
            this.Controls.Add(this.cmb_uretici);
            this.Controls.Add(this.btn_anasayfa);
            this.Controls.Add(this.btn_menu);
            this.Controls.Add(this.btn_kisi);
            this.Controls.Add(this.txt_barkod);
            this.IsMdiContainer = true;
            this.Name = "UrunEkleForm";
            this.Text = "UrunEkleForm";
            this.Load += new System.EventHandler(this.UrunEkleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_barkod;
        private System.Windows.Forms.Button btn_kisi;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.Button btn_anasayfa;
        private System.Windows.Forms.ComboBox cmb_uretici;
        private System.Windows.Forms.TextBox txt_urunadi;
        private System.Windows.Forms.ComboBox cmb_Kategori;
        private System.Windows.Forms.TextBox txt_urunicerik;
        private System.Windows.Forms.Button btn_gonder;
        private System.Windows.Forms.Label lbl_barkod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_urunadi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_icerik;
    }
}