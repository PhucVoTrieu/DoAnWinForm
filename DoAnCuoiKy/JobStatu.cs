//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAnCuoiKy
{
    using System;
    using System.Collections.Generic;
    
    public partial class JobStatu
    {
        public int JobID { get; set; }
        public int ApplicantID { get; set; }
        public Nullable<bool> IsFavorite { get; set; }
        public Nullable<bool> IsApplied { get; set; }
    
        public virtual Applicant Applicant { get; set; }
        public virtual Job Job { get; set; }
    }
}
