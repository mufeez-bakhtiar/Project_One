using Microsoft.AspNetCore.Mvc;

namespace Project_One.Controllers
{
	public class AdminController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
