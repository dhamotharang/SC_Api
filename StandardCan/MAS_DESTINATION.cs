//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StandardCan
{
    using System;
    using System.Collections.Generic;
    
    public partial class MAS_DESTINATION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MAS_DESTINATION()
        {
            this.TRAINING_ITEM = new HashSet<TRAINING_ITEM>();
        }
    
        public int MDT_ID { get; set; }
        public string MDT_NAME { get; set; }
        public Nullable<byte> MDT_STATUS { get; set; }
        public Nullable<int> MDT_CREATE_BY { get; set; }
        public Nullable<System.DateTime> MDT_CREATE_DATE { get; set; }
        public Nullable<int> MDT_UPDATE_BY { get; set; }
        public Nullable<System.DateTime> MDT_UPDATE_DATE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRAINING_ITEM> TRAINING_ITEM { get; set; }
    }
}
