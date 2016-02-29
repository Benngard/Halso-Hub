using System;

/// <summary>
/// Mattias Benngård
/// </summary>
namespace Halso_Hub
{
	/// <summary>
	/// Is the current challenge active for a user.
	/// </summary>
	public class CurrentChallenge
	{		
		public Challenge Challenge { get; private set; }
		public Time StartTime { get; private set; }

		/// <summary>
		/// Constructs a CurrentChallenge with its fields.
		/// </summary>
		/// <param name="challenge">Which challenge to take on. Null is not allowed as challenge.</param>
		public CurrentChallenge(Challenge challenge)
		{
			if (challenge == null)
			{
				throw new ArgumentException("Null Object is not allowed as challenge for current challenge.");
			}
			Challenge = challenge;
			DateTime now = DateTime.Now;
			StartTime = new Time(now.Hour, now.Minute, now.Second);
		}
	}
}
