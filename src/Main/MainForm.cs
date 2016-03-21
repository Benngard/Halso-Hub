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
using System.Security.AccessControl;
using Halso_Hub.Main;
using Halso_Hub;
namespace Halso_Hub
{
    public partial class MainForm : Form
    {
        private Presenter presenter;

        /// <summary>
        /// Initialize components in application window.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            timer.Stop();
            this.tabControl.Location = new Point(0, 0);
            this.tabControl.Size = new Size(this.Width, this.Height);

			// Setup for the Trophies tab
			trophiesEarnedListView.SmallImageList = trophyImageList;
			trophiesEarnedListView.View = View.Details;
			trophiesEarnedListView.Columns.Clear();
			trophiesEarnedListView.Columns.Add("Trophies Earned", trophiesEarnedList.Width - 4, HorizontalAlignment.Left);

			trophiesNotEarnedListView.SmallImageList = trophyImageList;
			trophiesNotEarnedListView.View = View.Details;
			trophiesNotEarnedListView.Columns.Clear();
			trophiesNotEarnedListView.Columns.Add("Incompleted Trophies", trophiesEarnedList.Width - 4, HorizontalAlignment.Left);
		}

        /// <summary>
        /// Sets the presenter for this form
        /// </summary>
        /// <param name="presenter"></param> the presenter for this form
        public void setPresenter(Presenter presenter)
        {
            this.presenter = presenter;
        }

        /*------------------ Main Tab ----------------------------------------*/

        #region Main Tab


