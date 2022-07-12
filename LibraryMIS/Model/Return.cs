namespace LibraryMIS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Return")]
    public partial class Return
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ReturnID { get; set; }

        [StringLength(20)]
        public string BookID { get; set; }

        [StringLength(20)]
        public string ReaderID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ReturnDate { get; set; }

        [StringLength(20)]
        public string Operator { get; set; }
    }
}
