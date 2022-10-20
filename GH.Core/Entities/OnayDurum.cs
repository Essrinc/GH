namespace GH.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OnayDurum")]
    public partial class OnayDurum
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OnayDurum()
        {
            UrunDuzeltmeTaleps = new HashSet<UrunDuzeltmeTalep>();
            UrunOnayDurums = new HashSet<UrunOnayDurum>();
        }

        public int OnayDurumID { get; set; }

        [Required]
        [StringLength(100)]
        public string Adi { get; set; }

        public bool isActive { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime CreatedDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime ModifiedDate { get; set; }

        public int CreatedBy { get; set; }

        public int ModifiedBy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UrunDuzeltmeTalep> UrunDuzeltmeTaleps { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UrunOnayDurum> UrunOnayDurums { get; set; }
    }
}
