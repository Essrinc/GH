using GH.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GH.DTOs
{
    public class CurrentKullaniciDTO
    {
        public int Id { get; set; }
        public Enums.Rols RolId { get; set; }
        public string KullaniciAdi { get; set; }
        public string Email { get; set; }
        public string Sifre { get; set; }

    }
}
