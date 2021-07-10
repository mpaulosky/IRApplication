using System;
using System.Diagnostics.CodeAnalysis;

namespace IR.Shared.Infrastructure.ErrorHandler
{
	[ExcludeFromCodeCoverage]
	public class ErrorHandler : IErrorHandler
	{
		public string GetMessage(ErrorMessages message)
		{
			switch (message)
			{
				case ErrorMessages.EntityNull:
					return "The entity passed is null {0}. Additional information: {1}";

				case ErrorMessages.ModelValidation:
					return "The request data is not correct. Additional information: {0}";

				case ErrorMessages.AuthUserDoesNotExists:
					return "The user doesn't not exists";

				case ErrorMessages.AuthWrongCredentials:
					return "The email or password are wrong";

				case ErrorMessages.AuthCannotCreate:
					return "Cannot create user";

				case ErrorMessages.AuthCannotDelete:
					return "Cannot delete user";

				case ErrorMessages.AuthCannotUpdate:
					return "Cannot update user";

				case ErrorMessages.AuthNotValidInformation:
					return "Invalid information";

				case ErrorMessages.AuthCannotRetrieveToken:
					return "Cannot retrieve token";
				default:
					throw new ArgumentOutOfRangeException(nameof(message), message, null);
			}
		}
	}
}