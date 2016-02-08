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

/// <summary>
/// Main class building the program window
/// </summary>
/// Author: Daniel Edsinger

namespace Halso_Hub
{
	public partial class ActivityMain : Form
	{
		private int timeLeft;
        private ArrayList activityList;
		private Activity currentActivity;

		/// <summary>
		/// Initialize all components in application window.
		/// </summary>
		public ActivityMain()
		{
			InitializeComponent();
            timeLeft = 0;
			timer.Stop();
            activityList = new ArrayList();
            activityList.Add(new Activity("Yoga", "Gör yoga i 10 sekunder.", 5, 10, null)); //Temp activity for testing
            activityList.Add(new Activity("Kaffe", "Drick en kopp kaffe.", 3, 15, null)); //Temp activity for testing
            listActivities(activityList);
        }

        /// <summary>
        /// Clock that counts down and stops if timer reaches zero
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void timer_Tick(object sender, EventArgs e)
		{
			if (timeLeft > 0)
			{
                timeLeft -= 1;
                timerText.Text = String.Format("{0:00} min {1:00} sec", timeLeft / 60, timeLeft % 60);
            }
			else 
			{
				timer.Stop();
                activityDone();
			}
		}

        /// <summary>
        /// Set a new time for the clock to count down from.
        /// </summary>
        /// <param name="time"> The time in seconds to count down from. </param>
		private void setTimeLeft(int time)
		{
			if (time > 0)
			{
                timer.Stop();
                timeLeft = time;
                timerText.Text = String.Format("{0:00} min {1:00} sec", timeLeft / 60, timeLeft % 60);
                timer.Start();
			}
		}

		/// <summary>
		/// Show the info of the current activity selected
		/// </summary>
        private void showActivity()
        {
            activityDescriptionBox.Clear();
            if (currentActivity == null)
            {
                activityDescriptionBox.AppendText("ERROR!");
                timerText.Text = String.Format("{0:00} min {1:00} sec", 0 / 60, 0 % 60);
            }
            else
            {
                activityDescriptionBox.AppendText(currentActivity.Description);

                timeLeft = currentActivity.Time;
                timerText.Text = String.Format("{0:00} min {1:00} sec", timeLeft / 60, timeLeft % 60);
            }
        }

        /// <summary>
        /// Lists based on the mood of the person, suitable activities in a selectable list.
        /// </summary>
        /// <param name="activities">A list of suitable activities made from algorithm</param>
        private void listActivities(ArrayList activities)
        {
            activitiesListbox.Items.Clear();

            foreach (Activity activity in activityList)
            {
                activitiesListbox.Items.Add(activity.Name);
            }
        }

		/// <summary>
		/// Do something when clock reaches 0
		/// </summary>
        private void activityDone()
        {

        }

		private void timerText_Click(object sender, EventArgs e)
		{

		}

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Start the timer countdown. (Temporarily start with 20 seconds every time)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startButton_Click(object sender, EventArgs e)
        {
            activitiesListbox.Items.Clear();
            timer.Start();
        }

        /// <summary>
        /// When selecting an activity in the list of activities, the decription for that activity is shown with time.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void activitiesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the currently selected item in the ListBox.
            string curItem = activitiesListbox.SelectedItem.ToString();

			// Get index of string in.
			int index = activitiesListbox.FindString(curItem);
			currentActivity = (Activity)activityList[index];

			showActivity();
            
        }
    }
}
