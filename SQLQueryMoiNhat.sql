drop table JobDetails
go
CREATE TABLE JobDetails (
  
  JobTitle varchar(200),
  JobPosition varchar(200),
  JobType varchar(200),
  JobSalary varchar(200),
  RecruitmentQuota varchar(200),
  Location varchar(200),
  ExpInYears varchar(200),
  JobDescription varchar(200),
 CompanyName varchar(200),
 Benefit varchar(200)
)
go
INSERT INTO JobDetails (JobTitle,JobPosition,JobType,JobSalary,RecruitmentQuota,Location,ExpInYears,JobDescription,CompanyName,Benefit)
VALUES('Phuc vu','Phu Bep','Full-time','50000','15-20','hcm','2 years','LamViec voi lua','MC Bank', 'Bao Hiem Y Te');
INSERT INTO JobDetails (JobTitle,JobPosition,JobType,JobSalary,RecruitmentQuota,Location,ExpInYears,JobDescription,CompanyName,Benefit)
VALUES('Nhan Vien Ban Hang','Ban Hang','Full-time','80000','10-15','hcm','1 year','Tu van va ban hang san pham','ABC Company', 'Bao Hiem Xa Hoi, Bao Hiem Y Te');
select * from JobDetails
INSERT INTO JobDetails (JobTitle,JobPosition,JobType,JobSalary,RecruitmentQuota,Location,ExpInYears,JobDescription,CompanyName,Benefit)
VALUES('Chuyen Vien Marketing','Marketing','Full-time','120000','5-10','hn','2 years','Thuc hien cac hoat dong marketing','XYZ Corp', 'Bao Hiem Y Te, Thuong Nien');
INSERT INTO JobDetails (JobTitle,JobPosition,JobType,JobSalary,RecruitmentQuota,Location,ExpInYears,JobDescription,CompanyName,Benefit)
VALUES('Lap Trinh Vien','Phan Mem','Full-time','150000','2-5','dn','3 years','Viet va phat trien phan mem','DEF Technologies', 'Bao Hiem Xa Hoi, Bao Hiem Y Te, Thuong Nien');
INSERT INTO JobDetails (JobTitle,JobPosition,JobType,JobSalary,RecruitmentQuota,Location,ExpInYears,JobDescription,CompanyName,Benefit)
VALUES('Ke Toan','Ke Toan Thu Chi','Full-time','60000','5-10','hn','2 years','Thuc hien cac cong viec ke toan','JKL Company', 'Bao Hiem Xa Hoi, Bao Hiem Y Te');
go
drop table FavoriteJob
go
CREATE TABLE FavoriteJob (
  
  JobTitle varchar(200),
  JobPosition varchar(200),
  JobType varchar(200),
  JobSalary varchar(200),
  RecruitmentQuota varchar(200),
  Location varchar(200),
  ExpInYears varchar(200),
  JobDescription varchar(200),
 CompanyName varchar(200),
 Benefit varchar(200)
)
go
--INSERT INTO FavoriteJob (JobTitle,JobPosition,JobType,JobSalary,RecruitmentQuota,Location,ExpInYears,JobDescription,CompanyName,Benefit)
--VALUES('Phuc vu','Phu Bep','Full-time','50000','15-20','hcm','2 years','LamViec voi lua','MC Bank', 'Bao Hiem Y Te');
select * from FavoriteJob

go

Drop table Profile
go
CREATE TABLE Profile (
  ID varchar(255) PRIMARY KEY,  -- Thay ð?i ð? dài n?u c?n
  Name varchar(255) NOT NULL,
  Gender varchar(255),
  Nationality varchar(255),
  Address varchar(255),
  DOB varchar(200),
  ExpYears varchar(200),  -- Thay ð?i ki?u d? li?u n?u kinh nghi?m là s? th?p phân
  Email varchar(255) ,  -- Email là duy nh?t
  Phone varchar(255),
  Describe varchar(200),  -- S? d?ng ntext cho mô t? dài
  ApplyPosition varchar(200),
  Skill varchar(200)
);
go
INSERT INTO Profile (ID, Name, Gender, Nationality, Address, DOB, ExpYears, Email, Phone, Describe,ApplyPosition,Skill)
VALUES
('123456', 'Nguyen Van Thang', 'Nam', 'Viet Nam', 'So 1, Pho X', '1990-01-01', 5, 'nguyenvana@gmail.com', '0123456789', 'Mo ta ve Nguyen Van Thang', 'Designer','TeamWork' )
INSERT INTO Profile (ID, Name, Gender, Nationality, Address, DOB, ExpYears, Email, Phone, Describe, ApplyPosition, Skill)
VALUES
('654321', 'Tran Thi Mai', 'Nu', 'Viet Nam', 'So 2, Quan Y', '1995-07-15', 3, 'tranthimai@gmail.com', '0987654321', 'Mo ta ve Tran Thi Mai', 'Developer', 'Problem Solving, Programming Languages')
INSERT INTO Profile (ID, Name, Gender, Nationality, Address, DOB, ExpYears, Email, Phone, Describe, ApplyPosition, Skill)
VALUES
('987012', 'Dao Quang Huy', 'Nam', 'Viet Nam', 'So 5, Tinh B', '1988-09-12', 7, 'daoquanghuy@gmail.com', '0167890123', 'Mo ta ve Dao Quang Huy', 'Head Accountant', 'Accounting, Financial Analysis')
INSERT INTO Profile (ID, Name, Gender, Nationality, Address, DOB, ExpYears, Email, Phone, Describe, ApplyPosition, Skill)
VALUES
('543210', 'Nguyen Thi My', 'Nu', 'Viet Nam', 'So 6, Quoc C', '1997-03-05', 1, 'nguyenthimy@gmail.com', '0978543210', 'Mo ta ve Nguyen Thi My', 'Translator', 'Foreign Languages, Translation Skills')

select * from Profilex 
Drop Table FavoriteApplicant
go
CREATE TABLE FavoriteApplicant (
  ID varchar(255) PRIMARY KEY,  -- Thay ð?i ð? dài n?u c?n
  Name varchar(255) NOT NULL,
  Gender varchar(255),
  Nationality varchar(255),
  Address varchar(255),
  DOB varchar(200),
  ExpYears varchar(200),  -- Thay ð?i ki?u d? li?u n?u kinh nghi?m là s? th?p phân
  Email varchar(255) ,  -- Email là duy nh?t
  Phone varchar(255),
  Describe varchar(200),  -- S? d?ng ntext cho mô t? dài
  ApplyPosition varchar(200),
  Skill varchar(200)
);
go
--INSERT INTO FavoriteApplicant (ID, Name, Gender, Nationality, Address, DOB, ExpYears, Email, Phone, Describe,ApplyPosition,Skill)
--VALUES
--('123456', 'Nguyen Van Thang', 'Nam', 'Viet Nam', 'So 1, Pho X', '1990-01-01', 5, 'nguyenvana@gmail.com', '0123456789', 'Mo ta ve Nguyen Van Thang', 'Designer','TeamWork' )
select * from FavoriteApplicant