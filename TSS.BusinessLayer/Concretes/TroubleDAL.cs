using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using TSS.Entities.Concretes;

namespace TSS.BusinessLayer.Concretes
{
    public class TroubleDAL : Abstracts.IEntityDAL<Troubles>
    {
        TSS.DataLayer.Abstracts.ITroubleServices _services = null;
        public TroubleDAL(TSS.DataLayer.Abstracts.ITroubleServices services)
        {
            _services = services;
        }

        public void AddEntities(Troubles Tentities)
        {
            _services.AddEntities(Tentities);
        }

        public void DeleteEntities(int id)
        {
            _services.DeleteEntities(id);
        }

        public List<Troubles> getAllEntities()
        {
            return _services.GetAllEntities();
        }

        public List<Troubles> GetAllEntitiesByFiltered(Predicate<Troubles> pre)
        {
            return _services.GetAllEntities().FindAll(pre);
        }

        public Troubles GetEntitieByFiltered(Predicate<Troubles> pre)
        {
            return _services.GetAllEntities().Find(pre);
        }

        public void UpdateEntities(int id, Troubles TEntities)
        {
            _services.UpdateEntities(id, TEntities);
        }
    }
}
