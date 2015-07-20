using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using wm.website.ui.Services;

namespace wm.website.ui.Controllers
{
    public class HomeController : Controller
    {
        IErrorLogger logger { get; set; }
        public HomeController(IErrorLogger log)
        {
            logger = log;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult VistaPersonalizada()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SubmitForm(string nombre, int edad)
        {
            var nombreRecibido = nombre;
            var edadRecibida = edad;
            return View("Index");
        }


        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }
    }
}
