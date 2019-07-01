using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentsPortal.Models.StudentsDetails;

namespace StudentsPortal.Controllers
{
    public class RegistrationsController : Controller
    {
        // GET: Registrations
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DashBoard()
        {
            return View();
        }

        public ActionResult RegisterCourses()
        {
            return View();
        }
    }
}