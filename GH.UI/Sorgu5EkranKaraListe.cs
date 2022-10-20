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
    public partial class Sorgu5EkranKaraListe : Form
    {
        KullaniciDAL kullaniciDAL = new KullaniciDAL();
        CurrentKullaniciDTO currentKullaniciDTO;
        EthanolKacKisininKaraListesindeDTO ethanolKacKisininKaraListesindeDTO;
        public Sorgu5EkranKaraListe(EthanolKacKisininKaraListesindeDTO _ethanolKacKisininKaraListesindeDTO)
        {
            InitializeComponent();
            this.ethanolKacKisininKaraListesindeDTO = _ethanolKacKisininKaraListesindeDTO;
        }

        private void Sorgu5EkranKaraListe_Load(object sender, EventArgs e)
        {
            List < EthanolKacKisininKaraListesindeDTO > ethanolKacKisininKaraListesindeDTOList = kullaniciDAL.EthanolKacKisininKaraListesinde(ethanolKacKisininKaraListesindeDTO);
            dataGridView1.DataSource = ethanolKacKisininKaraListesindeDTOList;
        }

        private void btn_anasayfa_Click(object sender, EventArgs e)
        {
            DefaultForm defaultForm = new DefaultForm(currentKullaniciDTO);
            defaultForm.Show();
            this.Hide();
        }
    }
}
