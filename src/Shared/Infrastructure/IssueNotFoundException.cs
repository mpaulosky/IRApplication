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

		private IssueNotFoundException(int id)
			: base($"Issue {id} was not found. ")
		{
		}
	}
}
