using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InfoOras.Models;

namespace InfoOras.Controllers
{
    public class GmsController : Controller
    {
  DataClasses1DataContext dbmlGMS = new DataClasses1DataContext();
  List<GM> newGMSList = new List<GM>();
  GM newGM = new GM();

  public List<GM> gmList() {
   newGMSList = dbmlGMS.GMs.OrderBy(x => x.ID).ToList();
   return newGMSList;
  }

  public List<GM> gmList2(int id)
  {
   newGMSList = dbmlGMS.GMs.Where(x => x.GMS == id).ToList();
   return newGMSList;
  }
  public GM singleGM(int id) {
   newGM = dbmlGMS.GMs.Where(g => g.OrasID == id || g.ID == id).FirstOrDefault();
   return newGM;
  }
        // GET: Gms
        public ActionResult Index(int id)
        {
   GM orasSessionID = singleGM(id);
   System.Web.HttpContext.Current.Session["orasID"] = orasSessionID.OrasID;
            return View(gmList());
        }

        // GET: Gms/Details/5
        public ActionResult Details(int id)
        {
   List<BiletViewModel> biletList = new List<BiletViewModel>();
   biletList = dbmlGMS.Bilets.Select(x => new BiletViewModel { ID = x.ID, GMSID = x.GMSID, Pret = x.Pret, Timp = x.Timp }).Where(x => x.GMSID == id).ToList();
   return View(biletList);
        }

        // GET: Gms/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Gms/Create
        [HttpPost]
        public ActionResult Create(GM collection)
        {
   if (gmList2(collection.GMS).Count() == 0)
   {
    int sessionID = Convert.ToInt32(Session["orasID"]);
    newGM.GMS = collection.GMS;
    newGM.OrasID = sessionID;
    //trans.OrasID = id;
    dbmlGMS.GMs.InsertOnSubmit(newGM);
    dbmlGMS.SubmitChanges();
    return RedirectToAction("Index", new { id = sessionID });
   }
   else
   {
    ModelState.AddModelError("GMS", "Exista deja!");
    return View();
   }
  }

        // GET: Gms/Edit/5
        public ActionResult Edit(int id)
        {
            return View(singleGM(id));
        }

        // POST: Gms/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, GM collection)
        {
   if (gmList2(collection.GMS).Count() == 0)
   {
    int sessionID = Convert.ToInt32(Session["orasID"]);
    newGM = singleGM(id);
    newGM.GMS = collection.GMS;
    dbmlGMS.SubmitChanges();
    return RedirectToAction("Index", new { id = sessionID });
   }
   else
   {
    ModelState.AddModelError("GMS", "Exista deja!");
    return View();
   }
  }

        // GET: Gms/Delete/5
        public ActionResult Delete(int id)
        {
   return View(singleGM(id));
  }

        // POST: Gms/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
    int sessionID = Convert.ToInt32(Session["orasID"]);
    newGM = singleGM(id);

    dbmlGMS.GMs.DeleteOnSubmit(newGM);
    dbmlGMS.SubmitChanges();
    return RedirectToAction("Index", new { id = sessionID });
   }
            catch
            {
                return View();
            }
        }
    }
}
