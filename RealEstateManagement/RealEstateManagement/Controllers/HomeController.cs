using System.Linq;
using System.Web.Mvc;
using RealEstateManagement.Core.DAL;
using RealEstateManagement.Core.Models;

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



			var buyer = new Person
			{
				FirstName = "john",
				LastName = "doe"
			};

			var buyer2 = new Person()
				{
					FirstName = "herooo"
				};
			
			
		
			testData.Buyers.Add(buyer2);
			testData.Buyers.Add(buyer);
			testData.SaveChanges();
			

			var test1 = testData.Buyers.First();
			
			
			//ViewBag.Message = "Your contact page.";
			return null;
			//return View(test1);
		}
	}
}
