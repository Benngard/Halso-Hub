using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
        private IUser user;
        private IMainForm view;

        public bool activitySelected;
        public bool challengeSelected;

        private int timeLeft;
        private string currentActivityHover;
        private string currentChallengeHover;

        //public List<Activity> allActivities;

        private ConnectToDatabase connectToDatabase;

        public Presenter(IMainForm view, IUser user)
        {
            connectToDatabase = new ConnectToDatabase("halso_hub");
            this.user = user;
            this.view = view;
            view.setPresenter(this);
            setupGUI();
			var recommendedActivities = connectToDatabase.GetActivitiesQuery();
			view.updateActivityList(recommendedActivities);
			//GetAllActivities();      
		}

        /// <summary>
        /// Setups the gui on startup.
        /// </summary>
        private void setupGUI()
        {
            view.hideAndStopTimer();
        }

		/// <summary>
		/// Updates user with the selected mood and calls for ChangeMood()
		/// </summary>
		/// <param name="mood"></param> The mood the user selected
		public void moodButtonPressed(string type, MoodType mood)
        {
			user.ChangeMood(type, mood);
			var recommendedActivities = connectToDatabase.GetActivitiesQuery();
			view.updateActivityList(recommendedActivities);
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
        /// Called when a user selects a challenge in the GUI.
        /// </summary>
        /// <param name="challengeName"></param>A string representing the choosen challenge.
        public void challengePressed(string challengeName)
        {
            currentChallengeHover = challengeName;
            String description = connectToDatabase.GetChallengeDescriptionQuery(challengeName);
            view.updateChallengeInfo(description);
        }

        /// <summary>
        /// Called when the user starts an activity in the GUI.
        /// Loads the activity in user and starts the activity with its validation method.
        /// Potential TO-DO: Add exception handler, more validation methods.
        /// </summary>
        public void startActivityButtonPressed()
        {

			Activity startedActivity = connectToDatabase.GetActivityQuery(currentActivityHover);

			if (startedActivity != null && activitySelected == false)
            {
				user.SetCurrentActivity(startedActivity);
				timeLeft = user.CurrentActivity.TimeLeft;
				setupAndStartTimer();
				activitySelected = true;
            }
            else
            {
                Challenge startedChallenge = user.findRecommendedActivityForChallenge(currentChallengeHover);

                if (startedChallenge != null)
                {
                    user.SetCurrentChallenge(startedChallenge);
                    challengeSelected = true;
                }

                var recommendedActivities = connectToDatabase.GetActivitiesQuery();
                view.updateActivityList(recommendedActivities);

                
            }
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
            else
            {
                view.hideAndStopTimer();
                completeActivity();
            }
        }

        /// <summary>
        /// This is just a stub.
        /// TO-DO: Implement the method.
        /// </summary>
        private void completeActivity()
        {
            var recommendedActivities = connectToDatabase.GetActivitiesQuery();
            view.updateActivityList(recommendedActivities);
            view.createActivityPopUp();
            // Run the complete activity pop-up
            // Need to add method(s) to IActivityMain to run the pop-up
        }

        /// <summary>
        /// This is just a stub.
        /// TO-DO: Implement the method.
        /// </summary>
        public void activityGradeButtonPressed(int grade, string feedback)
        {
            // When the pop-up for completeActivity has been run notify this method to handle the data!
            // switch is a dummy solution, may be changed.
            ActivityGrade activityGrade;
            switch (grade)
            {
                case 0:
                    activityGrade = ActivityGrade.Terrible;
                    break;
                case 1:
                    activityGrade = ActivityGrade.Bad;
                    break;
                case 2:
                    activityGrade = ActivityGrade.Good;
                    break;
                case 3:
                    activityGrade = ActivityGrade.Superb;
                    break;
                default:
                    activityGrade = ActivityGrade.Skipped;
                    break;
            }
            var newTrophies = user.CompleteCurrentActivity(activityGrade, feedback);

            // Call function for displaying trophys earned, then call to check if challange is completed etc...
        }

        /// <summary>
        /// Change between challenge and activity 
        /// </summary>
        public void changeBetweenChallengeAndActivity(Button b, Label labelDescription, Label l, ListBox lb, RichTextBox rtb)
        {
            if (b.Text == "Challenge")
            {
                b.Text = "Activity";
                labelDescription.Text = "Challenge Description";
                l.Text = "Challenges";
                lb.Items.Clear();
                rtb.Clear();

                var recommendedChallenges = connectToDatabase.GetChallengesQuery();
                view.updateActivityList(recommendedChallenges);
            }
            else {
                b.Text = "Challenge";
                labelDescription.Text = "Activity Description";
                l.Text = "Activities";
                lb.Items.Clear();
                rtb.Clear();
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

        /*/// <summary>
        /// Gets all activities from the database
        /// </summary>
        public void GetAllActivities()
        {
            allActivities = connectToDatabase.GetAllActivitiesQuery();
        }*/
    }
}