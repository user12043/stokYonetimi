namespace stokYonetimi.Models {
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("personeller")]
    public partial class Personel : Kisi {
        [Required]
        public string sicilNo { get; set; }
    }
}