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
    
    public partial class days_of_old2
    {
        public int iddayo { get; set; }
        public Nullable<int> idold { get; set; }
        public Nullable<bool> isSunday { get; set; }
        public Nullable<bool> isManday { get; set; }
        public Nullable<bool> isTuthday { get; set; }
        public Nullable<bool> isWenthday { get; set; }
        public Nullable<bool> isThursday { get; set; }
        public Nullable<bool> isFriday { get; set; }
        public Nullable<bool> isShabbat { get; set; }
        public Nullable<int> hourstarto { get; set; }
        public Nullable<int> hourendo { get; set; }
        public Nullable<int> conoID { get; set; }
        public Nullable<bool> isavliable { get; set; }
    
        public virtual Constraintsold Constraintsold { get; set; }
        public virtual old old { get; set; }
    }
}
