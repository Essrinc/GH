using GH.DAL.Concrete;
using GH.DTOs;
using GH.DTOs.RaporDTOs;
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
    public partial class KullaniciForm : Form
    {
        CurrentKullaniciDTO currentKullaniciDTO;
        KullaniciDAL kullaniciDAL = new KullaniciDAL();
        KayitTarihDTO kayitTarihDTO;
        UrunDAL urunDAL = new UrunDAL();
        KullaniciUrunDTO kullaniciUrunDTO;
        public KullaniciForm(CurrentKullaniciDTO _currentKullaniciDTO)
        {
            InitializeComponent();
            currentKullaniciDTO = _currentKullaniciDTO;
        }

        private void btn_anasayfa_Click(object sender, EventArgs e)
        {
            DefaultForm defaultForm = new DefaultForm(currentKullaniciDTO);
            defaultForm.Show();
            this.Hide();
        }

        private void dtgw_createdDate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void KullaniciForm_Load(object sender, EventArgs e)
        {
            txb_kayıtTarih.ReadOnly = true;
            txb_urunsayi.ReadOnly = true;

            List<KayitTarihDTO> kayitTarihDTOList = kullaniciDAL.KayitTarihi( currentKullaniciDTO);

            List<KullaniciUrunDTO> kullaniciUrunDTOList = urunDAL.KacUrunumVar(currentKullaniciDTO);


            kayitTarihDTO = kayitTarihDTOList.FirstOrDefault();
            kullaniciUrunDTO = kullaniciUrunDTOList.FirstOrDefault();

            txb_kayıtTarih.Text = kayitTarihDTO.CreatedDate.ToString();
            txb_urunsayi.Text = kullaniciUrunDTO.UrunSayisi.ToString();
        }

        private void dtgw_urunsayisi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgw_createdDate_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_cikisyap_Click(object sender, EventArgs e)
        {
            GirisSayfasiForm girisSayfasiForm = new GirisSayfasiForm();
            girisSayfasiForm.Show();
            this.Hide();
        }

        private void btn_epostadegistir_Click(object sender, EventArgs e)
        {
            KullaniciGuncellemeForm kullaniciGuncellemeForm = new KullaniciGuncellemeForm(currentKullaniciDTO);
            kullaniciGuncellemeForm.Show();
            this.Hide();
        }

        private void btn_favoriler_Click(object sender, EventArgs e)
        {
            FavUrunListEkran favUrunListEkran = new FavUrunListEkran(currentKullaniciDTO);
            favUrunListEkran.Show();
            this.Hide();
        }

        private void btn_sifredegistir_Click(object sender, EventArgs e)
        {
            KullaniciGuncellemeForm kullaniciGuncellemeForm = new KullaniciGuncellemeForm(currentKullaniciDTO);
            kullaniciGuncellemeForm.Show();
            this.Hide();
        }

        private void btn_karaliste_Click(object sender, EventArgs e)
        {
            karaliste karaListe = new karaliste(currentKullaniciDTO);
            karaListe.Show();
            this.Hide();
        }

        private void btn_aragecmisinitemizle_Click(object sender, EventArgs e)
        {
            bool isSuccess = kullaniciDAL.AramaGecmisiTmizle(currentKullaniciDTO);
            if (isSuccess)
                MessageBox.Show("arama geçmişiniz temizlendi!");
            else
            {
                MessageBox.Show("Beklenmeyen bir hata oluştu, daha sonra tekrar deneyin.");
            }
        }

        private void btn_profilguncelle_Click(object sender, EventArgs e)
        {
            KullaniciGuncellemeForm kullaniciGuncellemeForm = new KullaniciGuncellemeForm(currentKullaniciDTO);
            kullaniciGuncellemeForm.Show();
            this.Hide();
        }
    }
}
