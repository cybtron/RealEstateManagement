using Microsoft.VisualStudio.TestTools.UnitTesting;
using RealEstateManagement.Core.Models;

namespace RealEstateManagement.Tests.Models
{
	[TestClass]
	public class PropertyTypeTests
	{
		[TestMethod]
		public void PropertyType_ShouldHaveProperties()
		{
			var propertyType = new PropertyType
			{
				Name = "PropertyTypeName",
			};

			Assert.AreEqual(typeof(string), propertyType.Name.GetType());
		}
	}
}
