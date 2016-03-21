using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using Halso_Hub.Main;

/// <summary>
/// Anton Andrén
/// </summary>
namespace Halso_Hub
{
    /// <summary>
    /// Presenter class responsible for reacting to user input and updating the user
    /// </summary>
    public class Presenter
    {
        private User user;
        private MainForm view;

        public int Grade;
        public string Comment;

        public bool activitySelected = false;
        public bool challengeSelected = false;

        public CurrentChallenge currentChallenge;

        public int moodButtonState;
        public int timeLeft;
        private string currentActivityHover;
        private string currentChallengeHover;

        public List<Activity> allActivities;
		private List<Challenge> allChallenges;

        private ConnectToDatabase connectToDatabase;

        public Presenter(MainForm view, User user)
        {
            connectToDatabase = new ConnectToDatabase("halso_hub");
            this.user = user;
            this.view = view;
            moodButtonState = 0;
            view.setPresenter(this);
            setupGUI();

			if (connectToDatabase.onGoingChallenge(user.Username) == true)
            {
                ChallengeActivitiesLeftInCurrentChallenge();
                StartChallengeButtonPressed();
                view.HideChallengesDisplayed();
                view.ShowActivitiesForChallenge();

				currentChallengeHover = connectToDatabase.GetCurrentChallenge(user.Username);
				Challenge startedChallenge = user.GetChallengeQuery(currentChallengeHover);

                if (startedChallenge != null && challengeSelected == false)
				{
					challengeSelected = true;
                    user.SetCurrentChallenge(startedChallenge);
                }

				view.ChangeChallengeDescriptionAndLabel(startedChallenge.Name, startedChallenge.Description);
			}
			else
			{
				GetAndShowChallenges();
			}
        }

        /// <summary>
        /// Setups the gui on startup.
        /// </summary>
        private void setupGUI()
        {
            view.hideAndStopTimer();
            updateMoodButtons();
			UpdateTrophies();
			UpdateTotalPoints();
			view.AddCompletedTrophies(connectToDatabase.EarnedTrophies(user.Username));
			view.AddIncompletedTrophies(connectToDatabase.NotEarnedTrophies(user.Username));
		}

		private void UpdateTrophies()
		{
			UpdateTrophiesNumbers();
		}

		private void UpdateTotalPoints()
		{
			view.UpdatePoints(connectToDatabase.TotalPoints(user.Username));
		}

		private void UpdateTrophiesNumbers()
		{
			view.UpdateTrophiesNumbers(connectToDatabase.GoldTrophies(user.Username), connectToDatabase.SilverTrophies(user.Username), connectToDatabase.BronzeTrophies(user.Username));
		}

		/// <summary>
		/// Updates user with the selected mood and calls for updateMoodButtons()
		/// </summary>
		/// <param name="mood"></param> The mood the user selected
		public void moodButtonPressed(string mood)
        {
            switch (mood)
            {
                case "VerySad":
                    user.AddMood(MoodType.VerySad);
                    break;
                case "Sad":
                    user.AddMood(MoodType.Sad);
                    break;
                case "VeryHappy":
                    user.AddMood(MoodType.VeryHappy);
                    break;
                case "Happy":
                    user.AddMood(MoodType.Happy);
                    break;
                case "VeryTierd":
                    user.AddMood(MoodType.VeryTired);
                    break;
                case "Tired":
                    user.AddMood(MoodType.Tired);
                    break;
                case "VeryEnergetic":
                    user.AddMood(MoodType.VeryEnergetic);
                    break;
                case "Energetic":
                    user.AddMood(MoodType.Energetic);
                    break;
                case "VeryStressed":
                    user.AddMood(MoodType.VeryStressed);
                    break;
                case "Stressed":
                    user.AddMood(MoodType.Stressed);
                    break;
                case "VeryCalm":
                    user.AddMood(MoodType.VeryCalm);
                    break;
                case "Calm":
                    user.AddMood(MoodType.Calm);
                    break;
                case "VeryLonely":
                    user.AddMood(MoodType.VeryLonely);
                    break;
                case "Lonely":
                    user.AddMood(MoodType.Lonely);
                    break;
                case "VerySociable":
                    user.AddMood(MoodType.VerySociable);
                    break;
                case "Sociable":
                    user.AddMood(MoodType.Sociable);
                    break;
                default: break;
            }
            moodButtonState = (moodButtonState + 1) % 5;
            updateMoodButtons();
        }

