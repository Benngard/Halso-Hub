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
    /// Unit Test Suite for the Activity package.
    /// </summary>
    [TestClass]
    public class ActivityTestSuite
    {
        /// <summary>
        /// Test for the constructor in Activity.cs
        /// </summary>
        [TestMethod]
        public void TestActivityConstructor()
        {
            string name = "John Doe";
            string description = "Complete me";
            int points = 5;
            int time = 4;
            List<MoodType> curesMoods = new List<MoodType>();
            curesMoods.Add(MoodType.Sad);
            curesMoods.Add(MoodType.Lonely);

            Activity testActivity = new Activity(name, description, points, time, curesMoods);

            Assert.AreEqual(name, testActivity.Name);
            Assert.AreEqual(description, testActivity.Description);
            Assert.AreEqual(points, testActivity.Points);
            Assert.AreEqual(time, testActivity.Time);
            Assert.AreEqual(curesMoods, testActivity.CuresMoods);
        }

        /// <summary>
        /// Test for the constructor in CurrentActivity.cs
        /// </summary>
        [TestMethod]
        public void TestCurrentActivityConstructor()
        {
            Activity testActivity = new Activity("John Doe", "Complete me", 3, 4, null);
            CurrentActivity currActivity = new CurrentActivity(testActivity);

            Assert.AreEqual(testActivity, currActivity.Activity);
            Assert.AreEqual(testActivity.Time, currActivity.TimeLeft);
        }

        /// <summary>
        /// Test for the constructor in CompletedActivity.cs
        /// </summary>
        [TestMethod]
        public void TestCompletedActivityConstructor()
        {
            Activity testActivity = new Activity("John Doe", "Complete me", 3, 4, null);
            ActivityGrade ag = ActivityGrade.Superb;
            string comment = "Was great!";

            CompletedActivity completedActivity = new CompletedActivity(testActivity, ag, comment);

            Assert.AreEqual(testActivity, completedActivity.Activity);
            Assert.AreEqual(ag, completedActivity.Grade);
            Assert.AreEqual(comment, completedActivity.Comment);
        }
    }
}
