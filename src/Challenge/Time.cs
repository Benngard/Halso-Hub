using System;

/// <summary>
/// Mattias Benngård
/// </summary>
namespace Halso_Hub
{
	/// <summary>
	/// Helper class to store a time in 00:00:00 format. Fields are public!
	/// </summary>
	public class Time
	{
		public int Hours { get; set; }
		public int Minutes { get; set; }
		public int Seconds { get; set; }

		/// <summary>
		/// Instansiates a Time object with default values as parameters.
		/// </summary>
		/// <param name="hours">Default value for Hours</param>
		/// <param name="minutes">Default value for Minutes</param>
		/// <param name="seconds">Default value for Seconds</param>
		public Time(int hours, int minutes, int seconds)
		{
			Hours = hours;
			Minutes = minutes;
			Seconds = seconds;
		}

		/// <summary>
		/// Overrides ToString to format Hours, Minutes, Seconds.
		/// </summary>
		/// <returns>A string formatted as HH:mm:ss</returns>
		public override string ToString()
		{
			return String.Format("{0:00}:{1:00}:{2:00}", Hours, Minutes, Seconds);
		}
	}
}
