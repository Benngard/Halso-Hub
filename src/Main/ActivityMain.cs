using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using Halso_Hub.Main;

/// <summary>
/// Main class building the program window
/// </summary>
/// Author: Daniel Edsinger

namespace Halso_Hub
{
	partial class ActivityMain : Form, IActivityMain
    {
        private Presenter presenter;

		/// <summary>
		/// Initialize components in application window.
		/// </summary>
		public ActivityMain()
		{
			InitializeComponent();
            timer.Stop();
        }

        /// <summary>
        /// Sets the presenter for this form
        /// </summary>
        /// <param name="presenter"></param> the presenter for this form
        public void setPresenter(Presenter presenter)
        {
            this.presenter = presenter;
        }

        /// <summary>
        /// Notifys the presenter that a second has passed
        /// </summary>
        /// <param name="sender"></param> object that sent the event
        /// <param name="e"></param> event params (not used)
		private void timer_Tick(object sender, EventArgs e)
		{

            presenter.timerTick();
		}

        /// <summary>
        /// Unused.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void timerText_Click(object sender, EventArgs e)
		{

		}

        /// <summary>
        /// Unused
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Notifys the presenter that the first mood button has been pressed
        /// </summary>
        /// <param name="sender"></param> object that sent the event
        /// <param name="e"></param> event params (not used)
        private void moodButton1_Click(object sender, EventArgs e) {
            presenter.moodButtonPressed(moodButton1.Text);
        }

        /// <summary>
        /// Notifys the presenter that the second mood button has been pressed
        /// </summary>
        /// <param name="sender"></param> object that sent the event
        /// <param name="e"></param> event params (not used)
        private void moodButton2_Click(object sender, EventArgs e)
        {
            presenter.moodButtonPressed(moodButton2.Text);
        }

        /// <summary>
        /// Notifys the presenter that the third mood button has been pressed
        /// </summary>
        /// <param name="sender"></param> object that sent the event
        /// <param name="e"></param> event params (not used)
        private void moodButton3_Click(object sender, EventArgs e)
        {
            presenter.moodButtonPressed(moodButton3.Text);
        }

        /// <summary>
        /// Notifys the presenter that the forth mood button has been pressed
        /// </summary>
        /// <param name="sender"></param> object that sent the event
        /// <param name="e"></param> event params (not used)
        private void moodButton4_Click(object sender, EventArgs e)
        {
            presenter.moodButtonPressed(moodButton4.Text);
        }

        /// <summary>
        /// Notifys the presenter that the start button has been pressed
        /// </summary>
        /// <param name="sender"></param> object that sent the event
        /// <param name="e"></param> event params (not used)
        private void startButton_Click(object sender, EventArgs e)
        {
            if (!presenter.activitySelected)
            {
                presenter.startButtonPressed(challengeButton, activityDecriptionLabel, activitiesLabel);
            }
            changeNameOnStartButton();
        }

        /// <summary>
        /// Toggle the challengeButton between "Challenge" and "activity"
        /// </summary>
        /// <param name="sender"></param> Object that sent the event.
        /// <param name="e"></param> Event params.
        private void challengeButton_Click(object sender, EventArgs e)
        {
            presenter.changeBetweenChallengeAndActivity(challengeButton, activityDecriptionLabel, activitiesLabel, activitiesListbox);
        }

        /// <summary>
        /// Handles indexing of the activity list and forwards the last pressed activity to the presenter
        /// </summary>
        /// <param name="sender"></param> Object that sent the event
        /// <param name="e"></param> Event params (not used)
        private void activitiesList_SelectedIndexChanged(object sender, EventArgs e)
        {

            string curItem = activitiesListbox.SelectedItem.ToString();
			int index = activitiesListbox.FindString(curItem);

            if (challengeButton.Text == "Challenge" || activitiesLabel.Text == "Activities for challenge")
            {
                presenter.activityPressed(curItem);
            }
            else
            {
                presenter.challengePressed(curItem);
            }
        }

        /// <summary>
        /// Updates the four mood button's and the title's text
        /// </summary>
        /// <param name="one"></param> Text for button 1
        /// <param name="two"></param> Text for button 2
        /// <param name="three"></param> Text for button 3
        /// <param name="four"></param> Text for button 4
        /// <param name="title"></param> Text for title
        public void updateMoodButtons(string one, string two, string three, string four, string title)
        {
            moodButton1.Text = one;
            moodButton2.Text = two;
            moodButton3.Text = three;
            moodButton4.Text = four;
            moodLabel.Text = title;
        }

