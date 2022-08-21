using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSS.Entities.Concretes;
namespace TSS.BusinessLayer.Concretes
{
    public class ComputerUnitDAL : Abstracts.IEntityDAL<Computer_Unit>
    {
        DataLayer.Abstracts.IComputerUnitServices _services = null;
        public ComputerUnitDAL(DataLayer.Abstracts.IComputerUnitServices services)
        {
            _services = services;
        }

        public void AddEntities(Computer_Unit Tentities)
        {
            _services.AddEntities(Tentities);
        }

        public void DeleteEntities(int id)
        {
            _services.DeleteEntities(id);
        }

        public List<Computer_Unit> getAllEntities()
        {
            return _services.GetAllEntities();
        }

        public List<Computer_Unit> GetAllEntitiesByFiltered(Predicate<Computer_Unit> pre)
        {
            return _services.GetAllEntities().FindAll(pre);
        }

        public Computer_Unit GetEntitieByFiltered(Predicate<Computer_Unit> pre)
        {
            return _services.GetAllEntities().Find(pre);
        }

        public void UpdateEntities(int id, Computer_Unit TEntities)
        {
            _services.UpdateEntities(id,TEntities);
        }
    }
}
