# NoteTaker
This application can be used to take down simple notes, each note has a title and content. These notes are stored in an SQL database which can be simply connected using a connection string, from there a database handler class will communicate with the database using parameterized queries. A modern GUI has also been developed using a windows form to ensure easy accessibility for any user.

The purpose of this application was to provide me with some C# programming experience, this is my first ever application written in C#.

<p align="center">
    <b>GUI Design:</b> 
</p>

![alt text](https://i.imgur.com/6xNAz07.png)

# Prerequisites
* MS SQL Database

# Installation
1. Create a new database or use an existing one
2. Create a table called Notes
3. Run this query in order to create the table needed for the application:

CREATE TABLE Notes (
	ID int NOT NULL IDENTITY(1,1),
	Title varchar(255) NOT NULL,
	Content varchar(1000),
	PRIMARY KEY (ID)
);
