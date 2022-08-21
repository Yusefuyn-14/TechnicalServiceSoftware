using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSS.Entities.Concretes
{
    public class Currency : TSS.Entities.Abstracts.IEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public string GetLink { get; set; }
    }
}
