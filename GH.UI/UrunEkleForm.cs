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
    public partial class UrunEkleForm : Form
    {
        UrunDAL urunDAL = new UrunDAL();

        CurrentKullaniciDTO currentKullaniciDTO;

        List<UrunDTO> urunList;
        KayitTarihDTO kayitTarihDTO;



        public UrunEkleForm(List<UrunDTO> _urunList, CurrentKullaniciDTO _currentKullaniciDTO)
        {
            InitializeComponent();
            currentKullaniciDTO = _currentKullaniciDTO;
            urunList = _urunList;
        }

        private void UrunEkleForm_Load(object sender, EventArgs e)
        {
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

        }

        private void btn_gonder_Click(object sender, EventArgs e)
        {
            UrunDTO urunDTO = new UrunDTO();
            urunDTO.Barkod = txt_barkod.Text;
            urunDTO.UreticiID = Convert.ToInt32(cmb_uretici.SelectedValue);
            urunDTO.Adi = txt_urunadi.Text;
            urunDTO.KategoriID = Convert.ToInt32(cmb_Kategori.SelectedValue);
            urunDTO.Icerik = txt_urunicerik.Text;

            UrunEkleValidator urunEkleValidator = new UrunEkleValidator(urunDTO);

            if (urunEkleValidator.IsValid) //ilk elemanı seçince id 0 geliyor. validasyonda <0 yaptım. => combobox
            {
                bool isSuccess = urunDAL.Kayit(urunDTO);

                if (isSuccess)
                {
                    urunList = urunDAL.TumUrunleriListele("");

                    UrunYonetimi urunYonetimi = new UrunYonetimi(urunList, currentKullaniciDTO);
                    urunYonetimi.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show(urunEkleValidator.ValidationMessages.FirstOrDefault());
            }

        }

        private void cmb_uretici_SelectedIndexChanged(object sender, EventArgs e)
        {

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
    }
}
