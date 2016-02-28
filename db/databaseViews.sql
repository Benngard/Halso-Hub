
CREATE VIEW `halso_hub`.UserTotalPoints AS
(
	SELECT Users.Name, IFNULL( SUM(activity.Points), 0) AS TotalPoints
	FROM activity LEFT JOIN ActivityCompleted
		ON ActivityCompleted.activityName = activity.Name
    RIGHT JOIN Users
		ON ActivityCompleted.userName = Users.Name
    GROUP BY Users.Name
    
);

CREATE VIEW `halso_hub`.UserTotalTrophies AS
(
	SELECT Users.Name, IFNULL( COUNT(Trophy.Name), 0) AS TotalPoints
	FROM Trophy LEFT JOIN EarnedTrophy
		ON EarnedTrophy.trophyName = Trophy.Name
    RIGHT JOIN Users
		ON EarnedTrophy.userName = Users.Name
    GROUP BY Users.Name
);

CREATE VIEW `halso_hub`.UserTotalBronze AS
(
	SELECT Users.Name, IFNULL( COUNT(Trophy.Name), 0) AS TotalPoints
	FROM Trophy LEFT JOIN EarnedTrophy
		ON EarnedTrophy.trophyName = Trophy.Name AND Trophy.Quality = 'Bronze'
    RIGHT JOIN Users
		ON EarnedTrophy.userName = Users.Name
    GROUP BY Users.Name
    
);

CREATE VIEW `halso_hub`.UserTotalSilver AS
(
	SELECT Users.Name, IFNULL( COUNT(Trophy.Name), 0) AS TotalPoints
	FROM Trophy LEFT JOIN EarnedTrophy
		ON EarnedTrophy.trophyName = Trophy.Name AND Trophy.Quality = 'Silver'
    RIGHT JOIN Users
		ON EarnedTrophy.userName = Users.Name
    GROUP BY Users.Name
    
);

CREATE VIEW `halso_hub`.UserTotalGold AS
(
	SELECT Users.Name, IFNULL( COUNT(Trophy.Name), 0) AS TotalPoints
	FROM Trophy LEFT JOIN EarnedTrophy
		ON EarnedTrophy.trophyName = Trophy.Name AND Trophy.Quality = 'Gold'
    RIGHT JOIN Users
		ON EarnedTrophy.userName = Users.Name
    GROUP BY Users.Name
    
);

CREATE VIEW `halso_hub`.ChallengeActivitiesLeftInCurrentChallenge AS
(
	SELECT OnGoingChallenge.userName, ChallengeRequires.challengeName, ChallengeRequires.activityName, ChallengeRequires.nr, GREATEST( ChallengeRequires.nr - IFNULL( ActivityCompleted.nrToday, 0 ), 0)  AS nrLeft
    FROM OnGoingChallenge JOIN ChallengeRequires
		ON OnGoingChallenge.challengeName = ChallengeRequires.challengeName
	LEFT JOIN ActivityCompleted
		ON ActivityCompleted.activityName = ChallengeRequires.activityName 
        AND ActivityCompleted.userName = OnGoingChallenge.userName 
	
	ORDER BY OnGoingChallenge.userName
	
);


