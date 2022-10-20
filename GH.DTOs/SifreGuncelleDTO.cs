using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GH.DTOs
{
    public class SifreGuncelleDTO
    {
        public int KullaniciID { get; set; }
        public string Sifre { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }


    }
}
