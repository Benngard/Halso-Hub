

INSERT INTO Users 
VALUES ('Ola');

INSERT INTO Users
VALUES ('Mattias');

INSERT INTO Users 
VALUES ('Johan');

INSERT INTO Users
VALUES ('Daniel');

/* MOOD */
INSERT INTO Mood 
VALUES ('Very Sad');

INSERT INTO Mood 
VALUES ('Sad');

INSERT INTO Mood 
VALUES ('Happy');

INSERT INTO Mood 
VALUES ('Very Happy');

INSERT INTO Mood 
VALUES ('Very Tired');

INSERT INTO Mood 
VALUES ('Tired');

INSERT INTO Mood 
VALUES ('Energetic');

INSERT INTO Mood 
VALUES ('Very Energetic');

INSERT INTO Mood 
VALUES ('Very Stressed');

INSERT INTO Mood 
VALUES ('Stressed');

INSERT INTO Mood 
VALUES ('Calm');

INSERT INTO Mood 
VALUES ('Very Calm');

INSERT INTO Mood 
VALUES ('Very Lonely');

INSERT INTO Mood 
VALUES ('Lonely');

INSERT INTO Mood 
VALUES ('Sociable');

INSERT INTO Mood 
VALUES ('Very Sociable');


/* ACTIVITY */
INSERT INTO Activity
VALUES ('Limbo','How low can you go?','20','2');

INSERT INTO Activity
VALUES ('Pushups','Do 10 pushups!','20','2');

INSERT INTO Activity
VALUES ('Situps','Do 15 situps!','25','2');

INSERT INTO Activity
VALUES ('Fruit time','You either eat a banana or an appel, the choice is yours and yours only!','15','2');

INSERT INTO Activity
VALUES ('Cat video','Cheer up mate! Watch a cat video!','25','2');

/* TROPHY */
INSERT INTO Trophy
VALUES ('Cat lover','Watch a cat video to earn this trophy!','Silver');

INSERT INTO Trophy
VALUES ('Strength of an oxe','Complete Pushups and Situps to earn this trophy!','Gold');

INSERT INTO Trophy
VALUES ('Limbo master','Go as low as you can and earn this trophy!','Bronze');

INSERT INTO Trophy
VALUES ('Training deluxe','You must love to exercise!','Gold');

/* CHALLENGE */
INSERT INTO Challenge
VALUES ('Flexibility & Strength','Complete both Strength of an ox and Limbo Master to finish this challenge!','00:00:00','23:59:59');

INSERT INTO Challenge
VALUES ('Limbo guru','Go low low low low','00:00:00','23:59:59');

/* databaseRelations
------------------------------------*/

/* GOODFOR */
INSERT INTO GoodFor
VALUES ('Tired','Fruit time');

INSERT INTO GoodFor
VALUES ('Very Tired','Fruit time');

INSERT INTO GoodFor
VALUES ('Very Stressed','Cat video');

INSERT INTO GoodFor
VALUES ('Stressed','Cat video');

INSERT INTO GoodFor
VALUES ('Tired','Pushups');

INSERT INTO GoodFor
VALUES ('Very Tired','Situps');

INSERT INTO GoodFor
VALUES ('Very Sad','Limbo');

/* ACTIVITYCOMPLETED */
/*INSERT INTO ActivityCompleted
VALUES ('Ola','Pushups', 1, 0);

INSERT INTO ActivityCompleted
VALUES ('Ola','Situps', 3, 2);

INSERT INTO ActivityCompleted
VALUES ('Ola','Limbo', 1, 1);

INSERT INTO ActivityCompleted
VALUES ('Mattias','Situps', 4, 2);

INSERT INTO ActivityCompleted
VALUES ('Mattias','Pushups', 3, 3);

INSERT INTO ActivityCompleted
VALUES ('Johan','Cat video', 1, 0);

INSERT INTO ActivityCompleted
VALUES ('Daniel','Limbo', 2, 1);*/



/* ONGOINGACTIVITY */
/*INSERT INTO OnGoingActivity
VALUES ('Johan','Limbo');*/

/* ACTIVITYREWARDS */
INSERT INTO ActivityRewards
VALUES ('Strength of an oxe','Pushups', 1);

INSERT INTO ActivityRewards
VALUES ('Strength of an oxe','Situps', 2);

INSERT INTO ActivityRewards
VALUES ('Limbo master','Limbo', 2);

INSERT INTO ActivityRewards
VALUES ('Cat lover','Cat video', 2);

INSERT INTO ActivityRewards
VALUES ('Training deluxe','Pushups', 5);

INSERT INTO ActivityRewards
VALUES ('Training deluxe','Situps', 5);


/* CHALLENGEREQUIRES */
INSERT INTO ChallengeRequires
VALUES ('Flexibility & Strength','Limbo', 2);

INSERT INTO ChallengeRequires
VALUES ('Flexibility & Strength','Pushups', 3);

INSERT INTO ChallengeRequires
VALUES ('Flexibility & Strength','Situps', 1);

INSERT INTO ChallengeRequires
VALUES ('Limbo guru','Limbo', 1);

/* EARNEDTROPHY */
INSERT INTO EarnedTrophy
VALUES ('Ola','Strength of an oxe');

INSERT INTO EarnedTrophy
VALUES ('Johan','Cat lover');

INSERT INTO EarnedTrophy
VALUES ('Mattias','Cat lover');


/* CHALLENGEREWARDS */
INSERT INTO ChallengeRewards
VALUES ('Training deluxe','Flexibility & Strength');

/* ONGOINGCHALLENGE *//*
INSERT INTO OnGoingChallenge
VALUES ('Mattias','Flexibility & Strength');

INSERT INTO OnGoingChallenge
VALUES ('Daniel','Flexibility & Strength');

/* CHALLENGECOMPLETED */
/*INSERT INTO ChallengeCompleted
VALUES ('Ola','Flexibility & Strength');*/
