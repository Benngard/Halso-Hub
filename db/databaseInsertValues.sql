

INSERT INTO User 
VALUES ('Ola');

INSERT INTO User 
VALUES ('Mattias');

INSERT INTO User 
VALUES ('Johan');

INSERT INTO user
VALUES ('Daniel');

/* MOOD */
INSERT INTO Mood 
VALUES ('Stressed');

INSERT INTO Mood 
VALUES ('Tired');

INSERT INTO Mood 
VALUES ('Square');

INSERT INTO Mood 
VALUES ('Bored');

/* ACTIVITY */
INSERT INTO Activity
VALUES ('Limbo','How low can you go?','20','120');

INSERT INTO Activity
VALUES ('Pushups','Do 10 pushups!','20','60');

INSERT INTO Activity
VALUES ('Situps','Do 15 situps!','25','60');

INSERT INTO Activity
VALUES ('Fruit time','You either eat a banana or an appel, the choice is yours and yours only!','15','180');

INSERT INTO Activity
VALUES ('Cat video','Cheer up mate! Watch a cat video!','25','180');

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
VALUES ('Flexibility & Strength','Complete both Strength of an ox and Limbo Master to finish this challenge!','0','600');

/* databaseRelations
------------------------------------*/

/* GOODFOR */
INSERT INTO GoodFor
VALUES ('Tired','Fruit time');

INSERT INTO GoodFor
VALUES ('Stressed','Cat video');

INSERT INTO GoodFor
VALUES ('Bored','Pushups');

INSERT INTO GoodFor
VALUES ('Bored','Situps');

INSERT INTO GoodFor
VALUES ('Square','Limbo');

/* ACTIVITYCOMPLETED */
INSERT INTO ActivityCompleted
VALUES ('Ola','Pushups');

INSERT INTO ActivityCompleted
VALUES ('Ola','Situps');

INSERT INTO ActivityCompleted
VALUES ('Ola','Limbo');

INSERT INTO ActivityCompleted
VALUES ('Mattias','Situps');

INSERT INTO ActivityCompleted
VALUES ('Johan','Cat video');

/* ONGOINGACTIVITY */
INSERT INTO OnGoingActivity
VALUES ('Johan','Limbo');

/* ACTIVITYREWARDS */
INSERT INTO ActivityRewards
VALUES ('Strength of an oxe','Pushups');

INSERT INTO ActivityRewards
VALUES ('Strength of an oxe','Situps');

INSERT INTO ActivityRewards
VALUES ('Limbo master','Limbo');

INSERT INTO ActivityRewards
VALUES ('Cat lover','Cat video');

/* CHALLENGEREQUIRES */
INSERT INTO ChallengeRequires
VALUES ('Flexibility & Strength','Limbo');

INSERT INTO ChallengeRequires
VALUES ('Flexibility & Strength','Pushups');

INSERT INTO ChallengeRequires
VALUES ('Flexibility & Strength','Situps');

/* EARNEDTROPHY */
INSERT INTO EarnedTrophy
VALUES ('Ola','Strength of an oxe');

INSERT INTO EarnedTrophy
VALUES ('Johan','Cat lover');

/* USERMOOD */
INSERT INTO UserMood
VALUES ('Ola','Bored');

INSERT INTO UserMood
VALUES ('Mattias','Bored');

INSERT INTO UserMood
VALUES ('Johan','Stressed');

/* CHALLENGEREWARDS */
INSERT INTO ChallengeRewards
VALUES ('Training deluxe','Flexibility & Strength');

/* ONGOINGCHALLENGE */
INSERT INTO OnGoingChallenge
VALUES ('Mattias','Flexibility & Strengthuser');

/* CHALLENGECOMPLETED */
INSERT INTO ChallengeCompleted
VALUES ('Ola','Flexibility & Strength');

/* CHALLENGECOMPLETED */
INSERT INTO ChallengeCompleted
VALUES ('Mattias','Flexibility & Strength');