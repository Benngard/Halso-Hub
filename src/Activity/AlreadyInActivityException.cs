using System;
using System.Runtime.Serialization;

/// <summary>
/// Mattias Benngård
/// </summary>
namespace Halso_Hub
{
	[Serializable]
	public class AlreadyInActivityException : Exception
	{
		public AlreadyInActivityException()
			: base() { }

		public AlreadyInActivityException(string message)
			: base(message) { }

		public AlreadyInActivityException(string format, params object[] args)
			: base(string.Format(format, args)) { }

		public AlreadyInActivityException(string message, Exception innerException)
			: base(message, innerException) { }

		public AlreadyInActivityException(string format, Exception innerException, params object[] args)
			: base(string.Format(format, args), innerException) { }

		protected AlreadyInActivityException(SerializationInfo info, StreamingContext context)
			: base(info, context) { }
	}
}