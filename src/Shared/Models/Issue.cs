using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IR.Shared.Models
{
	public class Issue : BaseEntity
	{
		public string IssueDescription { get; set; }
		public string InitiatorId { get; set; }
		public string InitiatorName { get; set; }
		public List<Response> Responses { get; set; }
	}
}