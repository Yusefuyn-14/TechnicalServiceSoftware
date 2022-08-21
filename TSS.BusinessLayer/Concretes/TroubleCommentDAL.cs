using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSS.Entities.Concretes;

namespace TSS.BusinessLayer.Concretes
{
    public class TroubleCommentDAL : Abstracts.IEntityDAL<Troubles_Comment>
    {
        TSS.DataLayer.Abstracts.ITroubleCommentServices _services = null;
        public TroubleCommentDAL(TSS.DataLayer.Abstracts.ITroubleCommentServices services)
        {
            _services = services;
        }

        public void AddEntities(Troubles_Comment Tentities)
        {
            _services.AddEntities(Tentities);
        }

        public void DeleteEntities(int id)
        {
            _services.DeleteEntities(id);
        }

        public List<Troubles_Comment> getAllEntities()
        {
            return _services.GetAllEntities();
        }

        public List<Troubles_Comment> GetAllEntitiesByFiltered(Predicate<Troubles_Comment> pre)
        {
            return _services.GetAllEntities().FindAll(pre);
        }

        public Troubles_Comment GetEntitieByFiltered(Predicate<Troubles_Comment> pre)
        {
            return _services.GetAllEntities().Find(pre);
        }

        public void UpdateEntities(int id, Troubles_Comment TEntities)
        {
            _services.UpdateEntities(id,TEntities);
        }
    }
}
