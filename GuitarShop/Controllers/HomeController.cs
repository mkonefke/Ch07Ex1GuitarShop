using Microsoft.AspNetCore.Mvc;

namespace GuitarShop.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [Route("[action]/ContactUs")]
        public IActionResult ContactUs()
        {
            var contact = new Dictionary<string, string>
            {
                { "Phone", "555-123-4567" },
                { "Email", "info@myguitarshop.com" },
                { "Address", "123 Main St, Anytown, USA" }
                };
            return View(contact);
        }
        [Route("[action]")]
        public IActionResult About()
        {
            return View();
        }
    }
}
