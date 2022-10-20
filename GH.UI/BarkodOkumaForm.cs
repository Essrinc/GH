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
    public partial class BarkodOkumaForm : Form
    {
        BarkodDAL barkodDAL = new BarkodDAL();
        CurrentKullaniciDTO currentKullaniciDTO;
        public BarkodOkumaForm()
        {
            InitializeComponent();
        }

        private void BarkodOkumaForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            BarkodKontrolDTO barkodKontrolDTO = new BarkodKontrolDTO();
            if (txb_barkod.Text != "")

                barkodKontrolDTO.Barkod = new Guid(txb_barkod.Text);

            BarkodValidator barkodValidator = new BarkodValidator(barkodKontrolDTO);

            if (barkodValidator.IsValid)
            {
                bool barkodVarMi = barkodDAL.BarkodVarMi(barkodKontrolDTO.Barkod);
                if (!barkodVarMi)
                    MessageBox.Show("Böyle bir barkod yok.");
                else
                {
                    BarkodResultDTO currentBarkodDTO = barkodDAL.BarkodArama(barkodKontrolDTO.Barkod);

                    if (currentBarkodDTO != null)
                    {
                        //EE: elime ürün listesi döndüyse (arama için konuşuyoruz) başarılı bir arama olmuş demektir. bunu bu if bloğunun içinde git db de arama tablosuna kaydet.
                        UrunDetayForm urunDetayForm = new UrunDetayForm(currentBarkodDTO);
                        urunDetayForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Girilen barkod ile eşleşen ürün bulunamadı.");
                    }
                }
            }
            else
            {
                MessageBox.Show(barkodValidator.ValidationMessages.FirstOrDefault());
            }
        }

        private void btn_anasayfa_Click(object sender, EventArgs e)
        {
            DefaultForm defaultForm = new DefaultForm(currentKullaniciDTO);
            defaultForm.Show();
            this.Hide();

        }
    }
}
