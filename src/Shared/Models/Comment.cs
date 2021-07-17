using System.ComponentModel.DataAnnotations;

namespace IR.Shared.Models
{
	public class Comment : BaseEntity
	{
		[Required(ErrorMessage = "{0} Is Required")]
		[Display(Name = "Comment")]
		[DataType(DataType.Text)]
		[StringLength(1000, MinimumLength = 3, ErrorMessage = "{0} Requires a minimum of {2} and a maximum of {1} characters")]
		public string CommentDescription { get; set; }

		[Required(ErrorMessage = "{0} Is Required")]
		[Display(Name = "Commenter Id")]
		[DataType(DataType.Text)]
		[StringLength(100, ErrorMessage = "{0} Has a maximum of {1} characters")]
		public string CommenterId { get; set; }

		[Required(ErrorMessage = "{0} Is Required")]
		[Display(Name = "Commenter Name")]
		[DataType(DataType.Text)]
		[StringLength(100, ErrorMessage = "{0} Has a maximum of {1} characters")]
		public string CommenterName { get; set; }

		public long ResponseId { get; set; }
	}
}