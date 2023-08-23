using Microsoft.AspNetCore.Mvc;
using Project_One.Models;
using System.Diagnostics;
using System.Globalization;

namespace Project_One.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public string Mystring()
        {
            string abc = "!..........My name is Mufeez Bakhtiar..........!";
            return abc; 
        }

        public string weekday(int day = 1)
        {
            
            if (day == 1)
            {
                return "Today is Monday";
            }
            else if (day == 2) {
                return "Today is Tuesday";
            }

            else if (day == 3)
            {
                return "Today is Wednesday";
            }

            else if (day == 4)
            {
                return "Today is Thursday";
            }

            else if (day == 5)
            {
                return "Today is Friday";
            }

            else if (day == 6)
            {
                return "Today is Saturday";
            }

            else if (day == 7)
            {
                return "Today is Sunday";
            }

            else
            {
                return "Invalid Number";
            }

        }

    public int AddNumbers()
        {
            int a = 25;
            int b = 90;
            int c =100;
            int d = 200;

            int sum = a + b + c + d;
            return sum;
        }

        public string TwoStrings()
        {
            string a = "This is our first string in a fuction ";
            string b = "This is our second string in the same function. We are Concatenating the both using a function.";
            string c = "";
            return c = a + b;
        }

        public int conversion()
        {
            string a = "10";
            string b = "20";
            int c = int.Parse(a) + int.Parse(b);
            return c;
        }
            
        
        public string check()
        {
            int a = 202020;
            return a.ToString();
        }




        public int Sum(int num1 = 5, int num2 = 25 , int num3 = 155 )
        {
            return num1 + num2 + num3;
        }

        public string teststring(string a = "HELLO!!!")
        {
            return a;
        }

        public int Test()
        {
            int num1 = 5;
            int num2 = 25;
            return num1 + num2;
        }
    }
}