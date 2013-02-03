using System.Data.Entity;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using RealEstateManagement.App_Start;
using RealEstateManagement.Core.DAL;

namespace RealEstateManagement
{
	// Note: For instructions on enabling IIS6 or IIS7 classic mode, 
	// visit http://go.microsoft.com/?LinkId=9394801

	public class MvcApplication : System.Web.HttpApplication
	{
		protected void Application_Start()
		{
			AreaRegistration.RegisterAllAreas();

			WebApiConfig.Register(GlobalConfiguration.Configuration);
			FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
			RouteConfig.RegisterRoutes(RouteTable.Routes);
			BundleConfig.RegisterBundles(BundleTable.Bundles);

			//Database.SetInitializer(new DropCreateDatabaseAlways<RealEstateManagementContext>() );
			Database.SetInitializer(new RealEstateManagementInitializer());
			//AuthConfig.RegisterAuth();
		}
	}
}