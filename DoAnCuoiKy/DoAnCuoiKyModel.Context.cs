﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DoAnCuoiKyEntities : DbContext
    {
        public DoAnCuoiKyEntities()
            : base("name=DoAnCuoiKyEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Aboutme> Aboutmes { get; set; }
        public virtual DbSet<Applicant> Applicants { get; set; }
        public virtual DbSet<ApplicantSkill> ApplicantSkills { get; set; }
        public virtual DbSet<ApplicantsOfCompany> ApplicantsOfCompanies { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Education> Educations { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<JobSkill> JobSkills { get; set; }
        public virtual DbSet<JobStatu> JobStatus { get; set; }
        public virtual DbSet<PersonalProject> PersonalProjects { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }
        public virtual DbSet<WorkExperience> WorkExperiences { get; set; }
    }
}
