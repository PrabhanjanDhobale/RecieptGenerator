create database GamakaAI;

use GamakaAI;

-- ---------------------------------------------------------------------------------------------------------------
create table Login(username varchar(50) primary key, password varchar(50)); 

create table StudentDetails(id bigint primary key, name varchar(100), address varchar(150), skills varchar(100), class_reference varchar(50), qualification varchar(50),
year_of_passing varchar(50), mode_of_class varchar(50) default "Offline", pri_contact_number varchar(15), another_contact_number varchar(15), emailid varchar(50),
isAdmitted varchar(10), work_experience varchar(50), year_of_exprience varchar(50), course varchar(50), time_preference varchar(50), todayDate varchar(30)); 

create table Courses(id int auto_increment primary key, name varchar(50), fees int);

create table Payments(id int auto_increment primary key, studentID bigint, courseID int, installment varchar(20), 
paidfees int, remainingfees int, nextInstallment varchar(50), todayDate varchar(50),
foreign key(studentID) references StudentDetails(id), foreign key(courseID) references Courses(id)
);

create table Certificate(id int auto_increment primary key, studentID bigint, courseID int, todayDate varchar(50),
foreign key(studentID) references StudentDetails(id), foreign key(courseID) references Courses(id)
);

create table Receipt(id int auto_increment primary key, studentID bigint, paymentID int, todayDate varchar(50),
foreign key(paymentID) references Payments(id), foreign key(studentID) references StudentDetails(id)
);

desc login;
DESC StudentDetails;
desc Courses;
desc Payments;
desc Certificate;
desc Receipt;


-- ---------------------------------------------------------------------------------------------------------
drop table StudentDetails;

truncate table StudentDetails;

-- ------------------------------------------------------------------------------------------------------------------

insert into Login values('gamakaai', 'gamakaai@123'); 
insert into StudentDetails(id) values(2210201111);
insert into StudentDetails(id) values(2210201112);
insert into StudentDetails(id) values(2210201113);
insert into StudentDetails(id) values(2210201114);
insert into StudentDetails(id) values(2210201115);

select * from Login;
select * from StudentDetails;
select * from StudentDetails order by id DESC limit 1;


