using Microsoft.VisualStudio.TestTools.UnitTesting;
using RealEstateManagement.Core.Models;

namespace RealEstateManagement.Tests.Models
{
	[TestClass]
	public class OccupationStatusTests
	{
		[TestMethod]
		public void OccupationStatus_ShouldHaveProperties()
		{
			var occupationStatus = new OccupationStatus
			{
				Name = "OccupationStatusName",
			};

			Assert.AreEqual(typeof(string), occupationStatus.Name.GetType());
		}
	}
}