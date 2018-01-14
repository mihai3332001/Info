using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InfoOras.Models;

namespace InfoOras.Controllers
{



    public class LocatieController : Controller
    {
  // GET: Locatie
  DataClasses1DataContext dbmlLocatie = new DataClasses1DataContext();
  List<Locatie> newLocList = new List<Locatie>();
  Locatie newLoc = new Locatie();

  public List<Locatie> newLocationList() {
   newLocList = dbmlLocatie.Locaties.OrderBy(l => l.Name).ToList();
   return newLocList;
  }

  public List<Locatie> checkLocation(string name)
  {
   newLocList = dbmlLocatie.Locaties.Where(l => l.Name == name).ToList();
   return newLocList;
  }


  public Locatie newLocation(int id) {
   newLoc = dbmlLocatie.Locaties.Where(l => l.OrasID == id || l.ID == id).FirstOrDefault();
   return newLoc;
  }
  public ActionResult Index(int id)
        {
   Locatie orasSessionID = newLocation(id);
   System.Web.HttpContext.Current.Session["orasID"] = orasSessionID.OrasID;
   return View(newLocationList());
        }

     
        // GET: Locatie/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Locatie/Create
        [HttpPost]
        public ActionResult Create(Locatie collection)
        {
   if (checkLocation(collection.Name).Count() == 0)
   {
    int sessionID = Convert.ToInt32(Session["orasID"]);
    newLoc.Name = collection.Name;
    newLoc.OrasID = sessionID;
    dbmlLocatie.Locaties.InsertOnSubmit(newLoc);
    dbmlLocatie.SubmitChanges();
    TempData["Message"] = "Locatie adaugata!";
    return RedirectToAction("Index", new { id = sessionID });
   }
   else
   {
    ModelState.AddModelError("Name", "Exista deja!");
    return View();
   }
  }

        // GET: Locatie/Edit/5
        public ActionResult Edit(int id)
        {
            return View(newLocation(id));
        }

        // POST: Locatie/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Locatie collection)
        {
   if (checkLocation(collection.Name).Count() == 0)
   {
    int sessionID = Convert.ToInt32(Session["orasID"]);
    newLoc = newLocation(id);
    newLoc.Name = collection.Name;
    newLoc.OrasID = sessionID;
    dbmlLocatie.SubmitChanges();
    TempData["Message"] = "Locatie modificata";
    return RedirectToAction("Index", new { id = sessionID });
   }
   else
   {
    ModelState.AddModelError("Name", "Exista deja!");
    return View();
   }
  }

        // GET: Locatie/Delete/5
        public ActionResult Delete(int id)
        {
   return View(newLocation(id));
  }

        // POST: Locatie/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
    int sessionID = Convert.ToInt32(Session["orasID"]);
    newLoc = newLocation(id);
    dbmlLocatie.Locaties.DeleteOnSubmit(newLoc);
    dbmlLocatie.SubmitChanges();
    TempData["Message"] = "Locatie stearsa";
    return RedirectToAction("Index", new { id = sessionID });
   }
            catch
            {
                return View();
            }
        }
    }
}
