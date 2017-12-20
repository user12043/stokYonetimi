namespace stokYonetimi.Models {
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("siparisler")]
    public partial class Siparis {
        [Key]
        [Column("siparisId")]
        [Display(Name = "siparisId", ResourceType = typeof(Language.ModelLang.siparis))]
        public int SiparisId { get; set; }

        [Column("miktar")]
        [Display(Name = "miktar", ResourceType = typeof(Language.ModelLang.siparis))]
        public int Miktar { get; set; }

        [Column("tarih")]
        [Display(Name = "tarih", ResourceType = typeof(Language.ModelLang.siparis))]
        public DateTime Tarih { get; set; }

        [Column("fiyat")]
        [Display(Name = "fiyat", ResourceType = typeof(Language.ModelLang.siparis))]
        public int Fiyat { get; set; }

        [Column("durum")]
        [Display(Name = "durum", ResourceType = typeof(Language.ModelLang.siparis))]
        public bool Durum { get; set; }

        [Column("musteriId")]
        [Display(Name = "musteriId", ResourceType = typeof(Language.ModelLang.siparis))]
        public int MusteriId { get; set; }

        [Column("urunId")]
        [Display(Name = "urunId", ResourceType = typeof(Language.ModelLang.siparis))]
        public int UrunId { get; set; }

        [Column("faturaId")]
        [Display(Name = "faturaId", ResourceType = typeof(Language.ModelLang.siparis))]
        public int FaturaId { get; set; }

        public virtual Fatura Fatura { get; set; }

        public virtual Musteri Musteri { get; set; }

        public virtual Urun Urun { get; set; }
    }
}