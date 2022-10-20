using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GH.DTOs
{
    public class UrunDTO
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Barkod { get; set; }
        public int KategoriID { get; set; }
        public string KategoriAdi { get; set; }

        public int UreticiID { get; set; }
        public string UreticiAdi { get; set; }
        public string Icerik { get; set; }
        public int KullaniciId { get; set; }
    }
}
