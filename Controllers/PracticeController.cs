using Microsoft.AspNetCore.Mvc;
using Project_One.Models;
namespace Project_One.Controllers
{
	public class PracticeController : Controller
	{
		public IActionResult Index()
		{
			Practice Student1 = new Practice();	
			Student1.Id = 1;
			Student1.Name = "Ali Hamza";
			Student1.Description = "Ali Hamza is student of BSCS at Murray College. " +
				"He is doing Asp.net training from Theta Solutions";
		
			Practice Student2 = new Practice();	
			Student2.Id = 2;
			Student2.Name = "Rameez";
			Student2.Description = "Abcd ef gh ij kl mn op qr stuvqxyz";

			IList<Practice> TotalRecord = new List<Practice>();	
			TotalRecord.Add(Student1);
			TotalRecord.Add(Student2);
			return View(TotalRecord);
		}
	}
}
