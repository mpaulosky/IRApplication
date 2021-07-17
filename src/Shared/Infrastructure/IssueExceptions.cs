using System;
using IR.Shared.Models;

namespace IR.Shared.Infrastructure
{
	[Serializable]
	public class IssueNotCreatedException : IRServerException
	{
		public IssueNotCreatedException(BaseEntity issue)
			: this(issue.Id)
		{
		}

		private IssueNotCreatedException(long id)
			: base($"Issue {id} already exist. ")
		{
		}
	}
	
	[Serializable]
	public class IssueNotDeletedException : IRServerException
	{
		public IssueNotDeletedException(BaseEntity issue)
			: this(issue.Id)
		{
		}

		private IssueNotDeletedException(long id)
			: base($"Issue {id} was not deleted. ")
		{
		}
	}
	
	[Serializable]
	public class IssueNotFoundException : IRServerException
	{
		public IssueNotFoundException(BaseEntity issue)
			: this(issue.Id)
		{
		}

		private IssueNotFoundException(long id)
			: base($"Issue {id} was not found. ")
		{
		}
	}
	
	[Serializable]
	public class IssueNotUpdatedException : IRServerException
	{
		public IssueNotUpdatedException(Issue issue)
			: this(issue.Id)
		{
		}

		public IssueNotUpdatedException(long id)
			: base($"Issue {id} was not updated. ")
		{
		}
	}
}