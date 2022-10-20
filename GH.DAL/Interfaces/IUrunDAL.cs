using GH.DTOs;
using GH.DTOs.RaporDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GH.DAL.Interfaces
{
    public interface IUrunDAL
    {
        List<UrunDTO> TumUrunleriListele(string text);
        BarkodResultDTO UrunArama(int Id);
        List<KategoriDTO> TumKategorileriGetir();
        List<UreticiDTO> TumUreticileriGetir();
        List<UrunDTO> FavoriListemdekiUrunler(int favoriListeID, CurrentKullaniciDTO currentKullaniciDTO);
        bool UrunSil(int Id, CurrentKullaniciDTO currentKullaniciDTO);
        bool UrunGuncelle(int Id, BarkodResultDTO currentBarkodDTO, CurrentKullaniciDTO currentKullaniciDTO);
        List<HangiUrunKacMaddeDTO> UrunMaddeleriniGetir(HangiUrunKacMaddeDTO hangiUrunKacMaddeDTO);
        List<UrunMaddeDTO> EthanolIcerenUrunler(UrunMaddeDTO urunMaddeDTO);
        List<IcerikDTO> EnRiskliUrunler(IcerikDTO icerikDTO);
        List<IcerikDTO> EnAlerjenUrunler(IcerikDTO icerikDTO);
        List<EnMaddeliUrunlerDTO> EnMaddeliUrunler(EnMaddeliUrunlerDTO enMaddeliUrunlerDTO);
        List<FavListeDTO> BuAyFavlananUrunler(FavListeDTO favListeDTO);
        List<KaraListeDTO> BuAyKaraListeyeAlinanUrunler(KaraListeDTO karaListeDTO);
        List<KullaniciUrunDTO> KacUrunumVar(CurrentKullaniciDTO currentKullaniciDTO);

    }
}
