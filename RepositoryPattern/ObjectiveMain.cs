//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RepositoryPattern
{
    using System;
    using System.Collections.Generic;
    
    public partial class    ObjectiveMain
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ObjectiveMain()
        {
            this.ObjectiveSub = new HashSet<ObjectiveSub>();
        }
    
        public System.Guid Id { get; set; }
        public string EmployeeId { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<decimal> OverallScore { get; set; }
        public string OverallComment { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public string PersonalDevelopmentPlan { get; set; }
        public Nullable<int> TotalScore { get; set; }
    
        public virtual Employee Employee { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ObjectiveSub> ObjectiveSub { get; set; }
    }
}
