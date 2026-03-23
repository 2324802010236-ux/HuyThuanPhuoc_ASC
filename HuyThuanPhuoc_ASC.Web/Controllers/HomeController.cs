using HuyThuanPhuoc_ASC.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Diagnostics;

namespace HuyThuanPhuoc_ASC.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationSettings _applicationSettings;

        public HomeController(ILogger<HomeController> logger, IOptions<ApplicationSettings> applicationSettings)
        {
            _logger = logger;
            _applicationSettings = applicationSettings.Value;
        }

        public IActionResult Index()
        {
            var model = new DashboardViewModel
            {
                ApplicationName = _applicationSettings.ApplicationName,
                DashboardTitle = "Automobile Service Center Management Dashboard"
            };

            return View(model);
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
        public IActionResult DashboardSecure()
        {
            var model = new DashboardViewModel
            {
                ApplicationName = _applicationSettings.ApplicationName,
                DashboardTitle = "Secure Administration Dashboard"
            };

            return View(model);
        }
    }
}