using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Main class building the program window
/// </summary>
/// Author: Daniel Edsinger

namespace Halso_Hub
{
	public partial class ActivityMain : Form
	{
		private int timeLeft;

		public ActivityMain()
		{
			InitializeComponent();
			timer.Stop();
			setTimeLeft(20);
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			if (timeLeft >= 0)
			{
				timerText.Text = String.Format("{0:00} min {1:00} sec", timeLeft / 60, timeLeft % 60);
				timeLeft -= 1;
			}
			else 
			{
				timer.Stop();
			}
		}

		private void setTimeLeft(int time)
		{
			if (time > 0)
			{
				timeLeft = time;
				timer.Start();
			}
		}


		private void timerText_Click(object sender, EventArgs e)
		{

		}

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
