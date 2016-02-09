using Halso_Hub;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

/// <summary>
/// Anton Andrén
/// </summary>
namespace Halso_Hub_Tests
{
    /// <summary>
    /// Unit Test Suite for the User package.
    /// </summary>
    [TestClass]
    public class UserTestSuite
    {
        /// <summary>
        /// Test for the constructor in Trophy.cs
        /// </summary>
        [TestMethod]
        public void TestTrophyConstructor()
        {
            string Name = "test";
            string Description = "hello world";
            TrophyType TrophyType = TrophyType.Gold;
            List<Activity> Requirements = new List<Activity>();
            Requirements.Add(new Activity("John Doe", "Complete me", 3, 4, null));

            Trophy Trophy = new Trophy(Name, Description, TrophyType, Requirements);

            Assert.AreEqual(Name, Trophy.Name);
            Assert.AreEqual(Description, Trophy.Description);
            Assert.AreEqual(TrophyType, Trophy.Type);
            Assert.AreEqual(Requirements, Trophy.Requirements);
        }

        /// <summary>
        /// Test for the constructor in User.cs
        /// </summary>
        [TestMethod]
        public void TestUserConstructor()
        {
            string UserName = "John Doe";
            User User = new User(UserName);

            Assert.AreEqual(UserName, User.Username);
        }

        /// <summary>
        /// Test for AddMood() in User.cs
        /// </summary>
        [TestMethod]
        public void TestAddMood()
        {
            MoodType Mood = MoodType.Lonely;
            string UserName = "John Doe";
            User User = new User(UserName);

            Assert.AreEqual(0, User.CurrentMood.Count);

            User.AddMood(Mood);

            Assert.AreEqual(true, User.CurrentMood.Contains(Mood));
            Assert.AreEqual(1, User.CurrentMood.Count);
        }

        /// <summary>
        /// Test for SetCurrentActivity(Activity newActivity) in User.cs when the user does not have a current acitivity
        /// </summary>
        [TestMethod]
        public void TestSetCurrentActivityWhenTheUserHasNoCurrentActivity()
        {
            string UserName = "John Doe";
            User User = new User(UserName);
            List<MoodType> CuresMoods = new List<MoodType>();
            CuresMoods.Add(MoodType.Sad);
            Activity Activity = new Activity("test", "Check this out", 8, 25, CuresMoods);

            User.SetCurrentActivity(Activity);
            

            Assert.AreEqual(Activity, User.CurrentActivity.Activity);
            Assert.AreEqual(Activity.Time, User.CurrentActivity.TimeLeft);
        }

