namespace GH.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UrunOnayDurum")]
    public partial class UrunOnayDurum
    {
        [Key]
        public Guid TakipNumarasi { get; set; }

        public int UrunID { get; set; }

        public int OnayDurumID { get; set; }

        [StringLength(300)]
        public string Aciklama { get; set; }

        public bool isActive { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime CreatedDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime ModifiedDate { get; set; }

        public int CreatedBy { get; set; }

        public int ModifiedBy { get; set; }

        public virtual OnayDurum OnayDurum { get; set; }

        public virtual Urun Urun { get; set; }
    }
}
