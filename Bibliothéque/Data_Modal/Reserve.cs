//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bibliothéque.Data_Modal
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reserve
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Reserve()
        {
            this.Emprintes = new HashSet<Emprinte>();
        }
    
        public int Id { get; set; }
        public Nullable<int> Id_STG { get; set; }
        public Nullable<int> Id_LVR { get; set; }
        public System.DateTime Date_Reserve { get; set; }
        public string Etat { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Emprinte> Emprintes { get; set; }
        public virtual Livre Livre { get; set; }
        public virtual Stagiaire Stagiaire { get; set; }
    }
}
