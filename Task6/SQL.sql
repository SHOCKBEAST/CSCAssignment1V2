use master
create database CSC_Task6
use CSC_Task6

--Creation of Tables--
create table Customer(
CustomerNo int IDENTITY(1,1) not null,
CustomerID varchar(255) not null,
CustomerEmail varchar(255) not null
primary key (CustomerID))

create table Subscription(
SubNo int IDENTITY(1,1) not null,
SubID varchar(255) not null,
CustomerID varchar(255) not null,
PlanID varchar(255) not null,	
primary key (SubID))


--Alter table--
alter table Subscription
add foreign key (CustomerID) references Customer(CustomerID)

select * from Customer
select * from Subscription
