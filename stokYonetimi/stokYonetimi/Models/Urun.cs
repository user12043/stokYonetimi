namespace stokYonetimi.Models {
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("urunler")]
    public partial class Urun {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage",
            "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Urun() {
            Siparisler = new HashSet<Siparis>();
            Stoklar = new HashSet<Stok>();
        }

        [Key]
        [Column("urunId")]
        [Display(Name = "urunId", ResourceType = typeof(Language.ModelLang.urun))]
        public int UrunId { get; set; }

        [Required]
        [Column("isim")]
        [Display(Name = "isim", ResourceType = typeof(Language.ModelLang.urun))]
        public string Isim { get; set; }

        [Required]
        [Column("tur")]
        [Display(Name = "tur", ResourceType = typeof(Language.ModelLang.urun))]
        public string Tur { get; set; }

        [Column("adetFiyat")]
        [Display(Name = "adetFiyat", ResourceType = typeof(Language.ModelLang.urun))]
        public int AdetFiyat { get; set; }

        [Column("aciklama")]
        [Display(Name = "aciklama", ResourceType = typeof(Language.ModelLang.urun))]
        public string Aciklama { get; set; }

        [Column("resim")]
        [Display(Name = "resim", ResourceType = typeof(Language.ModelLang.urun))]
        public string Resim { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage",
            "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Siparis> Siparisler { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage",
            "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Stok> Stoklar { get; set; }
    }
}