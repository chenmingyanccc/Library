namespace LibraryMIS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Borrow")]
    public partial class Borrow
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BorrowID { get; set; }

        [StringLength(20)]
        public string BookID { get; set; }

        [StringLength(20)]
        public string ReaderID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? BorrowDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? MustReturnDate { get; set; }

        public int? RenewNum { get; set; }

        [StringLength(20)]
        public string Operator { get; set; }

        [StringLength(20)]
        public string State { get; set; }
    }
}
