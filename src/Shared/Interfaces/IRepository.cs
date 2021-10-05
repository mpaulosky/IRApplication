using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IR.Shared.Interfaces
{
	public interface IRepository
	{
		Task<IQueryable<T>> SelectAllAsync<T>() where T : class;
		Task<T> SelectByIdAsync<T>(long id) where T : class;
		Task CreateAsync<T>(T entity) where T : class;
		Task UpdateAsync<T>(T entity)	where T : class;
		Task DeleteAsync<T>(T entity) where T : class;
	}
}
