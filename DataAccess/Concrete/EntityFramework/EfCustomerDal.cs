using DataAccess.Abstract;
using Entities.Concrete;
using Business.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
	public class EfCustomerDal : IEfCustomerService
	{
		public string Result = "";
		IMicroServiceValidation _validation;

		public EfCustomerDal(IMicroServiceValidation validation)
		{
			_validation = validation;
		}
		

		public async Task Add(Customer customer)
		{
			bool isValid = await _validation.Validate(customer);

			if (isValid)
			{
				Result = "Kullanıcı Doğrulandı! " +  customer.CustomerFirstName;
			}
			else
			{
				Result = "Kullanıcı Doğrulanamadı";
			}
		}

		public void Delete(Customer customer)
		{
			throw new NotImplementedException();
		}

		public Customer Get(Expression<Func<Customer, bool>> filter)
		{
			throw new NotImplementedException();
		}

		public List<Customer> GetAll(Expression<Func<Customer, bool>> filter = null)
		{
			throw new NotImplementedException();
		}

		public void Update(Customer customer)
		{
			throw new NotImplementedException();
		}
	}
}
