using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSS.Entities.Concretes;

namespace TSS.DataLayer.Abstracts
{
    public interface IHardwareServices : IEntityRepository<TSS.Entities.Concretes.Hardwares>
    {
        Hardwares GetLastAddedHardware();
    }
}
