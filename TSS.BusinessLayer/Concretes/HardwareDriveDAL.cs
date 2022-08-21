using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSS.Entities.Concretes;

namespace TSS.BusinessLayer.Concretes
{
    public class HardwareDriveDAL : Abstracts.IEntityDAL<Hardwares_Drive>
    {
        TSS.DataLayer.Abstracts.IHardwareDriveServices _services = null;
        public HardwareDriveDAL(TSS.DataLayer.Abstracts.IHardwareDriveServices services)
        {
            _services = services;
        }

        public void AddEntities(Hardwares_Drive Tentities)
        {
            _services.AddEntities(Tentities);
        }

        public void DeleteEntities(int id)
        {
            _services.DeleteEntities(id);
        }

        public List<Hardwares_Drive> getAllEntities()
        {
            return _services.GetAllEntities();
        }

        public List<Hardwares_Drive> GetAllEntitiesByFiltered(Predicate<Hardwares_Drive> pre)
        {
            return _services.GetAllEntities().FindAll(pre);
        }

        public Hardwares_Drive GetEntitieByFiltered(Predicate<Hardwares_Drive> pre)
        {
            return _services.GetAllEntities().Find(pre);
        }

        public void UpdateEntities(int id, Hardwares_Drive TEntities)
        {
            _services.UpdateEntities(id,TEntities);
        }
    }
}
