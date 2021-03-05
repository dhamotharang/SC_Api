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
    
    public partial class TRAINING_ITEM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TRAINING_ITEM()
        {
            this.TRAINING_EMP = new HashSet<TRAINING_EMP>();
            this.TRAINING_EXPENSE = new HashSet<TRAINING_EXPENSE>();
            this.TRAINING_EXPERT = new HashSet<TRAINING_EXPERT>();
        }
    
        public int TrainingItemId { get; set; }
        public int TrainingId { get; set; }
        public Nullable<int> TrainingCourseId { get; set; }
        public Nullable<int> TrainingDestinationId { get; set; }
        public Nullable<System.DateTime> TrainingItemDate { get; set; }
        public string TrainingItemStart { get; set; }
        public string TrainingItemStop { get; set; }
    
        public virtual MAS_COURSE MAS_COURSE { get; set; }
        public virtual MAS_DESTINATION MAS_DESTINATION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRAINING_EMP> TRAINING_EMP { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRAINING_EXPENSE> TRAINING_EXPENSE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRAINING_EXPERT> TRAINING_EXPERT { get; set; }
    }
}
