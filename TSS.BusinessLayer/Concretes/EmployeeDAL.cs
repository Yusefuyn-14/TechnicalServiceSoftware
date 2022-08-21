using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSS.Entities.Concretes;

namespace TSS.BusinessLayer.Concretes
{
    public class EmployeeDAL : Abstracts.IEntityDAL<Employees>
    {
        DataLayer.Abstracts.IEmployeeServices _services = null;
        public EmployeeDAL(DataLayer.Abstracts.IEmployeeServices services)
        {
            _services = services;
        }

        public void AddEntities(Employees Tentities)
        {
            _services.AddEntities(Tentities);
        }

        public void DeleteEntities(int id)
        {
            _services.DeleteEntities(id);
        }

        public List<Employees> getAllEntities()
        {
            return _services.GetAllEntities();
        }

        public List<Employees> GetAllEntitiesByFiltered(Predicate<Employees> pre)
        {
            return _services.GetAllEntities().FindAll(pre);
        }

        public Employees GetEntitieByFiltered(Predicate<Employees> pre)
        {
            return _services.GetAllEntities().Find(pre);
        }

        public void UpdateEntities(int id, Employees TEntities)
        {
            _services.UpdateEntities(id,TEntities);
        }
    }
}
