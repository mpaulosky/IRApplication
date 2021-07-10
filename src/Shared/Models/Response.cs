using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IR.Shared.Models
{
	public class Response : BaseEntity
	{
		[Required(ErrorMessage = "{0} Is Required")]
		[Display(Name = "Response")]
		[DataType(DataType.Text)]
		[StringLength(1000, MinimumLength = 3, ErrorMessage = "{0} Requires a minimum of {2} and a maximum of {1} characters")]
		public string ResponseDescription { get; set; }

		[Required(ErrorMessage = "{0} Is Required")]
		[Display(Name = "Responder Id")]
		[DataType(DataType.Text)]
		[StringLength(100, ErrorMessage = "{0} Has a maximum of {1} characters")]
		public string ResponderId { get; set; }

		[Required(ErrorMessage = "{0} Is Required")]
		[Display(Name = "Responder Name")]
		[DataType(DataType.Text)]
		[StringLength(100, ErrorMessage = "{0} Has a maximum of {1} characters")]
		public string ResponderName { get; set; }

		public int IssueId { get; set; }

		public List<Comment> Comments { get; set; }
	}
}