using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSS.Entities.Concretes
{
    public class Hardwares_Component : TSS.Entities.Abstracts.IEntity
    {
        public int ID { get; set; }
        public int HardwaresID { get; set; }
        public int ComponentID { get; set; }
        public string Description { get; set; }
    }
}
