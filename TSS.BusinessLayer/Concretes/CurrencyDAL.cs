using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSS.Entities.Concretes;


namespace TSS.BusinessLayer.Concretes
{
    public class CurrencyDAL : Abstracts.IEntityDAL<Currency>
    {
        DataLayer.Abstracts.ICurrencyServices _services = null;
        public CurrencyDAL(DataLayer.Abstracts.ICurrencyServices services)
        {
            _services = services;
        }

        public void AddEntities(Currency Tentities)
        {
            _services.AddEntities(Tentities);
        }

        public void DeleteEntities(int id)
        {
            _services.DeleteEntities(id);
        }

        public List<Currency> getAllEntities()
        {
            return _services.GetAllEntities();
        }

        public List<Currency> GetAllEntitiesByFiltered(Predicate<Currency> pre)
        {
            return _services.GetAllEntities().FindAll(pre);
        }

        public Currency GetEntitieByFiltered(Predicate<Currency> pre)
        {
            return _services.GetAllEntities().Find(pre);
        }
        public void UpdateEntities(int id, Currency TEntities)
        {
            _services.UpdateEntities(id,TEntities);
        }
    }
}
