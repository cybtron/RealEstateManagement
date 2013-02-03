using Microsoft.VisualStudio.TestTools.UnitTesting;
using RealEstateManagement.Core.Models;

namespace RealEstateManagement.Tests.Models
{
	[TestClass]
	public class AddressTests
	{
		[TestMethod]
		public void Address_ShouldHaveProperties()
		{
			var address = new Address
				{
					AddressLine1 = "addressLine1",
					AddressLine2 = "addressLine2",
					City = "City",
					Province = new Province(),
					Country = new Country(),
					ZipCode = "ZipCode"
				};

			Assert.AreEqual(typeof(string), address.AddressLine1.GetType());
			Assert.AreEqual(typeof(string), address.AddressLine2.GetType());
			Assert.AreEqual(typeof(string), address.City.GetType());
			Assert.AreEqual(typeof(Province), address.Province.GetType());
			Assert.AreEqual(typeof(Country), address.Country.GetType());
			Assert.AreEqual(typeof(string), address.ZipCode.GetType());
		}
	}
}
