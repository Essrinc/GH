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
    public partial class FavoriListenizdekiUrunler : Form
    {
        UrunDAL urunDAL = new UrunDAL();
        CurrentKullaniciDTO currentKullaniciDTO;
        int favoriListeID;
        public FavoriListenizdekiUrunler(int _favoriListeID, CurrentKullaniciDTO _currentKullaniciDTO)
        {
            InitializeComponent();
            this.favoriListeID = _favoriListeID;
            this.currentKullaniciDTO = _currentKullaniciDTO;
        }

        private void FavoriListenizdekiUrunler_Load(object sender, EventArgs e)
        {
            List<UrunDTO> urunList = urunDAL.FavoriListemdekiUrunler(favoriListeID, currentKullaniciDTO);
            dataGridView1.DataSource = urunList; //Ürün list
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
