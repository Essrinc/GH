using GH.Common;
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
    public class KullaniciDAL : EFRepoBase<MyDbContext, Kullanici>, IKullaniciDAL
    {
        public bool KullaniciVarMi(string KullaniciAdi, string Sifre)
        {
            LoginDTO loginDTO = null;

            using (MyDbContext db = new MyDbContext())
            {
                loginDTO = (from k in db.Kullanicis
                            where k.KullaniciAdi == KullaniciAdi && k.Sifre == Sifre && k.isActive == true
                            select new LoginDTO
                            {
                                KullaniciAdi = k.KullaniciAdi,
                                Sifre = k.Sifre
                            }).FirstOrDefault();
            }
            if (loginDTO != null)
                return true;
            else
                return false;
        }
        public CurrentKullaniciDTO Login(string KullaniciAdi, string Sifre)
        {
            CurrentKullaniciDTO currentKullaniciDTO = null;

            using (MyDbContext db = new MyDbContext())
            {
                currentKullaniciDTO = (from k in db.Kullanicis
                                       where k.KullaniciAdi == KullaniciAdi && k.Sifre == Sifre && k.isActive == true
                                       select new CurrentKullaniciDTO
                                       {
                                           Id = k.KullaniciID,
                                           KullaniciAdi = k.KullaniciAdi,
                                           RolId = k.RolIdD != null ? (Enums.Rols)k.RolIdD : Enums.Rols.Normal,
                                           Email=k.Email,
                                           Sifre=k.Sifre
                                       }).FirstOrDefault();
            }
            return currentKullaniciDTO;
        }
        public bool Kayit(string KullaniciAdi, string Sifre, string Email)
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    Kullanici k = new Kullanici();
                    k.KullaniciAdi = KullaniciAdi;
                    k.Sifre = Sifre;
                    k.Email = Email;
                    k.isActive = true;
                    k.CreatedDate = DateTime.Now;
                    k.ModifiedDate = DateTime.Now;
                    k.CreatedBy = 1;
                    k.ModifiedBy = 1;
                    k.RolIdD = (int?)Enums.Rols.Normal;

                    db.Kullanicis.Add(k);
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {

            }
            return false;
        }
        public bool AramaKaydet(int id, CurrentKullaniciDTO currentKullaniciDTO)
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    Arama a = new Arama();
                    a.KullaniciID = currentKullaniciDTO.Id;
                    a.UrunId = id;
                    a.isActive = true;
                    a.CreatedDate = DateTime.Now;
                    a.ModifiedDate = DateTime.Now;
                    a.ModifiedBy = 1;

                    db.Aramas.Add(a);
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {

            }
            return false;
        }


        public List<UrunDTO> AramaGecmisiListele(CurrentKullaniciDTO currentKullaniciDTO)
        {
            List<UrunDTO> AramaList = null;

            using (MyDbContext db = new MyDbContext())
            {
                AramaList = (from a in db.Aramas
                             join u in db.Uruns on a.UrunId equals u.UrunID
                             where a.KullaniciID == currentKullaniciDTO.Id && a.isActive == true
                             select new UrunDTO
                             {
                                 Adi = u.Adi,
                                 Id = u.UrunID,
                                 KullaniciId = a.KullaniciID
                             }).ToList();
            }
            return AramaList;
        }

        public bool AramaGecmisiTmizle(CurrentKullaniciDTO currentKullaniciDTO)
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    List<Arama> Results = db.Aramas.ToList();
                    foreach (var item in Results)
                    {
                        if (item.KullaniciID == currentKullaniciDTO.Id && item.isActive)
                        {
                            item.isActive = false;
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

        public List<UrunDTO> KaraListeListele(CurrentKullaniciDTO currentKullaniciDTO)
        {
            List<UrunDTO> KaraListeList = null;

            using (MyDbContext db = new MyDbContext())
            {
                KaraListeList = (from kuikl in db.KullaniciUrunIcerikKaraListes
                                 join i in db.Iceriks on kuikl.IcerikID equals i.IcerikID
                                 join ui in db.UrunIceriks on i.IcerikID equals ui.IcerikID
                                 join u in db.Uruns on ui.UrunID equals u.UrunID
                                 where kuikl.KullaniciID == currentKullaniciDTO.Id && kuikl.IsActive == true
                                 select new UrunDTO
                                 {
                                     Adi = u.Adi,
                                     Id = u.UrunID,
                                     KullaniciId = kuikl.KullaniciID
                                 }).ToList();
            }
            return KaraListeList;
        }

        public List<FavoriListeDTO> TumFavoriListeleriGetir(CurrentKullaniciDTO currentKullaniciDTO)
        {
            List<FavoriListeDTO> favoriListeDTOList = null;
            using (MyDbContext db = new MyDbContext())
            {//KullaniciFavoriListe=TumFavoriListeleriGetir listeliyor, urunliste urunleri listeliyor.
                favoriListeDTOList = (from kfl in db.KullaniciFavoriListes
                                      join k in db.Kullanicis on kfl.CreatedBy equals k.KullaniciID
                                      where k.KullaniciID == currentKullaniciDTO.Id && kfl.isActive == true
                                      select new FavoriListeDTO
                                      {
                                          KullaniciID = k.KullaniciID,
                                          FavoriListeID = kfl.FavoriListeID,
                                          Adi = kfl.Adi
                                      }).ToList();
            }
            return favoriListeDTOList;
        }

        public List<KullaniciRolDTO> KullaniciRolDagilimiGetir(KullaniciRolDTO kullaniciRolDTO)
        {
            List<KullaniciRolDTO> KullaniciRolDTOList = null;

            using (MyDbContext db = new MyDbContext())
            {
                KullaniciRolDTOList = (from r in db.Rols
                                       join k in db.Kullanicis on r.RolID equals k.RolIdD into firstJoin
                                       from d in firstJoin.DefaultIfEmpty()
                                       group new { d.KullaniciAdi } by r.Adi into grp
                                       select new KullaniciRolDTO
                                       {
                                           RolAdi = grp.Key,
                                           KullaniciSayisi = grp.Where(x => x.KullaniciAdi != null).Count()
                                       }

                                       ).ToList();
            }
            return KullaniciRolDTOList;
        }

        //public List<IcerikDTO> EnfazlaRiskliUrunTutanKullanicilar(IcerikDTO icerikDTO)
        //{
        //    List<IcerikDTO> icerikDTOList = null;

        //    using (MyDbContext db = new MyDbContext())
        //    {
        //        icerikDTOList = (from k in db.Kullanicis
        //                         join u in db.Uruns on k.KullaniciID equals u.CreatedBy
        //                         join ui in db.UrunIceriks on u.UrunID equals ui.UrunID
        //                         join i in db.Iceriks on ui.IcerikID equals i.IcerikID
        //                         join r in db.RiskSeviyes on i.RiskSeviyeID equals r.RiskSeviyeID
        //                         where r.RiskSeviyeID == 4 && i.isActive == true
        //                         select new IcerikDTO
        //                         {
        //                             KullaniciID = k.KullaniciID,
        //                             KullaniciAdi = k.KullaniciAdi,
        //                             UrunID = u.UrunID,
        //                             UrunAdi = u.Adi,
        //                             IcerikID = i.IcerikID,
        //                             Adi = i.Adi,
        //                             RiskSeviyeID = r.RiskSeviyeID,
        //                             RiskAdi = r.Adi
        //                         }).Take(3).ToList();

        //        return icerikDTOList;
        //    }
        //}
        public List<KullaniciMailDTO> EnUrunluKullanicilar(KullaniciMailDTO kullaniciMailDTO)
        {
            List<KullaniciMailDTO> kullaniciMailDTOList = null;
            using (MyDbContext db = new MyDbContext())
            {
                kullaniciMailDTOList = (from k in db.Kullanicis
                                        join u in db.Uruns on k.KullaniciID equals u.CreatedBy
                                        where u.isActive == true
                                        select new KullaniciMailDTO
                                        {
                                            KullaniciID = k.KullaniciID,
                                            KullaniciAdi = k.KullaniciAdi,
                                            Email = k.Email
                                        }).Take(5).ToList();
            }
            return kullaniciMailDTOList;
        }

        public List<KayitTarihDTO> KayitTarihi(CurrentKullaniciDTO currentKullaniciDTO)
        {
            List<KayitTarihDTO> kayitTarihDTOList = null;
            using (MyDbContext db = new MyDbContext())
            {
                kayitTarihDTOList = (from k in db.Kullanicis
                                 where k.KullaniciID == currentKullaniciDTO.Id && k.isActive == true
                                 select new KayitTarihDTO
                                 {
                                     CreatedDate = k.CreatedDate

                                 }).ToList();
            }
            return kayitTarihDTOList;
        }

        public List<KullaniciUrunSayiDTO> KacUrunumVarFavListe(KullaniciUrunSayiDTO kullaniciUrunSayiDTO)
        {
            List<KullaniciUrunSayiDTO> list = null;
            using (MyDbContext db = new MyDbContext())
            {
                //list = (from k in db.Kullanicis
                //        join kuikl in db.KullaniciUrunIcerikKaraListes on k.KullaniciID equals kuikl.KullaniciID
                //        group new { k.KullaniciAdi, kuikl } by k.KullaniciID into grp
                //        select new KullaniciUrunSayiDTO()
                //        {
                //            KullaniciAdi = grp.Select(x => x.KullaniciAdi).FirstOrDefault(),
                //            UrunAdet = grp.Count()
                //        }).ToList();
                list = (from k in db.Kullanicis
                        join kfl in db.KullaniciFavoriListes on k.KullaniciID equals kfl.CreatedBy
                        join kufl in db.KullaniciUrunFavoriListes on kfl.FavoriListeID equals kufl.FavoriListeID
                        group new { k.KullaniciAdi, kufl } by k.KullaniciID into grp
                        select new KullaniciUrunSayiDTO()
                        {
                            KullaniciAdi = grp.Select(x => x.KullaniciAdi).FirstOrDefault(),
                            UrunAdet = grp.Count()
                        }).ToList();
            }
            return list;

        }

        public List<KullaniciUrunSayiDTO> KacUrunumVarKaraListe(KullaniciUrunSayiDTO kullaniciUrunSayiDTO)
        {
            List<KullaniciUrunSayiDTO> list = null;
            using (MyDbContext db = new MyDbContext())
            {
                list = (from k in db.Kullanicis
                        join kuikl in db.KullaniciUrunIcerikKaraListes on k.KullaniciID equals kuikl.KullaniciID
                        group new { k.KullaniciAdi, kuikl } by k.KullaniciID into grp
                        select new KullaniciUrunSayiDTO()
                        {
                            KullaniciAdi = grp.Select(x => x.KullaniciAdi).FirstOrDefault(),
                            UrunAdet = grp.Count()
                        }).ToList();
            }
            return list;

        }

        public List<EthanolKacKisininFavıDTO> EthanolKacKisininFavı(EthanolKacKisininFavıDTO ethanolKacKisininFavıDTO)
        {
            List<EthanolKacKisininFavıDTO> list = null;
            using (MyDbContext db = new MyDbContext())
            {
                list = (from kfl in db.KullaniciFavoriListes
                        join kufl in db.KullaniciUrunFavoriListes on kfl.FavoriListeID equals kufl.FavoriListeID
                        join u in db.Uruns on kufl.UrunID equals u.UrunID
                        join ui in db.UrunIceriks on u.UrunID equals ui.UrunID
                        join i in db.Iceriks on ui.IcerikID equals i.IcerikID
                        where i.Adi.Contains("ethanol")
                        join k in db.Kullanicis on i.CreatedBy equals k.KullaniciID
                        group new
                        {
                            u.Adi,
                            kufl
                        } by u.UrunID into grp
                        select new EthanolKacKisininFavıDTO
                        {
                            UrunAdi = grp.Select(x => x.Adi).FirstOrDefault(),
                            Adet = grp.Count()
                        }).ToList();
                return list;

            }

        }
        public List<EthanolKacKisininKaraListesindeDTO> EthanolKacKisininKaraListesinde(EthanolKacKisininKaraListesindeDTO ethanolKacKisininKaraListesindeDTO)
        { //OLMADI.
            List<EthanolKacKisininKaraListesindeDTO> list = null;
            using (MyDbContext db = new MyDbContext())
            {
                list = (from kuikl in db.KullaniciUrunIcerikKaraListes
                        join i in db.Iceriks on kuikl.IcerikID equals i.IcerikID
                        join ui in db.UrunIceriks on i.IcerikID equals ui.IcerikID
                        join u in db.Uruns on ui.UrunID equals u.UrunID
                        group new { u.Adi, kuikl } by u.UrunID into grp
                        select new EthanolKacKisininKaraListesindeDTO
                        {
                            UrunAdi = grp.Select(x => x.Adi).FirstOrDefault(),
                            Adet = grp.Count()
                        }).ToList();
                return list;

            }
        }
        public bool KullaniciGuncelle(CurrentKullaniciDTO currentKullaniciDTO)
        {
            bool dbdeVarMi = false;
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    List<Kullanici> Results = db.Kullanicis.ToList();
                    foreach (var item in Results)
                    {
                        if (item.KullaniciID == currentKullaniciDTO.Id)
                        {
                            item.Email = currentKullaniciDTO.Email;
                            item.KullaniciAdi = currentKullaniciDTO.KullaniciAdi;
                            item.Sifre = currentKullaniciDTO.Sifre;
                            db.Entry(item).State = EntityState.Modified;
                            db.SaveChanges();
                            dbdeVarMi = true;
                        }
                    }
                }
                if (dbdeVarMi)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {

            }
            return false;
        }

        public List<KullaniciGuncelleDTO> KisiBilgileriniListele(string text)
        {
            List<KullaniciGuncelleDTO> kullaniciGuncelleDTOList = null;
            using (MyDbContext db = new MyDbContext())
            {
                kullaniciGuncelleDTOList = (from k in db.Kullanicis
                                            where k.isActive == true && k.KullaniciAdi.Contains(text)
                                            select new KullaniciGuncelleDTO
                                            {
                                                KullaniciID = k.KullaniciID,
                                                KullaniciAdi = k.KullaniciAdi,
                                                Email = k.Email,
                                                Sifre = k.Sifre
                                            }).ToList();
            }
            return kullaniciGuncelleDTOList;
        }
    }
}
