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
    /// Unit Test Suite for Presenter.cs. 
    /// This testsuite is designed to test the constructor and that input from the View is working correctly.
    /// The tests do not check that the logic of the program behave as expected since there are separate tests for it.
    /// The tests do not test the View but rather uses a "Mock View" to verify that presenter.cs is working.
    /// 
    /// WARNING: SOME TESTS ALTER THE DATABASE! THESE TESTS ARE; TestActivityGradeButtonPressed()
    /// </summary>
    [TestClass]
    public class PresenterTestSuite
    {
        /// <summary>
        /// Tests the presenter constructor and subsequently; stopAndHideTimer, setupGUI, partially updateMoodButtons and showAllMoodButtons
        /// </summary>
        [TestMethod]
        public void TestPresenterConstructor()
        {
            MockView View = new MockView();
            User user = new User("testUser");
            Presenter pres = new Presenter(View, user);

            // Constructor
            Assert.AreEqual(pres, View.p);

            // stopAndHideTimer
            Assert.AreEqual(true, View.timerHidden);

            // updateMoodButtons
            Assert.AreEqual("VerySad", View.one);
            Assert.AreEqual("Sad", View.two);
            Assert.AreEqual("Happy", View.three);
            Assert.AreEqual("VeryHappy", View.four);
            Assert.AreEqual("How do you feel?", View.title);

            // showAllMoodButtons
            Assert.AreEqual(true, View.showAllMoodButtonsFlag);
        }

        /// <summary>
        /// Tests moodButtonPressed(string mood)
        /// The method has to be run 4 times for full covarage
        /// </summary>
        [TestMethod]
        public void TestMoodButtonPressed()
        {
            MockView View = new MockView();
            User user = new User("testUser");
            Presenter pres = new Presenter(View, user);

            pres.moodButtonPressed("Sad");
            Assert.AreEqual("VeryTierd", View.one);
            Assert.AreEqual("Tired", View.two);
            Assert.AreEqual("Energetic", View.three);
            Assert.AreEqual("VeryEnergetic", View.four);
            Assert.AreEqual("How do you feel?", View.title);

            pres.moodButtonPressed("Tired");
            Assert.AreEqual("VeryStressed", View.one);
            Assert.AreEqual("Stressed", View.two);
            Assert.AreEqual("Calm", View.three);
            Assert.AreEqual("VeryCalm", View.four);
            Assert.AreEqual("How do you feel?", View.title);

            pres.moodButtonPressed("Stressed");
            Assert.AreEqual("VeryLonely", View.one);
            Assert.AreEqual("Lonely", View.two);
            Assert.AreEqual("Sociable", View.three);
            Assert.AreEqual("VerySociable", View.four);
            Assert.AreEqual("How do you feel?", View.title);

            pres.moodButtonPressed("Lonely");
            Assert.AreEqual("Update now!", View.one);
            Assert.AreEqual("Hidden", View.two);
            Assert.AreEqual("Hidden", View.three);
            Assert.AreEqual("Hidden", View.four);
            Assert.AreEqual("Do you want to update your Mood?", View.title);

            Assert.AreEqual(false, View.showAllMoodButtonsFlag);
            Assert.IsNotNull(View.ActivityList);
        }

        /// <summary>
        /// Test for activityPressed(string activityName)
        /// This test may fail if the database is changed.
        /// </summary>
        [TestMethod]
        public void TestActivityPressed()
        {
            MockView View = new MockView();
            User user = new User("testUser");
            Presenter pres = new Presenter(View, user);

            pres.activityPressed("Limbo");

            Assert.AreEqual("How low can you go?", View.testActivityDescription);
        }

        /// <summary>
        /// Test for challengePressed(string challengeName)
        /// This test may fail if the databse is changed.
        /// </summary>
        [TestMethod]
        public void TestChallengePressed()
        {
            MockView View = new MockView();
            User user = new User("testUser");
            Presenter pres = new Presenter(View, user);

            pres.challengePressed("Flexibility & Strength");

            Assert.AreEqual("Complete both Strength of an ox and Limbo Master to finish this challenge!", View.testChallangeDescription);
        }

        /// <summary>
        /// Test for startButtonPressed(Button b, Label labelDescription, Label l)
        /// TO-DO Implement this test when startButtonPressed is adapted to the MVP pattern
        /// </summary>
        [TestMethod]
        public void TestStartButtonPressed()
        {
            MockView View = new MockView();
            User user = new User("testUser");
            Presenter pres = new Presenter(View, user);

            // The following is a stub...

            // The activity test is covered by TestTimer
            // For challange:
            // Once adapted to the MVP pattern [labelDescription.Text = "Description"] and [l.Text = "Activities for challenge"] should be set
            // using a method (in IActivityMain) that takes 2 string params. These needs to be verified using the MockView...
        }

        /// <summary>
        /// Test for timerTick(), setupAndStartTimer and completeActivity
        /// TO-DO Implement this test when startButtonPressed is adapted to the MVP pattern and completeActivity is fully implemented
        /// </summary>
        [TestMethod]
        public void TestTimer()
        {
            MockView View = new MockView();
            User user = new User("testUser");
            Presenter pres = new Presenter(View, user);

            // The following is a stub...
            /* XXX MUST BE REPLACED BY AN ACTIVITY USING THE TIMER!
            pres.startButtonPressed(XXX);
            int timeLeft = user.CurrentActivity.TimeLeft;
            for (int i = 0; i < timeLeft; i++)
            {
                pres.timerTick();
                Assert.AreEqual(String.Format("{0:00} min {1:00} sec", timeLeft / 60, timeLeft % 60), View.testTimeLeft);
            }
            pres.timerTick();
            Assert.AreEqual(true, View.testcreateActivityPopUp);
            */

        }

        /// <summary>
        /// activityGradeButtonPressed(int grade, string feedback)
        /// TO-DO implement the rest of the test once activityGradeButtonPressed is fully implemented.
        /// WARNING: THIS TEST ALTERS THE DATABASE BY THE COMPLETION OF AN ACTIVITY! AFFECTED TABLE: `halso_hub`.ActivityCompleted
        /// </summary>
        [TestMethod]
        public void TestActivityGradeButtonPressed()
        {
            MockView View = new MockView();
            User user = new User("testUser");
            Presenter pres = new Presenter(View, user);

            pres.activityGradeButtonPressed(2, "THIS WAS AUTO-GENERATED FROM A TEST, REMOVE FROM THE DATABASE");

        }

        /// <summary>
        /// changeBetweenChallengeAndActivity(Button b, Label labelDescription, Label l, ListBox lb, RichTextBox rtb)
        /// TO-DO Implement this test when changeBetweenChallengeAndActivity is adapted to the MVP pattern
        /// </summary>
        [TestMethod]
        public void TestChangeBetweenChallengeAndActivity()
        {
            MockView View = new MockView();
            User user = new User("testUser");
            Presenter pres = new Presenter(View, user);

            // In the current form changeBetweenChallengeAndActivity takes gui elements. This should not be the case.
            // It should instead take strings and communicate back via the interface IActivityMain by calling methods
            // and passing arguments as strings. Once this is done
        }

        /// <summary>
        /// Inner class representing a Mock View for testing
        /// </summary>
        private class MockView : IActivityMain
        {
            public Presenter p;
            public bool timerHidden = false;

            public string one;
            public string two;
            public string three;
            public string four;
            public string title;

            public bool showAllMoodButtonsFlag = false;

            public List<string> ActivityList;

            public string testActivityDescription;
            public string testChallangeDescription;

            public string testTimeLeft;

            public bool testcreateActivityPopUp = false;

            public void createActivityPopUp()
            {
                testcreateActivityPopUp = true;
            }

            public void createChallengePopUp()
            {

            }

            public void createTrophyPopUp()
            {

            }

            public void hideAndStopTimer()
            {
                timerHidden = true;
            }

            public void setPresenter(Presenter presenter)
            {
                p = presenter;
            }

            public void setupTimer(string time)
            {
                testTimeLeft = time;
            }

            public void showAllMoodButtons()
            {
                showAllMoodButtonsFlag = true;
            }

            public void showOneMoodButton()
            {
                showAllMoodButtonsFlag = false;
            }

            public void updateActivityInfo(string description)
            {
                testActivityDescription = description;
            }

            public void updateActivityList(List<string> activities)
            {
                ActivityList = activities;
            }

            public void updateChallengeInfo(string description)
            {
                testChallangeDescription = description;
            }

            public void updateChallengeList(List<string> challenges)
            {

            }

            public void updateMoodButtons(string one, string two, string three, string four, string title)
            {
                this.one = one;
                this.two = two;
                this.three = three;
                this.four = four;
                this.title = title;
            }

            public void updateTimer(string time)
            {
                testTimeLeft = time;
            }
        }
    }

}
