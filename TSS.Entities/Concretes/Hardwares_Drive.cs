using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSS.Entities.Concretes
{
    public class Hardwares_Drive: TSS.Entities.Abstracts.IEntity
    {
        public int ID { get; set; }
        public Hardwares Hardware { get; set; }
        public string Drive { get; set; }
        public string Description { get; set; }

    }
}
