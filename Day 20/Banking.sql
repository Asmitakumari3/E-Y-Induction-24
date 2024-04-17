create database bankingDB_EF

use bankingDB_EF

create table branchInfo
(
	branchNo int primary key,
	branchName varchar(20),
	branchLocation varchar(20)
)
insert into branchInfo values(10,'Salt Lake','Kolkatta')
insert into branchInfo values(20,'Hi-Tech','Hyderabad')
insert into branchInfo values(30,'Dadar','Mumbai')

create table accountsInfo
( 
	accNo int primary key,
	accName varchar(20),
	accType varchar(20),
	accBalance bigint,
	accIsActive bit,
	accBranch int,
	constraint fk_accBranch foreign key(accBranch) references branchInfo
	)
insert into accountsInfo values(1,'Ravi','Savings',6000,1,10)
insert into accountsInfo values(2,'Sumit','Savings',16000,0,20)
insert into accountsInfo values(3,'Arun','PF',63000,1,10)
insert into accountsInfo values(4,'Mohit','Current',26000,1,10)
insert into accountsInfo values(5,'Payal','Savings',3000,1,30)
insert into accountsInfo values(6,'Navya','Savings',33000,1,30)
insert into accountsInfo values(7,'Hemali','Savings',12000,1,10)
insert into accountsInfo values(8,'Suresh','PF',65000,1,10)
insert into accountsInfo values(9,'Karthik','Current',12000,1,10)
insert into accountsInfo values(10,'Rohit','Current',56000,0,10)
insert into accountsInfo values(11,'Manish','Savings',34000,1,20)
insert into accountsInfo values(12,'Sachin','Savings',66000,1,20)
insert into accountsInfo values(13,'Piyali','PF',99000,1,10)
insert into accountsInfo values(14,'Riya','Savings',123000,1,10)
insert into accountsInfo values(15,'Jiya','Savings',40000,1,20)
insert into accountsInfo values(16,'Mahesh','PF',88000,0,10)

