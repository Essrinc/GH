using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GH.DTOs
{
    public class MailGuncelleDTO
    {
        public int KullaniciID { get; set; }
        public string Email { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }


    }
}
