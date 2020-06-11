namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BusFunc")]
    public partial class BusFunc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BusFunc()
        {
            BusParOfBusFunc = new HashSet<BusParOfBusFunc>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Code { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        public string Comment { get; set; }

        [Column(TypeName = "xml")]
        public string LocalizedTitle { get; set; }

        public int TechFuncID { get; set; }

        public byte[] DsbSmallTile { get; set; }

        public byte[] DsbMediumTile { get; set; }

        public byte[] DsbLargeTile { get; set; }

        [StringLength(100)]
        public string DsbTileCssClass { get; set; }

        public bool IsCombo { get; set; }

        public bool FleetOnly { get; set; }

        public virtual TechFunc TechFunc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BusParOfBusFunc> BusParOfBusFunc { get; set; }
    }
}
