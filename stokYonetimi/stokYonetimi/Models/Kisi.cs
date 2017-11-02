namespace stokYonetimi.Models {
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kisiler")]
    public partial class Kisi {
        [Key]
        public int kisiId { get; set; }

        [Required]
        public string isim { get; set; }

        [Required]
        public string telefon { get; set; }

        [Required]
        public string adres { get; set; }

        public string mailAdresi { get; set; }

        [Required]
        public string sifre { get; set; }

        [Required]
        public string resim { get; set; }
    }
}