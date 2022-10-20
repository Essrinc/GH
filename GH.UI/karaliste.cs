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
    public partial class karaliste : Form
    {
        KullaniciDAL kullaniciDAL = new KullaniciDAL();
        CurrentKullaniciDTO currentKullaniciDTO;
        public karaliste(CurrentKullaniciDTO _currentKullaniciDTO)
        {
            InitializeComponent();
            this.currentKullaniciDTO = _currentKullaniciDTO;
        }

        private void karaliste_Load(object sender, EventArgs e)
        {
            List<UrunDTO> urunDTOList = kullaniciDAL.KaraListeListele(currentKullaniciDTO);
            if (urunDTOList.Count > 0)
                dataGridView1.DataSource = urunDTOList;
        }

        private void btn_anasayfa_Click(object sender, EventArgs e)
        {
            DefaultForm defaultForm = new DefaultForm(currentKullaniciDTO);
            defaultForm.Show();
            this.Hide();
        }
    }
}
