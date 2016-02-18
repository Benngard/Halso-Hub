CREATE TABLE `halso_hub`.`GoodFor`
(
	moodType			varchar(255)	NOT NULL,
	activityName		varchar(255)	NOT NULL,
	PRIMARY KEY (moodType, activityName),
	FOREIGN KEY (moodType) REFERENCES Mood(type),
	FOREIGN KEY (activityName) REFERENCES Activity(name)
);

CREATE TABLE `halso_hub`.ActivityCompleted
(
	userName			varchar(255)	NOT NULL,
	activityName		varchar(255)	NOT NULL,
	PRIMARY KEY (userName, activityName),
	FOREIGN KEY (userName) REFERENCES User(name),
	FOREIGN KEY (activityName) REFERENCES Activity(name)
);

CREATE TABLE `halso_hub`.OnGoingActivity
(
	userName			varchar(255)	NOT NULL,
	activityName		varchar(255)	NOT NULL,
	PRIMARY KEY (userName, activityName),
	FOREIGN KEY (userName) REFERENCES User(name),
	FOREIGN KEY (activityName) REFERENCES Activity(name)
);

CREATE TABLE `halso_hub`.ActivityRewards
(
	trophyName			varchar(255)	NOT NULL,
	activityName		varchar(255)	NOT NULL,
	PRIMARY KEY (trophyName, activityName),
	FOREIGN KEY (trophyName) REFERENCES Trophy(name),
	FOREIGN KEY (activityName) REFERENCES Activity(name)
);

CREATE TABLE `halso_hub`.ChallengeRequires
(
	challengeName			varchar(255)	NOT NULL,
	activityName		varchar(255)	NOT NULL,
	PRIMARY KEY (challengeName, activityName),
	FOREIGN KEY (challengeName) REFERENCES Challenge(name),
	FOREIGN KEY (activityName) REFERENCES Activity(name)
);

CREATE TABLE `halso_hub`.EarnedTrophy
(
	userName			varchar(255)	NOT NULL,
	trophyName		varchar(255)	NOT NULL,
	PRIMARY KEY (userName, trophyName),
	FOREIGN KEY (userName) REFERENCES User(name),
	FOREIGN KEY (trophyName) REFERENCES Trophy(name)
);

CREATE TABLE `halso_hub`.UserMood
(
	userName			varchar(255)	NOT NULL,
	currentMoodType		varchar(255)	NOT NULL,
	PRIMARY KEY (userName, currentMoodType),
	FOREIGN KEY (userName) REFERENCES User(name),
	FOREIGN KEY (currentMoodType) REFERENCES CurrentMood(type)
);

CREATE TABLE `halso_hub`.ChallengeRewards
(
	trophyName			varchar(255)	NOT NULL,
	challengeName		varchar(255)	NOT NULL,
	PRIMARY KEY (trophyName, challengeName),
	FOREIGN KEY (trophyName) REFERENCES Trophy(name),
	FOREIGN KEY (challengeName) REFERENCES Challenge(name)
);

CREATE TABLE `halso_hub`.OnGoingChallenge
(
	userName			varchar(255)	NOT NULL,
	challengeName		varchar(255)	NOT NULL,
	PRIMARY KEY (userName, challengeName),
	FOREIGN KEY (userName) REFERENCES User(name),
	FOREIGN KEY (challengeName) REFERENCES Challenge(name)
);

CREATE TABLE `halso_hub`.ChallengeCompleted
(
	userName			varchar(255)	NOT NULL,
	challengeName		varchar(255)	NOT NULL,
	PRIMARY KEY (userName, challengeName),
	FOREIGN KEY (userName) REFERENCES User(name),
	FOREIGN KEY (challengeName) REFERENCES Challenge(name)
);