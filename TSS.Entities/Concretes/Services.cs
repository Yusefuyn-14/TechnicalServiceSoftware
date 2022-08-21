using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSS.Entities.Concretes
{
    class Services
    {
        public int ID { get; set; }
        public Customers CustomerID { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public Services_Type ServiceTypeID { get; set; }
        public Services_Status ServicesStatusID { get; set; }
        public string Date { get; set; }
    }
}
