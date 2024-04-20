
CREATE TABLE Company (
  CompanyID int identity (1,1) primary key,
  CompanyEmail varchar(max),
  CompanyPassword varchar(50),
  CompanyName varchar(200),
  CompanyType varchar(200),
  CompanyAddress varchar(200),
  CompanyOverview varchar(max),
  CompanyBenefit varchar(max),
  CompanyWorkingDays varchar(50),
  CompanySize varchar (100),
  CompanyCountry varchar(100)
)
go
INSERT INTO Company (CompanyEmail,CompanyPassword,CompanyName, CompanyType, CompanyAddress, CompanyOverview, CompanyBenefit, CompanyWorkingDays, CompanySize, CompanyCountry)
VALUES ('c1@gmail.com','123','MB Bank', 'IT Product', '123 Duong XYZ, Quan 1, TP.HCM', 'Our company specializes in software development...', 'Good remuneration, dynamic working environment..', 'Monday-Friday', '50-100 employees', 'Viet Nam')
go
select* from company
go
CREATE TABLE Jobs (
  JobID int identity (1,1) primary key,
  JobTitle varchar(200),
  JobType varchar(200),
  JobSalary varchar(200),
  RecruitmentQuota varchar(200),
  Location varchar(200),
  ExpInYears varchar(200),
  JobRequirement varchar(max),
  JobDescription varchar(max),
  CompanyID int references Company(CompanyID),
  JobBenefit varchar(200)
)
go
INSERT INTO Jobs (JobTitle,JobType, JobSalary, RecruitmentQuota, Location, ExpInYears, JobRequirement, JobDescription, CompanyID, JobBenefit)
VALUES ('Software Developer','Full-time', '70000-90000 USD', '5', 'New York, USA', '3-5', 'Proficient in Java, SQL', 'Develop and maintain web applications', 1, 'Health insurance, Retirement plan');
 
go
select * from jobs
go
CREATE TABLE Applicant (
  ApplicantID int identity (1,1) primary key,
  ApplicantEmail varchar(200),
  ApplicantPassword varchar(200),
  ApplicantName varchar(200),
  ApplicantExpYears varchar(200),
  ApplicantNationality varchar(200),
  ApplicantAddress varchar(200),
  ApplicantGender varchar(200),
  ApplicantPhonenumber varchar(200),
  ApplicantDOB date,
  ApplicantDescription varchar(max),
)
go
INSERT INTO Applicant (ApplicantEmail, ApplicantPassword, ApplicantName, ApplicantExpYears, ApplicantNationality, ApplicantAddress, ApplicantGender, ApplicantPhonenumber, ApplicantDOB, ApplicantDescription)
VALUES ('a1@gmail.com', '123', 'John Doe', '5', 'American', '123 Main St, New York, NY', 'Male', '123-456-7890', '1980-01-01', 'Experienced software developer...');
go 
select * from Applicant

go



CREATE TABLE FavoriteJobs (
FavoriteJobsID int identity (1,1) primary key,
  JobID int references Jobs(jobID),
  ApplicantID int references Applicant(applicantID)
  
)
go
insert into FavoriteJobs(JobID,ApplicantID) values (1,1)
go
select * from FavoriteJobs
go


CREATE TABLE FavoriteApplicants (
	FavoriteApplicantsID int identity (1,1) primary key,
  CompanyID int references Company(companyID),
  ApplicantID int references Applicant(applicantID)
  
)
go
insert into FavoriteApplicants(CompanyID,ApplicantID) values (1,1)
go
select * from FavoriteApplicants

