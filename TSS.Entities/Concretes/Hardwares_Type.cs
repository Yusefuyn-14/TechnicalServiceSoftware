using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSS.Entities.Concretes
{
    public class Hardwares_Type : TSS.Entities.Abstracts.IEntity
    {
        public int ID { get; set; }
        public int HTID { get; set; }
        public string HardwaresTypeName { get; set; }
    }
}
