using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GH.DTOs
{
    public class IcerikDTO
    {
        public int UrunID { get; set; }
        public string UrunAdi { get; set; }
        public int IcerikID { get; set; }
        public string Adi { get; set; }
        public int RiskSeviyeID { get; set; }
        public string RiskAdi { get; set; }
        public string KullaniciAdi { get; set; }
        public int KullaniciID { get; set; }

        public DateTime CreatedDate { get; set; }




    }
}
