using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSS.Entities.Concretes;

namespace TSS.BusinessLayer.Concretes
{
    public class EmployeeLoginDAL : Abstracts.IEntityDAL<Employees_Account>
    {
        TSS.DataLayer.Abstracts.IEmployeeLoginServices _services = null;
        public EmployeeLoginDAL(TSS.DataLayer.Abstracts.IEmployeeLoginServices services)
        {
            _services = services;
        }

        public void AddEntities(Employees_Account Tentities)
        {
            _services.AddEntities(Tentities);
        }

        public void DeleteEntities(int id)
        {
            _services.DeleteEntities(id);
        }

        public List<Employees_Account> getAllEntities()
        {
            return _services.GetAllEntities();
        }

        public List<Employees_Account> GetAllEntitiesByFiltered(Predicate<Employees_Account> pre)
        {
            return _services.GetAllEntities().FindAll(pre);
        }

        public Employees_Account GetEntitieByFiltered(Predicate<Employees_Account> pre)
        {
            return _services.GetAllEntities().Find(pre);
        }

        public void UpdateEntities(int id, Employees_Account TEntities)
        {
            _services.UpdateEntities(id,TEntities);
        }
    }
}
