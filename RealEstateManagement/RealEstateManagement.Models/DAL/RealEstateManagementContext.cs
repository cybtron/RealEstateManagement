using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using RealEstateManagement.Core.Models;

namespace RealEstateManagement.Core.DAL
{
	public class RealEstateManagementContext : DbContext
	{
		public DbSet<Person> Buyers { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
		}
	}
}
