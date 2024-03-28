CREATE TABLE Jobdetails (
  
  JobTitle varchar(200),
  JobPosition varchar(200),
  JobType varchar(200),
  JobSalary varchar(200),
  RecruitmentQuota varchar(200),
  Location varchar(200),
  ExpInYears varchar(200),
  JobDescription varchar(200),
 
);
INSERT INTO Jobdetails (JobTitle,JobPosition,JobType,JobSalary,RecruitmentQuota,Location,ExpInYears,JobDescription)
VALUES('Phuc vu','Phu Bep','Full-time','50000','15-20','hcm','2 years','bao an trua');
select * from Jobdetails
Drop table Jobdetails