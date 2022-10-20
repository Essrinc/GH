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
    public partial class AramaSonucUrun : Form
    {
        UrunDAL urunDAL = new UrunDAL();

        List<UrunDTO> urunList;
        CurrentKullaniciDTO currentKullaniciDTO;
        KullaniciDAL kullaniciDAL = new KullaniciDAL();

        public AramaSonucUrun(List<UrunDTO> _urunList, CurrentKullaniciDTO _currentKullaniciDTO)
        {
            InitializeComponent();
            this.urunList = _urunList;
            this.currentKullaniciDTO = _currentKullaniciDTO;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AramaSonucUrun_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = urunList;
        }

        private void btn_urunegit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.dataGridView1.SelectedRows[0];
                int Id = Convert.ToInt32(row.Cells["Id"].Value.ToString());


                bool isSuccess = kullaniciDAL.AramaKaydet(Id,currentKullaniciDTO);

                BarkodResultDTO currentBarkodDTO = urunDAL.UrunArama(Id);

                if (currentBarkodDTO != null)
                {
                    UrunDetayForm urunDetayForm = new UrunDetayForm(currentBarkodDTO);
                    urunDetayForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("ürün bulunamadı.");
                }
            }
            else
                MessageBox.Show("Lütfen ürün seçiniz.");
        }

        private void btn_anasayfa_Click(object sender, EventArgs e)
        {
            DefaultForm defaultForm = new DefaultForm(currentKullaniciDTO);
            defaultForm.Show();
            this.Hide();
        }
    }
}
