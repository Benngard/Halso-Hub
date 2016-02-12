CREATE TABLE Activity
(
	Name			varchar(255) 	NOT NULL,
	Description		text,
	Points 			int				DEFAULT 0,
	Time			int,
	PRIMARY KEY (Name)
);

CREATE TABLE Mood
(
	Type			varchar(255)	NOT NULL,
	PRIMARY KEY (Type)
);

CREATE TABLE CurrentMood
(
	Type			varchar(255)	NOT NULL,
	PRIMARY KEY (Type)
);

CREATE TABLE CurrentMood
(
	Type			varchar(255)	NOT NULL,
	PRIMARY KEY (Type)
);

CREATE TABLE Trophy
(
	Name			varchar(255)	NOT NULL,
	Description		text,
	Quality			varchar(6)		NOT NULL,
	PRIMARY KEY (Name),
	CHECK (Quality='Bronze' OR Quality='Silver' OR Quality='Gold')
);

CREATE TABLE User
(
	Name			varchar(255)	NOT NULL,
	PRIMARY KEY (Name)
);

CREATE TABLE Challenge
(
	Name			varchar(255)	NOT NULL,
	Description		text,
	StartTime		int,
	EndTime			int,
	PRIMARY KEY (Name)
);