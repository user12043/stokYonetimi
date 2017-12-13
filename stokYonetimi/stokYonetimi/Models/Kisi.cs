namespace stokYonetimi.Models {
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("kisiler")]
    public partial class Kisi {
        [Key]
        [Column("kisiId")]
        [Display(Name = "kisiId", ResourceType = typeof(Language.ModelLang.kisi))]
        public int KisiId { get; set; }

        [Required]
        [Column("isim")]
        [Display(Name = "isim", ResourceType = typeof(Language.ModelLang.kisi))]
        public string Isim { get; set; }

        [Column("telefon")]
        [Display(Name = "telefon", ResourceType = typeof(Language.ModelLang.kisi))]
        public string Telefon { get; set; }

        [Column("adres")]
        [Display(Name = "adres", ResourceType = typeof(Language.ModelLang.kisi))]
        public string Adres { get; set; }

        [Column("mailAdresi")]
        [Display(Name = "mailAdresi", ResourceType = typeof(Language.ModelLang.kisi))]
        public string MailAdresi { get; set; }

        [Required]
        [Column("sifre")]
        [Display(Name = "sifre", ResourceType = typeof(Language.ModelLang.kisi))]
        public string Sifre { get; set; }

        [Column("resim")]
        [Display(Name = "resim", ResourceType = typeof(Language.ModelLang.kisi))]
        public string Resim { get; set; }

        [Column("rolu")]
        [Display(Name = "rolu", ResourceType = typeof(Language.ModelLang.kisi))]
        public int Rolu { get; set; }
    }
}