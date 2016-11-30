using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace InfoNews
{
	public interface IBaseApplicationService<T>
	{
		Task<T> GetById(int id);
		Task<T> GetByFilter(Expression<Func<T, bool>> filter);

		Task<IList<T>> GetAll();
		Task<IList<T>> GetAllByFilter(Expression<Func<T, bool>> filter);
	}
}
