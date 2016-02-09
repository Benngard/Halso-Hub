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
    /// Unit Test Suite for the Challenge package.
    /// TO-DO Add reliable test for TimeLeft() in Challange.cs
    /// </summary>
    [TestClass]
    public class ChallengeTestSuite
    {
        /// <summary>
        /// Test for the constructor in Time.cs
        /// </summary>
        [TestMethod]
        public void TestTimeConstructor()
        {
            int hour = 2;
            int min = 2;
            int sec = 2;

            Time testTime = new Time(hour, min, sec);

            Assert.AreEqual(hour, testTime.Hours);
            Assert.AreEqual(min, testTime.Minutes);
            Assert.AreEqual(sec, testTime.Seconds);
        }

        /// <summary>
        /// Test for the constructor in Challenge.cs with valid parameters
        /// </summary>
        [TestMethod]
        public void TestChallangeConstructorWithValidParameters()
        {
            string name = "John Doe";
            string description = "Complete me";
            Time startTime = new Time(00, 20, 30);
            Time endTime = new Time(01, 30, 20);
            List<Activity> requirements = new List<Activity>();
            requirements.Add(new Activity("John Doe", "Complete me", 3, 4, null));

            Challenge challange = new Challenge(name, description, startTime, endTime, requirements);

            Assert.AreEqual(name, challange.Name);
            Assert.AreEqual(description, challange.Description);
            Assert.AreEqual(startTime, challange.StartTime);
            Assert.AreEqual(endTime, challange.EndTime);
            Assert.AreEqual(requirements, challange.Requirements);
        }

        /// <summary>
        /// Test for the constructor in Challenge.cs with null parameters
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestChallangeConstructorWithNullParameters()
        {
            Challenge challenge = new Challenge(null, null, null, null, null);
        }

        /// <summary>
        /// Test for the constructor in Challenge.cs with invalid parameters
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestChallangeConstructorWithInvalidParameters()
        {
            string name = "John Doe";
            string description = "Complete me";
            Time startTime = new Time(00, 20, 30);
            Time endTime = new Time(01, 30, 20);
            List<Activity> requirements = new List<Activity>();

            Challenge challange = new Challenge(name, description, startTime, endTime, requirements);
        }

        /// <summary>
        /// Test for isOver() evaluation to true in Challenge.cs will fail between 00:00:00 and 00:00:01
        /// </summary>
        [TestMethod]
        public void TestIsOverEvaluatesToTrue()
        {
            string name = "John Doe";
            string description = "Complete me";
            Time startTime = new Time(00, 00, 00);
            Time endTime = new Time(00, 00, 01);
            List<Activity> requirements = new List<Activity>();
            requirements.Add(new Activity("John Doe", "Complete me", 3, 4, null));

            Challenge challenge = new Challenge(name, description, startTime, endTime, requirements);
            bool expectedToBeTrue = true;

            Assert.AreEqual(expectedToBeTrue, challenge.IsOver());
        }

        /// <summary>
        /// Test for isOver() evaluation to false in Challenge.cs
        /// </summary>
        [TestMethod]
        public void TestIsOverEvaluatesToFalse()
        {
            string name = "John Doe";
            string description = "Complete me";
            Time startTime = new Time(00, 00, 00);
            Time endTime = new Time(23, 59, 59);
            List<Activity> requirements = new List<Activity>();
            requirements.Add(new Activity("John Doe", "Complete me", 3, 4, null));

            Challenge challenge = new Challenge(name, description, startTime, endTime, requirements);
            bool expectedToBeTrue = false;

            Assert.AreEqual(expectedToBeTrue, challenge.IsOver());
        }

        /// <summary>
        /// Test for the constructor in CurrentChallenge.cs with valid parameter
        /// This test does not test for startTime
        /// </summary>
        [TestMethod]
        public void TestCurrentChallangeConstructorWithValidParameter()
        {
            List<Activity> requirements = new List<Activity>();
            requirements.Add(new Activity("John Doe", "Complete me", 3, 4, null));
            Challenge challenge = new Challenge("test", "test", new Time(0, 0, 0), new Time(1, 0, 0), requirements);
            CurrentChallenge currentChallange = new CurrentChallenge(challenge);

            DateTime now = DateTime.Now;

            Assert.AreEqual(challenge, currentChallange.Challenge);
        }

        /// <summary>
        /// Test for the constructor in CurrentChallenge.cs with null parameter
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestCurrentChallangeConstructorWithNullParameter()
        {
            CurrentChallenge CurrentChallange = new CurrentChallenge(null);
        }
    }
}
