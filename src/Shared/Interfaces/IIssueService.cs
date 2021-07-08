using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IR.Shared.Dtos;
using IR.Shared.Models;

namespace IR.Shared.Interfaces
{
	public interface IIssueService
	{
		Task<IEnumerable<IssueDto>> GetIssuesAsync();
		Task<IssueDto> GetIssueByIdAsync(int id);
		Task<IssueDto> CreateIssueAsync(NewIssueDto issue);
		Task<bool> UpdateIssueAsync(int id, IssueForUpdateDto issue);
		Task<bool> DeleteIssueAsync(IssueForDeleteDto issue);
		Task<bool> IssueExistsAsync(int id);
		Task<Issue> EnforceIssueExistenceAsync(int id);
	}
}
