using System.Collections.Generic;

/// <summary>
/// Mattias Benngård
/// </summary>
namespace Halso_Hub
{
	/// <summary>
	/// Different trophy types.
	/// </summary>
	public enum TrophyType
	{
		Gold,
		Silver,
		Bronze
	}

	/// <summary>
	/// Is an earned, by a user, trophy.
	/// </summary>
	public class Trophy
	{
		public string Name { get; private set; }
		public string Description { get; private set; }
		public TrophyType Type { get; private set; }
		public List<Activity> Requirements { get; private set; }

		/// <summary>
		/// Constructs a trophy with its fields.
		/// </summary>
		/// <param name="name">Name of the trophy.</param>
		/// <param name="description">Description of the trophy.</param>
		/// <param name="type">Which type the trophy has.</param>
		/// <param name="requirements">Which activities are required to be granted the trophy.</param>
		public Trophy(string name, string description, TrophyType type, List<Activity> requirements)
		{
			Name = name;
			Description = description;
			Type = type;
			Requirements = requirements;
		}
	}
}
