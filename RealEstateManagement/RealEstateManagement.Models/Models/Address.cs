namespace RealEstateManagement.Core.Models
{
	public class Address
	{
		public int AddressID { get; set; }
		public string AddressLine1 { get; set; }

		public string AddressLine2 { get; set; }

		public string City { get; set; }

		public Province Province { get; set; }

		public Country Country { get; set; }

		public string ZipCode { get; set; }
	}
}