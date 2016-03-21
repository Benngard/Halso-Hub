using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

/// <summary>
/// Mattias Benngård
/// </summary>
namespace Halso_Hub
{
    /// <summary>
    /// Is a user of the application.
    /// </summary>
    public class User
    { //hej
        public string Username { get; private set; }

        public List<MoodType> CurrentMood { get; private set; }
        public List<Trophy> trophiesEarned { get; private set; }

        public CurrentActivity CurrentActivity { get; private set; }
        public CurrentChallenge CurrentChallenge { get; private set; }
        public List<Challenge> CompletedChallenges { get; private set; }

        private ConnectToDatabase connectToDatabase;

        /// <summary>
        /// TEMPORARY
        /// Constructs a user with its fields.
        /// </summary>
        /// <param name="username">Name of the user.</param>
        public User(string username)
        {
            connectToDatabase = new ConnectToDatabase("halso_hub");
            Username = username;
            CurrentMood = new List<MoodType>();
        }

        /// <summary>
        /// Adds a new mood to the user.
        /// </summary>
        /// <param name="moodType">Which MoodType to add. Duplicates will not be stored.</param>
        public void AddMood(MoodType moodType)
        {
            CurrentMood.Add(moodType);
        }

        /// <summary>
        /// Emptys the Hashset containing the users mode
        /// </summary>
        public void ResetMood()
        {
            CurrentMood.Clear();
        }

        /// <summary>
        /// Gives the user a new activity to perform. Can not already be doing an activity.
        /// </summary>
        /// <param name="newActivity">New activity to start with.</param>
        public void SetCurrentActivity(Activity newActivity)
        {
            // can not start a new activity before completing the old one
            if (CurrentActivity != null)
            {
                throw new AlreadyInActivityException("Already performing an activity.");
            }

            // new activity is set for the user
            CurrentActivity = new CurrentActivity(newActivity);
            string name = CurrentActivity.Activity.Name;
            Debug.WriteLine(name);
        }

        public List<Trophy> allTrophies()
        {
            return connectToDatabase.AllTrophies();
        }

        /// <summary>
        /// Sets CurrentActivity to null.
        /// </summary>
        public void DropCurrentActivity()
        {
            CurrentActivity = null;
        }

        /// <summary>
        /// Returns all challenges
        /// </summary>
        /// <returns>A List of Challenges.</returns>
        public List<string> ActiveChallenges()
        {
            return connectToDatabase.GetChallengesQuery(Username);
        }

        /// <summary>
        /// Invokes CompleteActivity with CurrentActivity as activity.
        /// </summary>
        /// <param name="grade">What grade the user gives the activity.</param>
        /// <param name="comment">Any feedback the user leaves to the activity. Can be left blank or nulled.</param>
        /// <returns>A list of the name of all trophies and challenges that was earned. If nothing is earned then an empty list, safe to use for each.</returns>
        public List<Notification> CompleteCurrentActivity(int grade, string comment)
        {
            var ChallengeActivated = connectToDatabase.onGoingChallenge(Username);

			connectToDatabase.SubmitComment(grade, comment, Username, CurrentActivity.Activity.Name);

			connectToDatabase.CompleteActivity(Username, CurrentActivity.Activity.Name);
			trophiesEarned = connectToDatabase.getTrophiesEarnedAfterActivity(Username);

            var notifications = new List<Notification>();

            // add all, if any, trophies earned to the list
            foreach (Trophy t in trophiesEarned)
            {
                notifications.Add(new Notification("Trophy Earned!", "Congratulations, you earned the trophy: " + t.Name + "!"));
            }

            foreach (Trophy t in trophiesEarned)
            {
                Debug.WriteLine("" + t.Name);
            }

            // reset CurrentActivity and done
            DropCurrentActivity();
            return notifications;
        }

		public bool ChallengeCompleted()
		{
			if(CurrentChallenge == null)
			{
				return false;
			}
			else
			{
				return connectToDatabase.challengeCompleted(Username, CurrentChallenge.Challenge.Name);
			}
		}

