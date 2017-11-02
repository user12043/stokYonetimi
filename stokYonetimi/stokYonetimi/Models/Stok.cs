namespace stokYonetimi.Models {
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Stoklar")]
    public partial class Stok {
        [Key]
        public int stokId { get; set; }

        public int urunId { get; set; }

        [Required]
        public string olusturmaTarihi { get; set; }

        [Required]
        public string adet { get; set; }

        [Required]
        public string adetFiyat { get; set; }

        public virtual Urun Urun { get; set; }
    }
}