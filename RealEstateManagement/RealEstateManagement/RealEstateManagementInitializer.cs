using System.Data.Entity;
using RealEstateManagement.Core.DAL;
using RealEstateManagement.Core.Models;

namespace RealEstateManagement
{
	public class RealEstateManagementInitializer : DropCreateDatabaseIfModelChanges<RealEstateManagementContext>
	{
		protected override void Seed(RealEstateManagementContext context)
		{
			 var buyer = new Person
				 {
				FirstName = "john",
				LastName = "doe"
			};

			context.Buyers.Add(buyer);
		}
		


	}
}