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
    public partial class UrunGuncelleForm : Form
    {
        int urunId = 0;
        UrunDAL urunDAL = new UrunDAL();
        CurrentKullaniciDTO currentKullaniciDTO;
        List<UrunDTO> urunList;
        KayitTarihDTO kayitTarihDTO;


        public UrunGuncelleForm(int _urunId, CurrentKullaniciDTO _currentKullaniciDTO)
        {
            InitializeComponent();
            this.urunId = _urunId;
            this.currentKullaniciDTO = _currentKullaniciDTO;
        }

        private void txt_barkod_TextChanged(object sender, EventArgs e)
        {

        }

        private void UrunGuncelleForm_Load(object sender, EventArgs e)
        {
            BarkodResultDTO currentBarkodDTO = urunDAL.UrunArama(urunId);

            List<KategoriDTO> kategoriDTOList = urunDAL.TumKategorileriGetir();

            if (kategoriDTOList != null && kategoriDTOList.Count > 0)
            {
                foreach (var item in kategoriDTOList)
                {
                    //cmb_Kategori.Items.Add(item.Adi);
                    cmb_Kategori.DisplayMember = "Adi";
                    cmb_Kategori.ValueMember = "Id";
                    cmb_Kategori.DataSource = kategoriDTOList;
                }
            }

            List<UreticiDTO> ureticiDTOList = urunDAL.TumUreticileriGetir();

            if (ureticiDTOList != null && ureticiDTOList.Count > 0)
            {
                foreach (var item in ureticiDTOList)
                {
                    //cmb_uretici.Items.Add(item.Adi);
                    cmb_uretici.DisplayMember = "Adi";
                    cmb_uretici.ValueMember = "Id";
                    cmb_uretici.DataSource = ureticiDTOList;
                }
            }

            txt_barkod.Text = currentBarkodDTO.Barkod.ToString();
            txt_urunadi.Text = currentBarkodDTO.UrunAdi;
            cmb_Kategori.SelectedValue = currentBarkodDTO.KategoriId;
            cmb_uretici.SelectedValue = currentBarkodDTO.UreticiId;

        }

        private void btn_gonder_Click(object sender, EventArgs e)
        {
            BarkodResultDTO currentBarkodDTO = new BarkodResultDTO();

            currentBarkodDTO.Barkod = new Guid(txt_barkod.Text);
            currentBarkodDTO.UrunAdi = txt_urunadi.Text;
            currentBarkodDTO.KategoriId = (int)cmb_Kategori.SelectedValue;
            currentBarkodDTO.UreticiId = (int)cmb_uretici.SelectedValue;

            bool isSucces = urunDAL.UrunGuncelle(urunId, currentBarkodDTO, currentKullaniciDTO);
            if (isSucces)
            {
                urunList = urunDAL.TumUrunleriListele("");

                UrunYonetimi urunYonetimi = new UrunYonetimi(urunList, currentKullaniciDTO);
                urunYonetimi.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Güncelleme işlemi başarısız.");
            }

        }

        private void btn_anasayfa_Click(object sender, EventArgs e)
        {
            DefaultForm defaultForm = new DefaultForm(currentKullaniciDTO);
            defaultForm.Show();
            this.Hide();
        }

        private void btn_kisi_Click(object sender, EventArgs e)
        {
            KullaniciForm kullaniciForm = new KullaniciForm( currentKullaniciDTO);
            kullaniciForm.Show();
            this.Hide();

        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
            this.Hide();

        }

        private void txt_barkod_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txt_urunicerik_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
