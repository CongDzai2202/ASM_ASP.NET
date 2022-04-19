create database ShopOnline
go
use ShopOnline
go
create table Accounts
(
	AccountID int not null primary key,
	Phone varchar(12) not null,
	Email nvarchar(100) not null,
	Pass nvarchar(100) not null,
	Salt nchar(10),
	Active bit,
	FullName nvarchar(150),
	RoleID int,
	foreign key (RoleID) references Roles(RoleID)
)
create table Categories
(
	CatID int not null primary key,
	CatName nvarchar(250),
	Descripstion nvarchar(Max),
	ParentID int,
	Levels int,
	Orderring int,
	Publicshed bit,
	Img nvarchar(250),
	Title nvarchar(250),
	Alias nvarchar(250),
	MetaDesc nvarchar(250),
	MetaKey nvarchar(250),
	SchemaMarup nvarchar(Max),
)

create table Customers
(
	CustomerID int primary key,
	FullName nvarchar(250),
	Avatar nvarchar(250),
	Addresss nvarchar(250),
	Email nvarchar(250),
	Phone varchar(12),
	LocationID int,
	Distric int,
	Ward int,
	CreateDate Datetime,
	Pass nvarchar(50),
	LastLogin datetime,
	Active bit,
	foreign key (LocationID) references Location(LocationID),
)
create table Location 
(
	LocationID int not null Primary key,
	Name nvarchar(100),
	Tipe nvarchar(20),
	Slug nvarchar(100),
	NameWithType nvarchar(250),
	PathWithType nvarchar(250),
	ParentCode int,
	Levels int,

)
create table Orders
(
	OrderID int not null primary key,
	CustomerID int,
	OrderDate datetime,
	ShipDate datetime,
	TransactStatusID int ,
	Deleted bit,
	Paid bit,
	PaymentDate datetime,
	PaymentID int,
	Note nvarchar(max),
	foreign key (CustomerID) references Customers(CustomerID),
	foreign key (TransactStatusID) references TransactStatus(TransactStatusID)
)
create table TransactStatus
(
	TransactStatusID int not null Primary key,
	Statuss bit,
	Descriptions nvarchar(100)

)
create table OrderDetails
(
	 OrderDetailID int not null primary key,
	 OrderID int,
	 OrderNumber int,
	 Quantity int,
	 Discount int,
	 Total int,
	 ShipDate datetime,
	 foreign key (OrderID) references Orders(OrderID)
)
create table Products
(
	ProductID int not null primary key,
	ProductName nvarchar(255),
	ShortDesc nvarchar(255),
	Descriptions nvarchar(max),
	CatID int,
	Price int,
	Discount int,
	Thumb nvarchar(255),
	Video nvarchar(255),
	DateCreated datetime,
	DateModified datetime,
	BestSellers bit,
	HomeFlag bit,
	Active bit,
	Tags nvarchar(max),
	Title nvarchar(255),
	Alias nvarchar(255),
	MetaDesc nvarchar(255),
	MetaKey nvarchar(255),
	UnitslnStock int,
	foreign key (CatID) references Categories(CatID)
)
create table Roles
(
	RoleID int not null primary key,
	RoleName nvarchar(100),
	Descriptions nvarchar(100),

)
 
 