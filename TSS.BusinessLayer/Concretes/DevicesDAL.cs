using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSS.Entities.Concretes;

namespace TSS.BusinessLayer.Concretes
{
    public class DeviceDAL : Abstracts.IEntityDAL<Devices>
    {
        DataLayer.Abstracts.IDeviceServices _services = null;
        public DeviceDAL(DataLayer.Abstracts.IDeviceServices services)
        {
            _services = services;
        }

        public void AddEntities(Devices Tentities)
        {
            _services.AddEntities(Tentities);
        }

        public void DeleteEntities(int id)
        {
            _services.DeleteEntities(id);
        }

        public List<Devices> getAllEntities()
        {
            return _services.GetAllEntities();
        }

        public List<Devices> GetAllEntitiesByFiltered(Predicate<Devices> pre)
        {
            return _services.GetAllEntities().FindAll(pre);
        }

        public Devices GetEntitieByFiltered(Predicate<Devices> pre)
        {
            return _services.GetAllEntities().Find(pre);
        }

        public void UpdateEntities(int id, Devices TEntities)
        {
            _services.UpdateEntities(id,TEntities);
        }
    }
}