        /// <summary>
        /// Updates the Mood Buttons in the GUI
        /// </summary>
        public void updateMoodButtons()
        {
            switch (moodButtonState)
            {
                case 0:
                    user.ResetMood();
                    view.showMoodDesign();
                    view.updateMoodButtons("Very Sad", "Sad", "Happy", "Very Happy", "How do you feel?");
                    view.showAllMoodButtons();
                    view.disableResetButton();
                    break;
                case 1:
                    view.updateMoodButtons("Very Tired", "Tired", "Energetic", "Very Energetic", "How do you feel?");
                    view.enableResetButton();
                    break;
                case 2:
                    view.updateMoodButtons("Very Stressed", "Stressed", "Calm", "Very Calm", "How do you feel?");
                    break;
                case 3:
                    view.updateMoodButtons("Very Lonely", "Lonely", "Sociable", "Very Sociable", "How do you feel?");
                    break;
                case 4:
                    Debug.WriteLine("Presenter, show activities.");


                    var recommendedActivities = user.RecommendedActivities();
                    view.updateActivityList(recommendedActivities);

                    moodButtonState = 0;
                    view.hideMoodDesign();
                    view.showActivitiesRecommendation();
                    user.ResetMood();
                    break;  
            }
        }
        /// <summary>
        /// Called when a user selects an activity in the GUI.
        /// Loads the description of the activity in the GUI.
        /// Potential TO-DO: Add exception handling.
        /// </summary>
        /// <param name="activityName"></param> What activity has been pressed
        public void activityPressed(string activityName)
        {
			currentActivityHover = activityName;
			String description = connectToDatabase.GetActivityDescriptionQuery(activityName);
			view.updateActivityInfo(description);
        }

        /// <summary>
        /// Called when a user selects an challenge in the GUI.
        /// Loads the description of the challenge in the GUI.
        /// Potential TO-DO: Add exception handling.
        /// </summary>
        /// <param name="ChallengeName"></param> What activity has been pressed
        public void ChallengePressed(string challengeName)
        {
			if(currentChallengeHover != challengeName)
			{
				currentChallengeHover = challengeName;
				String description = connectToDatabase.GetChallengeDescriptionQuery(challengeName);
				view.updateChallengeInfo(description);
			}
        }

        /// <summary>
        /// Called when a user selects a activity for a challenge in the GUI.
        /// Loads the description of the acitivty for a challenge in the GUI
        /// </summary>
        /// <param name="activityName"></param>
        public void ActivityForChallengePressed(string activityName)
        {
            currentActivityHover = activityName;
            String description = connectToDatabase.GetActivityDescriptionQuery(activityName);
            view.UpdateActivityForChallengeInfo(description);
        }

        /// <summary>
        /// Called when the user starts an activity in the GUI.
        /// Loads the activity in user and starts the activity with its validation method.
        /// Potential TO-DO: Add exception handler, more validation methods.
        /// </summary>
        /// <param name="activity"></param>
        public void startActivityButtonPressed()
        {
            Activity startedActivity = user.GetActivityQuery(currentActivityHover);
			if (startedActivity != null && activitySelected == false)
            {
                user.SetCurrentActivity(startedActivity);
				timeLeft = user.CurrentActivity.TimeLeft;
                setupAndStartTimer();
                activitySelected = true;
            }
        }

		public void cancelActivityButtonPressed()
		{
			moodButtonState = 0;
			updateMoodButtons();
			dropActivity();
		}

		/// <summary>
		/// Called when the user starts an activity in the GUI.
		/// Loads the activity in user and starts the activity with its validation method.
		/// Potential TO-DO: Add exception handler, more validation methods.
		/// </summary>
		/// <param name="challenge"></param>
		public void StartChallengeButtonPressed()
        {
			Console.WriteLine("Current: " + currentChallengeHover);
            Challenge startedChallenge = user.GetChallengeQuery(currentChallengeHover);
			
            if (startedChallenge != null && challengeSelected == false)
            {
                user.SetCurrentChallenge(startedChallenge);
                challengeSelected = true;
            }
            
            List<Activity> activitysLeft = ChallengeActivitiesLeftInCurrentChallenge();
			view.UpdateActivityForChallengeList(activitysLeft);           
        }
        /// <summary>
        /// Calls the GUI to display a timer and start the timer
        /// </summary>
        private void setupAndStartTimer()
        {
            view.setupTimer(String.Format("{0:00} min {1:00} sec", timeLeft / 60, timeLeft % 60));
        }

        /// <summary>
        /// Called from the GUI once one second has passed with an active timer
        /// </summary>
        public void timerTick()
        {
			timeLeft--;
            if (timeLeft >= 0)
            {
                view.updateTimer(String.Format("{0:00} min {1:00} sec", timeLeft / 60, timeLeft % 60));
			}
            else  //Om tiden går ut
            {
                view.hideAndStopTimer();
            }

        }

