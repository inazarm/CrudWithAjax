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

        public JsonResult checkLogin(string username, string password)
        {
            var user = db.students.Where(x => x.Email == username && x.Password == password).SingleOrDefault();
            bool isLogged = true;
            if (user != null)
            {
                FormsAuthentication.SetAuthCookie(user.Email,false);
                isLogged = true;
            }
            else
            {
                isLogged = false;
            }
            return Json(isLogged, JsonRequestBehavior.AllowGet);
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
