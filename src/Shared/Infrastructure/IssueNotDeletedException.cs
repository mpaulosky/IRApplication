using System;

using IR.Shared.Models;

namespace IR.Shared.Infrastructure
{
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
}