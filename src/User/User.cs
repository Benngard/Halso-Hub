using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Mattias Benngård
/// </summary>
namespace Halso_Hub
{
	/// <summary>
	/// Is a user of the application.
	/// </summary>
    class User : IUser
    {
		public string Username { get; private set; }
		
		public Hashtable CurrentMood { get; private set; }

		public CurrentActivity CurrentActivity { get; private set; }
		public List<CompletedActivity> CompletedActivities { get; private set; }

		public List<Trophy> Trophies { get; private set; }

		public CurrentChallenge CurrentChallenge { get; private set; }
		public List<Challenge> CompletedChallenges { get; private set; }

		/// <summary>
		/// TEMPORARY
		/// Constructs a user with its fields.
		/// </summary>
		/// <param name="username">Name of the user.</param>
		public User (string username)
		{
			Username = username;
			CurrentMood = new Hashtable();
			CurrentMood.Add("sad", MoodType.VeryHappy);
			CurrentMood.Add("tired", MoodType.VeryEnergetic);
			CurrentMood.Add("stressed", MoodType.VeryCalm);
			CurrentMood.Add("lonely", MoodType.VerySociable);
		}

		/// <summary>
		/// Adds a new mood to the user.
		/// </summary>
		/// <param name="moodType">Which MoodType to add. Duplicates will not be stored.</param>
		public void ChangeMood(String type, MoodType mood)
		{
			CurrentMood.Remove(type);
			CurrentMood.Add(type,mood);
		}

        /// <summary>
        /// Emptys the Hashset containing the users mode
        /// </summary>
        public void ResetMood()
        {
            //CurrentMood.Clear();
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
		}

		/// <summary>
		/// Sets CurrentActivity to null.
		/// </summary>
		public void DropCurrentActivity()
		{
			CurrentActivity = null;
		}

		/// <summary>
		/// LEFT TO DO
		/// Gets recommended activities depending on the users mood.
		/// </summary>
		/// <returns>A List of Activities based on the user's mood.</returns>
		public List<Activity> GetRecommendedActivities()
		{
			var recommendedActivities = new List<Activity>();

            recommendedActivities.Add(new Activity("Yoga", "Träna Yoga! Tid: 10 sec", 5, 10, null)); //Temp activity for testing
            recommendedActivities.Add(new Activity("Kaffe", "Drick en kopp kaffe. Tid 15 sec", 3, 15, null)); //Temp activity for testing

            // LEFT TO DO : ADD ACTIVITIES TO LIST FROM DB

            return recommendedActivities;
		}

        /// <summary>
        /// Gets all challenges
        /// </summary>
        /// <returns></returns>A List of Challenges.
        public List<Challenge> GetRecommendedChallenges()
        {
            var recommendedChallenges = new List<Challenge>();

            recommendedChallenges.Add(new Challenge("Fitness Guru", "Yoga and push ups. ", new Time(13, 00, 00), new Time(17, 00, 00), GetRecommendedActivities())); //Temp challenge for testing
            recommendedChallenges.Add(new Challenge("Drinking Master", "Drink as much as possible.", new Time(13, 00, 00), new Time(17, 00, 00), GetRecommendedActivities())); //Temp challenge for testing

            // LEFT TO DO : ADD CHALLENGES TO LIST FROM DB

            return recommendedChallenges;
        }

        /// <summary>
        /// Invokes CompleteActivity with CurrentActivity as activity.
        /// </summary>
        /// <param name="grade">What grade the user gives the activity.</param>
        /// <param name="comment">Any feedback the user leaves to the activity. Can be left blank or nulled.</param>
        /// <returns>A list of all trophies that was earned. If no trophies have been earned then an empty list of trophies.</returns>
        public List<Trophy> CompleteCurrentActivity(ActivityGrade grade, String comment)
		{
			var trophies = CompleteActivity(CurrentActivity, grade, comment);
			CurrentActivity = null;
			return trophies;
		}

