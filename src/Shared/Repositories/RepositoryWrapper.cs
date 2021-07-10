using IR.Shared.Data;
using IR.Shared.Interfaces;

namespace IR.Shared.Repositories
{
	public class RepositoryWrapper : IRepositoryWrapper
	{
		private readonly DataContext _context;
		private IRepository _repository;

		public RepositoryWrapper(DataContext context)
		{
			_context = context;
		}

		public IRepository Repo
		{
			get
			{
				if (_repository == null)
				{
					_repository = new Repository<DataContext>(_context);
				}
				return _repository;
			}
		}
	}
}
