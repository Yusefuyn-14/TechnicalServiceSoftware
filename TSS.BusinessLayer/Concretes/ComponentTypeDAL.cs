using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSS.Entities.Concretes;

namespace TSS.BusinessLayer.Concretes
{
    public class ComponentTypeDAL : Abstracts.IEntityDAL<Components_Type>
    {
        DataLayer.Abstracts.IComponentTypeServices _services = null;
        public ComponentTypeDAL(DataLayer.Abstracts.IComponentTypeServices services)
        {
            _services = services;
        }

        public void AddEntities(Components_Type Tentities)
        {
            _services.AddEntities(Tentities);
        }

        public void DeleteEntities(int id)
        {
            _services.DeleteEntities(id);
        }

        public List<Components_Type> getAllEntities()
        {
            return _services.GetAllEntities();
        }

        public List<Components_Type> GetAllEntitiesByFiltered(Predicate<Components_Type> pre)
        {
            return _services.GetAllEntities().FindAll(pre);
        }

        public Components_Type GetEntitieByFiltered(Predicate<Components_Type> pre)
        {
            return _services.GetAllEntities().Find(pre);
        }

        public void UpdateEntities(int id, Components_Type TEntities)
        {
            _services.UpdateEntities(id,TEntities);
        }
    }
}
