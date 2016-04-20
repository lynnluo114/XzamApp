CREATE TABLE USER_TABLE 
(
Id int NOT NULL PRIMARY KEY,
Username varchar (20) NOT NULL,
Password varchar (20) NOT NULL,
Fullname varchar (50),
)
go
  insert into user_table values(1,'admin','password', 'Administrator')