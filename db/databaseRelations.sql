CREATE TABLE `halso_hub`.GoodFor
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
    nrAllTime			int,
    nrToday				int,
	PRIMARY KEY (userName, activityName),
	FOREIGN KEY (userName) REFERENCES Users(name),
	FOREIGN KEY (activityName) REFERENCES Activity(name),
    
    CONSTRAINT positiveNr
		CHECK (nrAllTime > 0 AND nrToday >= 0),
        
	CONSTRAINT moreAllTime
		CHECK (nrAllTime >= nrToday)
);

CREATE TABLE `halso_hub`.OnGoingActivity
(
	userName			varchar(255)	NOT NULL,
	activityName		varchar(255)	NOT NULL,
	PRIMARY KEY (userName, activityName),
	FOREIGN KEY (userName) REFERENCES Users(name),
	FOREIGN KEY (activityName) REFERENCES Activity(name)
);

CREATE TABLE `halso_hub`.ActivityRewards
(
	trophyName			varchar(255)	NOT NULL,
	activityName		varchar(255)	NOT NULL,
    totalNr				int,
	PRIMARY KEY (trophyName, activityName),
	FOREIGN KEY (trophyName) REFERENCES Trophy(name),
	FOREIGN KEY (activityName) REFERENCES Activity(name),
    
    CONSTRAINT positiveNr
		CHECK (totalNr > 0)
);

CREATE TABLE `halso_hub`.ChallengeRequires
(
	challengeName		varchar(255)	NOT NULL,
	activityName		varchar(255)	NOT NULL,
    nr					int,
	PRIMARY KEY (challengeName, activityName),
	FOREIGN KEY (challengeName) REFERENCES Challenge(name),
	FOREIGN KEY (activityName) REFERENCES Activity(name),
    
    CONSTRAINT positiveNr
		CHECK (nr > 0)
);

CREATE TABLE `halso_hub`.EarnedTrophy
(
	userName			varchar(255)	NOT NULL,
	trophyName			varchar(255)	NOT NULL,
	PRIMARY KEY (userName, trophyName),
	FOREIGN KEY (userName) REFERENCES Users(name),
	FOREIGN KEY (trophyName) REFERENCES Trophy(name)
);

CREATE TABLE `halso_hub`.UserMood
(
	userName			varchar(255)	NOT NULL,
	currentMoodType		varchar(255)	NOT NULL,
	PRIMARY KEY (userName, currentMoodType),
	FOREIGN KEY (userName) REFERENCES Users(name),
	FOREIGN KEY (currentMoodType) REFERENCES Mood(type)
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
	FOREIGN KEY (userName) REFERENCES Users(name),
	FOREIGN KEY (challengeName) REFERENCES Challenge(name)
);

CREATE TABLE `halso_hub`.ChallengeCompleted
(
	userName			varchar(255)	NOT NULL,
	challengeName		varchar(255)	NOT NULL,
	PRIMARY KEY (userName, challengeName),
	FOREIGN KEY (userName) REFERENCES Users(name),
	FOREIGN KEY (challengeName) REFERENCES Challenge(name)
);