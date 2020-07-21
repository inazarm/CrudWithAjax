using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CrudWithAjax.Models;

namespace CrudWithAjax.Controllers
{
    public class RecordController : Controller
    {
        exampleEntities db = new exampleEntities();
        // GET: Record
        public ActionResult Index()
        {
            List<Country> CountryList = db.Countries.ToList();
            ViewBag.CountryList = new SelectList(CountryList, "cID", "cName");
            //ListItems.Add("Select");
            //ListItems.Add("Pakistan");
            //ListItems.Add("Australia");
            //ListItems.Add("America");
            //ListItems.Add("South Africa");
            //SelectList Countries = new SelectList(ListItems);
            //ViewData["Countries"] = Countries;
            //var CountryList = db.countries.ToList();
            //var CountryList = from u in db.countries select u.CountryName;
            //var CountryList = db.countries.Select(c=>new {CId=c.CID,CName=c.CountryName }).ToList();
            //SelectList Countries = new SelectList(CountryList);
            //ViewData["Countries"] = Countries;
            return View();
        }

        public JsonResult GetStateList(int CountryID)
        {
            db.Configuration.ProxyCreationEnabled = false;
            List<State> StateList = db.States.Where(x => x.cID == CountryID).ToList();
            return Json(StateList,JsonRequestBehavior.AllowGet);
        }
    }
}