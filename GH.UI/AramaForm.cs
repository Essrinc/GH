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
    public partial class AramaForm : Form
    {
        UrunDAL urunDAL = new UrunDAL();
        CurrentKullaniciDTO currentKullaniciDTO;

        public AramaForm(CurrentKullaniciDTO _currentKullaniciDTO)
        {
            InitializeComponent();
            this.currentKullaniciDTO = _currentKullaniciDTO;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_urunara_Click(object sender, EventArgs e)
        {
            List<UrunDTO> urunList = urunDAL.TumUrunleriListele(txt_urunara.Text);

            if (urunList != null && urunList.Count>0)
            {
                //EE: elime ürün listesi döndüyse (arama için konuşuyoruz) başarılı bir arama olmuş demektir. bunu bu if bloğunun içinde git db de arama tablosuna kaydet.
                AramaSonucUrun aramaSonucUrun = new AramaSonucUrun(urunList, currentKullaniciDTO);
                aramaSonucUrun.Show();
                this.Hide();
            }
            else
            MessageBox.Show("Aradığınız kriterlerde ürün bulunamamıştır.");

        }

        private void txt_urunara_TextChanged(object sender, EventArgs e)
        {

        }

        private void AramaForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_anasayfa_Click(object sender, EventArgs e)
        {
            DefaultForm defaultForm = new DefaultForm(currentKullaniciDTO);
            defaultForm.Show();
            this.Hide();
        }
    }
}
