using System.Runtime.Serialization;

namespace CapPasCap.WebService
{
    [Serializable]
    public class ChallengeException : Exception
    {
        public ChallengeException()
        {
        }

        public ChallengeException(string? message) : base(message)
        {
        }

        public ChallengeException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected ChallengeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}