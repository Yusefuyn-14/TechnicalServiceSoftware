using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSS.DataLayer.Abstracts
{
    public interface IProductServices : IEntityRepository<TSS.Entities.Concretes.Products>
    {
        List<TSS.Entities.Concretes.Products> notSaleProduct();
    }
}
