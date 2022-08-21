using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSS.BusinessLayer.Abstracts
{
    interface IEntityDAL<T> where T:class,new()
    {
        List<T> getAllEntities();
        List<T> GetAllEntitiesByFiltered(Predicate<T> pre);
        T GetEntitieByFiltered(Predicate<T> pre);
        void DeleteEntities(int id);
        void UpdateEntities(int id, T Tentities);
        void AddEntities(T Tentities);
    }
}
