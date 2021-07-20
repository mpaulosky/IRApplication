using System;
using Microsoft.Extensions.Logging;
using Moq;

namespace TestHelpers
{
	public static class LoggerUtils
	{
		public static Mock<ILogger<T>> LoggerMock<T>() where T : class
		{
			return new();
		}

		public static void VerifyLog<T>(this Mock<ILogger<T>> loggerMock, LogLevel level, string message,
			string failMessage = null)
		{
			loggerMock.VerifyLog(level, message, Times.Once(), failMessage);
		}

		private static void VerifyLog<T>(this Mock<ILogger<T>> loggerMock, LogLevel level, string message, Times times,
			string failMessage = null)
		{
			loggerMock.Verify(
				x => x.Log(
					level,
					It.IsAny<EventId>(),
					It.Is<It.IsAnyType>((o, t) => o.ToString().Contains(message)),
					It.IsAny<Exception>(),
					(Func<It.IsAnyType, Exception, string>) It.IsAny<object>()),
				times);
		}
	}
}
