using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using wm.website.ui.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace wm.website.ui.Controllers
{
    public class ItemsController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            List<Item> items = new List<Item>(){
    new Item() { Id=1, Nombre="Item1" },
    new Item() { Id=2, Nombre="Item2" },
    new Item() { Id=3, Nombre="Item3" }};
            ViewBag.Mensaje = "¡Este valor es pasado por ViewBag!";
            return View(items);
        }

        public IActionResult Crear()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Crear(Item nuevoItem)
        {
            if (ModelState.IsValid)
            {
                // guardar en la base de datos
                return RedirectToAction("Index");
            }
            return View(nuevoItem);
        }


    }
}