        /// <summary>
        /// Sets the four mood buttons to visible
        /// </summary>
        public void showAllMoodButtons()
        {
            moodButton1.Visible = true;
            moodButton2.Visible = true;
            moodButton3.Visible = true;
            moodButton4.Visible = true;
        }

        /// <summary>
        /// Sets moodButton1 to visible, the other three to invisible
        /// </summary>
        public void showOneMoodButton()
        {
            moodButton1.Visible = true;
            moodButton2.Visible = false;
            moodButton3.Visible = false;
            moodButton4.Visible = false;
        }

        /// <summary>
        /// Updates the activitiesListBox with the recommended activities.
        /// </summary>
        /// <param name="activities"></param> List with the recommended activities.
        public void updateActivityList(List<string> activities)
        {
            activitiesListbox.Items.Clear();

            foreach (string s in activities)
            {
                activitiesListbox.Items.Add(s);
            }
        }

        /// <summary>
        /// Updates the activitiesListBox with challenges.
        /// </summary>
        /// <param name="activities"></param> List with challenges
        public void updateChallengeList(List<string> challenges)
        {
            activitiesListbox.Items.Clear();

            foreach (string s in challenges)
            {
                activitiesListbox.Items.Add(s);
            }
        }

        /// <summary>
        /// Updates the activityDescriptionBox with information about the selected activity.
        /// </summary>
        /// <param name="description"></param> Information about the selected activity.
        public void updateActivityInfo(string description)
        {
            activityDescriptionBox.Clear();
            activityDescriptionBox.AppendText(description);
        }

        /// <summary>
        /// Updates the activityDescriptionBox with information about the selected challenge
        /// </summary>
        /// <param name="description"></param> Information about the selected challenge
        public void updateChallengeInfo(string description)
        {
            activityDescriptionBox.Clear();
            activityDescriptionBox.AppendText(description);
        }

        /// <summary>
        /// Sets the timer and it's text to visible and updates the text with param and then starts the timer
        /// </summary>
        /// <param name="time"></param> time to be displayed
        public void setupTimer(string time)
        {
            activitiesListbox.Items.Clear();
            timerText.Text = time;
            timerText.Visible = true;
            timeLeftText.Visible = true;
            timer.Start();

        }

        /// <summary>
        /// Updates the text of the timer with param
        /// </summary>
        /// <param name="time"></param> time to be displayed
        public void updateTimer(string time)
        {
            timerText.Text = time;
        }

        /// <summary>
        /// Hides the timer
        /// </summary>
        public void hideAndStopTimer()
        {
            timerText.Visible = false;
            timeLeftText.Visible = false;
            timer.Stop();
        }

        /// <summary>
        /// Stops the timer
        /// </summary>
        public void StopTimer()
        {
            timer.Stop();
        }

        /// <summary>
        /// Starts the timer
        /// </summary>
        public void StartTimer()
        {
            timer.Start();
        }

        /// <summary>
        /// Creates the pop-up window for a activity from the other form Pop-up_Form
        /// and shows it as a dialog to make it impossible for the user to interact with the main form
        /// </summary>
        public void createActivityPopUp()
        {
            Pop_up pop_up = new Pop_up();
            pop_up.Text = "Congratulations you have finished the chosen activity!";
            pop_up.ShowDialog();
        }

        /// <summary>
        /// Creates the pop-up window for a challenge from the other form Pop-up_Form
        /// and shows it as a dialog to make it impossible for the user to interact with the main form
        /// </summary>
        public void createChallengePopUp()
        {
            Pop_up pop_up = new Pop_up();
            pop_up.Text = "Congratulations you have finished the chosen challenge!";
            pop_up.ShowDialog();
        }

        /// <summary>
        /// Creates the pop-up window for a trophy from the other form Pop-up_Form
        /// and shows it as a dialog to make it impossible for the user to interact with the main form
        /// </summary>
        public void createTrophyPopUp()
        {
            TrophyForm trophyForm = new TrophyForm();
            trophyForm.Text = "You have won a trophy!";
            trophyForm.ShowDialog();
        }

        /// <summary>
        /// Change the name on startButton to "Stop" or "Start"
        /// </summary>
        public void changeNameOnStartButton()
        {
            if (presenter.activitySelected && startButton.Text == "Start")
            {
                startButton.Text = "Stop";
            }

            else if (startButton.Text == "Stop")
            {
                StopTimer();
                DialogResult dialogResult = MessageBox.Show("Do you really wanna quit?", "Quit", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    startButton.Text = "Start";
                    hideAndStopTimer();
                    presenter.dropActivity();
                    presenter.activitySelected = false;
                }
                else
                {
                    StartTimer();
                }
            }
        }
    }
}
