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
    public partial class UrunDetayForm : Form
    {
        BarkodResultDTO currentBarkodDTO;
        CurrentKullaniciDTO currentKullaniciDTO;
        KayitTarihDTO kayitTarihDTO;

        public UrunDetayForm(BarkodResultDTO _currentBarkodDTO)
        {
            InitializeComponent();
            this.currentBarkodDTO = _currentBarkodDTO;
        }

        private void UrunDetayForm_Load(object sender, EventArgs e)
        {
            txb_kategoriadi.Text = currentBarkodDTO.KategoriAdi;
            txb_urunadi.Text = currentBarkodDTO.UrunAdi;
            txb_riskSeviyesiadi.Text = currentBarkodDTO.RiskSeviyesi;
            txb_uretivi.Text = currentBarkodDTO.Uretici;
            if(currentBarkodDTO.IcerikList!=null && currentBarkodDTO.IcerikList.Count > 0)
            {
                foreach (var item in currentBarkodDTO.IcerikList)
                {
                    lstbx_urunicerikleri.Items.Add(item);
                }
            }
            else
                lstbx_urunicerikleri.Items.Add("Ürün içeriği yok.");



        }

        private void txb_urunadi_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstbx_urunicerikleri_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_anasayfa_Click(object sender, EventArgs e)
        {
            DefaultForm defaultForm = new DefaultForm(currentKullaniciDTO);
            defaultForm.Show();
            this.Hide();
        }

        private void btn_kisi_Click(object sender, EventArgs e)
        {
            KullaniciForm kullaniciForm = new KullaniciForm( currentKullaniciDTO);
            kullaniciForm.Show();
            this.Hide();
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
            this.Hide();
        }
    }
}
