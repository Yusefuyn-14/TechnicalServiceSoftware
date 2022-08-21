using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSS.Entities.Concretes;

namespace TSS.BusinessLayer.Concretes
{
    public class DevicesHardwareDAL : Abstracts.IEntityDAL<Devices_Hardware>
    {
        DataLayer.Abstracts.IDevicesHardwareServices _services = null;
        public DevicesHardwareDAL(DataLayer.Abstracts.IDevicesHardwareServices services)
        {
            _services = services;
        }

        public void AddEntities(Devices_Hardware Tentities)
        {
            _services.AddEntities(Tentities);
        }

        public void DeleteEntities(int id)
        {
            _services.DeleteEntities(id);
        }

        public List<Devices_Hardware> getAllEntities()
        {
            return _services.GetAllEntities();
        }

        public List<Devices_Hardware> GetAllEntitiesByFiltered(Predicate<Devices_Hardware> pre)
        {
            return _services.GetAllEntities().FindAll(pre);
        }

        public Devices_Hardware GetEntitieByFiltered(Predicate<Devices_Hardware> pre)
        {
            return _services.GetAllEntities().Find(pre);
        }

        public void UpdateEntities(int id, Devices_Hardware TEntities)
        {
            _services.UpdateEntities(id, TEntities);
        }
    }
}
