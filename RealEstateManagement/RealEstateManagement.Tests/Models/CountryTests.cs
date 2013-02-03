using Microsoft.VisualStudio.TestTools.UnitTesting;
using RealEstateManagement.Core.Models;

namespace RealEstateManagement.Tests.Models
{
	[TestClass]
	public class CountryTests
	{
		[TestMethod]
		public void Country_ShouldHaveProperties()
		{
			var country = new Country
				{
					Name = "CountryName",
					Abbreviation = "Abbreviation",
				};

			Assert.AreEqual(typeof(string), country.Name.GetType());
			Assert.AreEqual(typeof(string), country.Abbreviation.GetType());
		}
	}
}
