using Microsoft.VisualStudio.TestTools.UnitTesting;
using RealEstateManagement.Core.Models;

namespace RealEstateManagement.Tests.Models
{
	[TestClass]
	public class ConstructionStatusTests
	{
		[TestMethod]
		public void ConstructionStatus_ShouldHaveProperties()
		{
			var constructionStatus = new ConstructionStatus
			{
				Name = "constructionStatusName",
			};

			Assert.AreEqual(typeof(string), constructionStatus.Name.GetType());
		}
	}
}