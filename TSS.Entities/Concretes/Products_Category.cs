using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSS.Entities.Concretes
{
   public class Products_Category : TSS.Entities.Abstracts.IEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Tax { get; set; }
    }
}
