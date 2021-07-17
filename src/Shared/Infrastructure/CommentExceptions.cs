using System;

using IR.Shared.Models;

namespace IR.Shared.Infrastructure
{
	public class CommentNotCreatedException : IRServerException
	{
		public CommentNotCreatedException(BaseEntity comment)
			: this(comment.Id)
		{
		}

		private CommentNotCreatedException(long id)
			: base($"Comment {id} already exist. ")
		{
		}
	}

	[Serializable]
	public class CommentNotDeletedException : IRServerException
	{
		public CommentNotDeletedException(BaseEntity comment)
			: this(comment.Id)
		{
		}

		private CommentNotDeletedException(long id)
			: base($"Comment {id} was not deleted. ")
		{
		}
	}

	[Serializable]
	public class CommentNotFoundException : IRServerException
	{
		public CommentNotFoundException(BaseEntity comment)
			: this(comment.Id)
		{
		}

		private CommentNotFoundException(long id)
			: base($"Comment {id} was not found. ")
		{
		}
	}

	[Serializable]
	public class CommentNotUpdatedException : IRServerException
	{
		public CommentNotUpdatedException(Comment comment)
			: this(comment.Id)
		{
		}

		public CommentNotUpdatedException(long id)
			: base($"Comment {id} was not updated. ")
		{
		}
	}
}