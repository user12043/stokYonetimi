//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace stokYonetimi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Kisiler_Musteriler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kisiler_Musteriler()
        {
            this.Faturalar = new HashSet<Faturalar>();
        }
    
        public int musteriId { get; set; }
        public int musteriNo { get; set; }
        public int kisiId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Faturalar> Faturalar { get; set; }
        public virtual Kisiler Kisiler { get; set; }
    }
}