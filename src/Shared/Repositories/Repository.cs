using IR.Shared.Interfaces;

using Microsoft.EntityFrameworkCore;

using System.Linq;
using System.Threading.Tasks;

namespace IR.Shared.Repositories
{
	public class Repository<TDbContext> : IRepository where TDbContext : DbContext
	{
		private readonly TDbContext _dbContext;

		public Repository(TDbContext context)
		{
			_dbContext = context;
		}

		public async Task CreateAsync<T>(T entity) where T : class
		{
			_dbContext.Set<T>().Add(entity);
			await _dbContext.SaveChangesAsync();
		}

		public async Task DeleteAsync<T>(T entity) where T : class
		{
			_dbContext.Set<T>().Remove(entity);
			await _dbContext.SaveChangesAsync();
		}

		public async Task<IQueryable<T>> SelectAllAsync<T>() where T : class
		{
			return _dbContext.Set<T>().AsNoTracking().AsQueryable();
		}

		public async Task<T> SelectByIdAsync<T>(long id) where T : class
		{
			return await _dbContext.Set<T>().FindAsync(id);
		}

		public async Task UpdateAsync<T>(T entity) where T : class
		{
			_dbContext.Set<T>().Update(entity);
			await _dbContext.SaveChangesAsync();
		}
	}
}
