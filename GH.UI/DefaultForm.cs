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
    public partial class DefaultForm : Form
    {
        UrunDAL urunDAL = new UrunDAL();
        CurrentKullaniciDTO currentKullaniciDTO;
        UrunMaddeDTO urunMaddeDTO;
        IcerikDTO icerikDTO;
        KullaniciRolDTO kullaniciRolDTO;
        KullaniciMailDTO kullaniciMailDTO;
        KaraListeDTO karaListeDTO;
        KayitTarihDTO kayitTarihDTO;
        FavListeDTO favListeDTO;
        KullaniciUrunSayiDTO kullaniciUrunSayiDTO;
        FavUrunSayiDTO favUrunSayiDTO;
        EthanolKacKisininFavıDTO ethanolKacKisininFavıDTO;
        EthanolKacKisininKaraListesindeDTO ethanolKacKisininKaraListesindeDTO;

        public DefaultForm(CurrentKullaniciDTO _currentKullaniciDTO)
        {
            InitializeComponent();
            this.currentKullaniciDTO = _currentKullaniciDTO;
        }

        private void btn_urunekleduzenle_Click(object sender, EventArgs e)
        {
            List<UrunDTO> urunList = urunDAL.TumUrunleriListele("");

            if (urunList != null && urunList.Count > 0)
            {
                //EE: elime ürün listesi döndüyse (arama için konuşuyoruz) başarılı bir arama olmuş demektir. bunu bu if bloğunun içinde git db de arama tablosuna kaydet.
                UrunYonetimi urunYonetimi = new UrunYonetimi(urunList, currentKullaniciDTO);
                urunYonetimi.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Listelenecek ürün bulunamadı.");
        }

        private void btn_barkodOkuma_Click(object sender, EventArgs e)
        {
            BarkodOkumaForm barkodOkumaForm = new BarkodOkumaForm();
            barkodOkumaForm.Show();
            this.Hide();
        }

        private void btn_Arama_Click(object sender, EventArgs e)
        {
            AramaForm aramaForm = new AramaForm(currentKullaniciDTO);
            aramaForm.Show();
            this.Hide();
        }

        private void DefaultForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_aramagecmisfavori_Click(object sender, EventArgs e)
        {
            AramaGecmisEkran aramaGecmisEkran = new AramaGecmisEkran(currentKullaniciDTO);
            aramaGecmisEkran.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Raporscs raporscs = new Raporscs( urunMaddeDTO, icerikDTO, kullaniciRolDTO, kullaniciMailDTO, karaListeDTO, favListeDTO, kullaniciUrunSayiDTO, 
                favUrunSayiDTO, ethanolKacKisininFavıDTO, ethanolKacKisininKaraListesindeDTO);
            raporscs.Show();
            this.Hide();
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
            this.Hide();
        }

        private void btn_kisi_Click(object sender, EventArgs e)
        {
            KullaniciForm kullaniciForm = new KullaniciForm(currentKullaniciDTO);
            kullaniciForm.Show();
            this.Hide();

        }
    }
}
