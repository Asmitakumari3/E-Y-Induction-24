create database empDB_SP
use empDB_SP

create table deptInfo
(
	deptNo int primary key,
	deptName varchar(20),
	deptCity varchar(20)
)

insert into deptInfo values(10,'HR','Mumbai')
insert into deptInfo values(20,'IT','Kolkatta')
insert into deptInfo values(30,'Sales','Pune')
insert into deptInfo values(40,'Accounts','New York')
insert into deptInfo values(50,'Transport','Paris')

--1. SP to select all the data
create procedure proc_AllDept
as
begin
	select * from deptInfo
end

exec proc_AllDept

--2. SP to select data based on DeptNo
create procedure proc_deptInfo(@dNo int)
as
begin
	select deptCity from deptInfo where deptNo = @dNo
end

exec proc_deptInfo 40


--3. SP to select data based on DeptCity
create procedure proc_depByCity(@city varchar(20))
as
begin
	select * from deptInfo where deptCity = @city
end

exec proc_depByCity 'Mumbai'

select * from deptInfo
--4. SP to insert a new dept
create procedure proc_NewDept(@deptNo int, @deptName varchar(20),@deptCity varchar(20))
as
begin
	insert into deptInfo values(@deptNo,@deptName,@deptCity)
end

exec proc_NewDept 60,'Cafe','Mumbai'

--5. SP to delete the dept by deptNo
create procedure proc_deleteDept(@deptno int)
as
begin
	delete from deptInfo where deptNo = @deptno
end

exec proc_deleteDept 20

--6. SP to update deptName by deptNo
create procedure proc_EditDeptName(@deptNo int, @newDeptName varchar(20))
as
begin
	update deptInfo set deptName = @newDeptName where deptNo = @deptNo
end

exec proc_EditDeptName 30,'Revenue'

select * from deptInfo


--7. SP with OUT parameter
create procedure proc_newDept_2(@deptName varchar(20),
					          @deptCity varchar(20),
							  @deptNo int out)
					as
					begin
					
						set @deptNo = (select max(deptNo) + 1 from deptInfo)
						insert into deptInfo values(@deptNo,@deptName,@deptCity)

					end



--1. you want me to give you task to create procedures again for practice
--2. start ADO.net and execute SP



























