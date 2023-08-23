using Microsoft.AspNetCore.Mvc;
using Project_One.Models;

namespace Project_One.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.detail = 1;
            TempData["details"] = "This string is coming to view through TempData Method";
            
            return View();
        }

		public IActionResult StudentDetails()
		{
			Student StudentDet1 = new Student();
			StudentDet1.Id = 1;
			StudentDet1.Name = "Mufeez Bakhtiar";
			StudentDet1.Description = "Learning Asp.net framework";
			StudentDet1.Exist = true;
			
			//ViewBag.StudentsDetails = StudentDet1;

			Student StudentDet2 = new Student();
			StudentDet2.Id = 2;
			StudentDet2.Name = "Ali Hamza";
			StudentDet2.Description = "Grade 10th student";
			StudentDet2.Exist = true;


			Student StudentDet3 = new Student();
			StudentDet3.Id = 3;
			StudentDet3.Name = "Rameez";
			StudentDet3.Description = "Learning Amazon PL";
			StudentDet3.Exist = true;


			Student StudentDet4 = new Student();
			StudentDet4.Id = 4;
			StudentDet4.Name = "Jamshaid";
			StudentDet4.Description = "Learning Asp.net framework";
			StudentDet4.Exist = true;


			Student StudentDet5 = new Student();
			StudentDet5.Id = 5;
			StudentDet5.Name = "Mr.ABC";
			StudentDet5.Description = "Learning Web Development using django";
			StudentDet5.Exist = true;

			IList<Student> TotalRecord = new List<Student>();
			TotalRecord.Add(StudentDet1);
			TotalRecord.Add(StudentDet2);
			TotalRecord.Add(StudentDet3);
			TotalRecord.Add(StudentDet4);
			TotalRecord.Add(StudentDet5);

			//ViewBag.details = "StudentDet";

			return View(TotalRecord);

		
         
        }
    }
}
