using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using RealEstateManagement.Core.Models;

namespace RealEstateManagement.Core.DAL
{
	public class RealEstateManagementContext : DbContext
	{
		static RealEstateManagementContext()
		{
			Database.SetInitializer(new CreateMySqlDatabaseIfNotExists<RealEstateManagementContext>());
		}

		public DbSet<Person> Persons { get; set; }
		public DbSet<Address> Addresses { get; set; }
		public DbSet<Country> Countries { get; set; }
		public DbSet<Province> Provinces { get; set; }
		public DbSet<PropertyType> PropertyTypes { get; set; }
		public DbSet<PropertyZone> PropertyZones { get; set; }
		public DbSet<OccupationStatus> OccupationStatuses { get; set; }
		public DbSet<ConstructionStatus> ConstructionStatuses { get; set; }
		public DbSet<Property> Properties { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
		}
	}
}
