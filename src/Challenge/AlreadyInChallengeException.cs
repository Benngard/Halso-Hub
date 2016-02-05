using System;
using System.Runtime.Serialization;

/// <summary>
/// Mattias Benngård
/// </summary>
namespace Halso_Hub
{
	[Serializable]
	public class AlreadyInChallengeException : Exception
	{
		public AlreadyInChallengeException()
			: base() { }

		public AlreadyInChallengeException(string message)
			: base(message) { }

		public AlreadyInChallengeException(string format, params object[] args)
			: base(string.Format(format, args)) { }

		public AlreadyInChallengeException(string message, Exception innerException)
			: base(message, innerException) { }

		public AlreadyInChallengeException(string format, Exception innerException, params object[] args)
			: base(string.Format(format, args), innerException) { }

		protected AlreadyInChallengeException(SerializationInfo info, StreamingContext context)
			: base(info, context) { }
	}
}