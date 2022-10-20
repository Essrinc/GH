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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GH.UI
{
    public partial class KayitSayfasiForm : Form
    {
        KullaniciDAL kullaniciDAL = new KullaniciDAL();
        public KayitSayfasiForm()
        {
            InitializeComponent();
        }

        private void btn_kayitOl_Click(object sender, EventArgs e)
        {
            KayitDTO kayitDTO = new KayitDTO();
            kayitDTO.KullaniciAdi = txb_kullaniciadi.Text;
            kayitDTO.Sifre = txb_sifre.Text;
            kayitDTO.Email = txb_email.Text;

            KayitValidator kayitValidator = new KayitValidator(kayitDTO);

            if (kayitValidator.IsValid)
            {
                bool isSuccess = kullaniciDAL.Kayit(txb_kullaniciadi.Text, txb_sifre.Text, txb_email.Text);

                if (isSuccess)
                {
                    GirisSayfasiForm girisSayfasiForm = new GirisSayfasiForm();
                    girisSayfasiForm.Show();
                    this.Hide();
                }
                //dbye kayıt etmeli. benimki etmiyor.
            }
            else
            {
                MessageBox.Show(kayitValidator.ValidationMessages.FirstOrDefault());
            }

        }

        private void KayitSayfasiForm_Load(object sender, EventArgs e)
        {

        }
    }
}
