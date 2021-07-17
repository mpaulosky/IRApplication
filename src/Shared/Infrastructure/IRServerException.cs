
using System;
using System.Runtime.Serialization;

namespace IR.Shared.Infrastructure
{
	[Serializable]
	// ReSharper disable once InconsistentNaming
	public class IRServerException : Exception
	{
		public IRServerException(string message) : base(message)
		{
		}

		public IRServerException(string message, Exception innerException) : base(message, innerException)
		{
		}

		protected IRServerException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}