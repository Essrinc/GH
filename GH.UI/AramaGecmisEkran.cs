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
    public partial class AramaGecmisEkran : Form
    {
        KullaniciDAL kullaniciDAL = new KullaniciDAL();
        CurrentKullaniciDTO currentKullaniciDTO;
        int Id;

        public AramaGecmisEkran(CurrentKullaniciDTO _currentKullaniciDTO)
        {
            InitializeComponent();
            this.currentKullaniciDTO = _currentKullaniciDTO;
        }

        private void lbl_urun_Click(object sender, EventArgs e)
        {

        }

        private void btn_karaliste_Click(object sender, EventArgs e)
        {
            karaliste karaListe = new karaliste(currentKullaniciDTO);
            karaListe.Show();
            this.Hide();
        }

        private void btn_favlis_Click(object sender, EventArgs e)
        {
            FavUrunListEkran favUrunListEkrani = new FavUrunListEkran(currentKullaniciDTO);
            favUrunListEkrani.Show();
            this.Hide();
        }

        private void AramaGecmisEkran_Load(object sender, EventArgs e)
        {
            List<UrunDTO> urunDTOList = kullaniciDAL.AramaGecmisiListele(currentKullaniciDTO);

            if (urunDTOList.Count > 0)
                dataGridView1.DataSource = urunDTOList;

        }

        private void btn_aramasil_Click(object sender, EventArgs e)
        {
            bool isSuccess = kullaniciDAL.AramaGecmisiTmizle(currentKullaniciDTO);
            if (isSuccess)
                MessageBox.Show("arama geçmişiniz temizlendi!");
            else
            {
                MessageBox.Show("Beklenmeyen bir hata oluştu, daha sonra tekrar deneyin.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