        /// <summary>
        /// Test for SetCurrentActivity(Activity newActivity) in User.cs when the user does have a current acitivity
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(AlreadyInActivityException))]
        public void TestSetCurrentActivityWhenTheUserHasACurrentActivity()
        {
            string UserName = "John Doe";
            User User = new User(UserName);
            List<MoodType> CuresMoods = new List<MoodType>();
            CuresMoods.Add(MoodType.Sad);
            Activity Activity = new Activity("test", "Check this out", 8, 25, CuresMoods);

            User.SetCurrentActivity(Activity);
            User.SetCurrentActivity(Activity);
        }

        /// <summary>
        /// Test for DropCurrentActivity() in User.cs
        /// </summary>
        [TestMethod]
        public void TestDropCurrentActivity()
        {
            string UserName = "John Doe";
            User User = new User(UserName);
            List<MoodType> CuresMoods = new List<MoodType>();
            CuresMoods.Add(MoodType.Sad);
            Activity Activity = new Activity("test", "Check this out", 8, 25, CuresMoods);

            User.SetCurrentActivity(Activity);
            User.DropCurrentActivity();

            Assert.AreEqual(null, User.CurrentActivity);
        }

        /// <summary>
        /// Test for GetRecommendedActivities() in User.cs (Currently trivial)
        /// </summary>
        [TestMethod]
        public void TestGetRecommendedActivities()
        {
            string UserName = "John Doe";
            User User = new User(UserName);
            List<MoodType> CuresMoods = new List<MoodType>();
            CuresMoods.Add(MoodType.Sad);

            Assert.AreEqual(0, User.GetRecommendedActivities().Count);
        }

        /// <summary>
        /// Test for CompleteCurrentActivity(ActivityGrade grade, String comment) in User.cs 
        /// </summary>
        [TestMethod]
        public void TestCompleteCurrentActivity()
        {
            string UserName = "John Doe";
            User User = new User(UserName);
            List<MoodType> CuresMoods = new List<MoodType>();
            CuresMoods.Add(MoodType.Sad);
            Activity Activity = new Activity("test", "Check this out", 8, 25, CuresMoods);

            User.SetCurrentActivity(Activity);
            Assert.AreEqual(0, User.CompleteCurrentActivity(ActivityGrade.Good, "Like!").Count);
        }

        /// <summary>
        /// Test for CompleteActivity(CurrentActivity activity, ActivityGrade grade, String comment) in User.cs with null as CurrentActivity parameter
        /// </summary>
        [TestMethod]
        public void TestCompleteActivityWithNullParameter() {
            string UserName = "John Doe";
            User User = new User(UserName);
            CurrentActivity Activity = null;

            Assert.AreEqual(0, User.CompleteActivity(Activity, ActivityGrade.Good, "I just broke the system, haha").Count);
        }

        /// <summary>
        /// Test for CompleteActivity(CurrentActivity activity, ActivityGrade grade, String comment) in User.cs with time left
        /// </summary>
        [TestMethod]
        public void TestCompleteActivityWithTimeLeft()
        {
            string UserName = "John Doe";
            User User = new User(UserName);
            List<MoodType> CuresMoods = new List<MoodType>();
            CuresMoods.Add(MoodType.Sad);
            Activity Activity = new Activity("test", "Check this out", 8, 3, CuresMoods);
            CurrentActivity CurrentActivity = new CurrentActivity(Activity);

            List<Trophy> TrophyList = User.CompleteActivity(CurrentActivity, ActivityGrade.Good, "Need more time");

            Assert.AreEqual(0, TrophyList.Count);
        }

        /// <summary>
        /// Test for CompleteActivity(CurrentActivity activity, ActivityGrade grade, String comment) in User.cs when the user successfully completes an activity
        /// </summary>
        [TestMethod]
        public void TestCompleteActivity()
        {
            string UserName = "John Doe";
            User User = new User(UserName);
            User.AddMood(MoodType.Sad);
            List<MoodType> CuresMoods = new List<MoodType>();
            CuresMoods.Add(MoodType.Sad);
            Activity Activity = new Activity("test", "Check this out", 8, 0, CuresMoods);
            CurrentActivity CurrentActivity = new CurrentActivity(Activity);

            List<Trophy> TrophyList = User.CompleteActivity(CurrentActivity, ActivityGrade.Good, "Need more time");

            Assert.AreEqual(0, User.CurrentMood.Count);
            Assert.AreEqual(0, TrophyList.Count);
        }

        /// <summary>
        /// Test for TotalPoints() in User.cs
        /// </summary>
        [TestMethod]
        public void TestTotalPoints()
        {
            string UserName = "John Doe";
            User User = new User(UserName);
            User.AddMood(MoodType.Sad);
            List<MoodType> CuresMoods = new List<MoodType>();
            CuresMoods.Add(MoodType.Sad);
            Activity Activity = new Activity("test", "Check this out", 8, 0, CuresMoods);
            CurrentActivity CurrentActivity = new CurrentActivity(Activity);

            List<Trophy> TrophyList = User.CompleteActivity(CurrentActivity, ActivityGrade.Good, "Need more time");
            Assert.AreEqual(8, User.TotalPoints());
        }

        // TO-DO ADD TEST FOR TOTAL x TROPHY ONCE THEY ARE IMPLEMENTED.

        /// <summary>
        /// Test for SetCurrentChallenge(Challenge newChallenge) in User.cs when currently having an active challange
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(AlreadyInChallengeException))]
        public void TestSetCurrentChallengeWithActiveChallange()
        {
            string UserName = "John Doe";
            User User = new User(UserName);
            List<Activity> requirements = new List<Activity>();
            requirements.Add(new Activity("John Doe", "Complete me", 3, 4, null));
            Challenge Challange = new Challenge("test", "do me", new Time(0, 0, 3), new Time(0, 3, 0), requirements);

            User.SetCurrentChallenge(Challange);
            User.SetCurrentChallenge(Challange);
        }

        /// <summary>
        /// Test for SetCurrentChallenge(Challenge newChallenge) in User.cs when not on a challange
        /// </summary>
        [TestMethod]
        public void TestSetCurrentChallengeWithNoActiveChallange()
        {
            string UserName = "John Doe";
            User User = new User(UserName);
            List<Activity> requirements = new List<Activity>();
            requirements.Add(new Activity("John Doe", "Complete me", 3, 4, null));
            Challenge Challange = new Challenge("test", "do me", new Time(0, 0, 3), new Time(0, 3, 0), requirements);

            User.SetCurrentChallenge(Challange);

            Assert.AreEqual(Challange, User.CurrentChallenge.Challenge);
        }

        /// <summary>
        /// Test for CompleteCurrentChallenge() in User.cs when eligble 
        /// </summary>
        [TestMethod]
        public void TestCompleteCurrentChallengeWhenPossible()
        {
            string UserName = "John Doe";
            User User = new User(UserName);
            List<Activity> requirements = new List<Activity>();
            requirements.Add(new Activity("John Doe", "Complete me", 3, 4, null));
            Challenge Challenge = new Challenge("test", "do me", new Time(0, 0, 0), new Time(23, 59, 59), requirements);

            Assert.AreEqual(false, User.CompletedChallenges.Contains(Challenge));

            User.SetCurrentChallenge(Challenge);
            User.CompleteCurrentChallenge();

            Assert.AreEqual(null, User.CurrentChallenge);
            Assert.AreEqual(true, User.CompletedChallenges.Contains(Challenge));
        }

        /// <summary>
        /// Test for CompleteCurrentChallenge() in User.cs when deadline has passed
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(TimeIsUpForChallengeException))]
        public void TestCompleteCurrentChallengeWhenDeadlineExpired()
        {
            string UserName = "John Doe";
            User User = new User(UserName);
            List<Activity> requirements = new List<Activity>();
            requirements.Add(new Activity("John Doe", "Complete me", 3, 4, null));
            Challenge Challange = new Challenge("test", "do me", new Time(0, 0, 0), new Time(0, 0, 01), requirements);

            User.SetCurrentChallenge(Challange);

            User.CompleteCurrentChallenge();
        }

        /// <summary>
        /// Test for FailCurrentChallenge() in User.cs
        /// </summary>
        [TestMethod]
        public void TestFailCurrentChallenge()
        {
            string UserName = "John Doe";
            User User = new User(UserName);
            List<Activity> requirements = new List<Activity>();
            requirements.Add(new Activity("John Doe", "Complete me", 3, 4, null));
            Challenge Challange = new Challenge("test", "do me", new Time(0, 0, 0), new Time(0, 0, 01), requirements);

            User.SetCurrentChallenge(Challange);

            Assert.AreEqual(Challange, User.CurrentChallenge.Challenge);

            User.FailCurrentChallenge();

            Assert.AreEqual(null, User.CurrentChallenge);
        }

    }
}
