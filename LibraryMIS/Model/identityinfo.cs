namespace LibraryMIS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("identityinfo")]
    public partial class identityinfo
    {
        [Key]
        [StringLength(50)]
        public string identityname { get; set; }

        public int? longTime { get; set; }

        public int? bigNum { get; set; }
    }
}