        /// <summary>
        /// Sets the current challenge, if there already is one then throws AlreadyInAChallengeException.
        /// </summary>
        /// <param name="newChallenge">Which challenge to undertake for the user.</param>
        public void SetCurrentChallenge(Challenge challenge)
        {

            // can not start a new challenge before completing the old one
            
            if (connectToDatabase.onGoingChallenge(Username))
            {
                CurrentChallenge = new CurrentChallenge(challenge);
            }
            
            // new challenge is set for the user
            else
            {
                if (connectToDatabase.setCurrentChallenge(Username, challenge.Name))
                {
                    Debug.WriteLine("connectToDatabase.setCurrentChallenge(Username,challenge.Name); has run.");
                    CurrentChallenge = new CurrentChallenge(challenge);
                }
            }
        }

		/// <summary>
		/// Drop the users current challenge. Resets everything in the database and in the program.
		/// </summary>
		public void DropCurrentChallenge()
		{
			Debug.WriteLine("Before resetting " + CurrentChallenge.Challenge.Name);
			connectToDatabase.DropCurrentChallenge(Username, CurrentChallenge.Challenge.Name);
			CurrentChallenge = null;
		}

		/// <summary>
		/// Get the total amount of points.
		/// </summary>
		/// <returns>Total number of points the user has achieved by summating all activities.</returns>
		public int TotalPoints()
        {
            return connectToDatabase.TotalPoints(Username);
        }

        /// <summary>
        /// Get the total amount of gold trophies.
        /// </summary>
        /// <returns>Total amount of gold trophies earned by the user.</returns>
        public int TotalGoldTrophies()
        {
            return connectToDatabase.GoldTrophies(Username);
        }

        /// <summary>
        /// Get the total amount of silver trophies.
        /// </summary>
        /// <returns>Total amount of silver trophies earned by the user.</returns>
        public int TotalSilverTrophies()
        {
            return connectToDatabase.SilverTrophies(Username);
        }

        /// <summary>
        /// Get the total amount of bronze trophies.
        /// </summary>
        /// <returns>Total amount of bronze trophies earned by the user.</returns>
        public int TotalBronzeTrophies()
        {
            return connectToDatabase.BronzeTrophies(Username);
        }

        /// <summary>
        /// Get the description of the Activity given as param. 
        /// </summary>
        /// <param name="activityName"></param>Name of Activity.
        /// <returns></returns>The description of the given Activity
        public String GetActivityDescriptionQuery(String activityName)
        {
            return connectToDatabase.GetActivityDescriptionQuery(activityName);
        }

        /// <summary>
        /// Get the description of the Challenge given as param. 
        /// </summary>
        /// <param name="challengeName"></param>Name of Challenge
        /// <returns></returns>The description of the given Challenge
        public String GetChallengeDescriptionQuery(String challengeName)
        {
            return connectToDatabase.GetChallengeDescriptionQuery(challengeName);
        }

        /// <summary>
        /// Get the Activity that is currently hovered.
        /// </summary>
        /// <param name="currentActivityHover"></param>Name of the currently Activity hover.
        /// <returns></returns>Returns the Activity being hovered.
        public Activity GetActivityQuery(String currentActivityHover)
        {
            return connectToDatabase.GetActivityQuery(currentActivityHover);
        }

        /// <summary>
        /// Get the Challenge that is currently hovered.
        /// </summary>
        /// <param name="currentChallengeHover"></param>Name of the currently Challenge hover.
        /// <returns></returns>Returns the Challenge being hovered.
        public Challenge GetChallengeQuery(String currentChallengeHover)
        {
            return connectToDatabase.GetChallengeQuery(currentChallengeHover);
        }

        /// <summary>
        /// Method for getting the recommended Activities for the User. 
        /// </summary>
        /// <returns></returns>A list with strings that is the names of the recommended activities. 
        public List<string> RecommendedActivities()
        {
            return connectToDatabase.RecommendedActivities(CurrentMood);
        }

        public List<Trophy> GetAllTrophies()
        {
            return connectToDatabase.AllTrophies();
        }

		/// <summary>
		/// Submit a comment with a grade to the database.
		/// </summary>
		/// <param name="grade">The grade from the user</param>
		/// <param name="comment">The comment from the user</param>
        public void submitComment(int grade, string comment)
        {
            connectToDatabase.SubmitComment(grade,comment,Username,CurrentActivity.Activity.Name);
        }

        public List<Trophy> EarnedTrophies()
        {
            return connectToDatabase.getTrophiesEarnedAfterActivity(Username);
        }
    }
}