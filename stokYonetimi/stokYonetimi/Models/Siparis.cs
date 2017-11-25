namespace stokYonetimi.Models {
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("siparisler")]
    public partial class Siparis {
        [Key]
        public int siparisId { get; set; }

        public int miktar { get; set; }

        public DateTime tarih { get; set; }

        public int fiyat { get; set; }

        public int musteriId { get; set; }

        public int urunId { get; set; }

        public int faturaId { get; set; }

        public virtual Fatura fatura { get; set; }

        public virtual Musteri musteri { get; set; }

        public virtual Urun urun { get; set; }
    }
}