using System;
using System.Collections;
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
        CurrentActivity CurrentActivity { get; }
        CurrentChallenge CurrentChallenge { get; }
        List<Challenge> CompletedChallenges { get; }

        String GetActivityDescriptionQuery(String activityName);
        String GetChallengeDescriptionQuery(String challengeName);
        Activity GetActivityQuery(String currentActivityHover);
        Challenge GetChallengeQuery(String currentChallengeHover);
        List<string> ActiveChallenges();
        List<string> RecommendedActivities();
        List<Trophy> allTrophies();

        void AddMood(MoodType moodType);
        void ResetMood();
        void SetCurrentActivity(Activity newActivity);
        void DropCurrentActivity();
        List<string> GetRecommendedActivities();
        List<Notification> CompleteCurrentActivity(int grade, String comment);
        int TotalPoints();
        int TotalGoldTrophies();
        int TotalSilverTrophies();
        int TotalBronzeTrophies();
        void SetCurrentChallenge(Challenge newChallenge);
        void FailCurrentChallenge();
    }
}
