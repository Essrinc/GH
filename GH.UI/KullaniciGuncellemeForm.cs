using GH.DAL.Concrete;
using GH.DTOs;
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
    public partial class KullaniciGuncellemeForm : Form
    {
        KullaniciDAL kullaniciDAL = new KullaniciDAL();
        CurrentKullaniciDTO currentKullaniciDTO;
        KullaniciGuncelleDTO kullaniciGuncelleDTO;
        KayitTarihDTO kayitTarihDTO;


        public KullaniciGuncellemeForm(CurrentKullaniciDTO _currentKullaniciDTO)
        {
            InitializeComponent();
            this.currentKullaniciDTO = _currentKullaniciDTO;
        }

        private void txt_sifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_kullaniciAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_anasayfa_Click(object sender, EventArgs e)
        {
            DefaultForm defaultForm = new DefaultForm(currentKullaniciDTO);
            defaultForm.Show();
            this.Hide();
        }

        private void KullaniciGuncellemeForm_Load(object sender, EventArgs e)
        {
            txt_email.Text = currentKullaniciDTO.Email;
            txt_kullaniciAdi.Text = currentKullaniciDTO.KullaniciAdi;
            txt_sifre.Text = currentKullaniciDTO.Sifre;
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {

            currentKullaniciDTO.KullaniciAdi = txt_kullaniciAdi.Text;
            currentKullaniciDTO.Email = txt_email.Text;
            currentKullaniciDTO.Sifre = txt_sifre.Text;

            if (txt_kullaniciAdi.Text == "")
            {
                MessageBox.Show("Kullanıcı Adı alanını boş bırakmayınız.");
            }
            else if (txt_email.Text == "")
            {
                MessageBox.Show("Email alanını boş bırakmayınız.");
            }
            else if (txt_sifre.Text == "")
            {
                MessageBox.Show("Şifre alanını boş bırakmayınız.");
            }

            bool isSucces = kullaniciDAL.KullaniciGuncelle(currentKullaniciDTO);

            if(isSucces)
            {
                KullaniciForm kullaniciForm = new KullaniciForm(currentKullaniciDTO);
                kullaniciForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Güncelleme işlemi başarısız.");
            }
        }
    }
}
