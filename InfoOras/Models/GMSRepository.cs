using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InfoOras.Models
{
    public class GMSRepository : IGMSRepository
    {
        DataClasses1DataContext dbmlGMS = new DataClasses1DataContext();

        public IList<GM> GMSALL() {
            List<GM> gmList = dbmlGMS.GMs.ToList();
            return gmList;
        }

        public GM GetGms(int id)
        {
           GM _gmID = gmList(id);
            return _gmID;
        }

        public GM AddGms(GM gm)
        {
            GM _gmNew = new GM();
            _gmNew.GMS = gm.GMS;
            _gmNew.OrasID = gm.OrasID;
            dbmlGMS.GMs.InsertOnSubmit(_gmNew);
            dbmlGMS.SubmitChanges();
            return _gmNew;
        }
        public GM UpdateGM(int id, GM gm)
        {
            GM _gmUpdate = gmList(id);
            _gmUpdate.GMS = gm.GMS;
            _gmUpdate.OrasID = gm.OrasID;
            dbmlGMS.SubmitChanges();
            return _gmUpdate;
        }
        public GM DeleteGM(int id)
        {
            GM _gmDelete = gmList(id);
            dbmlGMS.GMs.DeleteOnSubmit(_gmDelete);
            dbmlGMS.SubmitChanges();
            return _gmDelete;
        }

        private GM gmList(int id)
        {
          GM gm = dbmlGMS.GMs.Where(g => g.ID == id).FirstOrDefault();
            return gm;
        }

    }
}