using RealEstateManagement.Core.DAL;
using RealEstateManagement.Core.Models;

namespace RealManagement.Services.Properties
{
	public class PropertyService
	{
		public void AddNewProperty(Property property, RealEstateManagementContext dbContext)
		{
			dbContext.Properties.Add(property);
			dbContext.SaveChanges();
		}
	}
}