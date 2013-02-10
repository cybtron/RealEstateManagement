using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RealEstateManagement.Core.Models;

namespace RealEstateManagement.Tests.Models
{
	[TestClass]
	public class PropertyTests
	{
		[TestMethod]
		public void PropertyShouldHaveProperties()
		{
			var property = new Property()
				{
					LastTransferOn = new DateTime(),
					SoldOn = new DateTime(),
					PurchasedOn = new DateTime(),
					Buyer = new Person(),
					Seller = new Person(),
					PlotNumber = "",
					PlotSizeInKanals = 456,
					Address = new Address(),
					PropertyType = new PropertyType(),
					PropertyZone = new PropertyZone(),
					ConstructionStatus = new ConstructionStatus(),
					OccupationStatus = new OccupationStatus(),
				};

			Assert.AreEqual(typeof(DateTime), property.LastTransferOn.GetType());
			Assert.AreEqual(typeof(DateTime), property.SoldOn.GetType());
			Assert.AreEqual(typeof(DateTime), property.PurchasedOn.GetType());
			Assert.AreEqual(typeof(Person), property.Buyer.GetType());
			Assert.AreEqual(typeof(Person), property.Seller.GetType());
			Assert.AreEqual(typeof(string), property.PlotNumber.GetType());
			Assert.AreEqual(typeof(decimal), property.PlotSizeInKanals.GetType());
			Assert.AreEqual(typeof(Address), property.Address.GetType());
			Assert.AreEqual(typeof(PropertyType), property.PropertyType.GetType());
			Assert.AreEqual(typeof(PropertyZone), property.PropertyZone.GetType());
			Assert.AreEqual(typeof(ConstructionStatus), property.ConstructionStatus.GetType());
			Assert.AreEqual(typeof(OccupationStatus), property.OccupationStatus.GetType());
		}
	}
}
