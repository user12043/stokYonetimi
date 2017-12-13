namespace stokYonetimi.Models {
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("faturalar")]
    public partial class Fatura {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage",
            "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Fatura() {
            Siparisler = new HashSet<Siparis>();
        }

        [Key]
        [Column("faturaId")]
        [Display(Name = "faturaId", ResourceType = typeof(Language.ModelLang.fatura))]
        public int FaturaId { get; set; }

        [Column("fiyat")]
        [Display(Name = "fiyat", ResourceType = typeof(Language.ModelLang.fatura))]
        public int Fiyat { get; set; }

        [Column("musteriId")]
        [Display(Name = "musteriId", ResourceType = typeof(Language.ModelLang.fatura))]
        public int MusteriId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage",
            "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Siparis> Siparisler { get; set; }

        public virtual Musteri Musteri { get; set; }
    }
}