using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TSS.DataLayer.Abstracts
{
    public interface IEntityRepository<T> where T : class,TSS.Entities.Abstracts.IEntity,new()
    {
        List<T> GetAllEntities();
        void DeleteEntities(int id);
        void UpdateEntities(int id, T Tentities);
        void AddEntities(T Tentities);
    }
}
