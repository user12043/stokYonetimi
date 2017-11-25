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
            siparisler = new HashSet<Siparis>();
        }

        [Key]
        public int faturaId { get; set; }

        public int fiyat { get; set; }

        public int musteriId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage",
            "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Siparis> siparisler { get; set; }

        public virtual Musteri musteri { get; set; }
    }
}