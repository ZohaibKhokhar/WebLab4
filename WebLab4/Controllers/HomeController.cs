using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebLab4.Models;

namespace WebLab4.Controllers
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

        public IActionResult About()
        {
            ViewBag.Message = "this is view bag ";
            ViewData["data"] = "this is view data ";

            return View();
        }
   

        public IActionResult Task2()
        {
            Blogs blogs = new Blogs();
            blogs.Id= 1;
            blogs.Name= "Title of Blog";
            blogs.Description= "this is the description ";
            return View(blogs);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(string name,string email)
        {
            Console.WriteLine(name);
            Console.WriteLine(email);
            return View();
        }
        public IActionResult ProductList()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product
            {
                Id = 1,
                Name = "Laptop",
                Price = 10000,
                Description="This is a laptop"
            });
            products.Add(new Product
            {
                Id = 1,
                Name = "Mobile",
                Price = 10000,
                Description = "This is a Mobile"
            });

            return View(products);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
