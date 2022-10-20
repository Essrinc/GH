using GH.Common;
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
    public partial class UrunYonetimi : Form
    {
        UrunDAL urunDAL = new UrunDAL();

        CurrentKullaniciDTO currentKullaniciDTO;

        List<UrunDTO> urunList;

        public UrunYonetimi(List<UrunDTO> _urunList, CurrentKullaniciDTO _currentKullaniciDTO)
        {
            InitializeComponent();
            this.urunList = _urunList;
            this.currentKullaniciDTO = _currentKullaniciDTO;
        }

        private void UrunYonetimi_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = urunList;
            if (currentKullaniciDTO.RolId == Enums.Rols.Admin)
            { 
                btn_edit.Visible = true;
                btn_sil.Visible = true;
            }
            else
            {
                btn_edit.Visible = false;
                btn_sil.Visible = false;
            }
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            UrunEkleForm urunEkleForm = new UrunEkleForm(urunList, currentKullaniciDTO);
            urunEkleForm.Show();
            this.Hide();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.dataGridView1.SelectedRows[0];
                int Id = Convert.ToInt32(row.Cells["Id"].Value.ToString());
                UrunGuncelleForm urunGuncelleForm = new UrunGuncelleForm(Id, currentKullaniciDTO);
                urunGuncelleForm.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Lütfen güncellemek istediğiniz ürünü seçiniz.");

        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.dataGridView1.SelectedRows[0];
                int Id = Convert.ToInt32(row.Cells["Id"].Value.ToString());

                bool isSuccess = urunDAL.UrunSil(Id, currentKullaniciDTO);

                if (isSuccess)
                {
                    urunList = urunDAL.TumUrunleriListele("");

                    UrunYonetimi urunYonetimi = new UrunYonetimi(urunList, currentKullaniciDTO);
                    urunYonetimi.Show();
                    this.Hide();
                }
            }
            else
                MessageBox.Show("Lütfen silmek istediğiniz ürünü seçiniz.");
        }

        private void btn_anasayfa_Click(object sender, EventArgs e)
        {
            DefaultForm defaultForm = new DefaultForm(currentKullaniciDTO);
            defaultForm.Show();
            this.Hide();
        }
    }
}
