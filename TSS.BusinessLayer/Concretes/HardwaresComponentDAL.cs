using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSS.Entities.Concretes;

namespace TSS.BusinessLayer.Concretes
{
    public class HardwaresComponentDAL : Abstracts.IEntityDAL<TSS.Entities.Concretes.Hardwares_Component>
    {
        DataLayer.Abstracts.IHardwaresComponentService _services = null;
        public HardwaresComponentDAL(DataLayer.Abstracts.IHardwaresComponentService service)
        {
            _services = service;
        }
        public void AddEntities(Hardwares_Component Tentities)
        {
            _services.AddEntities(Tentities);
        }

        public void DeleteEntities(int id)
        {
            _services.DeleteEntities(id);
        }

        public List<Hardwares_Component> getAllEntities()
        {
            return _services.GetAllEntities();
        }

        public List<Hardwares_Component> GetAllEntitiesByFiltered(Predicate<Hardwares_Component> pre)
        {
            return _services.GetAllEntities().FindAll(pre);

        }

        public Hardwares_Component GetEntitieByFiltered(Predicate<Hardwares_Component> pre)
        {
            return _services.GetAllEntities().Find(pre);
        }

        public void UpdateEntities(int id, Hardwares_Component Tentities)
        {
            _services.UpdateEntities(id, Tentities);
        }
    }
}
