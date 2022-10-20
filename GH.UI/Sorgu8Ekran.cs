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
    public partial class Sorgu8Ekran : Form
    {
        UrunDAL urunDAL = new UrunDAL();
        CurrentKullaniciDTO currentKullaniciDTO;
        FavUrunSayiDTO favUrunSayiDTO;
        public Sorgu8Ekran(FavUrunSayiDTO _favUrunSayiDTO)
        {
            InitializeComponent();
            this.favUrunSayiDTO = _favUrunSayiDTO;
        }

        private void btn_anasayfa_Click(object sender, EventArgs e)
        {
            DefaultForm defaultForm = new DefaultForm(currentKullaniciDTO);
            defaultForm.Show();
            this.Hide();
        }

        private void Sorgu8Ekran_Load(object sender, EventArgs e)
        {
            List<FavUrunSayiDTO> FavUrunSayiDTOList = urunDAL.FavoriUrunSayisiTop3(favUrunSayiDTO);
            dataGridView1.DataSource = FavUrunSayiDTOList;
        }
    }
}
