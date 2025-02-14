using Azure.Core;
using LeaveManagementSystem.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LeaveManagementSystem.Web.Controllers
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
            // Define business logic
            //...

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            var model = new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
                //This line of code is determining the value of RequestId. It's checking if Activity.Current?.Id is not null (using the null conditional operator ?. to avoid a null reference exception). If Activity.Current?.Id is not null, it assigns its value to RequestId. If it is null, it assigns HttpContext.TraceIdentifier to RequestId.                       
            };
            return View(model);
        }
    }
}
