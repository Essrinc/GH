namespace GH.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Icerik")]
    public partial class Icerik
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Icerik()
        {
            KullaniciUrunIcerikKaraListes = new HashSet<KullaniciUrunIcerikKaraListe>();
            UrunIceriks = new HashSet<UrunIcerik>();
        }

        public int IcerikID { get; set; }

        [Required]
        [StringLength(100)]
        public string Adi { get; set; }

        [Required]
        [StringLength(1000)]
        public string Aciklama { get; set; }

        public int RiskSeviyeID { get; set; }

        public bool isActive { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime CreatedDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime ModifiedDate { get; set; }

        public int CreatedBy { get; set; }

        public int ModifiedBy { get; set; }

        public virtual RiskSeviye RiskSeviye { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KullaniciUrunIcerikKaraListe> KullaniciUrunIcerikKaraListes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UrunIcerik> UrunIceriks { get; set; }
    }
}
