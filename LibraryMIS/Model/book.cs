namespace LibraryMIS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("book")]
    public partial class book
    {
        [Key]
        [StringLength(50)]
        public string BID { get; set; }

        [StringLength(50)]
        public string BName { get; set; }

        [StringLength(50)]
        public string BWriter { get; set; }

        [StringLength(50)]
        public string BPublish { get; set; }

        public DateTime? BDate { get; set; }

        [StringLength(50)]
        public string BPrice { get; set; }

        [StringLength(50)]
        public string BNum { get; set; }

        [StringLength(50)]
        public string Type { get; set; }

        [StringLength(50)]
        public string BRemark { get; set; }
    }
}
