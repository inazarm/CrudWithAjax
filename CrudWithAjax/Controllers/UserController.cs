using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CrudWithAjax.Models;
using System.Web.Mvc;
using System.Data.Entity.Core.Metadata.Edm;
using System.Web.Security;

namespace CrudWithAjax.Controllers
{
    public class UserController : Controller
    {
        exampleEntities db = new exampleEntities();
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult checkLogin(string userEmail, string userPass)
        {
            //var dataItem = db.students.Where(x => x.Email == userEmail && x.Password == userPass).SingleOrDefault();
            //bool isLogged = true;
            //if (dataItem != null)
            //{
            //    FormsAuthentication.SetAuthCookie(dataItem.Email,false);
            //    isLogged = true;
            //}
            //else
            //{
            //    isLogged = false;
            //}
            //return Json(isLogged, JsonRequestBehavior.AllowGet);
            var user = from u in db.students where u.Email == userEmail && u.Password == userPass select u;
            //bool success = true;
            if (user.Count() > 0)
                return Json(new { Success = true }, JsonRequestBehavior.AllowGet);
            else
                return Json(new {Success=false },JsonRequestBehavior.AllowGet);
        }
        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: User/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
