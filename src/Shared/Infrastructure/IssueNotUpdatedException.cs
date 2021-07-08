﻿using IR.Shared.Models;

using System;

namespace IR.Shared.Infrastructure
{
	[Serializable]
	public class IssueNotUpdatedException : IrcerApiException
	{
		public IssueNotUpdatedException(Issue issue)
			: this(issue.Id)
		{
		}

		public IssueNotUpdatedException(int id)
			: base($"Issue {id} was not updated. ")
		{
		}
	}
}