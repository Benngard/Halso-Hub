DELIMITER $$


/*	 ActivityCompleted	 */

CREATE TRIGGER `halso_hub`.AddCompleteActivity
AFTER INSERT ON `halso_hub`.ActivityCompleted

FOR EACH ROW

BEGIN

	DECLARE challenge varchar(255);
    DECLARE activityNrLeft integer;
    
    SELECT SUM(nrLeft) INTO activityNrLeft
    FROM ChallengeActivitiesLeftInCurrentChallenge
    WHERE ChallengeActivitiesLeftInCurrentChallenge.userName = NEW.userName
    ORDER BY NEW.userName;
    
    SELECT OnGoingChallenge.challengeName INTO challenge
    FROM OnGoingChallenge
    WHERE OnGoingChallenge.userName = NEW.userName;
    
	IF (activityNrLeft = 0) THEN
		INSERT INTO ChallengeCompleted
			VALUES(NEW.userName, challenge);
		DELETE FROM OnGoingChallenge
			WHERE NEW.userName = OnGoingChallenge.userName;
    END IF;

END;
$$


CREATE TRIGGER `halso_hub`.BeforeUpdateCompleteActivity
BEFORE UPDATE ON `halso_hub`.ActivityCompleted

FOR EACH ROW

BEGIN
    
    IF(NEW.nrAllTime < NEW.nrToday) THEN	# If total of all time is lower than total totay
		SET NEW.nrAllTime = NEW.nrToday;
    END IF;
    
END; 
$$


CREATE TRIGGER `halso_hub`.AfterUpdateCompleteActivity
AFTER UPDATE ON `halso_hub`.ActivityCompleted

FOR EACH ROW

BEGIN
	DECLARE challenge varchar(255);
    DECLARE activityNrLeft integer;
    
    SELECT SUM(nrLeft) INTO activityNrLeft
    FROM ChallengeActivitiesLeftInCurrentChallenge
    WHERE ChallengeActivitiesLeftInCurrentChallenge.userName = NEW.userName
    ORDER BY NEW.userName;
    
    SELECT OnGoingChallenge.challengeName INTO challenge
    FROM OnGoingChallenge
    WHERE OnGoingChallenge.userName = NEW.userName;
    
	IF (activityNrLeft = 0) THEN
		INSERT INTO ChallengeCompleted
			VALUES(NEW.userName, challenge);
		DELETE FROM OnGoingChallenge
			WHERE NEW.userName = OnGoingChallenge.userName;
    END IF;
    
END; 
$$

DELIMITER ;