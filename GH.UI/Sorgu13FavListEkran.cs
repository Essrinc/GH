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
    public partial class Sorgu13FavListEkran : Form
    {
        UrunDAL urunDAL = new UrunDAL();
        FavListeDTO favListeDTO;
        CurrentKullaniciDTO currentKullaniciDTO;
        public Sorgu13FavListEkran(FavListeDTO _favListeDTO)
        {
            InitializeComponent();
            this.favListeDTO = _favListeDTO;
        }

        private void Sorgu13FavListEkran_Load(object sender, EventArgs e)
        {
            List<FavListeDTO> favListeDTOList = urunDAL.BuAyFavlananUrunler(favListeDTO);
            dataGridView1.DataSource = favListeDTOList;
        }

        private void btn_anasayfa_Click(object sender, EventArgs e)
        {
            DefaultForm defaultForm = new DefaultForm(currentKullaniciDTO);
            defaultForm.Show();
            this.Hide();
        }
    }
}
