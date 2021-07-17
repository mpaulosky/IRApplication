using System;
using System.ComponentModel.DataAnnotations;

namespace IR.Shared.Dtos
{
	public record CommentDto
	{
		public long Id { get; init; }

		[Display(Name = "Comment")]
		[DataType(DataType.Text)]
		public string CommentDescription { get; init; }

		[Display(Name = "Commenter Id")]
		[DataType(DataType.Text)]
		public string CommenterId { get; init; }

		[Display(Name = "Commenter Name")]
		[DataType(DataType.Text)]
		public string CommenterName { get; init; }

		[Display(Name = "Date Added")] public DateTimeOffset DateAddedUtc { get; init; }

		[Display(Name = "Date Modified")] public DateTimeOffset DateModifiedUtc { get; init; }

		[Display(Name = "Is Deleted")] public bool IsDeleted { get; init; }

		public long ResponseId { get; init; }
	}

	public record CommentForDeleteDto(long Id, [Display(Name = "Is Deleted")] bool IsDeleted);

	public record CommentForUpdateDto
	{
		public long Id { get; init; }

		[Required(ErrorMessage = "{0} Is Required")]
		[Display(Name = "Comment")]
		[DataType(DataType.Text)]
		[StringLength(1000, MinimumLength = 3,
			ErrorMessage = "{0} Requires a minimum of {2} and a maximum of {1} characters")]
		public string CommentDescription { get; init; }

		[Required(ErrorMessage = "{0} Is Required")]
		[Display(Name = "Commenter Id")]
		[DataType(DataType.Text)]
		[StringLength(100, ErrorMessage = "{0} Has a maximum of {1} characters")]
		public string CommenterId { get; init; }

		[Required(ErrorMessage = "{0} Is Required")]
		[Display(Name = "Commenter Name")]
		[DataType(DataType.Text)]
		[StringLength(100, ErrorMessage = "{0} Has a maximum of {1} characters")]
		public string CommenterName { get; init; }

		[Display(Name = "Date Modified")] public DateTimeOffset DateModifiedUtc { get; init; }

		[Display(Name = "Is Deleted")] public bool IsDeleted { get; init; }
	}

	public record NewCommentDto
	{
		[Required(ErrorMessage = "{0} Is Required")]
		[Display(Name = "Comment")]
		[DataType(DataType.Text)]
		[StringLength(1000, MinimumLength = 3,
			ErrorMessage = "{0} Requires a minimum of {2} and a maximum of {1} characters")]
		public string CommentDescription { get; init; }

		[Required(ErrorMessage = "{0} Is Required")]
		[Display(Name = "Commenter Id")]
		[DataType(DataType.Text)]
		[StringLength(100, ErrorMessage = "{0} Has a maximum of {1} characters")]
		public string CommenterId { get; init; }

		[Required(ErrorMessage = "{0} Is Required")]
		[Display(Name = "Commenter Name")]
		[DataType(DataType.Text)]
		[StringLength(100, ErrorMessage = "{0} Has a maximum of {1} characters")]
		public string CommenterName { get; init; }

		[Display(Name = "Date Added")] public DateTimeOffset DateAddedUtc { get; init; } = DateTimeOffset.UtcNow;

		[Display(Name = "Date Modified")] public DateTimeOffset DateModifiedUtc { get; init; } = DateTimeOffset.UtcNow;

		[Display(Name = "Is Deleted")] public bool IsDeleted { get; init; }

		public long ResponseId { get; init; }
	}
}