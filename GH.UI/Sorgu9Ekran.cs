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
    public partial class Sorgu9Ekran : Form
    {
        UrunDAL urunDAL = new UrunDAL();
        IcerikDTO icerikDTO;
        CurrentKullaniciDTO currentKullaniciDTO;
        public Sorgu9Ekran(IcerikDTO _icerikDTO)
        {
            InitializeComponent();
            this.icerikDTO = _icerikDTO;
        }

        private void Sorgu9Ekran_Load(object sender, EventArgs e)
        {
            List<IcerikDTO> ıcerikDTOList = urunDAL.EnAlerjenUrunler(icerikDTO);
            dataGridView1.DataSource = ıcerikDTOList;
        }

        private void btn_anasayfa_Click(object sender, EventArgs e)
        {
            DefaultForm defaultForm = new DefaultForm(currentKullaniciDTO);
            defaultForm.Show();
            this.Hide();
        }
    }
}
