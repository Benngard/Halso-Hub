CREATE TABLE `halso_hub`.Activity
(
	Name			varchar(255) 	NOT NULL,
	Description		text,
	Points 			int				DEFAULT 0,
	Time			int,
	PRIMARY KEY (Name),
    
    CONSTRAINT positiveNr
		CHECK (Points >= 0)
);

CREATE TABLE `halso_hub`.Mood
(
	Type			varchar(255)	NOT NULL,
	PRIMARY KEY (Type)
);

CREATE TABLE `halso_hub`.Trophy
(
	Name			varchar(255)	NOT NULL,
	Description		text,
	Quality			varchar(6)		NOT NULL,
	PRIMARY KEY (Name),
	CHECK (Quality='Bronze' OR Quality='Silver' OR Quality='Gold')
);

CREATE TABLE `halso_hub`.Users
(
	Name			varchar(255)	NOT NULL,
	PRIMARY KEY (Name)
);

CREATE TABLE `halso_hub`.Challenge
(
	Name			varchar(255)	NOT NULL,
	Description		text,
	StartTime		text,
	EndTime			text,
	PRIMARY KEY (Name)
);