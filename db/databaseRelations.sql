CREATE TABLE GoodFor
(
	moodType			varchar(255)	NOT NULL,
	activityName		varchar(255)	NOT NULL,
	PRIMARY KEY (moodType, activityName),
	FOREIGN KEY (moodType) REFERENCES Mood(type),
	FOREIGN KEY (activityName) REFERENCES Activity(name)
);

CREATE TABLE ActivityCompleted
(
	userName			varchar(255)	NOT NULL,
	activityName		varchar(255)	NOT NULL,
	PRIMARY KEY (userName, activityName),
	FOREIGN KEY (userName) REFERENCES User(name),
	FOREIGN KEY (activityName) REFERENCES Activity(name)
);

CREATE TABLE OnGoingActivity
(
	userName			varchar(255)	NOT NULL,
	activityName		varchar(255)	NOT NULL,
	PRIMARY KEY (userName, activityName),
	FOREIGN KEY (userName) REFERENCES User(name),
	FOREIGN KEY (activityName) REFERENCES Activity(name)
);