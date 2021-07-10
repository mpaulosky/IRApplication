using System;

using IR.Shared.Models;

namespace IR.Shared.Infrastructure
{
	[Serializable]
	public class IssueNotFoundException : IrcerApiException
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
}
