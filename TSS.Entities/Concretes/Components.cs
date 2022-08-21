using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSS.Entities.Concretes
{
    public class Components : TSS.Entities.Abstracts.IEntity
    {
        public int ID { get; set; }
        public int CID { get; set; }
        public string CompName { get; set; }
        public string CompDesc { get; set; }
        public int CompTypeID { get; set; }
        public string CompTypeName { get; set; }
        public string CompTypeExpl { get; set; }
    }
}
