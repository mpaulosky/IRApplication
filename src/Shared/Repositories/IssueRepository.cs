using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using IR.Shared.Data;
using IR.Shared.Interfaces;

using Microsoft.EntityFrameworkCore;
using IR.Shared.Models;

namespace IR.Shared.Repositories
{
	public class IssueRepository : IIssueRepository
	{
		private readonly DataContext _context;

		public IssueRepository(DataContext context)
		{
			_context = context;
		}

		public async Task<IEnumerable<Issue>> GetIssuesAsync()
		{
			var result = await _context.Issues.AsNoTracking().OrderBy(x => x.Id).ToListAsync();
			return result;
		}

		public async Task<Issue> GetIssueByIdAsync(int id)
		{
			var result = await _context.FindAsync<Issue>(id);
			return result;
		}

		public void CreateIssue(Issue issue)
		{
			_context.Add(issue);
		}

		public void UpdateIssue(Issue issue)
		{
			_context.Update(issue);
		}

		public void DeleteIssue(Issue issue)
		{
			// ToDo Make DeleteIssue a soft delete
			_context.Update(issue);
		}
	}
}
