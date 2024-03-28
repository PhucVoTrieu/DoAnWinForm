using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy
{
    public  class JobDetails
    {
        private string jobTitle;
        private string jobPosition;
        private string jobType;
        private string jobSalary;
        private string recruitmentQuota;
        private string location;
        private string expInYears;
        private string jobDescription;

        public JobDetails(   )
        {
          
        }
        public JobDetails (string jobTitle,string jobPosition, string jobType , string jobSalary , string recruitmentQuota , string location , string expInYears , string jobDescription )
        {
            this.jobTitle = jobTitle;
            this.jobPosition = jobPosition;
            this.jobType = jobType;
            this.jobSalary = jobSalary;
            this.recruitmentQuota = recruitmentQuota;
            this.location = location;
            this.expInYears = expInYears;
            this.jobDescription = jobDescription;
           
        }
        public string JobTitle
        { get { return jobTitle; }
           set { jobTitle = value; }
        }
        public string JobPosition
        { get { return jobPosition; }
            set { jobPosition = value; } 
        }

        public string JobType
        {
            get { return jobType; }
            set { jobType = value; }
        }
        public string JobSalary
        {
            get { return jobSalary; }
            set { jobSalary = value; }
        }
        public string RecruitmentQuota
        {
            get { return recruitmentQuota; }
            set { recruitmentQuota = value; }
        }
        public string Location 
        { get { return location; }
            set { location = value; } 
        }
        public string ExpInYears
        {
            get { return expInYears; }
            set { expInYears = value; }
        }
        public string JobDescription
        {
            get { return jobDescription; }
            set { jobDescription = value; }
        }
       

    }
    }

