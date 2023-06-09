using Business.Adapter;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using MernisClientValidation;

namespace MernisUserValidation
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		public async Task ValidationResult()
		{
			string TcNumber = NationalityId.Text;
			string firstName = FirstName.Text.ToUpper();
			string lastName = LastName.Text.ToUpper();
			DateTime birtOfYear = BirthOfYear.Value;
			EfCustomerDal customerDal = new EfCustomerDal(new MernisUserValidationCheckManager());
			await customerDal.Add(new Customer { CustomerId = 1, CustomerFirstName = firstName, CustomerLastName = lastName, NationalityId = TcNumber, DateOfBirthYear = birtOfYear });
			MessageBox.Show(customerDal.Result);
		}

		private void Validate_Click(object sender, EventArgs e)
		{
			ValidationResult();
		}
	
	}
}