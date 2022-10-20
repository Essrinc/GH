namespace GH.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RolYetki")]
    public partial class RolYetki
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RolID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int YetkiID { get; set; }

        public bool isActive { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime CreatedDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime ModifiedDate { get; set; }

        public int CreatedBy { get; set; }

        public int ModifiedBy { get; set; }

        public virtual Rol Rol { get; set; }

        public virtual Yetki Yetki { get; set; }
    }
}
