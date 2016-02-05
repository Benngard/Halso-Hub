﻿using System;
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
    class User
    {
		public string Username { get; private set; }
		
		public HashSet<MoodType> CurrentMood { get; private set; }

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
		/// Gives the user a new activity to perform. Can not already be doing an activity.
		/// </summary>
		/// <param name="newActivity">New activity to start with.</param>
		public void SetCurrentActivity(Activity newActivity)
		{
			// can not start a new activity before completing the old one
			if (CurrentActivity == null)
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

			// LEFT TO DO : ADD ACTIVITIES TO LIST

			return recommendedActivities;
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
    }
}