		/// <summary>
		/// LEFT TO DO:
		/// ExceptionHandling
		/// </summary>
		/// <param name="activity">Which activity has been completed.</param>
		/// <param name="grade">What grade the user gives the activity.</param>
		/// <param name="comment">Any feedback the user leaves to the activity. Can be left blank or nulled.</param>
		/// <returns>A list of all trophies that was earned. If no trophies have been earned then an empty list of trophies.</returns>
		public List<Trophy> CompleteActivity(CurrentActivity activity, ActivityGrade grade, String comment)
		{
			var newTrophies = new List<Trophy>();

			// avoid completing null activities or activities with time left on them, returns the empty list of Trophe
			if (activity == null || activity.TimeLeft > 0)
			{
				return newTrophies;
			}

			// remove moods from current mood based on what the activity cures
			foreach (MoodType m in activity.Activity.CuresMoods)
			{
				CurrentMood.Remove(m);
			}

			// check if any trophy was completed -- LEFT TO DO : Get Trophies from Database to compare against

			// remembers activity as completed -- LEFT TO DO : Add to Database
			CompletedActivities.Add(new CompletedActivity (activity.Activity, grade, comment));

			// returns all trophies earned, might be an empty list of no trophies have been earned
			return newTrophies;
		}

		/// <summary>
		/// Get the total amount of points.
		/// </summary>
		/// <returns>Total number of points the user has achieved by summating all activities.</returns>
		public int TotalPoints()
		{
			return CompletedActivities.Sum(a => a.Activity.Points);
		}

		/// <summary>
		/// Get the total amount of gold trophies.
		/// </summary>
		/// <returns>Total amount of gold trophies earned by the user.</returns>
		public int TotalGoldTrophies()
		{
			return Trophies.Count(i => i.Type == TrophyType.Gold);
		}

		/// <summary>
		/// Get the total amount of silver trophies.
		/// </summary>
		/// <returns>Total amount of silver trophies earned by the user.</returns>
		public int TotalSilverTrophies()
		{
			return Trophies.Count(i => i.Type == TrophyType.Silver);
		}

		/// <summary>
		/// Get the total amount of bronze trophies.
		/// </summary>
		/// <returns>Total amount of bronze trophies earned by the user.</returns>
		public int TotalBronzeTrophies()
		{
			return Trophies.Count(i => i.Type == TrophyType.Bronze);
		}

		/// <summary>
		/// Sets the current challenge, if there already is one then throws AlreadyInAChallengeException.
		/// </summary>
		/// <param name="newChallenge">Which challenge to undertake for the user.</param>
		public void SetCurrentChallenge(Challenge newChallenge)
		{
			// can not start a new challenge before completing the old one
			if (CurrentChallenge != null)
			{
				throw new AlreadyInChallengeException("Already performing in a challenge.");
			}

			// new challenge is set for the user
			CurrentChallenge = new CurrentChallenge(newChallenge);
		}

		/// <summary>
		/// Completes the current challenge if the deadline has not been passed,
		/// also adds it to the list of completed challenges.
		/// If so then fails the challenge and throws TimeIsUpForChallengeException.
		/// </summary>
		public void CompleteCurrentChallenge()
		{
			if (CurrentChallenge.Challenge.IsOver())
			{
				FailCurrentChallenge();
				throw new TimeIsUpForChallengeException("Deadline for this challenge has passed.");
			}
			CompletedChallenges.Add(CurrentChallenge.Challenge);
			CurrentChallenge = null;
		}

		/// <summary>
		/// Sets CurrentChallenge to null, should be invoked when time of challenge is complete.
		/// Automatically called in CompleteCurrentChallenge() if the time is over.
		/// </summary>
		public void FailCurrentChallenge()
		{
			CurrentChallenge = null;
		}

        /// <summary>
        /// Finds an activity from GetRecommendedActivities based on the Activitys name.
        /// </summary>
        /// <param name="name"></param> The name of the activity to be found
        /// <returns></returns> If found return the activity, else return null
        public Activity findRecommendedActivityByName(string name)
        {
            foreach (Activity a in GetRecommendedActivities())
            {
                if (a.Name.Equals(name)) {
                    return a;
                }
            }
            return null;
        }

        /// <summary>
        /// Finds an challenge from GetRecommendedChallenges based on the Challenges name.
        /// </summary>
        /// <param name="name"></param>The name of the challenge to be found 
        /// <returns></returns>If found return the challenge, else return null
        public Challenge findRecommendedActivityForChallenge(string name)
        {
            foreach (Challenge c in GetRecommendedChallenges())
            {
                if (c.Name.Equals(name))
                {
                    return c;
                }
            }
            return null;
        }
    }
}