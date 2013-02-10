using System;

namespace RealEstateManagement.Core.Models
{
	public class Property
	{
		public int PropertyID { get; set; }

		public DateTime? LastTransferOn { get; set; }

		public DateTime? SoldOn { get; set; }

		public DateTime? PurchasedOn { get; set; }

		public Person Buyer { get; set; }

		public Person Seller { get; set; }

		public string PlotNumber { get; set; }

		public decimal PlotSizeInKanals { get; set; }

		public Address Address { get; set; }

		public PropertyType PropertyType { get; set; }

		public PropertyZone PropertyZone { get; set; }

		public ConstructionStatus ConstructionStatus { get; set; }

		public OccupationStatus OccupationStatus { get; set; }
	}
}