using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IR.Shared.Models
{
	public class Issue : BaseEntity
	{
		[Required(ErrorMessage = "{0} Is Required")]
		[Display(Name = "Description")]
		[DataType(DataType.Text)]
		[StringLength(1000, MinimumLength = 3, ErrorMessage = "{0} Requires a minimum of {2} and a maximum of {1} characters")]
		public string IssueDescription { get; set; }

		[Required(ErrorMessage = "{0} Is Required")]
		[Display(Name = "Initiator Id")]
		[DataType(DataType.Text)]
		[StringLength(100, ErrorMessage = "{0} Has a maximum of {1} characters")]
		public string InitiatorId { get; set; }

		[Required(ErrorMessage = "{0} Is Required")]
		[Display(Name = "Initiator Name")]
		[DataType(DataType.Text)]
		[StringLength(100, ErrorMessage = "{0} Has a maximum of {1} characters")]
		public string InitiatorName { get; set; }

		[Display(Name = "Date Resolved")] 
		public DateTimeOffset DateResolvedUtc { get; set; }

		[Display(Name = "Resolved")] 
		public bool IsResolved { get; set; }

		public Response Response { get; set; }
	}
}