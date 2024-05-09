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
    
    public partial class Applicant
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Applicant()
        {
            this.Aboutmes = new HashSet<Aboutme>();
            this.ApplicantsOfCompanies = new HashSet<ApplicantsOfCompany>();
            this.ApplicantSkills = new HashSet<ApplicantSkill>();
            this.Educations = new HashSet<Education>();
            this.JobStatus = new HashSet<JobStatu>();
            this.PersonalProjects = new HashSet<PersonalProject>();
            this.WorkExperiences = new HashSet<WorkExperience>();
            this.Posts = new HashSet<Post>();
            this.DateInterviews = new HashSet<DateInterview>();
        }
    
        public int ApplicantID { get; set; }
        public string ApplicantTitle { get; set; }
        public string ApplicantEmail { get; set; }
        public string ApplicantPassword { get; set; }
        public string ApplicantName { get; set; }
        public string ApplicantExpYears { get; set; }
        public string ApplicantNationality { get; set; }
        public string ApplicantAddress { get; set; }
        public string ApplicantGender { get; set; }
        public string ApplicantPhonenumber { get; set; }
        public Nullable<System.DateTime> ApplicantDOB { get; set; }
        public string ApplicantPersonalLink { get; set; }
        public string ApplicantAvatar { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Aboutme> Aboutmes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ApplicantsOfCompany> ApplicantsOfCompanies { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ApplicantSkill> ApplicantSkills { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Education> Educations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JobStatu> JobStatus { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonalProject> PersonalProjects { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorkExperience> WorkExperiences { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Post> Posts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DateInterview> DateInterviews { get; set; }
    }
}
