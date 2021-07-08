using System.Collections.Generic;
using System.Threading.Tasks;

using IR.Shared.Models;

namespace IR.Shared.Interfaces
{
	public interface IIssueRepository
	{
		Task<IEnumerable<Issue>> GetIssuesAsync();
		Task<Issue> GetIssueByIdAsync(int id);
		void CreateIssue(Issue issue);
		void UpdateIssue(Issue issue);
		void DeleteIssue(Issue issue);
	}
}
