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
    public partial class Sorgu11Ekran : Form
    {
        KullaniciDAL kullaniciDAL = new KullaniciDAL();
        KullaniciMailDTO kullaniciMailDTO;
        CurrentKullaniciDTO currentKullaniciDTO;
        public Sorgu11Ekran(KullaniciMailDTO _kullaniciMailDTO)
        {
            InitializeComponent();
            this.kullaniciMailDTO = _kullaniciMailDTO;
        }

        private void Sorgu11Ekran_Load(object sender, EventArgs e)
        {
            List<KullaniciMailDTO> kullaniciMailDTOList = kullaniciDAL.EnUrunluKullanicilar(kullaniciMailDTO);
            dataGridView1.DataSource = kullaniciMailDTOList;
        }

        private void btn_anasayfa_Click(object sender, EventArgs e)
        {
            DefaultForm defaultForm = new DefaultForm(currentKullaniciDTO);
            defaultForm.Show();
            this.Hide();
        }
    }
}
