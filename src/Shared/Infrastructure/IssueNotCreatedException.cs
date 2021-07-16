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
}