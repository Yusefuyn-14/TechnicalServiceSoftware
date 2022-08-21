using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSS.Entities.Concretes
{
    class Solutions
    {
        public int ID { get; set; }
        public Customers CustomerID { get; set; }
        public string Description { get; set; }
        public string Resolution { get; set; }

    }
}
