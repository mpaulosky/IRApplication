﻿using System;

using IR.Shared.Models;

namespace IR.Shared.Infrastructure
{
	[Serializable]
	public class IssueNotCreatedException : IrcerApiException
	{
		public IssueNotCreatedException(BaseEntity issue)
			: this(issue.Id)
		{
		}

		private IssueNotCreatedException(int id)
			: base($"Issue {id} already exist. ")
		{
		}
	}
}