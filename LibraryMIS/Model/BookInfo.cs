namespace LibraryMIS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BookInfo")]
    public partial class BookInfo
    {
        [Key]
        [StringLength(50)]
        public string BookID { get; set; }

        [Required]
        [StringLength(50)]
        public string BookName { get; set; }

        [Required]
        [StringLength(50)]
        public string BookBarCode { get; set; }

        [Required]
        [StringLength(50)]
        public string BookType { get; set; }

        [Required]
        [StringLength(50)]
        public string TotalNum { get; set; }

        [Required]
        [StringLength(50)]
        public string StorPosion { get; set; }

        public double Price { get; set; }

        [Required]
        [StringLength(50)]
        public string Press { get; set; }

        [Required]
        [StringLength(50)]
        public string Author { get; set; }

        public DateTime StoreDate { get; set; }
    }
}
