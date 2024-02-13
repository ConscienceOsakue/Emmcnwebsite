using Emmcnorb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace Emmcnorb.Controllers
{
    /*The Controller handles user input, processes it, and communicates
    with the Model and View accordingly. It acts as an intermediary between
    the Model and View, receiving requests from the user, updating the Model,
    and then rendering the appropriate View with the updated data.*/

    // added the controller to the method
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // i use this IActionResult to call each page to display the website
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AboutPage()
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
    }
}
