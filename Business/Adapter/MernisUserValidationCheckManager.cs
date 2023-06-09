using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MernisClientValidation;
namespace Business.Adapter
{
	public class MernisUserValidationCheckManager : IMicroServiceValidation
	{
		public async Task<bool> Validate(Customer customer)
		{
			KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
			
			var result = await client.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.NationalityId),customer.CustomerFirstName.ToUpper(),customer.CustomerLastName.ToUpper(),customer.DateOfBirthYear.Year);
			
			return result.Body.TCKimlikNoDogrulaResult;
		}
	}

}
