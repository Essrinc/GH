using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GH.DTOs
{
    public class BarkodResultDTO
    {
        public Guid Barkod { get; set; }
        public string KategoriAdi { get; set; }
        public int KategoriId { get; set; }
        public string UrunAdi { get; set; }
        public string RiskSeviyesi { get; set; }
        public int RiskSeviyesiId { get; set; }
        public string Uretici { get; set; }
        public int UreticiId { get; set; }
        public string UrunIcerikleri { get; set; }
        public string Image { get; set; }
        public byte[] ImgByte { get; set; }
        public string Icerik { get; set; }
        public List<string> IcerikList { get; set; }

    }
}
