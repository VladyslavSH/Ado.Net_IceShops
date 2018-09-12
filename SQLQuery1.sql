create database TicketShops
use TicketShops
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
	id_Product int not null,
	foreign key (id_Product) references Product(id))
go

insert into Seller values 
	('Fedor', 'Lomonosov'),
	('Sergey', 'Kravchenko'),
	('Alexander', 'Snijko'),
	('Jora', 'Kornev')
go

insert into Buyer values
	('Katia', 'Prusnikina'),
	('Anastasia', 'Slobkina'),
	('Egor', 'Chegurko'),
	('Jora', 'Cheberyachko')
go

insert into Product values
	('VIP', 50),
	('Balcony', 35),
	('First row', 33),
	('Middle row', 100),
	('Last row', 150)
go

truncate table product