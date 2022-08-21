using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSS.Entities.Concretes;
namespace TSS.BusinessLayer.Concretes
{
    public class HardwareSizeDAL : Abstracts.IEntityDAL<Hardwares_Size>
    {
        TSS.DataLayer.Abstracts.IHardwareSizeServices _services = null;
        public HardwareSizeDAL(TSS.DataLayer.Abstracts.IHardwareSizeServices services)
        {
            _services = services;
        }

        public void AddEntities(Hardwares_Size Tentities)
        {
            _services.AddEntities(Tentities);
        }

        public void DeleteEntities(int id)
        {
            _services.DeleteEntities(id);
        }

        public List<Hardwares_Size> getAllEntities()
        {
            return _services.GetAllEntities();
        }

        public List<Hardwares_Size> GetAllEntitiesByFiltered(Predicate<Hardwares_Size> pre)
        {
            return _services.GetAllEntities().FindAll(pre);
        }

        public Hardwares_Size GetEntitieByFiltered(Predicate<Hardwares_Size> pre)
        {
            return _services.GetAllEntities().Find(pre);
        }

        public void UpdateEntities(int id, Hardwares_Size TEntities)
        {
            _services.UpdateEntities(id,TEntities);
        }
    }
}
