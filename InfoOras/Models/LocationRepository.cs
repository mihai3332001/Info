using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace InfoOras.Models
{
    public class LocationRepository : ILocationRepository
    {
        DataClasses1DataContext dbmlLocation = new DataClasses1DataContext();
        public IList<Locatie> GetLocations()
        {
            IList<Locatie> getLocations = dbmlLocation.Locaties.ToList();
            return getLocations;
        }

        public Locatie GetIdLocation(int id)
        {
            Locatie locID = getIDLocation(id);
            return locID;
        }


        public Locatie AddLocation(Locatie loc)
        {
            Locatie newLocation = new Locatie();
            newLocation.Name = loc.Name;
            newLocation.OrasID = loc.OrasID;
            dbmlLocation.Locaties.InsertOnSubmit(newLocation);
            dbmlLocation.SubmitChanges();
            return newLocation;
        }

        public Locatie UpdateLocation(int id, Locatie loc)
        {
            Locatie updateLoc = getIDLocation(id);
            updateLoc.Name = loc.Name;
            updateLoc.OrasID = loc.OrasID;
            dbmlLocation.SubmitChanges();
            return updateLoc;
        }

        public Locatie DeleteLocation(int id)
        {
           Locatie delLoc =  getIDLocation(id);
            return delLoc;
        }

        private Locatie getIDLocation(int id)
        {
            Locatie getLocation = dbmlLocation.Locaties.Where(l => l.ID == id).FirstOrDefault();
            return getLocation;
        }
    }
}