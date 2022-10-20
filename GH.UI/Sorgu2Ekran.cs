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
    public partial class Sorgu2Ekran : Form
    {
        UrunDAL urunDAL = new UrunDAL();
        UrunMaddeDTO urunMaddeDTO;
        CurrentKullaniciDTO currentKullaniciDTO;
        public Sorgu2Ekran(UrunMaddeDTO _urunMaddeDTO)
        {
            InitializeComponent();
            this.urunMaddeDTO = _urunMaddeDTO;

        }

        private void Sorgu2Ekran_Load(object sender, EventArgs e)
        {
            List<UrunMaddeDTO> urunMaddeDTOList = urunDAL.EthanolIcerenUrunler(urunMaddeDTO);
            dataGridView1.DataSource = urunMaddeDTOList;
        }

        private void btn_anasayfa_Click(object sender, EventArgs e)
        {
            DefaultForm defaultForm = new DefaultForm(currentKullaniciDTO);
            defaultForm.Show();
            this.Hide();
        }
    }
}
