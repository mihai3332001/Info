using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InfoOras.Models;

namespace InfoOras.Controllers
{
    public class InfoController : Controller
    {
  DataClasses1DataContext dbml = new DataClasses1DataContext();
  List<Ora> listOra = new List<Ora>();
  Ora oras = new Ora();
  // GET: Info
  public ActionResult Index()
        {
   listOra = dbml.Oras.Where(x=>x.Oras != null).ToList();
            return View(listOra);
        }

        // GET: Info/Details/5
        public ActionResult Details(int id)
        {
   OrasViewModel orasVM = new OrasViewModel();

   orasVM = dbml.Oras.Select(x => new OrasViewModel { ID = x.ID, Oras = x.Oras, Lat = x.Lat, Long = x.Long, Judet = x.Judet.Judet1, JudetID = x.JudetID }).FirstOrDefault();

   return View(orasVM);
  }

        // GET: Info/Create
        public ActionResult Create()
        {

   return View();
        }

        // POST: Info/Create
        [HttpPost]
        public ActionResult Create(string Oras, decimal? Lat, decimal? Long)
        {

   if (ModelState.IsValidField("Oras") && string.IsNullOrEmpty(Oras))
   {
    ModelState.AddModelError("Oras", "Campul este gol");
    return View();
   }
    if (checkOras(Oras).Count == 0)
    {
     oras.Oras = Oras;
     oras.Lat = Lat;
     oras.Long = Long;
     dbml.Oras.InsertOnSubmit(oras);
     dbml.SubmitChanges();
     return RedirectToAction("Index");
    // TODO: Add insert logic here
   }
    else {
     ModelState.AddModelError("Oras", "City already exists!");
    return View();
    }
    //return RedirectToAction("Index");

   }
       
      public List<Ora> checkOras(string checkName) {
   List<Ora> genericOras = dbml.Oras.Where(x => x.Oras == checkName).ToList();
   return genericOras;
  }
      

        public ActionResult Edit(int id)
        {
  
   return View(Interogare(id));
        }

        // POST: Info/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Ora collection)
        {

   // TODO: Add update logic here
   if (checkOras(collection.Oras).Count == 0)
   {
    oras = Interogare(id);
    oras.Oras = collection.Oras;
    dbml.SubmitChanges();
    return RedirectToAction("Index");
   }
   else
   {
    ModelState.AddModelError("Oras", "City already exists!");
    return View();
   }
  }

  public Ora Interogare(int IDElement) {
   // Judet judet = dbml.Judets;
   oras = dbml.Oras.Where(o => o.ID == IDElement).FirstOrDefault();
   return oras;
  }



        // GET: Info/Delete/5
        public ActionResult Delete(int id)
  {

   return View(Interogare(id));
  }

        // POST: Info/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
    oras = Interogare(id);
    // TODO: Add delete logic here
    dbml.Oras.DeleteOnSubmit(oras);
    dbml.SubmitChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
