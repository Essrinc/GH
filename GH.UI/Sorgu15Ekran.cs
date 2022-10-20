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
    public partial class Sorgu15Ekran : Form
    {
        KullaniciDAL kullaniciDAL = new KullaniciDAL();
        KullaniciRolDTO kullaniciRolDTO;
        CurrentKullaniciDTO currentKullaniciDTO;
        public Sorgu15Ekran(KullaniciRolDTO _kullaniciRolDTO)
        {
            InitializeComponent();
            this.kullaniciRolDTO = _kullaniciRolDTO;
        }

        private void Sorgu15Ekran_Load(object sender, EventArgs e)
        {

            List<KullaniciRolDTO> kullaniciRolDTOList = kullaniciDAL.KullaniciRolDagilimiGetir(kullaniciRolDTO);
            dataGridView1.DataSource = kullaniciRolDTOList;
        }

        private void btn_anasayfa_Click(object sender, EventArgs e)
        {
            DefaultForm defaultForm = new DefaultForm(currentKullaniciDTO);
            defaultForm.Show();
            this.Hide();
        }
    }
}
