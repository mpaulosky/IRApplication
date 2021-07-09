using System;
using System.ComponentModel.DataAnnotations;

namespace IR.Shared.Dtos
{
	/// <summary>
	/// Issue Dto
	/// </summary>
	public record IssueDto()
	{
		public int Id { get; init; }

		[Display(Name = "Description")] [DataType(DataType.Text)] public string IssueDescription { get; init; }

		[Display(Name = "Initiator Name")] [DataType(DataType.Text)] public string InitiatorName { get; init; }

		[Display(Name = "Date Added")] public DateTimeOffset DateAddedUtc { get; init; }

		[Display(Name = "Date Modified")] public DateTimeOffset DateModifiedUtc { get; init; }

		[Display(Name = "Date Resolved")] public DateTimeOffset DateResolvedUtc { get; init; }

		[Display(Name = "Is Deleted")] public bool IsDeleted { get; init; }

		[Display(Name = "Resolved")] public bool IsResolved { get; init; }
	};

	/// <summary>
	/// Issue For Deletes Dto
	/// </summary>
	public record IssueForDeleteDto(int Id, bool IsDeleted);

	/// <summary>
	/// Issue For Updates Dto
	/// </summary>
	public record IssueForUpdateDto()
	{
		public int Id { get; init; }

		[Required(ErrorMessage = "{0} Is Required")]
		[Display(Name = "Description")]
		[DataType(DataType.Text)]
		[StringLength(1000, MinimumLength = 3, ErrorMessage = "{0} Requires a minimum of {2} and a maximum of {1} characters")]
		public string IssueDescription { get; init; }

		[Required(ErrorMessage = "{0} Is Required")]
		[Display(Name = "Initiator Id")]
		[DataType(DataType.Text)]
		[StringLength(100, ErrorMessage = "{0} Has a maximum of {1} characters")]
		public string InitiatorId { get; init; }

		[Required(ErrorMessage = "{0} Is Required")]
		[Display(Name = "Initiator Name")]
		[DataType(DataType.Text)]
		[StringLength(100, ErrorMessage = "{0} Has a maximum of {1} characters")]
		public string InitiatorName { get; init; }

		[Display(Name = "Date Modified")] public DateTimeOffset DateModifiedUtc { get; init; }

		[Display(Name = "Date Resolved")] public DateTimeOffset? DateResolvedUtc { get; init; } = null;

		[Display(Name = "Resolved")] public bool IsResolved { get; init; } = false;
	};

	public record NewIssueDto
	{
		[Required(ErrorMessage = "{0} Is Required")]
		[Display(Name = "Description")]
		[DataType(DataType.Text)]
		[StringLength(1000, MinimumLength = 3, ErrorMessage = "{0} Requires a minimum of {2} and a maximum of {1} characters")]
		public string IssueDescription { get; init; }

		[Required(ErrorMessage = "{0} Is Required")]
		[Display(Name = "Initiator Id")]
		[DataType(DataType.Text)]
		[StringLength(100, ErrorMessage = "{0} Has a maximum of {1} characters")]
		public string InitiatorId { get; init; }

		[Required(ErrorMessage = "{0} Is Required")]
		[Display(Name = "Initiator Name")]
		[DataType(DataType.Text)]
		[StringLength(100, ErrorMessage = "{0} Has a maximum of {1} characters")]
		public string InitiatorName { get; init; }

		[Display(Name = "Date Added")] public DateTimeOffset DateAddedUtc { get; init; } = DateTimeOffset.UtcNow;

		[Display(Name = "Date Modified")] public DateTimeOffset DateModifiedUtc { get; init; } = DateTimeOffset.UtcNow;
	}
}