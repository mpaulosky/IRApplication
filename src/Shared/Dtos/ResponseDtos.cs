using System;
using System.ComponentModel.DataAnnotations;

namespace IR.Shared.Dtos
{
	/// <summary>
	/// Response Dto
	/// </summary>
	public record ResponseDto
	{
		public long Id { get; init; }

		[Display(Name = "Response")]
		[DataType(DataType.Text)]
		public string ResponseDescription { get; init; }

		[Display(Name = "Responder Id")]
		[DataType(DataType.Text)]
		public string ResponderId { get; init; }

		[Display(Name = "Responder Name")]
		[DataType(DataType.Text)]
		public string ResponderName { get; init; }

		[Display(Name = "Date Added")] public DateTimeOffset DateAddedUtc { get; init; }

		[Display(Name = "Date Modified")] public DateTimeOffset DateModifiedUtc { get; init; }

		[Display(Name = "Is Deleted")] public bool IsDeleted { get; init; }

		[Required(ErrorMessage = "{0} Is Required")]
		[Display(Name = "Issue Id")]
		public long IssueId { get; init; }
	}

	/// <summary>
	/// Response For Delete Dto
	/// </summary>
	/// <param name="Id"></param>
	/// <param name="IsDeleted"></param>
	public record ResponseForDeleteDto(long Id, [Display(Name = "Is Deleted")] bool IsDeleted);

	/// <summary>
	///	Response For Update Dto
	/// </summary>
	public record ResponseForUpdateDto
	{
		public long Id { get; init; }

		[Required(ErrorMessage = "{0} Is Required")]
		[Display(Name = "Response")]
		[DataType(DataType.Text)]
		[StringLength(1000, MinimumLength = 3,
			ErrorMessage = "{0} Requires a minimum of {2} and a maximum of {1} characters")]
		public string ResponseDescription { get; init; }

		[Required(ErrorMessage = "{0} Is Required")]
		[Display(Name = "Responder Id")]
		[DataType(DataType.Text)]
		[StringLength(100, ErrorMessage = "{0} Has a maximum of {1} characters")]
		public string ResponderId { get; init; }

		[Required(ErrorMessage = "{0} Is Required")]
		[Display(Name = "Responder Name")]
		[DataType(DataType.Text)]
		[StringLength(100, ErrorMessage = "{0} Has a maximum of {1} characters")]
		public string ResponderName { get; init; }

		[Display(Name = "Date Modified")] public DateTimeOffset DateModifiedUtc { get; init; }

		[Display(Name = "Is Deleted")] public bool IsDeleted { get; init; }
	}

	/// <summary>
	/// New Response Dto
	/// </summary>
	public record NewResponseDto
	{
		[Required(ErrorMessage = "{0} Is Required")]
		[Display(Name = "Response")]
		[DataType(DataType.Text)]
		[StringLength(1000, MinimumLength = 3,
			ErrorMessage = "{0} Requires a minimum of {2} and a maximum of {1} characters")]
		public string ResponseDescription { get; init; }

		[Required(ErrorMessage = "{0} Is Required")]
		[Display(Name = "Responder Id")]
		[DataType(DataType.Text)]
		[StringLength(100, ErrorMessage = "{0} Has a maximum of {1} characters")]
		public string ResponderId { get; init; }

		[Required(ErrorMessage = "{0} Is Required")]
		[Display(Name = "Responder Name")]
		[DataType(DataType.Text)]
		[StringLength(100, ErrorMessage = "{0} Has a maximum of {1} characters")]
		public string ResponderName { get; init; }

		[Required(ErrorMessage = "{0} Is Required")] 
		[Display(Name = "Issue Id")] 
		public long IssueId { get; init; }

		[Display(Name = "Date Added")] public DateTimeOffset DateAddedUtc { get; init; } = DateTimeOffset.UtcNow;

		[Display(Name = "Date Modified")] public DateTimeOffset DateModifiedUtc { get; init; } = DateTimeOffset.UtcNow;

		[Display(Name = "Is Deleted")] public bool IsDeleted { get; init; }
	}
}