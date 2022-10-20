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
    public partial class Sorgu10Ekran : Form
    {
        KullaniciDAL kullaniciDAL = new KullaniciDAL();
        UrunDAL urunDAL = new UrunDAL();
        EnRiskliUrunTutanKullaniciDTO enRiskliUrunTutanKullaniciDTO;
        CurrentKullaniciDTO currentKullaniciDTO;
            public Sorgu10Ekran(EnRiskliUrunTutanKullaniciDTO _enRiskliUrunTutanKullaniciDTO)
        {
            InitializeComponent();
            this.enRiskliUrunTutanKullaniciDTO = _enRiskliUrunTutanKullaniciDTO;
        }

        private void Sorgu10Ekran_Load(object sender, EventArgs e)
        {
            List<EnRiskliUrunTutanKullaniciDTO> enRiskliUrunTutanKullaniciDTOList = urunDAL.EnfazlaRiskliUrunTutanKullanicilar();
            dataGridView1.DataSource = enRiskliUrunTutanKullaniciDTOList;
        }

        private void btn_anasayfa_Click(object sender, EventArgs e)
        {
            DefaultForm defaultForm = new DefaultForm(currentKullaniciDTO);
            defaultForm.Show();
            this.Hide();
        }
    }
}
