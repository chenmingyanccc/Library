namespace LibraryMIS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReaderInfo")]
    public partial class ReaderInfo
    {
        [StringLength(20)]
        public string ReaderBarCode { get; set; }

        [Key]
        [StringLength(20)]
        public string ReaderID { get; set; }

        [StringLength(20)]
        public string ReaderName { get; set; }

        [StringLength(8)]
        public string Sex { get; set; }

        [StringLength(20)]
        public string ReaderType { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? BirthDate { get; set; }

        [StringLength(20)]
        public string CardName { get; set; }

        [StringLength(20)]
        public string CardNumber { get; set; }

        [StringLength(20)]
        public string Phone { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? RegisterDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ValidityDate { get; set; }

        [StringLength(20)]
        public string Operator { get; set; }

        [StringLength(100)]
        public string Remarks { get; set; }

        public int? BookBorrowNum { get; set; }

        public int? PeriodicalBorrowNum { get; set; }

        public bool? IsLoss { get; set; }
    }
}
