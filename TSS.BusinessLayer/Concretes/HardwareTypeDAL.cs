using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSS.Entities.Concretes;
namespace TSS.BusinessLayer.Concretes
{
    public class HardwareTypeDAL : Abstracts.IEntityDAL<Hardwares_Type>
    {
        TSS.DataLayer.Abstracts.IHardwareTypeServices _services = null;
        public HardwareTypeDAL(TSS.DataLayer.Abstracts.IHardwareTypeServices services)
        {
            _services = services;
        }

        public void AddEntities(Hardwares_Type Tentities)
        {
            _services.AddEntities(Tentities);
        }

        public void DeleteEntities(int id)
        {
            _services.DeleteEntities(id);
        }

        public List<Hardwares_Type> getAllEntities()
        {
            return _services.GetAllEntities();
        }

        public List<Hardwares_Type> GetAllEntitiesByFiltered(Predicate<Hardwares_Type> pre)
        {
            return _services.GetAllEntities().FindAll(pre);
        }

        public Hardwares_Type GetEntitieByFiltered(Predicate<Hardwares_Type> pre)
        {
            return _services.GetAllEntities().Find(pre);
        }

        public void UpdateEntities(int id, Hardwares_Type TEntities)
        {
            _services.UpdateEntities(id,TEntities);
        }
    }
}
