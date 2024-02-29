SELECT * FROM users

CREATE TABLE empdata
(
	id INT PRIMARY KEY IDENTITY(1,1),
	emp_id VARCHAR(MAX) NULL,
	firstname VARCHAR(MAX) NULL,
	middlename VARCHAR(MAX) NULL,
	lastname VARCHAR(MAX) NULL,
	empnum VARCHAR(MAX) NULL,
	birthdate DATE NULL,
	project VARCHAR(MAX) NULL,
	birthdate DATE NULL,
	startdate VARCHAR(MAX) NULL,
	enddate VARCHAR(MAX) NULL,
	image VARCHAR(MAX) NULL,
	contactname VARCHAR(MAX) NULL,
	contactnum VARCHAR(MAX) NULL,
	contactadd VARCHAR(MAX) NULL
)

SELECT * FROM empdata