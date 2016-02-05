using System.Collections.Generic;

/// <summary>
/// Mattias Benngård
/// </summary>
namespace Halso_Hub
{
	/// <summary>
	/// An activity for a user to perform.
	/// </summary>
	class Activity
	{
		public string Name { get; private set; }
		public string Description { get; private set; }
		public int Points { get; private set; }
		public int Time { get; private set; }
		public List<MoodType> CuresMoods { get; private set; }

		/// <summary>
		/// Constructs an activity with its fields.
		/// </summary>
		/// <param name="name">Name of the activity.</param>
		/// <param name="description">Description of the activity.</param>
		/// <param name="points">How many points it is worth.</param>
		/// <param name="time">What time the activity takes.</param>
		/// <param name="curesMoods">What moods it is meant to counter, null can be used, an empty list will then be created.</param>
		public Activity(string name, string description, int points, int time, List<MoodType> curesMoods)
		{
			Name = name;
			Description = description;
			Points = points;
			Time = time;
			CuresMoods = (curesMoods == null) ? new List<MoodType>() : curesMoods;	
		}
	}
}