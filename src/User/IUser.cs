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
    /// Interface for the model (user) used by the presenter.
    /// </summary>
    interface IUser
    {
        string Username { get; }
        HashSet<MoodType> CurrentMood { get; }
        CurrentActivity CurrentActivity { get; }
        List<CompletedActivity> CompletedActivities { get; }
        List<Trophy> Trophies { get; }
        CurrentChallenge CurrentChallenge { get; }
        List<Challenge> CompletedChallenges { get; }

        void AddMood(MoodType moodType);
        void ResetMood();
        void SetCurrentActivity(Activity newActivity);
        void DropCurrentActivity();
        List<Activity> GetRecommendedActivities();
        List<Trophy> CompleteCurrentActivity(ActivityGrade grade, String comment);
        int TotalPoints();
        int TotalGoldTrophies();
        int TotalSilverTrophies();
        int TotalBronzeTrophies();
        void SetCurrentChallenge(Challenge newChallenge);
        void CompleteCurrentChallenge();
        void FailCurrentChallenge();
        Activity findRecommendedActivityByName(string name);
    }
}
