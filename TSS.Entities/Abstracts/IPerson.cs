using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSS.Entities.Abstracts
{
    interface IPerson : TSS.Entities.Abstracts.IEntity
    {
        string Name { get; set; }
    }
}
