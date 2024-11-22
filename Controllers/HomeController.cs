using Microsoft.AspNetCore.Mvc;
using RohiniASP.NetMVC.Data;
using RohiniASP.NetMVC.Models;
using System.Diagnostics;

namespace RohiniASP.NetMVC.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDBContext _context = new ApplicationDBContext()
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var listOfData = _context.Users.ToList();
            return View(listOfData);
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
