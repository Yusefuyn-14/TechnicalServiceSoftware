using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TSS.Entities.Concretes;

namespace TSS.BusinessLayer.Concretes
{
    public class ComponentDAL : Abstracts.IEntityDAL<Components>
    {
        DataLayer.Abstracts.IComponentServices _services = null;

        public ComponentDAL(DataLayer.Abstracts.IComponentServices services)
        {
            _services = services;
        }

        public void AddEntities(Components Tentities)
        {
            _services.AddEntities(Tentities);
        }

        public void DeleteEntities(int id)
        {
            _services.DeleteEntities(id);
        }

        public List<Components> getAllEntities()
        {
           return _services.GetAllEntities();
        }

        public List<Components> GetAllEntitiesByFiltered(Predicate<Components> pre)
        {
            return _services.GetAllEntities().FindAll(pre);
        }

        public Components GetEntitieByFiltered(Predicate<Components> pre)
        {
            return _services.GetAllEntities().Find(pre);
        }

        public void UpdateEntities(int id, Components TEntities)
        {
            _services.UpdateEntities(id,TEntities);
        }
    }
}
