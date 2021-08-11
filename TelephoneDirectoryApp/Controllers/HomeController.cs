using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TelephoneDirectoryApp.Manager.WebManager;
using TelephoneDirectoryApp.Model.WebModel;
using TelephoneDirectoryApp.Models;

namespace TelephoneDirectoryApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IContactInformationTypeManager _contactInformationTypeManager;


        public HomeController(ILogger<HomeController> logger, IContactInformationTypeManager contactInformationTypeManager)
        {
            _logger = logger;
            _contactInformationTypeManager = contactInformationTypeManager;
        }

        public IActionResult Index()
        {
            //ToDo: Typelar için seelad yap
            //add Test
            _contactInformationTypeManager.AddType(new ContactInformationTypeWM() { Name="Test" });
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
