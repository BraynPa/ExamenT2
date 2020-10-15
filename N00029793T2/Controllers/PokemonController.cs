using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using N00029793T2.Models;

namespace N00029793T2.Controllers
{

    [Authorize]
    public class PokemonController : BaseController
        {
            private N00029793T2Context _context;
            public IHostEnvironment _hostEnv;

            public PokemonController(N00029793T2Context context, IHostEnvironment hostEnv) : base(context)
            {
                _context = context;
                _hostEnv = hostEnv;
            }

            [HttpGet]
            public ActionResult Index()
            {
                var Pokemon = new Pokemon();
                var por = _context.Pokemons
                    .Include(o => o.Type)
                    .ToList();
            return View(por);
            }


            [HttpGet]
            public ActionResult Create() // GET
            {
                ViewBag.Types = _context.Types.ToList();
                return View("Create", new Pokemon());
            }

            [HttpPost]
            public ActionResult Create(Pokemon pokemon, IFormFile img) // POST
            {
            var pokemonv = _context.Pokemons.FirstOrDefault(o => o.Nombre == pokemon.Nombre);
            if (pokemonv != null) {
                ModelState.AddModelError("Nombre2", "Ya existe ese pokemon");
            }
                
            if (ModelState.IsValid)
                {
                    pokemon.RutaImgPo = SaveImage(img);

                    _context.Pokemons.Add(pokemon);
                    _context.SaveChanges();

                    return RedirectToAction("Index");
                }
                ViewBag.Types = _context.Types.ToList();
                return View("Create", pokemon);
            }



            [HttpGet]
            public ActionResult Edit(int PokemonId)
            {
                ViewBag.Types = _context.Types.ToList();
                var pokemon = _context.Pokemons.Where(o => o.Id == PokemonId).FirstOrDefault(); // si no lo encutra retorna un null

                return View(pokemon);
            }

            [HttpPost]
            public ActionResult Edit(Pokemon pokemon)
            {
            var pokemonv = _context.Pokemons.FirstOrDefault(o => o.Nombre == pokemon.Nombre);
            if (pokemonv != null)
                ModelState.AddModelError("Name2", "Ya existe ese pokemon");
            if (ModelState.IsValid)
                {
                    _context.Pokemons.Update(pokemon);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }

                ViewBag.Types = _context.Types.ToList();
                return View(pokemon);
            }

            [HttpGet]
            public ActionResult Delete(int PokemonId)
            {
                var pokemon = _context.Pokemons.Where(o => o.Id == PokemonId).FirstOrDefault();
                _context.Pokemons.Remove(pokemon);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            [HttpGet]
            public ActionResult Capturar(int Id) // GET
            {
            if (ModelState.IsValid)
            {
                var pokeser = new PokeUser { IdPokemon = Id, IdUser = LoggedUser().Id, FechaCaptura = DateTime.Now };
                _context.PokeUsers.Add(pokeser);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            return View("Index");
        }
            [HttpGet]
            public ActionResult Capturados() // GET
            {
            var pokeser = _context.PokeUsers.Where(o => o.IdUser == LoggedUser().Id)
            .Include(x => x.Pokemon.Type).ToList();

                return View(pokeser);
            }
            [HttpGet]
            public ActionResult liberar(int PokemonId) // GET
            {
                var pokeser = _context.PokeUsers.Where(o => o.IdPokemon == PokemonId && o.IdUser == LoggedUser().Id).FirstOrDefault();
                _context.PokeUsers.Remove(pokeser);
                _context.SaveChanges();
                return RedirectToAction("Capturados");
            }

        private string SaveImage(IFormFile image)
            {
                if (image != null && image.Length > 0)
                {
                    var basePath = _hostEnv.ContentRootPath + @"\wwwroot";
                    var ruta = @"\files\" + image.FileName;

                    using (var strem = new FileStream(basePath + ruta, FileMode.Create))
                    {
                        image.CopyTo(strem);
                        return ruta;
                    }
                }
                return null;
            }
        

    }
}