        public void completeActivity()
        {
            view.createActivityPopUp();

            if (currentChallenge != null)
            {
                var currentChallengeString = user.CurrentChallenge.Challenge.Name;
            }

            var listWithNotification = user.CompleteCurrentActivity(Grade,Comment);

			if (user.ChallengeCompleted())	//If challenge if completed
			{
				listWithNotification.Add(new Notification("Challenge Completed!", "Congratulations, you completed the challenge: " + user.CurrentChallenge.Challenge.Name + "!"));
				DropChallenge();
				view.ShowChallengesDisplayed();
				view.HideActivitiesForChallenge();
				view.updateChallengeList(user.ActiveChallenges());
			}

            view.AddAndRemoveCompletedTrophies(user.trophiesEarned);
            UpdateTotalPoints();

            if (listWithNotification.Count > 0)
            {
                foreach (Notification n in listWithNotification)
                {
                    if (n.Title == "Challenge Completed!")
                    {
                        view.createChallengePopUp();
                    }
                    else if (n.Title == "Trophy Earned!")
                    {
                        view.createTrophyPopUp();
                        UpdateTrophies();
                    }
                }
            }

			if(user.CurrentChallenge != null)
			{
				List<Activity> activitysLeft = ChallengeActivitiesLeftInCurrentChallenge();
				Debug.WriteLine("Activities left in challenge: ");
				foreach (Activity activity in activitysLeft)
				{
					Debug.WriteLine(activity.Name);
				}
				view.UpdateActivityForChallengeList(activitysLeft);
			}
        }

        /// <summary>
        /// Drops the activity for user.
        /// </summary>
        public void dropActivity()
        {
            user.DropCurrentActivity();
            activitySelected = false;
        }

        /// <summary>
        /// Checks if CurrentActivity is null.
        /// </summary>
        /// <returns></returns>Returns true if CurrentActivity is null, otherwise false.
        public bool currentActivity()
        {
            return user.CurrentActivity == null ? true : false;
        }

        /// <summary>
        /// Gets all activities from the database
        /// </summary>
        public void GetAllActivities()
        {
            allActivities = connectToDatabase.GetAllActivitiesQuery();
        }

        /// <summary>
        /// Gets the name of the activity from the database
        /// </summary>
        /// <returns></returns> the name of the activity
        public string GetActivityName()
        {
            var activity = connectToDatabase.GetActivityQuery(currentActivityHover);
            return activity.Name;
        }

        /// <summary>
        /// Gets a specific activity from the database and updates the description of it.
        /// </summary>
        public void GetAndShowActivityPressed()
        {
            var activity = connectToDatabase.GetActivityQuery(currentActivityHover);
            view.updateActivityInfo(activity.Description);
        }

        /// <summary>
        /// Gets the name of the challenge from the database.
        /// </summary>
        /// <returns>
        /// Name of the challenge
        /// </returns>
        public string GetChallengeName()
        {
            var challenge = connectToDatabase.GetChallengeQuery(currentChallengeHover);
            return challenge.Name;
        }

        /// <summary>
        /// Gets the Description of the challenge from the database.
        /// </summary>
        /// <returns>
        /// Description of the challenge
        /// </returns>
        public string GetChallengeDescription()
        {
            var challenge = connectToDatabase.GetChallengeQuery(currentChallengeHover);
            return challenge.Description;
        }

        /// <summary>
        /// Gets all activitys from the database and updates the activityList.
        /// </summary>
        public void GetAndShowRecommendedActivities()
        {
            var recommendedActivities = connectToDatabase.GetActivitiesQuery();
            view.updateActivityList(recommendedActivities);
        }

        /// <summary>
        /// Gets the name for all the challenges and updates the ChallengeList.
        /// </summary>
        /// <returns>
        /// The challenge which is available for a user
        /// </returns>
        public List<string> GetAndShowChallenges()
        {
            var recommendedChallenges = connectToDatabase.GetChallengesQuery(user.Username);
            view.updateChallengeList(recommendedChallenges);
			return recommendedChallenges;
        }

        /// <summary>
        /// Notifys the user to get the current challenge hovered.
        /// </summary>
        /// <returns>
        /// The challenge hovered
        /// </returns>
        public Challenge getChallenge()
        {
            return user.GetChallengeQuery(currentChallengeHover);
        }

        /// <summary>
        /// Gets the activities left for a user to do in a challenge
        /// </summary>
        /// A list of activites
        /// <returns></returns>
        public List<Activity> ChallengeActivitiesLeftInCurrentChallenge()
        {
			return connectToDatabase.getGetChallengeActivitiesLeftInCurrentChallenge(user.Username);         
        }

		/// <summary>
		/// Drop the users current challenge.
		/// </summary>
		public void DropChallenge()
		{
			user.DropCurrentChallenge();
			challengeSelected = false;
			currentChallengeHover = null;
		}

        public void SubmitComment(int grade, string comment)
        {
            Grade = grade;
            Comment = comment;
        }
       
    }
}