using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TSS.Entities.Concretes;

namespace TSS.BusinessLayer.Concretes
{
    public class TroublePriceDAL : Abstracts.IEntityDAL<Troubles_Price>
    {
        TSS.DataLayer.Abstracts.ITroublePriceServices _services = null;
        public TroublePriceDAL(TSS.DataLayer.Abstracts.ITroublePriceServices services)
        {
            _services = services;
        }

        public void AddEntities(Troubles_Price Tentities)
        {
            _services.AddEntities(Tentities);
        }

        public void DeleteEntities(int id)
        {
            _services.DeleteEntities(id);
        }

        public List<Troubles_Price> getAllEntities()
        {
            return _services.GetAllEntities();
        }

        public List<Troubles_Price> GetAllEntitiesByFiltered(Predicate<Troubles_Price> pre)
        {
            return _services.GetAllEntities().FindAll(pre);
        }

        public Troubles_Price GetEntitieByFiltered(Predicate<Troubles_Price> pre)
        {
            return _services.GetAllEntities().Find(pre);
        }

        public void UpdateEntities(int id, Troubles_Price TEntities)
        {
            _services.UpdateEntities(id,TEntities);
        }

        public DataTable JoinTroubleProductTable(int troubleID) {
            return _services.JoinTroubleProductTable(troubleID);
        }
    }
}
