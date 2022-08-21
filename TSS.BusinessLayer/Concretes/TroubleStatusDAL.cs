using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSS.Entities.Concretes;

namespace TSS.BusinessLayer.Concretes
{
    public class TroubleStatusDAL : Abstracts.IEntityDAL<Troubles_Status>
    {
        TSS.DataLayer.Abstracts.ITroubleStatusServices _services = null;
        public TroubleStatusDAL(TSS.DataLayer.Abstracts.ITroubleStatusServices services)
        {
            _services = services;
        }

        public void AddEntities(Troubles_Status Tentities)
        {
            _services.AddEntities(Tentities);
        }

        public void DeleteEntities(int id)
        {
            _services.DeleteEntities(id);
        }

        public List<Troubles_Status> getAllEntities()
        {
            return _services.GetAllEntities();
        }

        public List<Troubles_Status> GetAllEntitiesByFiltered(Predicate<Troubles_Status> pre)
        {
            return _services.GetAllEntities().FindAll(pre);
        }

        public Troubles_Status GetEntitieByFiltered(Predicate<Troubles_Status> pre)
        {
            return _services.GetAllEntities().Find(pre);
        }

        public void UpdateEntities(int id, Troubles_Status TEntities)
        {
            _services.UpdateEntities(id,TEntities);
        }
    }
}
