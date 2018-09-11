create database IceShops
use IceShops
go

create table Seller (
	id int primary key identity,
	FirstName varchar(25) not null,
	LastName varchar(25) not null)
go

create table Buyer (
	id int primary key identity,
	FirstName varchar(25) not null,
	LastName varchar(25) not null)
go

create table Product (
	id int primary key identity,
	productName varchar(50) not null,
	Quantity int null)
go

create table Sales (
	DateOfSold date not null,
	id_Seller int not null,
	foreign key (id_Seller) references Seller(id),
	id_Buyer int not null,
	foreign key (id_Buyer) references Buyer(id),
	id)
