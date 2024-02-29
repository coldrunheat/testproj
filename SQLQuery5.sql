CREATE TABLE userdb
(
	id INT PRIMARY KEY IDENTITY(1,1),
	username VARCHAR(MAX) NOT NULL,
	password VARCHAR(MAX) NOT NULL,
	date_register DATE NOT NULL
)

SELECT * FROM userdb

CREATE TABLE empdatadb
(
	emp_id VARCHAR(12) NOT NULL PRIMARY KEY,
	empfirstname VARCHAR(MAX) NOT NULL,
	empmiddlename VARCHAR(MAX) NOT NULL,
	emplastname VARCHAR(MAX) NOT NULL,
	empcnum VARCHAR(MAX) NOT NULL,
	empbirthdate DATE NOT NULL,
	empaddress VARCHAR(MAX) NOT NULL,
	empproject DATE NOT NULL,
	empstartdate DATE NOT NULL,
	empenddate VARCHAR(MAX) NOT NULL,
	image VARCHAR(MAX) NOT NULL,
	contactname VARCHAR(MAX) NOT NULL,
	contactnum VARCHAR(MAX) NOT NULL,
	contactadd VARCHAR(MAX) NOT NULL
)

SELECT * FROM empdatadb


