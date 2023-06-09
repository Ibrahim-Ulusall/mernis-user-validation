using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
	public class Customer : IEntity
	{
        public int CustomerId { get; set; }
        public string? CustomerFirstName { get; set; }
        public string? CustomerLastName { get; set; }
        public string? NationalityId { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime DateOfBirthYear { get; set; }
    }
}
