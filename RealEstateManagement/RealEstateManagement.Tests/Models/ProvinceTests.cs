using Microsoft.VisualStudio.TestTools.UnitTesting;
using RealEstateManagement.Core.Models;

namespace RealEstateManagement.Tests.Models
{
	[TestClass]
	public class ProvinceTests
	{
		[TestMethod]
		public void Country_ShouldHaveProperties()
		{
			var province = new Province
				{
					Name = "CountryName",
					Abbreviation = "Abbreviation",
				};

			Assert.AreEqual(typeof(string), province.Name.GetType());
			Assert.AreEqual(typeof(string), province.Abbreviation.GetType());
		}
	}
}
