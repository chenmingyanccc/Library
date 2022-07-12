namespace LibraryMIS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("type")]
    public partial class type
    {
        [Key]
        public int TID { get; set; }

        [Column("type")]
        [StringLength(50)]
        public string type1 { get; set; }

        [StringLength(50)]
        public string tRemark { get; set; }
    }
}
