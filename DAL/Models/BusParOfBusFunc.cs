namespace DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BusParOfBusFunc")]
    public partial class BusParOfBusFunc
    {
        public int ID { get; set; }

        public int BusFuncID { get; set; }

        public int BusParID { get; set; }

        public string Comment { get; set; }

        public int? Value_MaxCount { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Value_DateInterval_From { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Value_DateInterval_To { get; set; }

        public bool? Value_FeatureOption { get; set; }

        public virtual BusFunc BusFunc { get; set; }

        public virtual BusPar BusPar { get; set; }
    }
}
