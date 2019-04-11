using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Stumasys.Model;
using System.Web.Mvc;
using System.IO;

namespace Stumasys.Web.Controllers
{
    public class HomeController : Controller
    {
        private Person _students = new Person();
        private Course _courses = new Course();
        public ActionResult Index()
        {             
            return View(_students.GetAll());
        }

        public ActionResult Look(int personId)
        {
            return View(_students.Get(personId));
        }

        public ActionResult Crud(int personId=0)
        {
            ViewBag.allCourses = _courses.GetAll();
            return View(personId >0 ? _students.Get(personId)
                                    : this._students
                       );
        }

        /*public ActionResult Save(Person student, int[] selectedCourses = null)
        {
            if (selectedCourses != null)
            {
                foreach (var c in selectedCourses)
                    student.Courses.Add(new Course { CourseID = c});
            }
            else
            {
                ModelState.AddModelError("coursesMsgError", "You must choose at least one course");
            }

            if (ModelState.IsValid)
            {
                student.Save();

                return Redirect("~/Home/Crud?PersonID=" + student.PersonID);
            }
            else
            {
                ViewBag.allCourses = this._courses.GetAll();
                return View("Crud",student);
            }
            
        }*/

        public ActionResult Delete(int personId)
        {
            _students.Delete(personId);
            return Redirect("~/Home");
        }

        [HttpPost]
        public JsonResult Save(Person student, int[] selectedCourses = null)
        {
            var response = new ResponseModel
            {
                State = true,
                Redirect = "/Home/Crud?PersonID=" + student.PersonID,
                Error = ""
            };
             
            if (selectedCourses != null)
            {
                foreach (var c in selectedCourses)
                    student.Courses.Add(new Course { CourseID = c });
            }
            else
            {
                ModelState.AddModelError("coursesMsgError", "You must choose at least one course");
                response.State = false;
                response.Error = "You must choose at least one course";
                //response.Error = ModelState.Values.Select(x=>x.Errors).ToList().ToString();
            }

            if (ModelState.IsValid)
            {
                student.Save();
                response.Redirect = "/Home/Crud?PersonID=" + student.PersonID;
            }

            var errorList = ModelState.Values.SelectMany(m => m.Errors)
                                 .Select(e => e.ErrorMessage)
                                 .ToList();

            return Json(response);
        }
        public JsonResult Attach(int _personID,HttpPostedFileBase file)
        {
            var response = new ResponseModel
            {
                State = true,
                Error = ""
            };
            if (file != null)
            {
                string attached = DateTime.Now.ToString("yyyyMMddHHmmss") + Path.GetExtension(file.FileName);
                file.SaveAs(Server.MapPath("~/Uploads/" + attached));

                this._students.Attach(new Attachment { FileName = attached, PersonID = _personID });
            }
            else
            {
                response.State = false;
                response.Error = "You must attach to file.";
            }
            return Json(response);
        }

        public PartialViewResult Attachments(int _personID)
        {
            return PartialView(this._students.GetAllAttachments(_personID));
        }
    }
}