
CREATE VIEW `halso_hub`.UserTotalPoints AS
(
	SELECT User.Name, IFNULL( SUM(activity.Points), 0) AS TotalPoints
	FROM activity LEFT JOIN ActivityCompleted
		ON ActivityCompleted.activityName = activity.Name
    RIGHT JOIN user
		ON ActivityCompleted.userName = user.Name
    GROUP BY User.Name
    
);

CREATE VIEW `halso_hub`.UserTotalTrophies AS
(
	SELECT User.Name, IFNULL( COUNT(Trophy.Name), 0) AS TotalPoints
	FROM Trophy LEFT JOIN EarnedTrophy
		ON EarnedTrophy.trophyName = Trophy.Name
    RIGHT JOIN user
		ON EarnedTrophy.userName = user.Name
    GROUP BY User.Name
);

CREATE VIEW `halso_hub`.UserTotalBronze AS
(
	SELECT User.Name, IFNULL( COUNT(Trophy.Name), 0) AS TotalPoints
	FROM Trophy LEFT JOIN EarnedTrophy
		ON EarnedTrophy.trophyName = Trophy.Name AND Trophy.Quality = 'Bronze'
    RIGHT JOIN user
		ON EarnedTrophy.userName = user.Name
    GROUP BY User.Name
    
);

CREATE VIEW `halso_hub`.UserTotalSilver AS
(
	SELECT User.Name, IFNULL( COUNT(Trophy.Name), 0) AS TotalPoints
	FROM Trophy LEFT JOIN EarnedTrophy
		ON EarnedTrophy.trophyName = Trophy.Name AND Trophy.Quality = 'Silver'
    RIGHT JOIN user
		ON EarnedTrophy.userName = user.Name
    GROUP BY User.Name
    
);

CREATE VIEW `halso_hub`.UserTotalGold AS
(
	SELECT User.Name, IFNULL( COUNT(Trophy.Name), 0) AS TotalPoints
	FROM Trophy LEFT JOIN EarnedTrophy
		ON EarnedTrophy.trophyName = Trophy.Name AND Trophy.Quality = 'Gold'
    RIGHT JOIN user
		ON EarnedTrophy.userName = user.Name
    GROUP BY User.Name
    
);

CREATE VIEW `halso_hub`.ChallengeActivitiesLeftInCurrentChallenge AS
(
	SELECT 
	
	
);