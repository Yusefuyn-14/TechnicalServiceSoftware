using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSS.Entities.Concretes;

namespace TSS.BusinessLayer.Concretes
{
    public class HardwaresDAL : Abstracts.IEntityDAL<Hardwares>
    {
        TSS.DataLayer.Abstracts.IHardwareServices _services = null;
        public HardwaresDAL(TSS.DataLayer.Abstracts.IHardwareServices services)
        {
            _services = services;
        }

        public void AddEntities(Hardwares Tentities)
        {
            _services.AddEntities(Tentities);
        }

        public void DeleteEntities(int id)
        {
            _services.DeleteEntities(id);
        }

        public List<Hardwares> getAllEntities()
        {
            return _services.GetAllEntities();
        }

        public List<Hardwares> GetAllEntitiesByFiltered(Predicate<Hardwares> pre)
        {
            return _services.GetAllEntities().FindAll(pre);
        }

        public Hardwares GetEntitieByFiltered(Predicate<Hardwares> pre)
        {
            return _services.GetAllEntities().Find(pre);
        }

        public void UpdateEntities(int id, Hardwares TEntities)
        {
            _services.UpdateEntities(id, TEntities);
        }

        public Hardwares GetLastAddedHardware()
        {
            return _services.GetLastAddedHardware();
        }
    }
}
