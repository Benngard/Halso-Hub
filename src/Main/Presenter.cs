using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Anton Andrén
/// </summary>
namespace Halso_Hub
{
    /// <summary>
    /// Presenter class responsible for reacting to user input and updating the user
    /// </summary>
    class Presenter
    {
        private IUser user;
        private IActivityMain view;

        private string activitySelected;

        private int moodButtonState;
        private int timeLeft;
        private string currentActivityHover;

        public Presenter(IActivityMain view, IUser user)
        {
            this.user = user;
            this.view = view;
            moodButtonState = 0;
            view.setPresenter(this);
            setupGUI();
        }

        /// <summary>
        /// Setups the gui on startup.
        /// </summary>
        private void setupGUI()
        {
            view.hideAndStopTimer();
            updateMoodButtons();

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
                case "Happy":
                    user.AddMood(MoodType.Happy);
                    break;
                case "VeryTierd":
                    user.AddMood(MoodType.VeryTierd);
                    break;
                case "Tired":
                    user.AddMood(MoodType.Tired);
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
                case "Calm":
                    user.AddMood(MoodType.Calm);
                    break;
                case "VeryLonely":
                    user.AddMood(MoodType.VeryLonely);
                    break;
                case "Lonely":
                    user.AddMood(MoodType.Lonely);
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
        private void updateMoodButtons()
        {
            switch (moodButtonState)
            {
                case 0:
                    user.ResetMood();
                    view.updateMoodButtons("VerySad", "Sad", "Happy", "VeryHappy", "How do you feel?");
                    view.showAllMoodButtons();
                    break;
                case 1:
                    view.updateMoodButtons("VeryTierd", "Tired", "Energetic", "VeryEnergetic", "How do you feel?");
                    break;
                case 2:
                    view.updateMoodButtons("VeryStressed", "Stressed", "Calm", "VeryCalm", "How do you feel?");
                    break;
                case 3:
                    view.updateMoodButtons("VeryLonely", "Lonely", "Sociable", "VerySociable", "How do you feel?");
                    break;
                case 4:
                    var recommendedActivities = new List<string>();
                    foreach (Activity a in user.GetRecommendedActivities())
                    {
                        recommendedActivities.Add(a.Name);
                    }
                    view.updateActivityList(recommendedActivities);
                    view.showOneMoodButton();
                    view.updateMoodButtons("Update now!", "Hidden", "Hidden", "Hidden", "Do you want to update your Mood?");
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
            Activity tmp = user.findRecommendedActivityByName(activityName);
            if (tmp != null)
            {
                string description = tmp.Description;
                if (description != null)
                {
                    view.updateActivityInfo(description);
                }
            }

        }

        /// <summary>
        /// Called when the user starts an activity in the GUI.
        /// Loads the activity in user and starts the activity with its validation method.
        /// Potential TO-DO: Add exception handler, more validation methods.
        /// </summary>
        /// <param name="activity"></param>
        public void startButtonPressed()
        {
            Activity startedActivity = user.findRecommendedActivityByName(currentActivityHover);

            if (startedActivity != null)
            {
                user.SetCurrentActivity(startedActivity);
                timeLeft = user.CurrentActivity.TimeLeft;
                setupAndStartTimer();
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
            var recommendedActivities = new List<string>();
            foreach (Activity a in user.GetRecommendedActivities())
            {
                recommendedActivities.Add(a.Name);
            }
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

    }
}