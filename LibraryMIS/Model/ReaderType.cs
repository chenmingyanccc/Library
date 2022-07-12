namespace LibraryMIS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReaderType")]
    public partial class ReaderType
    {
        [Key]
        [StringLength(20)]
        public string TypeName { get; set; }

        public int? BookNum { get; set; }

        public int? PeriodicalNum { get; set; }

        public int? RenewNum { get; set; }

        public bool? IsRestrictBook { get; set; }

        public bool? IsRestrictPeriodical { get; set; }
    }
}
