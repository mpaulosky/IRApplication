using System;

namespace IR.Shared.Models
{
	public class Comment : BaseEntity
	{
		public int CommentId { get; set; }
		public string CommentText { get; set; }
		public string CommentorId { get; set; }
		public string CommentorName { get; set; }
		public int ResponseId { get; set; }
	}
}