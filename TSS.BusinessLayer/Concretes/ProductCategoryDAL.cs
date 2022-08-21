using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSS.Entities.Concretes;

namespace TSS.BusinessLayer.Concretes
{
    public class ProductCategoryDAL : Abstracts.IEntityDAL<Products_Category>
    {
        TSS.DataLayer.Abstracts.IProductCategoryServices _services = null;
        public ProductCategoryDAL(TSS.DataLayer.Abstracts.IProductCategoryServices services)
        {
            _services = services;
        }

        public void AddEntities(Products_Category Tentities)
        {
            _services.AddEntities(Tentities);
        }

        public void DeleteEntities(int id)
        {
            _services.DeleteEntities(id);
        }

        public List<Products_Category> getAllEntities()
        {
            return _services.GetAllEntities();
        }

        public List<Products_Category> GetAllEntitiesByFiltered(Predicate<Products_Category> pre)
        {
            return _services.GetAllEntities().FindAll(pre);
        }

        public Products_Category GetEntitieByFiltered(Predicate<Products_Category> pre)
        {
            return _services.GetAllEntities().Find(pre);
        }

        public void UpdateEntities(int id, Products_Category TEntities)
        {
            _services.UpdateEntities(id,TEntities);
        }
    }
}
