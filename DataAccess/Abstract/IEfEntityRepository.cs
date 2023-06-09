using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
	public interface IEfEntityRepository<T> where T: class, IEntity,new()
	{
		Task Add(T entity);
		void Delete(T entity);
		void Update(T entity);
		List<T> GetAll(Expression<Func<T, bool>> filter = null);
		T Get(Expression<Func<T, bool>> filter);
	}
}
