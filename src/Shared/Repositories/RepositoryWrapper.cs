using System.Threading.Tasks;

using IR.Shared.Data;
using IR.Shared.Interfaces;

namespace IR.Shared.Repositories
{
	public class RepositoryWrapper : IRepositoryWrapper
	{
		private readonly DataContext _context;
		private IIssueRepository _issue;

		public RepositoryWrapper(DataContext context)
		{
			_context = context;
		}

		public IIssueRepository Issue
		{
			get
			{
				if (_issue == null)
				{
					_issue = new IssueRepository(_context);
				}

				return _issue;
			}
		}

		public async Task SaveAsync()
		{
			await _context.SaveChangesAsync();
		}
	}
}
