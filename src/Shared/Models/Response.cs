using System;
using System.Collections.Generic;

namespace IR.Shared.Models
{
	public class Response : BaseEntity
	{
		public string ResponseText { get; set; }
		public string ResponderId { get; set; }
		public string ResponderName { get; set; }
		public int IssueId { get; set; }
		public List<Comment> Comments { get; set; }
	}
}