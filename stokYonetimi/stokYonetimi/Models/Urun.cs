namespace stokYonetimi.Models {
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Urunler")]
    public partial class Urun {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage",
            "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Urun() {
            Siparisler = new HashSet<Siparis>();
            Stoklar = new HashSet<Stok>();
        }

        [Key]
        public int urunId { get; set; }

        [Required]
        public string isim { get; set; }

        [Required]
        public string tur { get; set; }

        [Required]
        public string adetFiyat { get; set; }

        [Required]
        public string aciklama { get; set; }

        [Required]
        public string resim { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage",
            "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Siparis> Siparisler { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage",
            "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Stok> Stoklar { get; set; }
    }
}