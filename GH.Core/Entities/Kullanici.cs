namespace GH.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kullanici")]
    public partial class Kullanici
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kullanici()
        {
            Aramas = new HashSet<Arama>();
            KullaniciAktivites = new HashSet<KullaniciAktivite>();
            KullaniciFavoriListes = new HashSet<KullaniciFavoriListe>();
            KullaniciUrunIcerikKaraListes = new HashSet<KullaniciUrunIcerikKaraListe>();
        }

        public int KullaniciID { get; set; }

        [Required]
        [StringLength(100)]
        public string KullaniciAdi { get; set; }

        [Required]
        [StringLength(100)]
        public string Sifre { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        public int? RolIdD { get; set; }

        public bool isActive { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime CreatedDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime ModifiedDate { get; set; }

        public int? CreatedBy { get; set; }

        public int? ModifiedBy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Arama> Aramas { get; set; }

        public virtual Rol Rol { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KullaniciAktivite> KullaniciAktivites { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KullaniciFavoriListe> KullaniciFavoriListes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KullaniciUrunIcerikKaraListe> KullaniciUrunIcerikKaraListes { get; set; }
    }
}
