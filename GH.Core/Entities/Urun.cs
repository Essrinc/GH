namespace GH.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Urun")]
    public partial class Urun
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Urun()
        {
            Aramas = new HashSet<Arama>();
            KullaniciUrunFavoriListes = new HashSet<KullaniciUrunFavoriListe>();
            UrunDuzeltmeTaleps = new HashSet<UrunDuzeltmeTalep>();
            UrunIceriks = new HashSet<UrunIcerik>();
            UrunOnayDurums = new HashSet<UrunOnayDurum>();
        }

        public int UrunID { get; set; }

        public Guid Barkod { get; set; }

        [Required]
        [StringLength(100)]
        public string Adi { get; set; }

        [Column(TypeName = "image")]
        public byte[] Icerik { get; set; }

        [Column(TypeName = "image")]
        public byte[] OnYuz { get; set; }

        [Column(TypeName = "image")]
        public byte[] ArkaYuz { get; set; }

        public int KategoriID { get; set; }

        public int UreticiID { get; set; }

        public bool isActive { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime CreatedDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime ModifiedDate { get; set; }

        public int CreatedBy { get; set; }

        public int ModifiedBy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Arama> Aramas { get; set; }

        public virtual Kategori Kategori { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KullaniciUrunFavoriListe> KullaniciUrunFavoriListes { get; set; }

        public virtual Uretici Uretici { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UrunDuzeltmeTalep> UrunDuzeltmeTaleps { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UrunIcerik> UrunIceriks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UrunOnayDurum> UrunOnayDurums { get; set; }
    }
}
