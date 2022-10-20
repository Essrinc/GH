using GH.Core.Entities;
using GH.Core.Repo;
using GH.DAL.Interfaces;
using GH.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GH.DAL.Concrete
{
    public class BarkodDAL : EFRepoBase<MyDbContext, Urun>, IBarkodDAL
    {
        public bool BarkodVarMi(Guid Barkod)
        {
            BarkodKontrolDTO barkodKontrolDTO = new BarkodKontrolDTO();


            using (MyDbContext db = new MyDbContext())
            {
                barkodKontrolDTO = (from u in db.Uruns
                                    where u.Barkod == Barkod && u.isActive == true
                                    select new BarkodKontrolDTO
                                    {
                                        Barkod = u.Barkod
                                    }).FirstOrDefault();
            }
            if (barkodKontrolDTO != null)
                return true;
            else
                return false;
        }

        public BarkodResultDTO BarkodArama(Guid Barkod)
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
                                        where u.Barkod == Barkod && u.isActive == true
                                        select new BarkodResultDTO
                                        {
                                            Barkod = u.Barkod,
                                            UrunAdi = u.Adi,
                                            KategoriAdi = kat.Adi,
                                            RiskSeviyesi = risk.Adi,
                                            RiskSeviyesiId = risk.RiskSeviyeID,
                                            Uretici = ut.Adi,
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


    }
}
