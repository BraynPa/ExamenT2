using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using N00029793T2.Models;

namespace N00029793T2.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private List<Pokemon> accounts = new List<Pokemon>
        {
            new Pokemon {Id = 1, Nombre = "Efectivo"},
            new Pokemon {Id = 2, Nombre = "Tarjeta Credito BCP"},
            new Pokemon {Id = 3, Nombre = "Tarjeta Credito Interbank"},
            new Pokemon {Id = 4, Nombre = "Chanchito"},
            new Pokemon {Id = 5, Nombre = "Bajo el colchon"}
        };


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Create(Pokemon account)
        {
            if (string.IsNullOrEmpty(account.Nombre))
                ModelState.AddModelError("Nombre", "Nombre es requerido");

            if (ModelState.IsValid)
            {
                //Guardar
                return RedirectToAction("Index");
            }

            return View(account);
            // No guardar
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

        public List<Pokemon> BuscarPorNombre(string name)
        {
            //name = name.Replace("é", "e");
            return accounts.Where(o => string.Compare(
        RemoveAccents(o.Nombre), RemoveAccents(name), StringComparison.InvariantCultureIgnoreCase) == 0).ToList();
        }

        private static string RemoveAccents(string s)
        {
            Encoding destEncoding = Encoding.GetEncoding("utf-8");

            return destEncoding.GetString(
                Encoding.Convert(Encoding.UTF8, destEncoding, Encoding.UTF8.GetBytes(s)));
        }
    }
}
