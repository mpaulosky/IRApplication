using System;
using System.ComponentModel.DataAnnotations;

namespace IR.Shared.Models
{
	public class Comment : BaseEntity
	{
		[Required(ErrorMessage = "{0} Is Required")]
		[Display(Name = "Comment")]
		[DataType(DataType.Text)]
		[StringLength(1000, MinimumLength = 3, ErrorMessage = "{0} Requires a minimum of {2} and a maximum of {1} characters")]
		public string CommentText { get; set; }

		[Required(ErrorMessage = "{0} Is Required")]
		[Display(Name = "Commentor Id")]
		[DataType(DataType.Text)]
		[StringLength(100, ErrorMessage = "{0} Has a maximum of {1} characters")]
		public string CommentorId { get; set; }

		[Required(ErrorMessage = "{0} Is Required")]
		[Display(Name = "Commentor Name")]
		[DataType(DataType.Text)]
		[StringLength(100, ErrorMessage = "{0} Has a maximum of {1} characters")]
		public string CommentorName { get; set; }

		public int ResponseId { get; set; }
	}
}