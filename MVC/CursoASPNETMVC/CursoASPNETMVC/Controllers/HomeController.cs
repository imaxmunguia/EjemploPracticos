using CursoASPNETMVC.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CursoASPNETMVC.Models;

namespace CursoASPNETMVC.Controllers
{
    public class HomeController : Controller
    {
        private PeliculasRepository _peliculasRepository;

        public HomeController()
        {
            _peliculasRepository = new PeliculasRepository();
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index2(Pelicula pelicula)
        {
            ViewBag.Message = "Exitoso";
            return View(pelicula);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            ViewBag.nValor = 20611060;
            ViewBag.sValor = "IM3";
            return View();
        }

        [ChildActionOnly]
        [HttpPost]
        public ActionResult Contact(int valor)
        {
            ViewBag.Message = "Your contact page." + valor.ToString();

            return View();
        }

        public ActionResult MyAction()
        {
            var model = _peliculasRepository.ObtenerPeliculas();

            ViewBag.Pelicula = _peliculasRepository.ObtenerPelicula();

            var estados = Enum.GetValues(typeof(Models.EstadoOperacion))
                              .Cast<Models.EstadoOperacion>()
                              .ToList().Select(s=>new SelectListItem {
                                  Value= ((int)s).ToString(),
                                  Text = s.ToString()
                              });

            var estado = (int)Models.EstadoOperacion.En_Proceso;
            var a = (Models.EstadoOperacion)estado;

            var t = typeof(Models.EstadoOperacion);

            if (!t.IsEnum) { throw new ApplicationException("Tipo debe ser enum"); }

            var estados2 = Enum.GetValues(typeof(Models.EstadoOperacion))
                  .Cast<Models.EstadoOperacion>()
                  .ToList().Select(s => new
                  {
                      Value = ((int)Enum.Parse(t, s.ToString())),
                      Text = s.ToString()
                  });


            ViewBag.ListaPeliculas = model
                                     .Select(x => new SelectListItem
                                     {
                                         Value = x.Titulo,
                                         Text = x.Titulo,
                                         Disabled = !x.EstaEnCartelera
                                     }).ToList();

            return View(model);
        }
        public ActionResult ResponsivePage()
        {
            return View();
        }

    }
}