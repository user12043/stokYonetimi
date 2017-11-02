namespace stokYonetimi.Models {
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Siparisler")]
    public partial class Siparis {
        [Key]
        public int siparisId { get; set; }

        [Required]
        public string siparisAdedi { get; set; }

        [Required]
        public string siparisTarihi { get; set; }

        [Required]
        public string fiyat { get; set; }

        public int musteriId { get; set; }

        public int urunId { get; set; }

        public int faturaId { get; set; }

        public virtual Fatura Fatura { get; set; }

        public virtual Urun Urun { get; set; }
    }
}