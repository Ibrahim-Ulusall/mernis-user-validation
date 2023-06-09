using Business.Adapter;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

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
			EfCustomerDal customerDal = new EfCustomerDal(new MernisUserValidationCheckManager());
			await customerDal.Add(new Customer { CustomerId = 1, CustomerFirstName = "ibrahim", CustomerLastName = "Ulusal", NationalityId = "28253393342", DateOfBirthYear = new DateTime(2000, 08, 08) });
			MessageBox.Show(customerDal.Result);
		}

		private void Validate_Click(object sender, EventArgs e)
		{
			ValidationResult();
		}
	}
}