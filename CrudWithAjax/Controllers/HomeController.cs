using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CrudWithAjax.Models;

namespace CrudWithAjax.Controllers
{
    public class HomeController : Controller
    {
        exampleEntities db = new exampleEntities();
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult CreateStudent(tblTask std)
        {
            db.tblTasks.Add(std);
            db.SaveChanges();
            string msg = "Success";
            return Json(new { Message = msg, JsonRequestBehavior.AllowGet });
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}