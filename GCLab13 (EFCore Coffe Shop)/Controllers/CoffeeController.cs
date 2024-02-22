using GCLab13__EFCore_Coffe_Shop_.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Eventing.Reader;

namespace GCLab13__EFCore_Coffe_Shop_.Controllers
{
    public class CoffeeController : Controller
    {
        private CoffeeDbContext dbContext = new CoffeeDbContext();
        [HttpGet]
        public IActionResult Index()
        {
            List<Coffee> result = dbContext.Coffees.ToList(); 
            return View(result);
        }

        [HttpPost]
        public IActionResult Index(Coffee c)
        {
            dbContext.Coffees.Add(c);
            dbContext.SaveChanges();

            List<Coffee> result = dbContext.Coffees.ToList();
            return View(result);
        }

        public IActionResult Details(int id)
        {
            Coffee result = dbContext.Coffees.FirstOrDefault(c => c.Id == id);
            return View(result);
        }
    }
}
