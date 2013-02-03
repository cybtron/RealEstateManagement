using Microsoft.VisualStudio.TestTools.UnitTesting;
using RealEstateManagement.Core.Models;

namespace RealEstateManagement.Tests.Models
{
	[TestClass]
	public class PropertyZoneTests
	{
		[TestMethod]
		public void PropertyZone_ShouldHaveProperties()
		{
			var propertyZone = new PropertyZone
				{
					Name = "PropertyZoneName",
				};

			Assert.AreEqual(typeof(string), propertyZone.Name.GetType());
		}
	}
}