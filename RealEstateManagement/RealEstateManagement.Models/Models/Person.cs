using System;

namespace RealEstateManagement.Core.Models
{
	public class Person
	{
		public Guid PersonID { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string NicNumber { get; set; }
		public string FathersName { get; set; }

	}
}
