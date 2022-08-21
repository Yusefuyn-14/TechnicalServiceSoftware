using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSS.Entities.Concretes;

namespace TSS.BusinessLayer.Concretes
{
    public class CustomerDAL : Abstracts.IEntityDAL<Customers>
    {
        DataLayer.Abstracts.ICustomerServices _services = null;
        public CustomerDAL(DataLayer.Abstracts.ICustomerServices services)
        {
            _services = services;
        }

        public void AddEntities(Customers Tentities)
        {
            _services.AddEntities(Tentities);
        }

        public void DeleteEntities(int id)
        {
            _services.DeleteEntities(id);
        }

        public List<Customers> getAllEntities()
        {
            return _services.GetAllEntities();
        }

        public List<Customers> GetAllEntitiesByFiltered(Predicate<Customers> pre)
        {
            return _services.GetAllEntities().FindAll(pre);
        }

        public Customers GetEntitieByFiltered(Predicate<Customers> pre)
        {
            return _services.GetAllEntities().Find(pre);
        }

        public void UpdateEntities(int id, Customers Tentities)
        {
            _services.UpdateEntities(id, Tentities);
        }
    }
}
