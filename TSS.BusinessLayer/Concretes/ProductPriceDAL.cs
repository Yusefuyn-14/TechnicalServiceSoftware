using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSS.Entities.Concretes;

namespace TSS.BusinessLayer.Concretes
{
    public class ProductPriceDAL : Abstracts.IEntityDAL<Products_Price>
    {

        TSS.DataLayer.Abstracts.IProductPriceService _services = null;
        public ProductPriceDAL(TSS.DataLayer.Abstracts.IProductPriceService services)
        {
            _services = services;
        }

        public void AddEntities(Products_Price Tentities)
        {
            _services.AddEntities(Tentities);
        }

        public void DeleteEntities(int id)
        {
            _services.DeleteEntities(id);

        }

        public List<Products_Price> getAllEntities()
        {
            return _services.GetAllEntities();
        }

        public List<Products_Price> GetAllEntitiesByFiltered(Predicate<Products_Price> pre)
        {
            return _services.GetAllEntities().FindAll(pre);
        }

        public Products_Price GetEntitieByFiltered(Predicate<Products_Price> pre)
        {
            return _services.GetAllEntities().Find(pre);
        }

        public void UpdateEntities(int id, Products_Price TEntities)
        {
            _services.UpdateEntities(id, TEntities);
        }

    }
}
