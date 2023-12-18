using Microsoft.AspNetCore.Mvc;
using portfollio.Models;
using System.Diagnostics;

namespace portfollio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult DownloadCV()
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwoot", "CV.pdf");
            byte[] fileBytes = System.IO.File.ReadAllBytes(filePath);
            return File(fileBytes, "application/pdf", "CV.pdf");
        }

        public IActionResult CV()
        {
            return View();
        }

        public IActionResult Juridique()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Techno()
        {
            return View();
        }

        public IActionResult about()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }


        public IActionResult Documents()
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