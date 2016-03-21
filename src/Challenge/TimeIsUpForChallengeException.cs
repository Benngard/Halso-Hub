using System;
using System.Runtime.Serialization;

/// <summary>
/// Mattias Benngård
/// </summary>
namespace Halso_Hub
{
    [Serializable]
    public class TimeIsUpForChallengeException : Exception
    {
        public TimeIsUpForChallengeException()
            : base()
        { }

        public TimeIsUpForChallengeException(string message)
            : base(message)
        { }

        public TimeIsUpForChallengeException(string format, params object[] args)
            : base(string.Format(format, args))
        { }

        public TimeIsUpForChallengeException(string message, Exception innerException)
            : base(message, innerException)
        { }

        public TimeIsUpForChallengeException(string format, Exception innerException, params object[] args)
            : base(string.Format(format, args), innerException)
        { }

        protected TimeIsUpForChallengeException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        { }
    }
}
