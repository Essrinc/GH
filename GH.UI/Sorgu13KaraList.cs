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
    public partial class Sorgu13KaraList : Form
    {
        UrunDAL urunDAL = new UrunDAL();
        KaraListeDTO karaListeDTO;
        CurrentKullaniciDTO currentKullaniciDTO;
        public Sorgu13KaraList(KaraListeDTO _karaListeDTO)
        {
            InitializeComponent();
            this.karaListeDTO = _karaListeDTO;
        }

        private void Sorgu13KaraList_Load(object sender, EventArgs e)
        {
            List<KaraListeDTO> karaListeDTOList = urunDAL.BuAyKaraListeyeAlinanUrunler(karaListeDTO);
            dataGridView1.DataSource = karaListeDTOList;
        }

        private void btn_anasayfa_Click(object sender, EventArgs e)
        {
            DefaultForm defaultForm = new DefaultForm(currentKullaniciDTO);
            defaultForm.Show();
            this.Hide();
        }
    }
    
}
