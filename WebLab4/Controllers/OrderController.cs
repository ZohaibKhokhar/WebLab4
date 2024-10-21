using Microsoft.AspNetCore.Mvc;
using WebLab4.Models;

namespace WebLab4.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Order()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Order(string fooditem,int quantity)
        {
            if (quantity>=0)
            {
                Console.WriteLine(fooditem);
                Console.WriteLine(quantity);
                return RedirectToAction("Success");
            }
            return View();
        }

        public IActionResult Success()
        {
            return View();
        }
    }
}
