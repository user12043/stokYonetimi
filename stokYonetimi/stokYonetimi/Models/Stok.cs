namespace stokYonetimi.Models {
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("stoklar")]
    public partial class Stok {
        [Key]
        public int stokId { get; set; }

        public DateTime olusturulmaTarihi { get; set; }

        public int miktar { get; set; }

        public int adetFiyat { get; set; }

        public int urunId { get; set; }

        public virtual Urun urun { get; set; }
    }
}