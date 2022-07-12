namespace LibraryMIS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("bookOut")]
    public partial class bookOut
    {
        [Key]
        public int OID { get; set; }

        [StringLength(50)]
        public string BID { get; set; }

        [StringLength(50)]
        public string PID { get; set; }

        public DateTime? ODate { get; set; }
    }
}
