using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSS.DataLayer.Abstracts
{
    public interface IDataBaseObj
    {
        DbConnection Connection { get; set; }
        DbCommand Command { get; set; }
        DbDataAdapter Adaptor { get; set; }
    }
}
