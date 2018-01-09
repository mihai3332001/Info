using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InfoOras.Models;


namespace InfoOras.Controllers
{
    public class TramsportController : Controller
    {
  DataClasses1DataContext dbmlTransport = new DataClasses1DataContext();
  List<Transport> transList = new List<Transport>();
  Transport trans = new Transport();

  public Transport transport (int transID) {
   trans = dbmlTransport.Transports.Where(t=>t.ID == transID).FirstOrDefault();
   return trans;
  }

  public List<Transport> transportList(string checkName)
  {
   transList = dbmlTransport.Transports.Where(t => t.Name == checkName).ToList();
   return transList;
  }
        // GET: Tramsport
        public ActionResult Index(int id)
        {

   List<Transport> transportID = dbmlTransport.Transports.Where(t => t.OrasID == id).ToList();
            return View(transportID);
        }

        // GET: Tramsport/Details/5
        public ActionResult Details(int id)
        {
   List<BiletViewModel> biletList = new List<BiletViewModel>();
   biletList = dbmlTransport.Bilets.Select(x => new BiletViewModel { ID = x.ID, TransportID = x.TransportID, Pret = x.Pret, Timp = x.Timp, Name = x.Transport.Name }).Where(x => x.TransportID == id).ToList();
            return View(biletList);
        }

        // GET: Tramsport/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tramsport/Create
        [HttpPost]
        public ActionResult Create(Transport collection, int id)
        {
   if (transportList(collection.Name).Count() == 0)
   {
    trans.Name = collection.Name;
    trans.OrasID = collection.ID;
    //trans.OrasID = id;
    dbmlTransport.Transports.InsertOnSubmit(trans);
    dbmlTransport.SubmitChanges();
    return RedirectToAction("Index");
   }
   else
   {
    ModelState.AddModelError("Oras", "City already exists!");
    return View();
   }
  }

        // GET: Tramsport/Edit/5
        public ActionResult Edit(int id)
        {
            return View(transport(id));
        }

        // POST: Tramsport/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Transport collection)
        {
          
    // TODO: Add update logic here
    if (transportList(collection.Name).Count() == 0)
    {
     trans = transport(id);
     trans.Name= collection.Name;

    dbmlTransport.SubmitChanges();
     return RedirectToAction("Index", "Tramsport", new { id = trans.ID });
    }
    else
    {
     ModelState.AddModelError("Oras", "City already exists!");
     return View();
    }
   }


        // GET: Tramsport/Delete/5
        public ActionResult Delete(int id)
        {
            return View(transport(id));
        }

        // POST: Tramsport/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
    // TODO: Add delete logic here
    trans = transport(id);
    dbmlTransport.Transports.DeleteOnSubmit(trans);
    dbmlTransport.SubmitChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
