using GH.Core.Entities;
using GH.Core.Interfaces;
using GH.DTOs;
using GH.DTOs.RaporDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GH.DAL.Interfaces
{
    public interface IKullaniciDAL
    {
        bool KullaniciVarMi(string KullaniciAdi, string Sifre);

        CurrentKullaniciDTO Login(string KullaniciAdi, string Sifre);

        bool Kayit(string KullaniciAdi, string Sifre, string Email);
        bool AramaKaydet(int id, CurrentKullaniciDTO currentKullaniciDTO);

        List<UrunDTO> AramaGecmisiListele(CurrentKullaniciDTO currentKullaniciDTO);

        bool AramaGecmisiTmizle(CurrentKullaniciDTO currentKullaniciDTO);
        List<UrunDTO> KaraListeListele(CurrentKullaniciDTO currentKullaniciDTO);
        List<FavoriListeDTO> TumFavoriListeleriGetir(CurrentKullaniciDTO currentKullaniciDTO);
        List<KullaniciRolDTO> KullaniciRolDagilimiGetir(KullaniciRolDTO kullaniciRolDTO);
        //List<IcerikDTO> EnfazlaRiskliUrunTutanKullanicilar(IcerikDTO icerikDTO);
        List<KullaniciMailDTO> EnUrunluKullanicilar(KullaniciMailDTO kullaniciMailDTO);
        List<KayitTarihDTO> KayitTarihi(CurrentKullaniciDTO currentKullaniciDTO);
        List<KullaniciUrunSayiDTO> KacUrunumVarFavListe(KullaniciUrunSayiDTO kullaniciUrunSayiDTO);
        List<KullaniciUrunSayiDTO> KacUrunumVarKaraListe(KullaniciUrunSayiDTO kullaniciUrunSayiDTO);
        List<EthanolKacKisininFavıDTO> EthanolKacKisininFavı(EthanolKacKisininFavıDTO ethanolKacKisininFavıDTO);
        List<EthanolKacKisininKaraListesindeDTO> EthanolKacKisininKaraListesinde(EthanolKacKisininKaraListesindeDTO ethanolKacKisininKaraListesindeDTO);
        bool KullaniciGuncelle(CurrentKullaniciDTO currentKullaniciDTO);
    }
}
