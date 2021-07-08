
using System;
using System.Runtime.Serialization;

namespace IR.Shared.Infrastructure
{
	[Serializable]
	public class IrcerApiException : Exception
	{
		public IrcerApiException(string message) : base(message)
		{
		}

		public IrcerApiException(string message, Exception innerException) : base(message, innerException)
		{
		}

		protected IrcerApiException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
