using System.Linq;
using System.Web.Mvc;
using RealEstateManagement.Core.DAL;

namespace RealEstateManagement.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your app description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
		public ActionResult Test()
		{
			var testData = new RealEstateManagementContext();

			var test1 = testData.Buyers.First();
			
			
			//ViewBag.Message = "Your contact page.";

			return View(test1);
		}
	}
}
