namespace LibraryMIS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BookType")]
    public partial class BookType
    {
        [Key]
        [StringLength(20)]
        public string TypeID { get; set; }

        [StringLength(20)]
        public string TypeName { get; set; }

        public int? BorrowDays { get; set; }
    }
}
