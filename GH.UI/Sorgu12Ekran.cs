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
    public partial class Sorgu12Ekran : Form
    {
        UrunDAL urunDAL = new UrunDAL();
        EnMaddeliUrunlerDTO enMaddeliUrunlerDTO;
        CurrentKullaniciDTO currentKullaniciDTO;
        public Sorgu12Ekran(EnMaddeliUrunlerDTO _enMaddeliUrunlerDTO)
        {
            InitializeComponent();
            this.enMaddeliUrunlerDTO = _enMaddeliUrunlerDTO;
        }

        private void Sorgu12Ekran_Load(object sender, EventArgs e)
        {
            List<EnMaddeliUrunlerDTO> enMaddeliUrunlerDTOList = urunDAL.EnMaddeliUrunler(enMaddeliUrunlerDTO);
            dataGridView1.DataSource = enMaddeliUrunlerDTOList;
        }

        private void btn_anasayfa_Click(object sender, EventArgs e)
        {
            DefaultForm defaultForm = new DefaultForm(currentKullaniciDTO);
            defaultForm.Show();
            this.Hide();
        }
    }
}
