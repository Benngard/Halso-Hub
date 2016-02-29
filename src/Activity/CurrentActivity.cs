/// <summary>
/// Mattias Benngård
/// </summary>
namespace Halso_Hub
{
	/// <summary>
	/// Is an active currently being undertaken by a user.
	/// </summary>
	public class CurrentActivity
	{
		public Activity Activity { get; private set; }
		public int TimeLeft { get; private set; }

		/// <summary>
		/// Construct a current activity with its fields. Sets TimeLeft to Activity.Time.
		/// </summary>
		/// <param name="activity">Which activity to undertake.</param>
		public CurrentActivity(Activity activity)
		{
			Activity = activity;
			TimeLeft = activity.Time;
		}
	}
}
