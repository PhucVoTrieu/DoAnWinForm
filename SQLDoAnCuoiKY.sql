

CREATE TABLE Skills (
	SkillID int identity (1,1) primary key,
	SkillName nvarchar(2000),
	)
go
INSERT INTO Skills (SkillName)
VALUES ('Java'), ('Python'), ('SQL');
go
CREATE TABLE Company (
  CompanyID int identity (1,1) primary key,
  CompanyEmail varchar(max),
  CompanyPassword varchar(50),
  CompanyName varchar(200),
  CompanyType varchar(200),
  CompanyAddress nvarchar(200),
  CompanyOverview nvarchar(max),
  CompanyBenefit nvarchar(max),
  CompanyWorkingDays varchar(50),
  CompanySize varchar (100),
  CompanyCountry varchar(100),
  CompanyAvatar varchar(max) default null
)
go
INSERT INTO Company (CompanyEmail,CompanyPassword,CompanyName, CompanyType, CompanyAddress, CompanyOverview, CompanyBenefit, CompanyWorkingDays, CompanySize, CompanyCountry, CompanyAvatar)
VALUES ('c1@gmail.com','123','MB Bank', 'IT Product', N'123 Duong XYZ, Quan 1, TP.HCM', N'Overview about Mcredit - Công ty Tài chính TNHH MB Shinsei
Được thành lập từ năm 2016, Công Ty Tài Chính Trách Nhiệm Hữu Hạn MB Shinsei (Mcredit) là công ty tài chính liên doanh giữa Ngân hàng TMCP Quân đội (thuộc MB Group) và Ngân hàng SBI Shinsei (Nhật Bản).
Trong giai đoạn chuyển đổi số mạnh mẽ, Mcredit tập trung phát triển các sản phẩm: Core banking, Core card, Bot, Mobile banking… bằng nền tảng công nghệ: Cloud, Mobile (Flutter) và tối ưu các công nghệ Java, .Net, Python (AI, ML), Flutter cùng sự đồng hành của đối tác hàng đầu: Amazon Web Services, T24…
Mcredit hướng tới việc xây dựng môi trường làm việc tốt nhất cho nhân viên bằng chế độ làm việc linh hoạt (Agile), chuyên nghiệp, có máy tập thể hình, bàn bi-a, khu pantry riêng và các hoạt động giải trí đa dạng sau mỗi giờ làm việc. Mcredit còn thường xuyên tổ chức các cuộc thi dành riêng cho khối IT về game cũng như tổ chức các khóa học, buổi chia sẻ về nghiệp vụ và công nghệ.

'
, N'Mức lương cạnh tranh, hấp dẫn (Thưởng xếp loại thực hiện công việc 6 tháng/lần, thưởng sinh nhật ngân hàng, thưởng các ngày lễ tết trong năm…).
Chế độ phúc lợi cạnh tranh: Du lịch hàng năm, Khám sức khỏe định kì hàng năm; Gói bảo hiểm sức khỏe; Các hoạt động tri ân, chăm lo đời sống tinh thần CBNV và Thân nhân...
Môi trường làm việc chuyên nghiệp, thân thiện, cởi mở.
Được làm việc với các hệ thống hiện đại, tiên tiến nhất thị trường, áp dụng các công nghệ hàng đầu về an ninh bảo mật để đảm bảo an toàn cho người sử dụng.
Cơ hội học hỏi nghiệp vụ ngân hàng.', 'Monday-Friday', '50-100 employees', 'Viet Nam', Null)
go
INSERT INTO Company (CompanyEmail,CompanyPassword,CompanyName, CompanyType, CompanyAddress, CompanyOverview, CompanyBenefit, CompanyWorkingDays, CompanySize, CompanyCountry, CompanyAvatar)
VALUES ('c2@gmail.com','123','FPT Software', 'IT Product', N'123 Duong XYZ, Quan 1, TP.HCM', N'Overview about Mcredit - Công ty Tài chính TNHH MB Shinsei
Được thành lập từ năm 2016, Công Ty Tài Chính Trách Nhiệm Hữu Hạn MB Shinsei (Mcredit) là công ty tài chính liên doanh giữa Ngân hàng TMCP Quân đội (thuộc MB Group) và Ngân hàng SBI Shinsei (Nhật Bản).
Trong giai đoạn chuyển đổi số mạnh mẽ, Mcredit tập trung phát triển các sản phẩm: Core banking, Core card, Bot, Mobile banking… bằng nền tảng công nghệ: Cloud, Mobile (Flutter) và tối ưu các công nghệ Java, .Net, Python (AI, ML), Flutter cùng sự đồng hành của đối tác hàng đầu: Amazon Web Services, T24…
Mcredit hướng tới việc xây dựng môi trường làm việc tốt nhất cho nhân viên bằng chế độ làm việc linh hoạt (Agile), chuyên nghiệp, có máy tập thể hình, bàn bi-a, khu pantry riêng và các hoạt động giải trí đa dạng sau mỗi giờ làm việc. Mcredit còn thường xuyên tổ chức các cuộc thi dành riêng cho khối IT về game cũng như tổ chức các khóa học, buổi chia sẻ về nghiệp vụ và công nghệ.

'
, N'Mức lương cạnh tranh, hấp dẫn (Thưởng xếp loại thực hiện công việc 6 tháng/lần, thưởng sinh nhật ngân hàng, thưởng các ngày lễ tết trong năm…).
Chế độ phúc lợi cạnh tranh: Du lịch hàng năm, Khám sức khỏe định kì hàng năm; Gói bảo hiểm sức khỏe; Các hoạt động tri ân, chăm lo đời sống tinh thần CBNV và Thân nhân...
Môi trường làm việc chuyên nghiệp, thân thiện, cởi mở.
Được làm việc với các hệ thống hiện đại, tiên tiến nhất thị trường, áp dụng các công nghệ hàng đầu về an ninh bảo mật để đảm bảo an toàn cho người sử dụng.
Cơ hội học hỏi nghiệp vụ ngân hàng.', 'Monday-Friday', '50-100 employees', 'Viet Nam' , Null)
go
select* from company
go
CREATE TABLE Jobs (
  JobID int identity (1,1) primary key,
  JobTitle nvarchar(200),
  JobType nvarchar(200),
  JobSalary nvarchar(200),
  RecruitmentQuota varchar(200),
  Location nvarchar(200),
  ExpInYears nvarchar(200),
  JobRequirement nvarchar(max),
  JobDescription nvarchar(max),
  CompanyID int references Company(CompanyID),
  JobBenefit nvarchar(max)
)
go
INSERT INTO Jobs (JobTitle,JobType, JobSalary, RecruitmentQuota, Location, ExpInYears, JobRequirement, JobDescription, CompanyID, JobBenefit)
VALUES ('Software Developer','Full-time', '70000-90000 USD', '5', 'New York, USA', '5', N'Yêu cầu chung:

Tốt nghiệp Đại học chính quy các chuyên ngành Công nghệ thông tin, Khoa học máy tính, Điện tử viễn thông, Công nghệ phần mềm, Hệ thống thông tin ... và/hoặc có chứng chỉ lập trình viên tương đương (Aptech Greenwich, ...).
Thành thạo tiếng Anh (TOEIC 450 trở lên hoặc tương đương).
Hiểu biết về quy trình phát triển phần mềm và quen thuộc với tư duy làm việc Agile.
Đối với ứng viên Junior:

Tối thiểu 02 năm kinh nghiệm làm việc tại các công ty, dự án về lập trình BackEnd.
Thành thạo ít nhất 01 trong các ngôn ngữ BackEnd (VD: Java).
Thành thạo, làm việc tốt với Spring framework: Spring Core, Spring Security, Spring Boots.
Thành thạo ít nhất 01 trong các loại database: Oracle, SQLserver, PostgreSQL, Mongodb ...
Có kinh nghiệm trong mảng tài chính ngân hàng là một lợi thế.
​Đối với ứng viên Senior: Bổ sung các điều kiện:

Tối thiểu 03 năm kinh nghiệm làm việc tại các công ty, dự án về lập trình BackEnd; trong đó, tối thiểu 01 năm kinh nghiệm làm việc với microservices.
Có kiến thức tốt về kiến trúc hệ thống; thông thuộc nhiều thiết kế phần mềm.
Hiểu biết sâu về các kỹ thuật/công nghệ: MySQL, Redis, MongoDB, PostgreSQL, Kafka …
Có khả năng tuning performance của ứng dụng, hệ thống.
Có kinh nghiệm phát triển, sử dụng cloud, FrontEnd là một lợi thế.', 
N'Junior BackEnd Developer:

Lập trình, phát triển các hệ thống, ứng dụng của Ngân hàng.
Phát triển hoặc phối hợp cùng các nhà cung cấp phát triển và triển khai các giải pháp CNTT.
Quản lý, phát triển dịch vụ tích hợp với các hệ thống core như: T24, WAY4, BPM, CRM, CIC ...
Quản lý, phát triển API trên API Gateway phục vụ tích hợp với các đối tác trong nước và quốc tế.
Nghiên cứu, thử nghiệm, triển khai áp dụng các xu hướng công nghệ mới vào việc phát triển: GraphQL, Docker Container (K8s), CICD, EventSourcing, CQRS, NoSQL ...
Duy trì hoạt động của các sản phẩm dịch vụ trong phạm vi quản lý.
Senior BackEnd Developer: Bổ sung các nhóm công việc sau:

Tham gia phân tích nghiệp vụ, đề xuất giải pháp, phương án triển khai nhằm cải tiến, nâng cao hiệu quả của các dự án trong quá trình làm việc.
Lên timeline công việc, chia tasks cho các thành viên trong nhóm, giám sát và hỗ trợ các thành viên hoàn thành đúng cam kết.
Dẫn dắt nhóm 03-06 nhân sự, giúp thành viên cùng phát triển và hoàn thành nhiệm vụ được giao
', 1, 
N'Mức lương cạnh tranh, hấp dẫn (Thưởng xếp loại thực hiện công việc 6 tháng/lần, thưởng sinh nhật ngân hàng, thưởng các ngày lễ tết trong năm…).
Chế độ phúc lợi cạnh tranh: Du lịch hàng năm, Khám sức khỏe định kì hàng năm; Gói bảo hiểm sức khỏe; Các hoạt động tri ân, chăm lo đời sống tinh thần CBNV và Thân nhân...
Môi trường làm việc chuyên nghiệp, thân thiện, cởi mở.
Được làm việc với các hệ thống hiện đại, tiên tiến nhất thị trường, áp dụng các công nghệ hàng đầu về an ninh bảo mật để đảm bảo an toàn cho người sử dụng.
Cơ hội học hỏi nghiệp vụ ngân hàng.');



INSERT INTO Jobs (JobTitle,JobType, JobSalary, RecruitmentQuota, Location, ExpInYears, JobRequirement, JobDescription, CompanyID, JobBenefit)
VALUES ('Front-end Developer','Full-time', '70000-90000 USD', '5', 'New York, USA', '3-5', N'Yêu cầu chung:

Tốt nghiệp Đại học chính quy các chuyên ngành Công nghệ thông tin, Khoa học máy tính, Điện tử viễn thông, Công nghệ phần mềm, Hệ thống thông tin ... và/hoặc có chứng chỉ lập trình viên tương đương (Aptech Greenwich, ...).
Thành thạo tiếng Anh (TOEIC 450 trở lên hoặc tương đương).
Hiểu biết về quy trình phát triển phần mềm và quen thuộc với tư duy làm việc Agile.
Đối với ứng viên Junior:

Tối thiểu 02 năm kinh nghiệm làm việc tại các công ty, dự án về lập trình BackEnd.
Thành thạo ít nhất 01 trong các ngôn ngữ BackEnd (VD: Java).
Thành thạo, làm việc tốt với Spring framework: Spring Core, Spring Security, Spring Boots.
Thành thạo ít nhất 01 trong các loại database: Oracle, SQLserver, PostgreSQL, Mongodb ...
Có kinh nghiệm trong mảng tài chính ngân hàng là một lợi thế.
​Đối với ứng viên Senior: Bổ sung các điều kiện:

Tối thiểu 03 năm kinh nghiệm làm việc tại các công ty, dự án về lập trình BackEnd; trong đó, tối thiểu 01 năm kinh nghiệm làm việc với microservices.
Có kiến thức tốt về kiến trúc hệ thống; thông thuộc nhiều thiết kế phần mềm.
Hiểu biết sâu về các kỹ thuật/công nghệ: MySQL, Redis, MongoDB, PostgreSQL, Kafka …
Có khả năng tuning performance của ứng dụng, hệ thống.
Có kinh nghiệm phát triển, sử dụng cloud, FrontEnd là một lợi thế.', 
N'Junior BackEnd Developer:

Lập trình, phát triển các hệ thống, ứng dụng của Ngân hàng.
Phát triển hoặc phối hợp cùng các nhà cung cấp phát triển và triển khai các giải pháp CNTT.
Quản lý, phát triển dịch vụ tích hợp với các hệ thống core như: T24, WAY4, BPM, CRM, CIC ...
Quản lý, phát triển API trên API Gateway phục vụ tích hợp với các đối tác trong nước và quốc tế.
Nghiên cứu, thử nghiệm, triển khai áp dụng các xu hướng công nghệ mới vào việc phát triển: GraphQL, Docker Container (K8s), CICD, EventSourcing, CQRS, NoSQL ...
Duy trì hoạt động của các sản phẩm dịch vụ trong phạm vi quản lý.
Senior BackEnd Developer: Bổ sung các nhóm công việc sau:

Tham gia phân tích nghiệp vụ, đề xuất giải pháp, phương án triển khai nhằm cải tiến, nâng cao hiệu quả của các dự án trong quá trình làm việc.
Lên timeline công việc, chia tasks cho các thành viên trong nhóm, giám sát và hỗ trợ các thành viên hoàn thành đúng cam kết.
Dẫn dắt nhóm 03-06 nhân sự, giúp thành viên cùng phát triển và hoàn thành nhiệm vụ được giao
', 1, 
N'Mức lương cạnh tranh, hấp dẫn (Thưởng xếp loại thực hiện công việc 6 tháng/lần, thưởng sinh nhật ngân hàng, thưởng các ngày lễ tết trong năm…).
Chế độ phúc lợi cạnh tranh: Du lịch hàng năm, Khám sức khỏe định kì hàng năm; Gói bảo hiểm sức khỏe; Các hoạt động tri ân, chăm lo đời sống tinh thần CBNV và Thân nhân...
Môi trường làm việc chuyên nghiệp, thân thiện, cởi mở.
Được làm việc với các hệ thống hiện đại, tiên tiến nhất thị trường, áp dụng các công nghệ hàng đầu về an ninh bảo mật để đảm bảo an toàn cho người sử dụng.
Cơ hội học hỏi nghiệp vụ ngân hàng.');
go
INSERT INTO Jobs (JobTitle,JobType, JobSalary, RecruitmentQuota, Location, ExpInYears, JobRequirement, JobDescription, CompanyID, JobBenefit)
VALUES ('Software Developer2','Full-time', '70000-90000 USD', '5', 'HoChiMinh, Quan 9', '5', N'Yêu cầu chung:

Tốt nghiệp Đại học chính quy các chuyên ngành Công nghệ thông tin, Khoa học máy tính, Điện tử viễn thông, Công nghệ phần mềm, Hệ thống thông tin ... và/hoặc có chứng chỉ lập trình viên tương đương (Aptech Greenwich, ...).
Thành thạo tiếng Anh (TOEIC 450 trở lên hoặc tương đương).
Hiểu biết về quy trình phát triển phần mềm và quen thuộc với tư duy làm việc Agile.
Đối với ứng viên Junior:

Tối thiểu 02 năm kinh nghiệm làm việc tại các công ty, dự án về lập trình BackEnd.
Thành thạo ít nhất 01 trong các ngôn ngữ BackEnd (VD: Java).
Thành thạo, làm việc tốt với Spring framework: Spring Core, Spring Security, Spring Boots.
Thành thạo ít nhất 01 trong các loại database: Oracle, SQLserver, PostgreSQL, Mongodb ...
Có kinh nghiệm trong mảng tài chính ngân hàng là một lợi thế.
​Đối với ứng viên Senior: Bổ sung các điều kiện:

Tối thiểu 03 năm kinh nghiệm làm việc tại các công ty, dự án về lập trình BackEnd; trong đó, tối thiểu 01 năm kinh nghiệm làm việc với microservices.
Có kiến thức tốt về kiến trúc hệ thống; thông thuộc nhiều thiết kế phần mềm.
Hiểu biết sâu về các kỹ thuật/công nghệ: MySQL, Redis, MongoDB, PostgreSQL, Kafka …
Có khả năng tuning performance của ứng dụng, hệ thống.
Có kinh nghiệm phát triển, sử dụng cloud, FrontEnd là một lợi thế.', 
N'Junior BackEnd Developer:

Lập trình, phát triển các hệ thống, ứng dụng của Ngân hàng.
Phát triển hoặc phối hợp cùng các nhà cung cấp phát triển và triển khai các giải pháp CNTT.
Quản lý, phát triển dịch vụ tích hợp với các hệ thống core như: T24, WAY4, BPM, CRM, CIC ...
Quản lý, phát triển API trên API Gateway phục vụ tích hợp với các đối tác trong nước và quốc tế.
Nghiên cứu, thử nghiệm, triển khai áp dụng các xu hướng công nghệ mới vào việc phát triển: GraphQL, Docker Container (K8s), CICD, EventSourcing, CQRS, NoSQL ...
Duy trì hoạt động của các sản phẩm dịch vụ trong phạm vi quản lý.
Senior BackEnd Developer: Bổ sung các nhóm công việc sau:

Tham gia phân tích nghiệp vụ, đề xuất giải pháp, phương án triển khai nhằm cải tiến, nâng cao hiệu quả của các dự án trong quá trình làm việc.
Lên timeline công việc, chia tasks cho các thành viên trong nhóm, giám sát và hỗ trợ các thành viên hoàn thành đúng cam kết.
Dẫn dắt nhóm 03-06 nhân sự, giúp thành viên cùng phát triển và hoàn thành nhiệm vụ được giao
', 2, 
N'Mức lương cạnh tranh, hấp dẫn (Thưởng xếp loại thực hiện công việc 6 tháng/lần, thưởng sinh nhật ngân hàng, thưởng các ngày lễ tết trong năm…).
Chế độ phúc lợi cạnh tranh: Du lịch hàng năm, Khám sức khỏe định kì hàng năm; Gói bảo hiểm sức khỏe; Các hoạt động tri ân, chăm lo đời sống tinh thần CBNV và Thân nhân...
Môi trường làm việc chuyên nghiệp, thân thiện, cởi mở.
Được làm việc với các hệ thống hiện đại, tiên tiến nhất thị trường, áp dụng các công nghệ hàng đầu về an ninh bảo mật để đảm bảo an toàn cho người sử dụng.
Cơ hội học hỏi nghiệp vụ ngân hàng.');
go
INSERT INTO Jobs (JobTitle,JobType, JobSalary, RecruitmentQuota, Location, ExpInYears, JobRequirement, JobDescription, CompanyID, JobBenefit)
VALUES ('Front-end Developer2','Full-time', '70000-90000 USD', '5', 'Ha Noi', '3', N'Yêu cầu chung:

Tốt nghiệp Đại học chính quy các chuyên ngành Công nghệ thông tin, Khoa học máy tính, Điện tử viễn thông, Công nghệ phần mềm, Hệ thống thông tin ... và/hoặc có chứng chỉ lập trình viên tương đương (Aptech Greenwich, ...).
Thành thạo tiếng Anh (TOEIC 450 trở lên hoặc tương đương).
Hiểu biết về quy trình phát triển phần mềm và quen thuộc với tư duy làm việc Agile.
Đối với ứng viên Junior:

Tối thiểu 02 năm kinh nghiệm làm việc tại các công ty, dự án về lập trình BackEnd.
Thành thạo ít nhất 01 trong các ngôn ngữ BackEnd (VD: Java).
Thành thạo, làm việc tốt với Spring framework: Spring Core, Spring Security, Spring Boots.
Thành thạo ít nhất 01 trong các loại database: Oracle, SQLserver, PostgreSQL, Mongodb ...
Có kinh nghiệm trong mảng tài chính ngân hàng là một lợi thế.
​Đối với ứng viên Senior: Bổ sung các điều kiện:

Tối thiểu 03 năm kinh nghiệm làm việc tại các công ty, dự án về lập trình BackEnd; trong đó, tối thiểu 01 năm kinh nghiệm làm việc với microservices.
Có kiến thức tốt về kiến trúc hệ thống; thông thuộc nhiều thiết kế phần mềm.
Hiểu biết sâu về các kỹ thuật/công nghệ: MySQL, Redis, MongoDB, PostgreSQL, Kafka …
Có khả năng tuning performance của ứng dụng, hệ thống.
Có kinh nghiệm phát triển, sử dụng cloud, FrontEnd là một lợi thế.', 
N'Junior BackEnd Developer:

Lập trình, phát triển các hệ thống, ứng dụng của Ngân hàng.
Phát triển hoặc phối hợp cùng các nhà cung cấp phát triển và triển khai các giải pháp CNTT.
Quản lý, phát triển dịch vụ tích hợp với các hệ thống core như: T24, WAY4, BPM, CRM, CIC ...
Quản lý, phát triển API trên API Gateway phục vụ tích hợp với các đối tác trong nước và quốc tế.
Nghiên cứu, thử nghiệm, triển khai áp dụng các xu hướng công nghệ mới vào việc phát triển: GraphQL, Docker Container (K8s), CICD, EventSourcing, CQRS, NoSQL ...
Duy trì hoạt động của các sản phẩm dịch vụ trong phạm vi quản lý.
Senior BackEnd Developer: Bổ sung các nhóm công việc sau:

Tham gia phân tích nghiệp vụ, đề xuất giải pháp, phương án triển khai nhằm cải tiến, nâng cao hiệu quả của các dự án trong quá trình làm việc.
Lên timeline công việc, chia tasks cho các thành viên trong nhóm, giám sát và hỗ trợ các thành viên hoàn thành đúng cam kết.
Dẫn dắt nhóm 03-06 nhân sự, giúp thành viên cùng phát triển và hoàn thành nhiệm vụ được giao
', 2, 
N'Mức lương cạnh tranh, hấp dẫn (Thưởng xếp loại thực hiện công việc 6 tháng/lần, thưởng sinh nhật ngân hàng, thưởng các ngày lễ tết trong năm…).
Chế độ phúc lợi cạnh tranh: Du lịch hàng năm, Khám sức khỏe định kì hàng năm; Gói bảo hiểm sức khỏe; Các hoạt động tri ân, chăm lo đời sống tinh thần CBNV và Thân nhân...
Môi trường làm việc chuyên nghiệp, thân thiện, cởi mở.
Được làm việc với các hệ thống hiện đại, tiên tiến nhất thị trường, áp dụng các công nghệ hàng đầu về an ninh bảo mật để đảm bảo an toàn cho người sử dụng.
Cơ hội học hỏi nghiệp vụ ngân hàng.');
go
CREATE TABLE JobSkill (
	JobSkillID int identity (1,1) unique,
	SkillID  int references Skills(SkillID),
	JobID int references Jobs(JobID),
	primary key ( SkillID, JobID)
	)
go
select * from jobs
go
CREATE TABLE Applicant (
  ApplicantID int identity (1,1) primary key,
  ApplicantTitle varchar(200),
  ApplicantEmail varchar(200),
  ApplicantPassword varchar(200),
  ApplicantName varchar(200),
  ApplicantExpYears varchar(200),
  ApplicantNationality varchar(200),
  ApplicantAddress varchar(200),
  ApplicantGender varchar(200),
  ApplicantPhonenumber varchar(200),
  ApplicantDOB date,
  ApplicantPersonalLink varchar(200),
  ApplicantAvatar nvarchar(max) default null
)
go
INSERT INTO Applicant (ApplicantEmail,ApplicantTitle, ApplicantPassword, ApplicantName, ApplicantExpYears, ApplicantNationality, ApplicantAddress, ApplicantGender, ApplicantPhonenumber, ApplicantDOB,ApplicantPersonalLink,ApplicantAvatar)
VALUES ('a1@gmail.com','Mobile application developer', '1', 'John Doe', '5', 'American', '123 Main St, New York, NY', 'Male', '123-456-7890', '1980-01-01','https://www.facebook.com/phuc.master.90/','Friday, 10 May 2024 082820i28aA.D.e20.jpA.D.');
INSERT INTO Applicant (ApplicantEmail,ApplicantTitle, ApplicantPassword, ApplicantName, ApplicantExpYears, ApplicantNationality, ApplicantAddress, ApplicantGender, ApplicantPhonenumber, ApplicantDOB,ApplicantPersonalLink,ApplicantAvatar)
VALUES ('b2@gmail.com','Mobile application developer2', '1', 'John Doe2', '5', 'American', '123 Main St, New York, NY', 'Male', '123-456-7890', '1980-01-01','https://www.facebook.com/profile.php?id=100009132017523','Friday, 10 May 2024 082820i28aA.D.e20.jpA.D.');

go 
select * from Applicant
go
CREATE TABLE JobStatus (
  JobID int references Jobs(jobID),
  ApplicantID int references Applicant(applicantID),
  IsFavorite bit default 0,
  IsApplied bit default 0, 
  Primary key(JobID,ApplicantID)
)
go
CREATE TABLE ApplicantsOfCompany (
  CompanyID int references Company(companyID),
  ApplicantID int references Applicant(applicantID),
  IsFavorite bit default 0 ,
  IsAccepted bit default 0,
  JobID int references Jobs(JobID)
  primary key (ApplicantID,CompanyID ,JobID)
)
go
CREATE TABLE Aboutme (
	AboutmeID int identity (1,1) primary key,
	AboutmeDetails nvarchar(2000),
	ApplicantID int references Applicant(ApplicantID)
	)
go
INSERT INTO Aboutme (AboutmeDetails, ApplicantID)
VALUES ('I am a software developer with 5 years of experience.', 1);
INSERT INTO Aboutme (AboutmeDetails, ApplicantID)
VALUES ('I am a software developer with 8 years of experience.', 2);
go

go
CREATE TABLE ApplicantSkill (
	ApplicantSkillID int identity (1,1) ,
	SkillID  int references Skills(SkillID),
	ApplicantID int references Applicant(ApplicantID)
	primary key ( SkillID, ApplicantID)
	)
go
INSERT INTO ApplicantSkill (SkillID, ApplicantID)
VALUES (1, 1), 
       (2, 1), 
       (3, 1),
	   (1, 2), 
       (2, 2), 
       (3, 2);
select * from ApplicantSkill
go
CREATE TABLE Education (
	EducationID int identity (1,1) primary key,
	School nvarchar(200),
	Major nvarchar(200),
	FromMonth nvarchar(200),
	FromYear nvarchar(200),
	ToMonth nvarchar(200),
	ToYear nvarchar(200), 
	AddDetails nvarchar(2000),
	ApplicantID int references Applicant(ApplicantID)
	)
go
INSERT INTO Education (School, Major, FromMonth, FromYear,ToMonth,ToYear, AddDetails, ApplicantID)
VALUES ('Hanoi University', 'Computer Science', '12','2010','5','2024', 'I graduated with a GPA of 3.5.', 1);
INSERT INTO Education (School, Major, FromMonth, FromYear,ToMonth,ToYear, AddDetails, ApplicantID)
VALUES ('HoChiMinh University', 'Computer Science', '12','2010','5','2024', 'I graduated with a GPA of 3.5.', 2);
go
CREATE TABLE WorkExperience (
	WorkExperienceID int identity (1,1) primary key,
	JobTitle nvarchar(200),
	CompanyName nvarchar(200),

	FromMonth nvarchar(200),
	FromYear nvarchar(200),
	ToMonth nvarchar(200),
	ToYear nvarchar(200), 

	WorkDetails nvarchar(2000),
	ProjectDetails nvarchar(2000),
	ApplicantID int references Applicant(ApplicantID)
	)
go
INSERT INTO WorkExperience (JobTitle, CompanyName, FromMonth, FromYear,ToMonth,ToYear, WorkDetails, ProjectDetails, ApplicantID)
VALUES ('Software Developer', 'ABC Company', '12','2010','5','2024', 'I worked on developing web applications.', 'I led a project on developing a CRM system.', 1),
       ('Data Analyst', 'XYZ Company', '12','2010','5','2024', 'I worked on analyzing customer data.', 'I worked on a project on customer segmentation.', 1);
INSERT INTO WorkExperience (JobTitle, CompanyName, FromMonth, FromYear,ToMonth,ToYear, WorkDetails, ProjectDetails, ApplicantID)
VALUES ('Software Developer2', 'ABC Company', '12','2010','5','2024', 'I worked on developing web applications.', 'I led a project on developing a CRM system.', 2),
       ('Data Analyst2', 'XYZ Company', '12','2010','5','2024', 'I worked on analyzing customer data.', 'I worked on a project on customer segmentation.', 2);
go
 CREATE TABLE PersonalProject (
	PersonalProjectID int identity (1,1) primary key,
	ProjectName nvarchar(200),
	FromMonth nvarchar(200),
	FromYear nvarchar(200),
	ToMonth nvarchar(200),
	ToYear nvarchar(200), 
	ShortDescription nvarchar(2000),
	ProjectURL nvarchar(200),
	ApplicantID int references Applicant(ApplicantID)
	)
go
INSERT INTO PersonalProject (ProjectName, FromMonth, FromYear,ToMonth,ToYear, ShortDescription, ProjectURL, ApplicantID)
VALUES ('Personal Website', '12','2010','5','2024', 'I developed a personal website using HTML, CSS, and JavaScript.', 'www.example.com', 1),
       ('Data Visualization Project', '12','2010','5','2024', 'I worked on a project on visualizing customer data using Python.', 'www.example.com', 1);
go
CREATE TABLE Post (
PostID int identity (1,1) primary key,
  ApplicantID int references Applicant(applicantID),
  PostContent nvarchar(max)
)
Insert Into Post (ApplicantID , PostContent)
VALUES (1, 'Tìm việc cho sinh viên thủ đức full time thứ 2 đến thứ 7 tối'),
		(1,'Nữ 2k4 cần tìm việc bao ăn ở'),
		(1,'Nam 2k cần tìm việc ca sáng có kinh nghiệm pha chế 2 năm');
Insert Into Post (ApplicantID , PostContent)
VALUES (2, 'Tìm việc cho sinh viên thủ đức full time thứ 2 đến thứ 7 sáng'),
		(2,'Nữ 2k4 cần tìm việc bao ăn ở'),
		(2,'Nam 2k cần tìm việc ca sáng có kinh nghiệm pha chế 3 năm');

go
Drop table Dateinterview
create table DateInterview (
DateID int identity (1,1) primary key,
ApplicantID int references Applicant(applicantID),
CompanyID int references Company(companyID),
DateInterview varchar(max)
)
