//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace sorucevapuyg.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Soru
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Soru()
        {
            this.Cevap = new HashSet<Cevap>();
        }
    
        public int SoruId { get; set; }
        public string Baslik { get; set; }
        public string SoruIcerik { get; set; }
        public System.DateTime Tarih { get; set; }
        public int KullaniciId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cevap> Cevap { get; set; }
        public virtual Kullanici Kullanici { get; set; }
    }
}
