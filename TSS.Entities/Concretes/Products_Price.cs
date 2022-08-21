using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSS.Entities.Concretes
{
    public class Products_Price : TSS.Entities.Abstracts.IEntity
    {
        public int ID { get; set; }
        public Products ProductID { get; set; }
        public Currency CurrencyID { get; set; }
        public int PurchasePrice { get; set; }
        public int SalePrice { get; set; }

    }
}
