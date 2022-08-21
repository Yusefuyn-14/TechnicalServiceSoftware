using TSS.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSS.Entities.Concretes
{
    public class Troubles_Status : TSS.Entities.Abstracts.IEntity
    {
        public int ID { get; set; }
        public string StatusComment { get; set; }
        public int Statu { get; set; }
    }
}
