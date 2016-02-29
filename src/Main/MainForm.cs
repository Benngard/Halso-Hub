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

namespace Halso_Hub
{
	public partial class MainForm : Form, IMainForm
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
		}

		/// <summary>
		/// Sets the presenter for this form
		/// </summary>
		/// <param name="presenter"></param> the presenter for this form
		public void setPresenter(Presenter presenter)
		{
			this.presenter = presenter;
		}




		/*----------------- Mood Tab -----------------------------------------*/

		#region Mood Buttons

		private void sadButton1_Click(object sender, EventArgs e)
		{
			presenter.moodButtonPressed("sad", MoodType.VerySad);
		}

		private void sadButton2_Click(object sender, EventArgs e)
		{
			presenter.moodButtonPressed("sad", MoodType.Sad);
		}

		private void sadButton3_Click(object sender, EventArgs e)
		{
			presenter.moodButtonPressed("sad", MoodType.Happy);
		}

		private void sadButton4_Click(object sender, EventArgs e)
		{
			presenter.moodButtonPressed("sad", MoodType.VeryHappy);
		}

		private void tiredButton1_Click(object sender, EventArgs e)
		{
			presenter.moodButtonPressed("tired", MoodType.VeryTired);
		}

		private void tiredButton2_Click(object sender, EventArgs e)
		{
			presenter.moodButtonPressed("sad", MoodType.Tired);
		}

		private void tiredButton3_Click(object sender, EventArgs e)
		{
			presenter.moodButtonPressed("sad", MoodType.Energetic);
		}

		private void tiredButton4_Click(object sender, EventArgs e)
		{
			presenter.moodButtonPressed("sad", MoodType.VeryEnergetic);
		}

		private void stressedButton1_Click(object sender, EventArgs e)
		{
			presenter.moodButtonPressed("sad", MoodType.VeryStressed);
		}

		private void stressedButton2_Click(object sender, EventArgs e)
		{
			presenter.moodButtonPressed("sad", MoodType.Stressed);
		}

		private void stressedButton3_Click(object sender, EventArgs e)
		{
			presenter.moodButtonPressed("sad", MoodType.Calm);
		}

		private void stressedButton4_Click(object sender, EventArgs e)
		{
			presenter.moodButtonPressed("sad", MoodType.VeryCalm);
		}

		private void lonelyButton1_Click(object sender, EventArgs e)
		{
			presenter.moodButtonPressed("sad", MoodType.VeryLonely);
		}

		private void lonelyButton2_Click(object sender, EventArgs e)
		{
			presenter.moodButtonPressed("sad", MoodType.Lonely);
		}

		private void lonelyButton3_Click(object sender, EventArgs e)
		{
			presenter.moodButtonPressed("sad", MoodType.Sociable);
		}

		private void lonelyButton4_Click(object sender, EventArgs e)
		{
			presenter.moodButtonPressed("sad", MoodType.VerySociable);
		}

		#endregion


		/*--------------- Activity Tab ---------------------------------------*/

		#region Activity

		public void hideAndStopTimer()
		{
			timerText.Visible = false;
			timeLeftText.Visible = false;
			timer.Stop();
		}

		public void updateActivityInfo(string description)
		{
			activityDescriptionBox.Clear();
			activityDescriptionBox.AppendText(description);
			Console.WriteLine("Updatera");
		}

		public void updateActivityList(List<string> activities)
		{
			activitiesListbox.Items.Clear();

			foreach (string s in activities)
			{
				activitiesListbox.Items.Add(s);
			}

		}

		private void activitiesListbox_SelectedIndexChanged(object sender, EventArgs e)
		{
			string curItem = activitiesListbox.SelectedItem.ToString();
			int index = activitiesListbox.FindString(curItem);
			presenter.activityPressed(curItem);
		}

		private void startActivityButton_Click(object sender, EventArgs e)
		{
			presenter.startActivityButtonPressed();
			changeNameOnStartButton();
			
		}

		public void createActivityPopUp()
		{
			Pop_up pop_up = new Pop_up();
			pop_up.Text = "Congratulations you have finished the chosen activity!";
			pop_up.ShowDialog();
		}

		/// <summary>
		/// Change the name on startButton to "Stop" or "Start"
		/// </summary>
		public void changeNameOnStartButton()
		{

			if (presenter.activitySelected && startActivityButton.Text == "Start")
			{
				startActivityButton.Text = "Stop";
			}

			else if (startActivityButton.Text == "Stop")
			{
				StopTimer();
				DialogResult dialogResult = MessageBox.Show("Do you really wanna quit?", "Quit", MessageBoxButtons.YesNo);
				if (dialogResult == DialogResult.Yes)
				{
					startActivityButton.Text = "Start";
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

		public void updateTimer(string time)
		{
			timerText.Text = time;
		}

		public void setupTimer(string time)
		{
			//activitiesListbox.Items.Clear();
			timerText.Text = time;
			timerText.Visible = true;
			timeLeftText.Visible = true;
			timer.Start();
		}

#endregion


		/*-------------- Challenge Tab ---------------------------------------*/

		#region Challenge

		public void updateChallengeInfo(string description)
		{
			activityDescriptionBox.Clear();
			activityDescriptionBox.AppendText(description);
		}

		public void updateChallengeList(List<string> challenges)
		{
			activitiesListbox.Items.Clear();
			foreach (string s in challenges)
			{
				activitiesListbox.Items.Add(s);
			}
		}

		public void createChallengePopUp()
		{
			Pop_up pop_up = new Pop_up();
			pop_up.Text = "Congratulations you have finished the chosen challenge!";
			pop_up.ShowDialog();
		}


		

		#endregion


		/*---------------- Trophies Tab --------------------------------------*/

		#region Thophies

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
