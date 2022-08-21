using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSS.Entities.Concretes;

namespace TSS.BusinessLayer.Concretes
{
    public class MacListDAL : Abstracts.IEntityDAL<Mac_Address>
    {
        TSS.DataLayer.Abstracts.IMacAddressServices _services = null;
        public MacListDAL(TSS.DataLayer.Abstracts.IMacAddressServices services)
        {
            _services = services;
        }

        public void AddEntities(Mac_Address Tentities)
        {
            _services.AddEntities(Tentities);
        }

        public void DeleteEntities(int id)
        {
            _services.DeleteEntities(id);
        }

        public List<Mac_Address> getAllEntities()
        {
            return _services.GetAllEntities();
        }

        public List<Mac_Address> GetAllEntitiesByFiltered(Predicate<Mac_Address> pre)
        {
            return _services.GetAllEntities().FindAll(pre);
        }

        public Mac_Address GetEntitieByFiltered(Predicate<Mac_Address> pre)
        {
            return _services.GetAllEntities().Find(pre);
        }

        public void UpdateEntities(int id, Mac_Address TEntities)
        {
            _services.UpdateEntities(id,TEntities);
        }
    }
}
