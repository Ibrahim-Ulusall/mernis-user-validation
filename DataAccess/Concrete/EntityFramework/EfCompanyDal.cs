using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
	public class EfCompanyDal : IEfCompanyService
	{
		public void Add(Company entity)
		{
			throw new NotImplementedException();
		}

		public void Delete(Company entity)
		{
			throw new NotImplementedException();
		}

		public Company Get(Expression<Func<Company, bool>> filter)
		{
			throw new NotImplementedException();
		}

		public List<Company> GetAll(Expression<Func<Company, bool>> filter = null)
		{
			throw new NotImplementedException();
		}

		public void Update(Company entity)
		{
			throw new NotImplementedException();
		}
	}
}
