using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using opg_201910_interview.Models;
using Newtonsoft.Json;


namespace opg_201910_interview.Controllers
{
    public class HomeController : Controller
    {
       // private readonly ILogger<HomeController> _logger;
        private readonly Appsettings _appSettings;
        public HomeController(IConfiguration configuration)
        {
            _appSettings = new Appsettings();
            configuration.GetSection("AppSettings").Bind(_appSettings);
        }

        public ContentResult Index()
        {
            try
            {
                var model = _appSettings.ClientSettings;

                string json = JsonConvert.SerializeObject(model, Formatting.Indented);

                return Content(json);
            }
            catch (Exception ex)
            {
                return Content("Error found!", ex.Message);
            }
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
