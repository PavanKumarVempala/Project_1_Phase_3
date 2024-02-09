create database Ecommerce

use Ecommerce

create table Orders(Oid int primary key,Odate date,Oaddress varchar(40))
create table Products(Pid int primary key,Pname varchar(20),Pprice float, Oid int, foreign key (Oid) references Orders(Oid))

insert into Orders values(1,'10-02-2024','vijayawada')
insert into Products values(1,'laptop',12589,1)

select * from Orders
select * from Products