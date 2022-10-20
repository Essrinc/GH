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
    public partial class Sorgu5EkranFavListe : Form
    {
        KullaniciDAL kullaniciDAL = new KullaniciDAL();
        CurrentKullaniciDTO currentKullaniciDTO;
        EthanolKacKisininFavıDTO ethanolKacKisininFavıDTO;
        public Sorgu5EkranFavListe(EthanolKacKisininFavıDTO _ethanolKacKisininFavıDTO)
        {
            InitializeComponent();
            this.ethanolKacKisininFavıDTO = _ethanolKacKisininFavıDTO;
        }

        private void btn_anasayfa_Click(object sender, EventArgs e)
        {
            DefaultForm defaultForm = new DefaultForm(currentKullaniciDTO);
            defaultForm.Show();
            this.Hide();
        }

        private void Sorgu5EkranFavListe_Load(object sender, EventArgs e)
        {
            List<EthanolKacKisininFavıDTO> ethanolKacKisininFavıDTOList = kullaniciDAL.EthanolKacKisininFavı(ethanolKacKisininFavıDTO);
            dataGridView1.DataSource = ethanolKacKisininFavıDTOList;

        }
    }
}
