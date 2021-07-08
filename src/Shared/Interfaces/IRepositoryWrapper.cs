using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IR.Shared.Interfaces
{
	public interface IRepositoryWrapper
	{
		IIssueRepository Issue { get; }
		Task SaveAsync();
	}
}
