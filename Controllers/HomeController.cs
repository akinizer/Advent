using System.Diagnostics;
using System.Security.Claims;
using Advent.Models;
using Microsoft.AspNetCore.Mvc;

namespace Advent.Controllers
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
        public IActionResult Blog()
        {
            return View();
        }
        public IActionResult Events()
        {
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }
        public IActionResult Profile()
        {
            return View(new UserProfileModel()
            {
                Username = Environment.UserName,
                Password = "12345678",

                Email = Environment.UserName + "@user.com",
                Avatar = "https://img.freepik.com/free-vector/blue-circle-with-white-user_78370-4707.jpg",
                Contact = "54321",
                Language = "en",
                SocialMedia = "AdvertBlog"
            });
        }
        public IActionResult Settings()
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
