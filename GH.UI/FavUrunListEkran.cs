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
    public partial class FavUrunListEkran : Form
    {
        KullaniciDAL KullaniciDAL = new KullaniciDAL();

        CurrentKullaniciDTO currentKullaniciDTO;

        int favoriListeID;

        public FavUrunListEkran(CurrentKullaniciDTO _currentKullaniciDTO)
        {
            InitializeComponent();
            this.currentKullaniciDTO = _currentKullaniciDTO;
        }

        private void FavUrunListEkran_Load(object sender, EventArgs e)
        {
            List<FavoriListeDTO> favoriListeDTOList = KullaniciDAL.TumFavoriListeleriGetir(currentKullaniciDTO);

            if (favoriListeDTOList != null && favoriListeDTOList.Count > 0)
            {
                comboBox1.DisplayMember = "Adi";
                comboBox1.ValueMember = "FavoriListeID";
                comboBox1.DataSource = favoriListeDTOList;
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FavoriListeDTO favoriListeDTO = new FavoriListeDTO();
                favoriListeID = Convert.ToInt32(comboBox1.SelectedValue);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBox1.Text) && comboBox1.SelectedIndex != -1)
                //liste dolu mu boş mu kontrolu yapınca çalışmadı. haklı. liste geldi ama sen seçtin mi diye bak. ya da sen yapamadın sor bunu.
            {
                FavoriListenizdekiUrunler favoriListenizdekiUrunler = new FavoriListenizdekiUrunler(favoriListeID, currentKullaniciDTO);
                favoriListenizdekiUrunler.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Lütfen liste seçiniz!");
            }            
        }

        private void btn_anasayfa_Click(object sender, EventArgs e)
        {
            DefaultForm defaultForm = new DefaultForm(currentKullaniciDTO);
            defaultForm.Show();
            this.Hide();
        }
    }
}
