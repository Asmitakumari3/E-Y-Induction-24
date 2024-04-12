select * from EmployeeInfo

update EmployeeInfo set empSal = empSal + 300

select * from loginInfo

create table loginInfo(userName varchar(20) primary key,password varchar(20))
insert into loginInfo values('Nikhil','Nik@1234')
insert into loginInfo values('Rahul','Nik@1234')
insert into loginInfo values('Akshay','Nik@1234')
insert into loginInfo values('Jitesh','Nik@1234')
insert into loginInfo values('Shraddha','Nik@1234')

select count(*) from loginInfo where USerName='Nikhil' and password = 'Nik@1234'

select count(*) from loginInfo where userNAME=@uName and password = @pwd