use ThemePark;

create table Purchases(
	ticketId varchar(10) primary key not null,
	purchtime varchar(10) not null,
	purchdate varchar(12) not null,
	totVal float not null
);

create table Events(
	eventID varchar(10) primary key not null,
	eventName varchar(50) not null,
	price float not null,
	maintenance int not null
);

create table ticketDetails(
	ticketId varchar(10) not null,
	eventId varchar(10) not null,
	FOREIGN KEY (ticketId) REFERENCES Purchases(ticketId),
	FOREIGN KEY (eventId) REFERENCES Events(eventID),
);

create table Employees(
	Emp_id varchar(10) primary key not null,
	Emp_fname varchar (20),
	Emp_lname varchar (10),
	Emp_add varchar(100),
	phone varchar(10)
);

create table Users(
	username varchar(10) primary key not null,
	pwd varchar (250),
	user_type int,
	empo_id varchar(10),
	FOREIGN KEY (emp_id) REFERENCES Employees(Emp_id)
);

Insert into Purchases values('S0001','9.00AM','2016-12-04',245.0);
Insert into Purchases values('S0002','6.00AM','2016-12-04',245.0);
Insert into Purchases values('S0003','7.00AM','2016-12-04',245.0);

Insert into Events values('Ses001','Sesam Street - When I Grow Up',20.0,50);
Insert into Events values('Ses002','Sesam Street - Spaghetti Space Chase',25.0,40);
Insert into Events values('Ses003','Sesam Street - DriveThrough New Yoke',25.0,25);
Insert into Events values('Sci003','Sci-Fi World - TRANSFORMERS 3D Battle',40.0,35);
Insert into Events values('Sci002','Sci-Fi World - BattlestarGalactica',30.0,20);
Insert into Events values('Sci001','Sci-Fi World - Lights, Camera, Action!',25.0,60);
Insert into Events values('Srk001','Shrek - Shrek 4-D Adventure',25.0,100);
Insert into Events values('Srk002','Shrek - Puss in Boots’ Giant Journey',30.0,30);
Insert into Events values('Srk003','Shrek - Enchanted Airways',25.0,40);

insert into ticketDetails values('S0001','Ses001');
insert into ticketDetails values('S0001','Ses002');
insert into ticketDetails values('S0001','Ses003');
insert into ticketDetails values('S0001','Sci001');
insert into ticketDetails values('S0001','Sci002');
insert into ticketDetails values('S0001','Sci003');
insert into ticketDetails values('S0001','Srk001');
insert into ticketDetails values('S0001','Srk002');
insert into ticketDetails values('S0001','Srk003');

Insert into Employees values('Emp001','Janith','Ganewatta','Galle',772921081);
Insert into Employees values('Emp002','Ashan','Pro','Maharagama',777123123);

Insert into Users values('janith','123456',1,'Emp001');
Insert into Users values('ashan','789456',2,'Emp002');

select * from ticketDetails;
select * from Purchases;
select * from Users;

Delete from Users where username='janith';

drop table Users;

SELECT TOP 1 ticketId FROM Purchases ORDER BY ticketId DESC; 

select username from Users where username='janith' AND pwd='123456';

select eventId from ticketDetails  where ticketId='S0001';

select sum(totVal) from Purchases;

delete from Users where username=