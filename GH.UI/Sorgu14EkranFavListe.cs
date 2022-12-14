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
    public partial class Sorgu14EkranFavListe : Form
    {
        KullaniciDAL kullaniciDAL = new KullaniciDAL();
        CurrentKullaniciDTO currentKullaniciDTO;
        KullaniciUrunSayiDTO kullaniciUrunSayiDTO;
        public Sorgu14EkranFavListe(KullaniciUrunSayiDTO _kullaniciUrunSayiDTO)
        {
            InitializeComponent();
            this.kullaniciUrunSayiDTO = _kullaniciUrunSayiDTO;
        }

        private void btn_anasayfa_Click(object sender, EventArgs e)
        {
            DefaultForm defaultForm = new DefaultForm(currentKullaniciDTO);
            defaultForm.Show();
            this.Hide();
        }

        private void Sorgu14Ekran_Load(object sender, EventArgs e)
        {
            List<KullaniciUrunSayiDTO> kullaniciUrunSayiDTOList = kullaniciDAL.KacUrunumVarFavListe(kullaniciUrunSayiDTO);
            dataGridView1.DataSource = kullaniciUrunSayiDTOList;
        }
    }
}
