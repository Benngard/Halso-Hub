using System;

/// <summary>
/// Mattias Benngård
/// </summary>
namespace Halso_Hub
{
	/// <summary>
	/// An activity completed by a user, also holds the users grade and (optionally) comment on the activity.
	/// </summary>
	public enum ActivityGrade
	{
		Terrible,
		Bad,
		Good,
		Superb
	}

	/// <summary>
	/// An activity completed by a user.
	/// </summary>
	class CompletedActivity
	{
		public Activity Activity { get; private set; }
		public ActivityGrade Grade {get; private set;}
		public string Comment { get; private set; }

		/// <summary>
		/// Construct a completed activity with its fields.
		/// </summary>
		/// <param name="activity">The completed activity.</param>
		/// <param name="grade">The grade that was given.</param>
		/// <param name="comment">The comment that was given. It is optional, can be null.</param>
		public CompletedActivity(Activity activity, ActivityGrade grade, string comment)
		{
			Activity = activity;
			Grade = grade;
			Comment = (comment == null) ? "" : comment;
		}
	}
}