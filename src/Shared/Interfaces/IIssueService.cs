using System.Collections.Generic;
using System.Threading.Tasks;

using IR.Shared.Dtos;
using IR.Shared.Models;

namespace IR.Shared.Interfaces
{
	public interface IIssueService
	{
		Task<IEnumerable<IssueDto>> GetIssuesAsync();
		Task<IssueDto> GetIssueByIdAsync(long id);
		Task<IssueDto> CreateIssueAsync(NewIssueDto issue);
		Task<bool> UpdateIssueAsync(long id, IssueForUpdateDto issue);
		Task<bool> DeleteIssueAsync(IssueForDeleteDto issue);
		Task<bool> IssueExistsAsync(long id);
		Task<Issue> EnforceIssueExistenceAsync(long id);
	}
}