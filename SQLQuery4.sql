CREATE TABLE empdata
(
	emp_id VARCHAR(12) NOT NULL PRIMARY KEY,
	empfirstname VARCHAR(MAX) NOT NULL,
	empmiddlename VARCHAR(MAX) NOT NULL,
	emplastname VARCHAR(MAX) NOT NULL,
	empcnum VARCHAR(MAX) NOT NULL,
	empbirthdate DATE NOT NULL,
	empaddress VARCHAR(MAX) NOT NULL,
	empproject VARCHAR(MAX) NOT NULL,
	empstartdate VARCHAR(MAX) NOT NULL,
	empenddate VARCHAR(MAX) NOT NULL,
	image VARCHAR(MAX) NOT NULL,
	contactname VARCHAR(MAX) NOT NULL,
	contactnum VARCHAR(MAX) NOT NULL,
	contactadd VARCHAR(MAX) NOT NULL
)

SELECT * FROM empdata