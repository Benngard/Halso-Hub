DELIMITER $$


/*	 ActivityCompleted	 */

CREATE TRIGGER `halso_hub`.AddsToCompleteActivity
BEFORE INSERT ON `halso_hub`.ActivityCompleted

FOR EACH ROW

BEGIN
	DECLARE activityNr integer;
    DECLARE activityNrToday integer;
    
	SELECT IFNULL(ActivityCompleted.nrAllTime, 0) INTO activityNr
    FROM ActivityCompleted
	WHERE NEW.userName = ActivityCompleted.userName AND NEW.ActivityName = ActivityCompleted.activityName;
    
    SELECT IFNULL(ActivityCompleted.nrToday, 0) INTO activityNrToday
    FROM ActivityCompleted
	WHERE NEW.userName = ActivityCompleted.userName AND NEW.ActivityName = ActivityCompleted.activityName;
    
    
    IF (activityNr > 0) THEN
		UPDATE ActivityCompleted SET ActivityCompleted.nr = (activityNr+1)
			WHERE ActivityCompleted.userName = NEW.userName AND ActivityCompleted.activityName = NEW.activityName;
		CALL raise_application_error(-20001, 'Already have a counter for activity');
	
    ELSE 
		INSERT INTO ActivityCompleted
			VALUES(NEW.userName, NEW.activityName. activityNr+1, activityNr);
	END IF;


END;
$$


CREATE TRIGGER `halso_hub`.UpdateCompleteActivity
BEFORE UPDATE ON `halso_hub`.ActivityCompleted

FOR EACH ROW

BEGIN
	DECLARE activityNr integer;
    
	SELECT IFNULL(ActivityCompleted.nr, 0) INTO activityNr
    FROM ActivityCompleted
	WHERE NEW.userName = ActivityCompleted.userName AND NEW.ActivityName = ActivityCompleted.activityName;
    
	SET NEW.nr = activityNr+1;

END; 
$$

DELIMITER ;