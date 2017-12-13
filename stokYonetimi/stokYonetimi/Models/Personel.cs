namespace stokYonetimi.Models {
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("personeller")]
    public partial class Personel : Kisi {
        [Required]
        [Column("sicilNo")]
        [Display(Name = "sicilNo", ResourceType = typeof(Language.ModelLang.personel))]
        public int SicilNo { get; set; }
    }
}