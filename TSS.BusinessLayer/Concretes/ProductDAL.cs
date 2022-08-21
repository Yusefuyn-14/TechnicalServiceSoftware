using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSS.Entities.Concretes;

namespace TSS.BusinessLayer.Concretes
{
    public class ProductDAL : Abstracts.IEntityDAL<Products>
    {
        TSS.DataLayer.Abstracts.IProductServices _services = null;
        public ProductDAL(TSS.DataLayer.Abstracts.IProductServices services)
        {
            _services = services;
        }

        public void AddEntities(Products Tentities)
        {
            _services.AddEntities(Tentities);
        }

        public void DeleteEntities(int id)
        {
            _services.DeleteEntities(id);
        }

        public List<Products> getAllEntities()
        {
            return _services.GetAllEntities();
        }

        public List<Products> GetAllEntitiesByFiltered(Predicate<Products> pre)
        {
            return _services.GetAllEntities().FindAll(pre);
        }

        public Products GetEntitieByFiltered(Predicate<Products> pre)
        {
            return _services.GetAllEntities().Find(pre);
        }

        public void UpdateEntities(int id, Products TEntities)
        {
            _services.UpdateEntities(id,TEntities);
        }

        public List<Products> NotSaleProduct() {
           return _services.notSaleProduct();
        }
    }
}
