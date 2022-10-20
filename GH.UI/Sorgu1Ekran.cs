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
    public partial class Sorgu1Ekran : Form
    {
        UrunDAL urunDAL = new UrunDAL();
        HangiUrunKacMaddeDTO hangiUrunKacMaddeDTO;
        CurrentKullaniciDTO currentKullaniciDTO;
        

        public Sorgu1Ekran(HangiUrunKacMaddeDTO _hangiUrunKacMaddeDTO)
        {
            InitializeComponent();
            this.hangiUrunKacMaddeDTO = _hangiUrunKacMaddeDTO;

        }

        private void Sorgu1Ekran_Load(object sender, EventArgs e)
        {
            List<HangiUrunKacMaddeDTO> list = urunDAL.UrunMaddeleriniGetir(hangiUrunKacMaddeDTO);
            dataGridView1.DataSource = list;
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
