CREATE DATABASE users;

USE users;

CREATE TABLE customer_table (
	userID int IDENTITY(1,1) primary key,
	username varchar(50) not null,
	email varchar(50) not null,
	pwd varchar (50) not null,
	acctype varchar(20) not null
)

drop table customer_table
drop procedure user_acc
drop procedure UpdateUsers

---procedure---
CREATE PROCEDURE user_acc
	@username varchar (50),
	@email varchar(50),
	@pwd varchar (50),
	@acctype Varchar(50)
AS
INSERT INTO customer_table(username, email, pwd, acctype)
			VALUES(@username, @email, @pwd, @acctype)

CREATE PROCEDURE UpdateUsers
	@userID int,
	@username varchar (50),
	@email varchar (50),
	@pwd varchar (50),
	@acctype varchar (20)
AS
BEGIN
	UPDATE customer_table 
	SET username = @username, pwd = @pwd
	WHERE userID = @userID;
END;


CREATE PROCEDURE DeleteUsers
	@userid int,
	@username varchar(50),
	@email varchar (50),
	@pwd varchar(50),
	@acctype varchar(20)
AS
BEGIN
	DELETE FROM customer_table 
	WHERE userID = @userID and username = @username and pwd = @pwd and acctype = @acctype;
END;

---view--
CREATE VIEW ViewUsers AS
SELECT
	userID,
	username,
	email,
	acctype
FROM
	customer_table

---alter---


----------------
SELECT * FROM customer_table

INSERT INTO customer_table(username, email, pwd, acctype)
	VALUES ('admin','admin@gmail.com', 'admin', 'admin')

INSERT INTO	customer_table(username, email, pwd, acctype)
	VALUES ('cust', 'cust@gmail.com', 'customer', 'Customer')


