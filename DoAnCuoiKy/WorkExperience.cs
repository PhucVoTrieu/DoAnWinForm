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
    
    public partial class WorkExperience
    {
        public int WorkExperienceID { get; set; }
        public string JobTitle { get; set; }
        public string CompanyName { get; set; }
        public string FromMonth { get; set; }
        public string FromYear { get; set; }
        public string ToMonth { get; set; }
        public string ToYear { get; set; }
        public string WorkDetails { get; set; }
        public string ProjectDetails { get; set; }
        public Nullable<int> ApplicantID { get; set; }
    
        public virtual Applicant Applicant { get; set; }
    }
}
