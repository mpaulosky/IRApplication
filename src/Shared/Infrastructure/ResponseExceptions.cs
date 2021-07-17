using System;

using IR.Shared.Models;

namespace IR.Shared.Infrastructure
{
	public class ResponseNotCreatedException : IRServerException
	{
		public ResponseNotCreatedException(BaseEntity response)
			: this(response.Id)
		{
		}

		private ResponseNotCreatedException(long id)
			: base($"Response {id} already exist. ")
		{
		}
	}

	[Serializable]
	public class ResponseNotDeletedException : IRServerException
	{
		public ResponseNotDeletedException(BaseEntity response)
			: this(response.Id)
		{
		}

		private ResponseNotDeletedException(long id)
			: base($"Response {id} was not deleted. ")
		{
		}
	}

	[Serializable]
	public class ResponseNotFoundException : IRServerException
	{
		public ResponseNotFoundException(BaseEntity response)
			: this(response.Id)
		{
		}

		private ResponseNotFoundException(long id)
			: base($"Response {id} was not found. ")
		{
		}
	}

	[Serializable]
	public class ResponseNotUpdatedException : IRServerException
	{
		public ResponseNotUpdatedException(Response response)
			: this(response.Id)
		{
		}

		public ResponseNotUpdatedException(long id)
			: base($"Response {id} was not updated. ")
		{
		}
	}
}