        private void ActivityButton_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
        }

        private void ChallengeButton_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 2;
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        #endregion

        /*----------------- Activity Tab -------------------------------------*/

        #region Activity Tab

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
            MoodButton1.Text = one;
            MoodButton2.Text = two;
            MoodButton3.Text = three;
            MoodButton4.Text = four;
            MoodHeadline.Text = title;
        }

        /// <summary>
        /// Sets the four mood buttons to visible
        /// </summary>
        public void showAllMoodButtons()
        {
            MoodButton1.Visible = true;
            MoodButton2.Visible = true;
            MoodButton3.Visible = true;
            MoodButton4.Visible = true;
        }

        /// <summary>
        /// Sets MoodButton1 to visible, the other three to invisible
        /// </summary>
        public void showOneMoodButton()
        {
            MoodButton1.Visible = true;
            MoodButton2.Visible = false;
            MoodButton3.Visible = false;
            MoodButton4.Visible = false;
        }

        /// <summary>
        /// Sets MoodButton1 and MoodButton2 to visible, the other two to invisible
        /// </summary>
        public void showTwoMoodButtons()
        {
            MoodButton1.Visible = true;
            MoodButton2.Visible = true;
            MoodButton3.Visible = false;
            MoodButton4.Visible = false;
        }

        /// <summary>
        /// Sets the entire mood design to visible
        /// </summary>
        public void showMoodDesign()
        {
            MoodButton1.Visible = true;
            MoodButton2.Visible = true;
            MoodButton3.Visible = true;
            MoodButton4.Visible = true;
            MoodHeadline.Visible = true;
            ResetButton.Visible = true;
        }

        /// <summary>
        /// Sets the entire mood design to invisible
        /// </summary>
        public void hideMoodDesign()
        {
            MoodButton1.Visible = false;
            MoodButton2.Visible = false;
            MoodButton3.Visible = false;
            MoodButton4.Visible = false;
            MoodHeadline.Visible = false;
            ResetButton.Visible = false;
        }

        /// <summary>
        /// Sets the ActivitiesRecommendation design to visible
        /// </summary>
        public void showActivitiesRecommendation()
        {
            activitiesListbox.Visible = true;
            ActivitiesLabel.Visible = true;
            activityDescriptionBox.Visible = true;
            startActivityButton.Visible = true;
            ActivitesBackButton.Visible = true;
        }

        /// <summary>
        /// Sets the ActivitiesRecommendation design to invisible
        /// </summary>
        public void hideActivitiesRecommendation()
        {
            activitiesListbox.Visible = false;
            ActivitiesLabel.Visible = false;
            activityDescriptionBox.Visible = false;
            startActivityButton.Visible = false;
            ActivitesBackButton.Visible = false;

        }

        /// <summary>
        /// Sets the StartedActivity design to visible
        /// and moves the activityDescriptionBox to a different location to fit the layout
        /// </summary>
        public void showStartedActivity()
        {
            SelectedActivityLabel.Visible = true;
            timerText.Visible = true;
            timeLeftText.Visible = true;
            ActivitiesLabel.Visible = true;
            CompleteActivityButton.Visible = true;
            CancelActivityButton.Visible = true;
            activityDescriptionBox.Visible = true;
            activityDescriptionBox.Location = new System.Drawing.Point(217,90);
        }

        /// <summary>
        /// Sets the StartedActivity design to visible
        /// and moves the activityDescriptionBox back to the original location to fit the layout
        /// </summary>
        public void hideStartedActivity()
        {
            SelectedActivityLabel.Visible = false;
            timerText.Visible = false;
            timeLeftText.Visible = false;
            ActivitiesLabel.Visible = false;
            CompleteActivityButton.Visible = false;
            CancelActivityButton.Visible = false;
            activityDescriptionBox.Location = new System.Drawing.Point(400,78);
        }

        /// <summary>
        /// Disables the ResetButton
        /// </summary>
        public void disableResetButton()
        {
            ResetButton.Enabled = false;
        }

        /// <summary>
        /// Enables the ResetButton
        /// </summary>
        public void enableResetButton()
        {
            ResetButton.Enabled = true;
        }

        /// <summary>
        /// Disables the CompleteButton
        /// </summary>
        public void DisableCompleteButton()
        {
            CompleteActivityButton.Enabled = false;
        }

        /// <summary>
        /// Enables the CompleteButton
        /// </summary>
        public void EnableCompleteButton()
        {
            CompleteActivityButton.Enabled = true;
        }

        /// <summary>
        /// Notifys the presenter that the first mood button has been pressed
        /// </summary>
        /// <param name="sender"></param> object that sent the event
        /// <param name="e"></param> event params (not used)
        private void MoodButton1_Click(object sender, EventArgs e)
        {
            presenter.moodButtonPressed(MoodButton1.Text);
        }

        /// <summary>
        /// Notifys the presenter that the second mood button has been pressed
        /// </summary>
        /// <param name="sender"></param> object that sent the event
        /// <param name="e"></param> event params (not used)
        private void MoodButton2_Click(object sender, EventArgs e)
        {
            presenter.moodButtonPressed(MoodButton2.Text);
        }

        /// <summary>
        /// Notifys the presenter that the third mood button has been pressed
        /// </summary>
        /// <param name="sender"></param> object that sent the event
        /// <param name="e"></param> event params (not used)
        private void MoodButton3_Click(object sender, EventArgs e)
        {
            presenter.moodButtonPressed(MoodButton3.Text);
        }

        /// <summary>
        /// Notifys the presenter that the fourth mood button has been pressed
        /// </summary>
        /// <param name="sender"></param> object that sent the event
        /// <param name="e"></param> event params (not used)
        private void MoodButton4_Click(object sender, EventArgs e)
        {
            presenter.moodButtonPressed(MoodButton4.Text);
        }

        /// <summary>
        /// Notifys the presenter that the state of moodbutton should be reset,
        /// to update the moodButtons and disables the resetButton
        /// </summary>
        /// <param name="sender"></param> object that sent the event
        /// <param name="e"></param> event params (not used)
        private void ResetButton_Click(object sender, EventArgs e)
        {
            presenter.moodButtonState = 0;
            presenter.updateMoodButtons();
            disableResetButton();
        }
        /// <summary>
        /// Notifys the presenter that the start button in activities has been pressed. 
        /// The MoodDesign is set to invisible and shows the StartedActivity design instead.
        /// Hides all other tabs than activity, disables the CompleteButton and notifys the presenter that
        /// GetAndShowActivity should be called.
        /// </summary>
        /// <param name="sender"></param> object that sent the event
        /// <param name="e"></param> event params (not used)
        private void startActivityButton_Click(object sender, EventArgs e)
        {
			if (activitiesListbox.SelectedItem != null)
			{
				presenter.startActivityButtonPressed();
				hideActivitiesRecommendation();
				hideMoodDesign();
				showStartedActivity();
				SetCurrentActivityLabel();
				tabControl.TabPages.Remove(MainTab);
				tabControl.TabPages.Remove(ChallengeTab);
				tabControl.TabPages.Remove(TrophiesTab);
				DisableCompleteButton();
				presenter.GetAndShowActivityPressed();
			}
        }

        /// <summary>
        /// Clears the DescriptionBox, makes sure we end up in the main tab, notifys the presenter that moodbuttonstate should be reset.
        /// Hides all the used grafical components and the timer.
        /// Adds all the tabs but it first removes the ActivityTab to make sure they get their original index.
        /// Notifys the presenter to drop the current activity.
        /// </summary>
        /// <param name="sender"></param> object that sent the event
        /// <param name="e"></param> event params (not used)
        private void CancelActivityButton_Click(object sender, EventArgs e)
        {
            activityDescriptionBox.Clear();
            tabControl.SelectedIndex = 0;
			presenter.cancelActivityButtonPressed();
			hideActivitiesRecommendation();
            hideStartedActivity();
            hideAndStopTimer();
            tabControl.TabPages.Remove(ActivityTab);
            tabControl.TabPages.Add(MainTab);
            tabControl.TabPages.Add(ActivityTab);
            tabControl.TabPages.Add(ChallengeTab);
            tabControl.TabPages.Add(TrophiesTab);

        }
        /// <summary>
        /// Clears the activity descriptionbox.
        /// Notifys the presenter to reset the state of the MoodButtons and to update the MoodButtons
        /// Hides the design of ActivitiesRecmooendation and shows the MoodDesign instead.
        /// </summary>
        /// <param name="sender"></param> object that sent the event
        /// <param name="e"></param>
        private void ActivitesBackButton_Click(object sender, EventArgs e)
        {
            activityDescriptionBox.Clear();
            presenter.moodButtonState = 0;
            presenter.updateMoodButtons();
            hideActivitiesRecommendation();
            showMoodDesign();
        }

        /// <summary>
        /// Calls the method CancelActivityButton_Click and is notifying the presenter to complete the activity 
        /// </summary>
        /// <param name="sender"></param> object that sent the event
        /// <param name="e"></param> the click event argument>
        private void CompleteActivityButton_Click(object sender, EventArgs e)
        {
            presenter.completeActivity();
            CancelActivityButton_Click(sender, e);
        }

        /// <summary>
        /// Sets the text of the timer and the textfield timeLeftText to not visible
        /// and enables the completeButton
        /// </summary>
        public void hideAndStopTimer()
        {
            timerText.Visible = false;
            timeLeftText.Visible = false;
            timer.Stop();
            EnableCompleteButton();
        }

        /// <summary>
        /// Clears the activityDescriptionBox and sets the description of the activity in it.
        /// </summary>
        /// <param name="description"></param>
        public void updateActivityInfo(string description)
        {
            activityDescriptionBox.Clear();
            activityDescriptionBox.AppendText(description);
        }

        /// <summary>
        /// Clears the activitiesListbox and each string found in the acitivites list is added to the activitiesListbox.
        /// </summary>
        /// <param name="activities"></param>
        public void updateActivityList(List<string> activities)
        {
            activitiesListbox.Items.Clear();

            foreach (string s in activities)
            {
                activitiesListbox.Items.Add(s);
            }

        }

        /// <summary>
        /// Notifys the presenter what item in the activitesListbox we have pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void activitiesListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
			if(activitiesListbox.SelectedItem != null)
			{
				string curItem = activitiesListbox.SelectedItem.ToString();
				int index = activitiesListbox.FindString(curItem);
				presenter.activityPressed(curItem);
			}
        }

        /// <summary>
        /// Sets the label of the activity with the name of the choosen activity.
        /// </summary>
        private void SetCurrentActivityLabel()
        {
            SelectedActivityLabel.Text = "" + presenter.GetActivityName();
        }

        /// <summary>
        /// Creates an pop-up for activity.
        /// </summary>
        public void createActivityPopUp()
        {
            Pop_up pop_up = new Pop_up(presenter);
            pop_up.Text = "Finished activity!";
            pop_up.ShowDialog();
        }

        /// <summary>
        /// Updates the text of the timer.
        /// </summary>
        /// <param name="time"></param>
        public void updateTimer(string time)
        {
            timerText.Text = time;
        }

        /// <summary>
        /// Sets up the timer properly and makes sure the listbox with all activites is cleared.
        /// </summary>
        /// <param name="time"></param>
        public void setupTimer(string time)
        {
            activitiesListbox.Items.Clear();
            timerText.Text = time;
            timerText.Visible = true;
            timeLeftText.Visible = true;
            timer.Start();
        }

        #endregion

        /*----------------- Challenge Tab ------------------------------------*/

        #region Challenge

        public void clearAllForChallenge()
        {
            ChallengeDescriptionBox.Clear();
            ActivityForChallengeDescriptionBox.Clear();
            ChallengesListbox.Items.Clear();
            ActivitiesForChallengeListbox.Items.Clear();
        }
        
        /// <summary>
        /// Clear the description in ChallengeDescriptionBox and puts the new description in it.
        /// </summary>
        /// <param name="description"></param>
        public void updateChallengeInfo(string description)
        {
            ChallengeDescriptionBox.Clear();
            ChallengeDescriptionBox.AppendText(description);
        }
        /// <summary>
        /// Clears the description of an activity for a challenge in ActivityForChallengeDescriptionBox and puts a new description in it.
        /// </summary>
        /// <param name="description"></param>
        public void UpdateActivityForChallengeInfo(string description)
        {
            ActivityForChallengeDescriptionBox.Clear();
            ActivityForChallengeDescriptionBox.AppendText(description);
        }

        /// <summary>
        /// Clears the ChallengesListbox and each string found in the challenges list is added to the ChallengesListbox.
        /// </summary>
        /// <param name="challenges"></param>
        public void updateChallengeList(List<string> challenges)
        {
			clearAllForChallenge();

			ChallengesListbox.Items.Clear();
            foreach (string s in challenges)
            {
                ChallengesListbox.Items.Add(s);
            }
        }
        /// <summary>
        /// Clears the ActivitesChallengesListbox and each activity found in the challenges lists name is added to the ActivitiesForChallengeListBox.
        /// </summary>
        /// <param name="challenges"></param>
        public void UpdateActivityForChallengeList(List<Activity> challenges)
        {
            ActivitiesForChallengeListbox.Items.Clear();
            foreach (Activity s in challenges)
            {
                ActivitiesForChallengeListbox.Items.Add(s.Name);
            }
			ActivityForChallengeDescriptionBox.Clear();

		}

        /// <summary>
        /// Notifys the presenter what item in the ChallengesListbox we have pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChallengesListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
			if (ChallengesListbox.SelectedItem != null)
			{
				string curItem = ChallengesListbox.SelectedItem.ToString();
				presenter.ChallengePressed(curItem);
			}
        }

        /// <summary>
        /// Notifys the presenter what item in the ActivitiesForChallengeListbox we have pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ActivitiesForChallengeListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
			if(ActivitiesForChallengeListbox.SelectedItem != null)
			{
				string curItem = ActivitiesForChallengeListbox.SelectedItem.ToString();
				presenter.ActivityForChallengePressed(curItem);
			}
		}

        /// <summary>
        /// Creates a pop-up for a challenge
        /// </summary>
        public void createChallengePopUp()
        {
            Pop_up pop_up = new Pop_up(presenter);
            pop_up.Text = "Finished challenge!";
            pop_up.textBox1.Text = "Give this challenge a rating!";
            pop_up.ShowDialog();
        }

        /// <summary>
        /// Hides the ChallengesDisplayed design.
        /// </summary>
        public void HideChallengesDisplayed()
        {
            ChallengesListbox.Visible = false;
            ChallengeDescriptionBox.Visible = false;
            ChallengesLabel.Visible = false;
            ChallengeStartButton.Visible = false;
            ChallengeUpdateButton.Visible = false;
			ChallengesCancelButton.Visible = true;
		}

        /// <summary>
        /// Shows the ChallengesDisplayed design.
        /// </summary>
        public void ShowChallengesDisplayed()
        {
            ChallengesListbox.Visible = true;
            ChallengeDescriptionBox.Visible = true;
			ChallengesLabel.Visible = true;
            ChallengeStartButton.Visible = true;
            ChallengeUpdateButton.Visible = true;
			ChallengesCancelButton.Visible = false;
        }

        /// <summary>
        /// Shows the ActivitiesForChallenge design.
        /// </summary>
        public void ShowActivitiesForChallenge()
        {
            ActivitiesForChallengeListbox.Visible = true;
            ActivityForChallengeDescriptionBox.Visible = true;
            SelectedChallengeLabel.Visible = true;
            SelectedChallengeDescription.Visible = true;
            startActivityForChallengeButton.Visible = true;
            ChallengesCancelButton.Visible = true;
        }

        /// <summary>
        /// Hides the ActivitiesForChallenge design.
        /// </summary>
        public void HideActivitiesForChallenge()
        {
            ActivitiesForChallengeListbox.Visible = false;
            ActivityForChallengeDescriptionBox.Visible = false;
            SelectedChallengeLabel.Visible = false;
            SelectedChallengeDescription.Visible = false;
            startActivityForChallengeButton.Visible = false;
            ChallengesCancelButton.Visible = false;
        }

		public void ChangeChallengeDescriptionAndLabel(string label, string description)
		{
			SelectedChallengeLabel.Text = label;
			SelectedChallengeDescription.Text = description;
		}

        /// <summary>
        /// Notifys the presenter that a challenge has been started.
        /// Hides the ChallengeDisplayed design and shows the ActivitesForChallenge design.
        /// Sets the label and the description of the challenge to the selected challenge.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ChallengeStartButton_Click(object sender, EventArgs e)
        {
			if(ChallengesListbox.SelectedIndex != -1)
			{
				presenter.StartChallengeButtonPressed();
				HideChallengesDisplayed();
				ShowActivitiesForChallenge();
				ChangeChallengeDescriptionAndLabel(presenter.GetChallengeName() + " Challenge", presenter.GetChallengeDescription());
			}
		}

		private void startActivityForChallengeButton_Click(object sender, EventArgs e)
		{
			if (ActivitiesForChallengeListbox.SelectedItem != null)
			{
				presenter.startActivityButtonPressed();
				hideActivitiesRecommendation();
				hideMoodDesign();
				showStartedActivity();
				SetCurrentActivityLabel();
				tabControl.TabPages.Remove(MainTab);
				tabControl.TabPages.Remove(ChallengeTab);
				tabControl.TabPages.Remove(TrophiesTab);
				DisableCompleteButton();
				presenter.GetAndShowActivityPressed();
			}
		}

		/// <summary>
		/// Notifys the presenter that the UpdateButton for challenge has been pressed.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ChallengeUpdateButton_Click(object sender, EventArgs e)
        {
			updateChallengeInfo("");
			presenter.GetAndShowChallenges();
			ActivitiesForChallengeListbox.ClearSelected();
		}

        /// <summary>
        /// Notifys the presenter that the CancelButton for challenge has been pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChallengesCancelButton_Click(object sender, EventArgs e)
        {
            HideActivitiesForChallenge();
			presenter.DropChallenge();
			ChallengesListbox.ClearSelected();
			ShowChallengesDisplayed();
			ActivitiesForChallengeListbox.ClearSelected();
			ChallengeDescriptionBox.Clear();
		}

		#endregion

		/*---------------- Trophies Tab --------------------------------------*/

		#region Thophies

		/// <summary>
		/// Add trophies to the list of completed trophies.
		/// </summary>
		/// <param name="trophies">List of trophies to add.</param>
		public void AddCompletedTrophies(List<Trophy> trophies)
		{
			foreach (Trophy trophy in trophies)
			{
				ListViewItem titel = trophiesEarnedListView.Items.Add(trophy.Name, trophy.Name, trophy.Type);
				titel.UseItemStyleForSubItems = false;
				titel.Font = new System.Drawing.Font("Arial", 13, FontStyle.Bold);

				ListViewItem description = trophiesEarnedListView.Items.Add(trophy.Name, trophy.Description, "");
				description.UseItemStyleForSubItems = false;
				description.Font = new System.Drawing.Font("Arial", 10);
			}
		}

		/// <summary>
		/// Add trophies to the list of completed trophies and also remove them from the list of not completed trophies.
		/// </summary>
		/// <param name="trophies">List of trophies to add.</param>
		public void AddAndRemoveCompletedTrophies(List<Trophy> trophies)
		{
			AddCompletedTrophies(trophies);

			foreach (Trophy trophy in trophies)
			{
				trophiesNotEarnedListView.Items.RemoveByKey(trophy.Name);   // Remove trophy from list of incompleted trophies
				trophiesNotEarnedListView.Items.RemoveByKey(trophy.Name);
			}
		}

		/// <summary>
		/// Add trophies to the list of not completed trophies.
		/// </summary>
		/// <param name="trophies">List of trophies to add.</param>
		public void AddIncompletedTrophies(List<Trophy> trophies)
		{
			foreach (Trophy trophy in trophies)
			{
				ListViewItem titel = trophiesNotEarnedListView.Items.Add(trophy.Name, trophy.Name, trophy.Type);
				titel.UseItemStyleForSubItems = false;
				titel.Font = new System.Drawing.Font("Arial", 13, FontStyle.Bold);

				ListViewItem description = trophiesNotEarnedListView.Items.Add(trophy.Name, trophy.Description, "");
				description.UseItemStyleForSubItems = false;
				description.Font = new System.Drawing.Font("Arial", 10);
			}
		}

		public void UpdateTrophiesNumbers( int gold, int silver, int bronze)
		{
			nrGoldLabel.Text = gold.ToString();
			nrSilverLabel.Text = silver.ToString();
			nrBronzeLabel.Text = bronze.ToString();
		}

		public void UpdatePoints(int points)
		{
			pointsLabel.Text = "Points: " + points;
		}

		public void createTrophyPopUp()
        {
            TrophyForm trophyForm = new TrophyForm();
            trophyForm.Text = "You have won a trophy!";
            trophyForm.ShowDialog();
        }

        #endregion


        private void MainForm_Load(object sender, EventArgs e)
        {

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
	}
}
