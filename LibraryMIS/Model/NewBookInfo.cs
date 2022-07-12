namespace LibraryMIS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NewBookInfo")]
    public partial class NewBookInfo
    {
        [Key]
        [StringLength(50)]
        public string BookID { get; set; }

        [StringLength(50)]
        public string BookName { get; set; }

        [StringLength(50)]
        public string BookBarCode { get; set; }

        [StringLength(50)]
        public string BookType { get; set; }

        [StringLength(50)]
        public string TotalNum { get; set; }

        [StringLength(50)]
        public string StorPosion { get; set; }

        public double? NewPrice { get; set; }

        [StringLength(50)]
        public string Press { get; set; }

        [StringLength(50)]
        public string Author { get; set; }

        public DateTime? StoreDate { get; set; }
    }
}
