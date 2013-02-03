using System.Data.Entity;
using RealEstateManagement.Core.DAL;
using RealEstateManagement.Core.Models;

namespace RealEstateManagement
{
	public class RealEstateManagementInitializer : DropCreateDatabaseAlways<RealEstateManagementContext>
	{
		protected override void Seed(RealEstateManagementContext context)
		{
			var buyer = new Person
				{
					FirstName = "john",
					LastName = "doe"
				};
			//context.Database.Connection.BeginTransaction();
			context.Buyers.Add(buyer);
			context.SaveChanges();
			
		}
		


	}
}