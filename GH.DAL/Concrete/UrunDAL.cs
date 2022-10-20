using GH.Core.Entities;
using GH.Core.Repo;
using GH.DAL.Interfaces;
using GH.DTOs;
using GH.DTOs.RaporDTOs;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GH.DAL.Concrete
{
    public class UrunDAL : EFRepoBase<MyDbContext, Urun>, IUrunDAL
    {
        public List<UrunDTO> TumUrunleriListele(string text)
        {
            List<UrunDTO> urunDTOList = null;

            using (MyDbContext db = new MyDbContext())
            {
                urunDTOList = (from u in db.Uruns
                               where u.isActive == true && u.Adi.Contains(text)
                               select new UrunDTO
                               {
                                   Id = u.UrunID,
                                   Adi = u.Adi
                               }).ToList();
            }
            return urunDTOList;
        }

        public BarkodResultDTO UrunArama(int Id)
        {
            List<string> icerikList = new List<string>();
            List<BarkodResultDTO> currentBarkodDTOList = null;
            string riskSeviyesi = "Temiz";
            int riskSeviyesiId = 1;
            using (MyDbContext db = new MyDbContext())
            {
                currentBarkodDTOList = (from u in db.Uruns
                                        join kat in db.Kategoris on u.KategoriID equals kat.KategoriID
                                        join ui in db.UrunIceriks on u.UrunID equals ui.UrunID
                                        join I in db.Iceriks on ui.IcerikID equals I.IcerikID
                                        join risk in db.RiskSeviyes on I.RiskSeviyeID equals risk.RiskSeviyeID
                                        join ut in db.Ureticis on u.UreticiID equals ut.UreticiID
                                        where u.UrunID == Id && u.isActive == true
                                        select new BarkodResultDTO
                                        {
                                            Barkod = u.Barkod,
                                            UrunAdi = u.Adi,
                                            KategoriAdi = kat.Adi,
                                            KategoriId = kat.KategoriID,
                                            RiskSeviyesi = risk.Adi,
                                            RiskSeviyesiId = risk.RiskSeviyeID,
                                            Uretici = ut.Adi,
                                            UreticiId = ut.UreticiID,
                                            Icerik = I.Adi
                                        }).ToList();
            }
            foreach (var item in currentBarkodDTOList)
            {
                if (item.RiskSeviyesiId > riskSeviyesiId)
                {
                    riskSeviyesiId = item.RiskSeviyesiId;
                    riskSeviyesi = item.RiskSeviyesi;
                }
                icerikList.Add(item.Icerik);
            }

            BarkodResultDTO currentBarkodDTO = new BarkodResultDTO();
            //currentBarkodDTO.IcerikList = new List<string>();
            currentBarkodDTO = currentBarkodDTOList.FirstOrDefault();
            currentBarkodDTO.IcerikList = icerikList;
            currentBarkodDTO.RiskSeviyesiId = riskSeviyesiId;
            currentBarkodDTO.RiskSeviyesi = riskSeviyesi;

            return currentBarkodDTO;
        }

        public List<KategoriDTO> TumKategorileriGetir()
        {
            List<KategoriDTO> KategoriDTOList = null;

            using (MyDbContext db = new MyDbContext())
            {
                KategoriDTOList = (from kat in db.Kategoris
                                   where kat.isActive == true
                                   select new KategoriDTO
                                   {
                                       Id = kat.KategoriID,
                                       Adi = kat.Adi
                                   }).ToList();
            }
            return KategoriDTOList;
        }

        public List<UreticiDTO> TumUreticileriGetir()
        {
            List<UreticiDTO> UreticiDTOList = null;

            using (MyDbContext db = new MyDbContext())
            {
                UreticiDTOList = (from urt in db.Ureticis
                                  where urt.isActive == true
                                  select new UreticiDTO
                                  {
                                      Id = urt.UreticiID,
                                      Adi = urt.Adi
                                  }).ToList();
            }
            return UreticiDTOList;
        }

        public bool Kayit(UrunDTO urunDTO)
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    Urun u = new Urun();
                    u.Adi = urunDTO.Adi;
                    u.Barkod = new Guid(urunDTO.Barkod);
                    u.KategoriID = urunDTO.KategoriID;
                    u.UreticiID = urunDTO.UreticiID;
                    u.Icerik = null;
                    u.isActive = true;
                    u.CreatedDate = DateTime.Now;
                    u.ModifiedDate = DateTime.Now;
                    u.CreatedBy = 1;
                    u.ModifiedBy = 1;

                    db.Uruns.Add(u);
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {

            }
            return false;
        }

        public List<UrunDTO> FavoriListemdekiUrunler(int favoriListeID, CurrentKullaniciDTO currentKullaniciDTO)
        {
            List<string> favoriUrunList = new List<string>();
            List<UrunDTO> favoriListeninUrunleri = null;

            using (MyDbContext db = new MyDbContext())
            {
                favoriListeninUrunleri = (from kfl in db.KullaniciFavoriListes
                                          join kufl in db.KullaniciUrunFavoriListes on kfl.FavoriListeID equals kufl.FavoriListeID
                                          join u in db.Uruns on kufl.UrunID equals u.UrunID
                                          where kfl.CreatedBy == currentKullaniciDTO.Id && kfl.isActive == true && kfl.FavoriListeID == favoriListeID
                                          select new UrunDTO
                                          {
                                              Id = u.UrunID,
                                              Adi = u.Adi
                                          }).ToList();
            }

            return favoriListeninUrunleri;
        }
        public List<KullaniciUrunDTO> KacUrunumVar(CurrentKullaniciDTO currentKullaniciDTO)
        {
            List<KullaniciUrunDTO> kullaniciUrunDTOList = null;

            using (MyDbContext db = new MyDbContext())
            {
                kullaniciUrunDTOList = (from u in db.Uruns
                                        join k in db.Kullanicis on u.CreatedBy equals  k.KullaniciID 
                                        //where k.KullaniciID == currentKullaniciDTO.Id && k.isActive == true
                                        group k.KullaniciAdi by u.CreatedBy into grp
                                        select new KullaniciUrunDTO()
                                        {
                                         KullaniciAdi = grp.Select(x => x).FirstOrDefault(),
                                         UrunSayisi = grp.Count()
                                        }).ToList();
            }

            return kullaniciUrunDTOList;
        }
        public bool UrunSil(int Id, CurrentKullaniciDTO currentKullaniciDTO)
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    List<Urun> Results = db.Uruns.ToList();
                    foreach (var item in Results)
                    {
                        if (item.UrunID == Id && item.isActive)
                        {
                            item.isActive = false;
                            item.ModifiedBy = currentKullaniciDTO.Id;
                            db.Entry(item).State = EntityState.Modified;
                            db.SaveChanges();
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {

            }
            return false;
        }

        public bool UrunGuncelle(int Id, BarkodResultDTO currentBarkodDTO, CurrentKullaniciDTO currentKullaniciDTO)
        {
            bool dbdeVarMi = false;
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    List<Urun> Results = db.Uruns.ToList();
                    foreach (var item in Results)
                    {
                        if (item.UrunID == Id && item.isActive)
                        {
                            item.Barkod = currentBarkodDTO.Barkod;
                            item.Adi = currentBarkodDTO.UrunAdi;
                            item.KategoriID = currentBarkodDTO.KategoriId;
                            item.UreticiID = currentBarkodDTO.UreticiId;
                            item.ModifiedBy = currentKullaniciDTO.Id;
                            db.Entry(item).State = EntityState.Modified;
                            db.SaveChanges();
                            dbdeVarMi = true;
                        }
                    }
                }
                if (dbdeVarMi)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {

            }
            return false;

        }

        public List<HangiUrunKacMaddeDTO> UrunMaddeleriniGetir(HangiUrunKacMaddeDTO hangiUrunKacMaddeDTO)
        {
            List<HangiUrunKacMaddeDTO> list = null;

            using (MyDbContext db = new MyDbContext())
            {
                list = (from u in db.Uruns
                                    join ui in db.UrunIceriks on u.UrunID equals ui.UrunID
                                    group new {u.Adi, ui} by u.UrunID into grp
                                    //join i in db.Iceriks on ui.IcerikID equals i.IcerikID
                                    select new HangiUrunKacMaddeDTO()
                                    {
                                        UrunAdi = grp.Select(x => x.Adi).FirstOrDefault(),
                                        IcerikAdet = grp.Count()

                                    }).ToList();
            }
            return list;
        }

        public List<UrunMaddeDTO> EthanolIcerenUrunler(UrunMaddeDTO urunMaddeDTO)
        {
            List<UrunMaddeDTO> UrunMaddeDTOList = null;

            using (MyDbContext db = new MyDbContext())
            {
                UrunMaddeDTOList = (from u in db.Uruns
                                    join ui in db.UrunIceriks on u.UrunID equals ui.UrunID
                                    join i in db.Iceriks on ui.IcerikID equals i.IcerikID
                                    where i.Adi.Contains("Ethanol") && u.isActive == true
                                    select new UrunMaddeDTO
                                    {
                                        UrunID = u.UrunID,
                                        UrunAdi = u.Adi,
                                        IcerikID = i.IcerikID,
                                        Adi = i.Adi
                                    }).ToList();
            }
            return UrunMaddeDTOList;
        }

        public List<IcerikDTO> EnRiskliUrunler(IcerikDTO icerikDTO)
        {
            List<IcerikDTO> IcerikDTOList = null;

            using (MyDbContext db = new MyDbContext())
            {
                IcerikDTOList = (from u in db.Uruns
                                 join ui in db.UrunIceriks on u.UrunID equals ui.UrunID
                                 join i in db.Iceriks on ui.IcerikID equals i.IcerikID
                                 join r in db.RiskSeviyes on i.RiskSeviyeID equals r.RiskSeviyeID
                                 where r.RiskSeviyeID == 4 && i.isActive == true
                                 select new IcerikDTO
                                 {
                                     UrunID = u.UrunID,
                                     UrunAdi = u.Adi,
                                     IcerikID = i.IcerikID,
                                     Adi = i.Adi,
                                     RiskSeviyeID = r.RiskSeviyeID,
                                     RiskAdi = r.Adi


                                 }).ToList();
            }
            return IcerikDTOList;
        }

        public List<IcerikDTO> EnAlerjenUrunler(IcerikDTO icerikDTO)
        {
            List<IcerikDTO> IcerikDTOList = null;

            using (MyDbContext db = new MyDbContext())
            {
                IcerikDTOList = (from u in db.Uruns
                                 join ui in db.UrunIceriks on u.UrunID equals ui.UrunID
                                 join i in db.Iceriks on ui.IcerikID equals i.IcerikID
                                 join r in db.RiskSeviyes on i.RiskSeviyeID equals r.RiskSeviyeID
                                 where r.RiskSeviyeID == 4 && i.isActive == true
                                 select new IcerikDTO
                                 {
                                     UrunID = u.UrunID,
                                     UrunAdi = u.Adi,
                                     IcerikID = i.IcerikID,
                                     Adi = i.Adi,
                                     RiskSeviyeID = r.RiskSeviyeID,
                                     RiskAdi = r.Adi


                                 }).ToList();
            }
            return IcerikDTOList;
        }
        public List<EnMaddeliUrunlerDTO> EnMaddeliUrunler(EnMaddeliUrunlerDTO enMaddeliUrunlerDTO)
        {
            List<EnMaddeliUrunlerDTO> EnMaddeliUrunlerDTOList;
            using (MyDbContext db = new MyDbContext())
            {
                EnMaddeliUrunlerDTOList = (from u in db.Uruns
                                    join ui in db.UrunIceriks on u.UrunID equals ui.UrunID
                                    join i in db.Iceriks on ui.IcerikID equals i.IcerikID
                                    group u.Adi by u.UrunID into grp
                                    select new EnMaddeliUrunlerDTO
                                    {
                                        UrunAdi = grp.Select(x => x).FirstOrDefault(),
                                         IcerikSayi = grp.Count()

                                    }).Take(10).ToList();
            }
            return EnMaddeliUrunlerDTOList;
        }

        public List<FavListeDTO> BuAyFavlananUrunler(FavListeDTO favListeDTO)
        {
            List<FavListeDTO> favListeDTOList;
            using (MyDbContext db = new MyDbContext())
            {
                favListeDTOList = (from u in db.Uruns
                                 join kufl in db.KullaniciUrunFavoriListes on u.UrunID equals kufl.UrunID
                                 where u.isActive == true 
                                 select new FavListeDTO
                                 {
                                     UrunAdi = u.Adi,
                                     CreatedDate = u.CreatedDate

                                 }).ToList();
            }
            return favListeDTOList;
        }

        public List<KaraListeDTO> BuAyKaraListeyeAlinanUrunler(KaraListeDTO karaListeDTO)
        {
            List<KaraListeDTO> karaListeDTOList;
            using (MyDbContext db = new MyDbContext())
            {
                karaListeDTOList = (from kuikl in db.KullaniciUrunIcerikKaraListes
                                    join i in db.Iceriks on kuikl.IcerikID equals i.IcerikID
                                    join ui in db.UrunIceriks on i.IcerikID equals ui.IcerikID
                                    join u in db.Uruns on ui.UrunID equals u.UrunID
                                    where u.isActive == true
                                    select new KaraListeDTO
                                    {
                                        UrunAdi = u.Adi,
                                        CreatedDate = u.CreatedDate

                                    }).ToList();
            }
            return karaListeDTOList;
        }

        public List<EnRiskliUrunTutanKullaniciDTO> EnfazlaRiskliUrunTutanKullanicilar()
        {
            List<EnRiskliUrunTutanKullaniciDTO> kullaniciRiskliUrunDTOs = null;
            using (MyDbContext db = new MyDbContext())
            {
                kullaniciRiskliUrunDTOs = (from u in db.Uruns
                                           join k in db.Kullanicis on u.CreatedBy equals k.KullaniciID
                                           join ui in db.UrunIceriks on u.UrunID equals ui.UrunID
                                           join i in db.Iceriks on ui.IcerikID equals i.IcerikID
                                           where i.RiskSeviyeID == (int)Common.Enums.RiskSeviye.Riskli
                                           group new { k.KullaniciAdi, u.UrunID } by k.KullaniciID into grp
                                           orderby grp.Count() descending
                                           select new EnRiskliUrunTutanKullaniciDTO
                                           {
                                               KullaniciAdi = grp.Select(x => x.KullaniciAdi).FirstOrDefault(),
                                               RiskliUrunSayisi = grp.Distinct().Count()
                                           }).Take(3).ToList();
            }
            return kullaniciRiskliUrunDTOs;
        }

        public List<FavUrunSayiDTO> FavoriUrunSayisi(FavUrunSayiDTO favUrunSayiDTO)
        {
            List<FavUrunSayiDTO> FavUrunSayiDTOList = null;
            using (MyDbContext db = new MyDbContext())
            {
                FavUrunSayiDTOList = (from u in db.Uruns
                                     join kufl in db.KullaniciUrunFavoriListes on u.UrunID equals kufl.UrunID
                                     group u.Adi by u.UrunID into grp
                                     orderby grp.Count() descending
                                     select new FavUrunSayiDTO()
                                     {
                                         UrunAdi = grp.Select(x => x).FirstOrDefault(),
                                         FavoriSayisi = grp.Count()
                                     }).ToList();
            }
            return FavUrunSayiDTOList;
        }

        public List<FavUrunSayiDTO> FavoriUrunSayisiTop3(FavUrunSayiDTO favUrunSayiDTO)
        {
            List<FavUrunSayiDTO> FavUrunSayiDTOList = null;
            using (MyDbContext db = new MyDbContext())
            {
                FavUrunSayiDTOList = (from u in db.Uruns
                                      join kufl in db.KullaniciUrunFavoriListes on u.UrunID equals kufl.UrunID
                                      group u.Adi by u.UrunID into grp
                                      orderby grp.Count() descending
                                      select new FavUrunSayiDTO()
                                      {
                                          UrunAdi = grp.Select(x => x).FirstOrDefault(),
                                          FavoriSayisi = grp.Count()
                                      }).Take(3).ToList();
            }
            return FavUrunSayiDTOList;
        }


    }
}
