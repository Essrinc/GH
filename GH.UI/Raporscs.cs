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
    public partial class Raporscs : Form
    {
        UrunMaddeDTO urunMaddeDTO;
        IcerikDTO icerikDTO;
        KullaniciRolDTO kullaniciRolDTO;
        KullaniciMailDTO kullaniciMailDTO;
        KaraListeDTO karaListeDTO;
        CurrentKullaniciDTO currentKullaniciDTO;
        HangiUrunKacMaddeDTO hangiUrunKacMaddeDTO;
        EnRiskliUrunTutanKullaniciDTO enRiskliUrunTutanKullaniciDTO;
        EnMaddeliUrunlerDTO enMaddeliUrunlerDTO;
        FavListeDTO favListeDTO;
        KullaniciUrunSayiDTO kullaniciUrunSayiDTO;
        FavUrunSayiDTO favUrunSayiDTO;
        EthanolKacKisininFavıDTO ethanolKacKisininFavıDTO;
        EthanolKacKisininKaraListesindeDTO ethanolKacKisininKaraListesindeDTO;


        public Raporscs(UrunMaddeDTO _urunMaddeDTO, IcerikDTO _icerikDTO, KullaniciRolDTO _kullaniciRolDTO, KullaniciMailDTO _kullaniciMailDTO, 
            KaraListeDTO _karaListeDTO, FavListeDTO _favListeDTO, KullaniciUrunSayiDTO _kullaniciUrunSayiDTO, FavUrunSayiDTO _favUrunSayiDTO,
            EthanolKacKisininFavıDTO _ethanolKacKisininFavıDTO, EthanolKacKisininKaraListesindeDTO _ethanolKacKisininKaraListesindeDTO)
        {
            InitializeComponent();
            this.urunMaddeDTO = _urunMaddeDTO;
            this.icerikDTO = _icerikDTO;
            this.kullaniciRolDTO = _kullaniciRolDTO;
            this.kullaniciMailDTO = _kullaniciMailDTO;
            this.favListeDTO = _favListeDTO;
            this.kullaniciUrunSayiDTO = _kullaniciUrunSayiDTO;
            this.favUrunSayiDTO = _favUrunSayiDTO;
            this.ethanolKacKisininFavıDTO = _ethanolKacKisininFavıDTO;
            this.ethanolKacKisininKaraListesindeDTO = _ethanolKacKisininKaraListesindeDTO;
        }
        
        private void button8_Click(object sender, EventArgs e) //soru 13 favlist
        {
            Sorgu13FavListEkran sorgu13FavListEkran = new Sorgu13FavListEkran(favListeDTO);
            sorgu13FavListEkran.Show();
            this.Hide();
        }

        private void btn_soru1_Click(object sender, EventArgs e)
        {
            Sorgu1Ekran sorgu1Ekran = new Sorgu1Ekran(hangiUrunKacMaddeDTO);
            sorgu1Ekran.Show();
            this.Hide();
        }

        private void btn_soru2_Click(object sender, EventArgs e)
        {
            Sorgu2Ekran sorgu2Ekran = new Sorgu2Ekran(urunMaddeDTO);
            sorgu2Ekran.Show();
            this.Hide();
        }

        private void btn_soru6_Click(object sender, EventArgs e)
        {
            Sorgu6Ekran sorgu6Ekran = new Sorgu6Ekran(icerikDTO);
            sorgu6Ekran.Show();
            this.Hide();
        }

        private void Raporscs_Load(object sender, EventArgs e)
        {

        }

        private void btn_soru9_Click(object sender, EventArgs e)
        {
            Sorgu9Ekran sorgu9Ekran = new Sorgu9Ekran(icerikDTO);
            sorgu9Ekran.Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Sorgu15Ekran sorgu15Ekran = new Sorgu15Ekran(kullaniciRolDTO);
            sorgu15Ekran.Show();
            this.Hide();

        }

        private void btn_soru10_Click(object sender, EventArgs e)
        {
            Sorgu10Ekran sorgu10Ekran = new Sorgu10Ekran(enRiskliUrunTutanKullaniciDTO);
            sorgu10Ekran.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sorgu11Ekran sorgu11Ekran = new Sorgu11Ekran(kullaniciMailDTO);
            sorgu11Ekran.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sorgu12Ekran sorgu12Ekran = new Sorgu12Ekran(enMaddeliUrunlerDTO);
            sorgu12Ekran.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e) //soru13karalidt
        {
            Sorgu13KaraList sorgu13KaraList = new Sorgu13KaraList(karaListeDTO);
            sorgu13KaraList.Show();
            this.Hide();
        }

        private void btn_anasayfa_Click(object sender, EventArgs e)
        {
            DefaultForm defaultForm = new DefaultForm(currentKullaniciDTO);
            defaultForm.Show();
            this.Hide();
        }

        private void btn_soru3_Click(object sender, EventArgs e)
        {
            Sorgu3Ekran sorgu3Ekran = new Sorgu3Ekran(currentKullaniciDTO);
            sorgu3Ekran.Show();
            this.Hide();
        }

        private void btn_soru4_Click(object sender, EventArgs e)
        {
            Sorgu4Ekran sorgu4Ekran = new Sorgu4Ekran();
            sorgu4Ekran.Show();
            this.Hide();
        }

        private void btn_soru5_Click(object sender, EventArgs e)
        {
            Sorgu5EkranFavListe sorgu5Ekran = new Sorgu5EkranFavListe(ethanolKacKisininFavıDTO);
            sorgu5Ekran.Show();
            this.Hide();
        }

        private void btn_soru7_Click(object sender, EventArgs e)
        {
            Sorgu7Ekran sorgu7Ekran = new Sorgu7Ekran(favUrunSayiDTO);
            sorgu7Ekran.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Sorgu8Ekran sorgu8Ekran = new Sorgu8Ekran(favUrunSayiDTO);
            sorgu8Ekran.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Sorgu14EkranFavListe sorgu14Ekran = new Sorgu14EkranFavListe( kullaniciUrunSayiDTO);
            sorgu14Ekran.Show();
            this.Hide();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            Sorgu14EkranKaraListe sorgu14Ekran = new Sorgu14EkranKaraListe(kullaniciUrunSayiDTO);
            sorgu14Ekran.Show();
            this.Hide();
        }

        private void sor5karaListe_Click(object sender, EventArgs e)
        {
            Sorgu5EkranKaraListe sorgu5EkranKaraListe = new Sorgu5EkranKaraListe(ethanolKacKisininKaraListesindeDTO);
            sorgu5EkranKaraListe.Show();
            this.Hide();
        }
    }
}
