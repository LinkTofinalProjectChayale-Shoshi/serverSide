//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dal
{
    using System;
    using System.Collections.Generic;
    
    public partial class old
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public old()
        {
            this.days_of_old = new HashSet<days_of_old>();
            this.days_of_old2 = new HashSet<days_of_old2>();
            this.Placement = new HashSet<Placement>();
        }
    
        public int idold { get; set; }
        public string fnameold { get; set; }
        public string lnameold { get; set; }
        public int idcity { get; set; }
        public Nullable<int> nomhomeold { get; set; }
        public string nationold { get; set; }
        public Nullable<int> conoID { get; set; }
        public Nullable<bool> ischeck { get; set; }
    
        public virtual city city { get; set; }
        public virtual Constraintsold Constraintsold { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<days_of_old> days_of_old { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<days_of_old2> days_of_old2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Placement> Placement { get; set; }
    }
}
