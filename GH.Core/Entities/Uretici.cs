namespace GH.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Uretici")]
    public partial class Uretici
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Uretici()
        {
            Uruns = new HashSet<Urun>();
        }

        public int UreticiID { get; set; }

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
        public virtual ICollection<Urun> Uruns { get; set; }
    }
}
