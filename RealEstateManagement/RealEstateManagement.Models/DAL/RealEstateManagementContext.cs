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

		//public RealEstateManagementContext()
		//	: base("Name=LocalMySqlServer")
		//{
		//}

		public DbSet<Person> Buyers { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
		}
	}
}
