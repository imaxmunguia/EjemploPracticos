using Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private Alumno alumno = new Alumno();
        private Curso curso = new Curso();

        public ActionResult Index()
        {
            return View(alumno.Listar());
        }

        public ActionResult Ver(int id)
        {
            return View(alumno.Obtener(id));
        }

        public ActionResult Crud(int id = 0)
        {
            ViewBag.Cursos = curso.Todo();
            return View(
                id > 0 ? alumno.Obtener(id)
                       : alumno
            );
        }

        public ActionResult Eliminar(int id)
        {
            alumno.Eliminar(id);
            return Redirect("~/home");
        }

        /*public ActionResult Guardar(Alumno model, int[] cursos = null) 
        {
            if (cursos != null)
            {
                foreach (var c in cursos)
                    model.Cursos.Add(new Curso { id = c });
            }
            else 
            {
                ModelState.AddModelError("cursos-elegidos", "Debe seleccionar por lo menos un curso");
            }

            if (ModelState.IsValid)
            {
                model.Guardar();
                return Redirect("~/home/crud/" + model.id);
            }
            else 
            {
                ViewBag.Cursos = curso.Todo();
                return View("~/views/home/crud.cshtml", model);
            }
        }*/

        [HttpPost]
        public JsonResult Guardar(Alumno model, int[] cursos_seleccionados = null)
        {
            var respuesta = new ResponseModel
            {
                respuesta = true,
                redirect = "/home/crud/" + model.id,
                error = ""
            };

            if (cursos_seleccionados != null)
            {
                foreach (var c in cursos_seleccionados)
                    model.Cursos.Add(new Curso { id = c });
            }
            else
            {
                ModelState.AddModelError("cursos", "Debe seleccionar por lo menos un curso");
                respuesta.respuesta = false;
                respuesta.error = "Debe seleccionar por lo menos un curso";
            }

            if (ModelState.IsValid)
            {
                model.Guardar();
            }

            return Json(respuesta);
        }

        public JsonResult Adjuntar(int Alumno_id, HttpPostedFileBase documento)
        {
            var respuesta = new ResponseModel
            {
                respuesta = true,
                error = ""
            };

            if (documento != null)
            {
                string adjunto = DateTime.Now.ToString("yyyyMMddHHmmss") + Path.GetExtension(documento.FileName);
                documento.SaveAs(Server.MapPath("~/uploads/" + adjunto));

                this.alumno.Adjuntar(new Adjunto
                {
                    Archivo = adjunto,
                    Alumno_id = Alumno_id
                });
            }
            else
            {
                respuesta.respuesta = false;
                respuesta.error = "Debe adjuntar un documento";
            }

            return Json(respuesta);
        }

        public PartialViewResult Adjuntos(int Alumno_id) 
        {
            return PartialView(alumno.ListarAdjuntos(Alumno_id));
        }
    }
}
