using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSS.DataLayer.Abstracts
{
    public interface ITroublePriceServices : IEntityRepository<TSS.Entities.Concretes.Troubles_Price>
    {
        DataTable JoinTroubleProductTable(int troubleID);
    }
}
