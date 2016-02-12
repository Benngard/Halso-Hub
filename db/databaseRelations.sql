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

CREATE TABLE ActivityRewards
(
	trophyName			varchar(255)	NOT NULL,
	activityName		varchar(255)	NOT NULL,
	PRIMARY KEY (trophyName, activityName),
	FOREIGN KEY (trophyName) REFERENCES Trophy(name),
	FOREIGN KEY (activityName) REFERENCES Activity(name)
);

CREATE TABLE ChallengeRequires
(
	challengeName			varchar(255)	NOT NULL,
	activityName		varchar(255)	NOT NULL,
	PRIMARY KEY (challengeName, activityName),
	FOREIGN KEY (challengeName) REFERENCES Challenge(name),
	FOREIGN KEY (activityName) REFERENCES Activity(name)
);

CREATE TABLE EarnedTrophy
(
	userName			varchar(255)	NOT NULL,
	trophyName		varchar(255)	NOT NULL,
	PRIMARY KEY (userName, trophyName),
	FOREIGN KEY (userName) REFERENCES User(name),
	FOREIGN KEY (trophyName) REFERENCES Trophy(name)
);

CREATE TABLE UserMood
(
	userName			varchar(255)	NOT NULL,
	currentMoodType		varchar(255)	NOT NULL,
	PRIMARY KEY (userName, currentMoodType),
	FOREIGN KEY (userName) REFERENCES User(name),
	FOREIGN KEY (currentMoodType) REFERENCES CurrentMood(type)
);

CREATE TABLE ChallengeRewards
(
	trophyName			varchar(255)	NOT NULL,
	challengeName		varchar(255)	NOT NULL,
	PRIMARY KEY (trophyName, challengeName),
	FOREIGN KEY (trophyName) REFERENCES Trophy(name),
	FOREIGN KEY (challengeName) REFERENCES Challenge(name)
);

CREATE TABLE OnGoingChallenge
(
	userName			varchar(255)	NOT NULL,
	challengeName		varchar(255)	NOT NULL,
	PRIMARY KEY (userName, challengeName),
	FOREIGN KEY (userName) REFERENCES User(name),
	FOREIGN KEY (challengeName) REFERENCES Challenge(name)
);

CREATE TABLE ChallengeCompleted
(
	userName			varchar(255)	NOT NULL,
	challengeName		varchar(255)	NOT NULL,
	PRIMARY KEY (userName, challengeName),
	FOREIGN KEY (userName) REFERENCES User(name),
	FOREIGN KEY (challengeName) REFERENCES Challenge(name)
);