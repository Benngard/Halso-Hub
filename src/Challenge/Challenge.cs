using System;
using System.Collections.Generic;

/// <summary>
/// Mattias Benngård
/// </summary>
namespace Halso_Hub
{
	/// <summary>
	/// A challenge set up by supervisor(s) for user(s) to perform. Can hold one to many activities.
	/// </summary>
	class Challenge
	{
		public string Name { get; private set; }
		public string Description { get; private set; }
		public Time StartTime { get; private set; }
		public Time EndTime { get; private set; }
		public List<Activity> Requirements { get; private set; }

		/// <summary>
		/// Constructs a Challenge with its fields.
		/// </summary>
		/// <param name="name">Name of the challenge.</param>
		/// <param name="description">Description of the challenge.</param>
		/// <param name="startTime">At what time it starts, expressed as 00:00:00.</param>
		/// <param name="endTime">At what time it ends, expressed as 00:00:00.</param>
		/// <param name="requirements"></param>
		public Challenge(string name, string description, Time startTime, Time endTime, List<Activity> requirements)
		{
			Name = name;
			Description = description;
			StartTime = startTime;
			EndTime = endTime;
			Requirements = requirements;

			if (Requirements == null)
			{
				throw new ArgumentException("Null List is not allowed as requirements for a challenge.");
			}

			if (Requirements.Count == 0)
			{
				throw new ArgumentException("No requirements specified for a challenge.");
			}
		}

		/// <summary>
		/// Gets the time left from EndTime to DateTime.Now
		/// </summary>
		/// <returns>A string HH:mm:ss with time left. Minimum to return is 00:00:00.</returns>
		public string TimeLeft () {
			int hoursLeft;
			int minutesLeft;
			int secondsLeft;

			// store current time now
			DateTime now = DateTime.Now;

			// subract seconds, borrow from minute if needed
			if (now.Second < EndTime.Seconds)
			{
				secondsLeft = EndTime.Seconds - now.Second;
			}
			else
			{
				secondsLeft = 60 + EndTime.Seconds - now.Second;
				now = now.AddMinutes(-1);
			}

			// subract minutes, borrow from hour if needed
			if (now.Minute < EndTime.Minutes)
			{
				minutesLeft = EndTime.Minutes - now.Minute;
			}
			else
			{
				minutesLeft = 60 + EndTime.Minutes - now.Minute;
				now = now.AddHours(-1);
			}

			// subract an hour, or default to 0
			if (now.Hour < EndTime.Hours)
			{
				hoursLeft = EndTime.Hours - now.Hour;
			}
			else
			{
				hoursLeft = 0;
			}

			return String.Format("{0:00}:{1:00}:{2:00}", hoursLeft, minutesLeft, secondsLeft);
		}

		/// <summary>
		/// Checks if the challenge has met its deadline or not.
		/// </summary>
		/// <returns>If EndTime has passed DateTime.Now.</returns>
		public bool IsOver()
		{
			DateTime now = DateTime.Now;
			return (EndTime.Hours < now.Hour ||
					EndTime.Hours == now.Hour && EndTime.Minutes == now.Minute && EndTime.Seconds == now.Second);
		}
	}
}
