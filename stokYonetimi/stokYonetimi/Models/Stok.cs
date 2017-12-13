namespace stokYonetimi.Models {
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("stoklar")]
    public partial class Stok {
        [Key]
        [Column("stokId")]
        [Display(Name = "stokId", ResourceType = typeof(Language.ModelLang.stok))]
        public int StokId { get; set; }

        [Column("olusturulmaTarihi")]
        [Display(Name = "olusturulmaTarihi", ResourceType = typeof(Language.ModelLang.stok))]
        public DateTime OlusturulmaTarihi { get; set; }

        [Column("miktar")]
        [Display(Name = "miktar", ResourceType = typeof(Language.ModelLang.stok))]
        public int Miktar { get; set; }

        [Column("adetFiyat")]
        [Display(Name = "adetFiyat", ResourceType = typeof(Language.ModelLang.stok))]
        public int AdetFiyat { get; set; }

        [Column("urunId")]
        [Display(Name = "urunId", ResourceType = typeof(Language.ModelLang.stok))]
        public int UrunId { get; set; }

        public virtual Urun Urun { get; set; }
    }
}