using GH.DAL;
using GH.DAL.Concrete;
using GH.DTOs;
using GH.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GH.UI
{
    public partial class GirisSayfasiForm : Form
    {
        KullaniciDAL kullaniciDAL = new KullaniciDAL();

        public GirisSayfasiForm()
        {
            InitializeComponent();
        }

        private void btn_girisYap_Click(object sender, EventArgs e)
        {
            LoginDTO loginDTO = new LoginDTO();
            loginDTO.KullaniciAdi = txb_kullaniciadi.Text;
            loginDTO.Sifre = txb_sifre.Text;

            LoginValidator loginValidator = new LoginValidator(loginDTO);

            if (loginValidator.IsValid)
            {
                bool kullaniciVarMi = kullaniciDAL.KullaniciVarMi(txb_kullaniciadi.Text, txb_sifre.Text);
                if (!kullaniciVarMi)
                    MessageBox.Show("Böyle bir kullanıcı yok.");
                else
                {
                    CurrentKullaniciDTO currentKullaniciDTO = kullaniciDAL.Login(txb_kullaniciadi.Text, txb_sifre.Text);

                    if (currentKullaniciDTO != null)
                    {
                        //EE: elime ürün listesi döndüyse (arama için konuşuyoruz) başarılı bir arama olmuş demektir. bunu bu if bloğunun içinde git db de arama tablosuna kaydet.
                        DefaultForm defaultForm = new DefaultForm(currentKullaniciDTO);
                        defaultForm.Show();
                        this.Hide();
                    }
                }
                txb_kullaniciadi.Text = "";
                txb_sifre.Text = "";
            }
            else
            {
                MessageBox.Show(loginValidator.ValidationMessages.FirstOrDefault());
            }
        }

        private void btn_kayitOl_Click(object sender, EventArgs e)
        {
            KayitSayfasiForm kayitSayfasiform = new KayitSayfasiForm();
            kayitSayfasiform.Show();
            Hide();
        }

        private void GirisSayfasiForm_Load(object sender, EventArgs e)
        {

        }
    }
}
