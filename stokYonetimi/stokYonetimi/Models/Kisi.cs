namespace stokYonetimi.Models {
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("kisiler")]
    public partial class Kisi {
        [Key]
        public int kisiId { get; set; }

        [Required]
        public string isim { get; set; }

        public string telefon { get; set; }

        public string adres { get; set; }

        public string mailAdresi { get; set; }

        [Required]
        public string sifre { get; set; }

        public string resim { get; set; }

        public int rolu { get; set; }
    }
}