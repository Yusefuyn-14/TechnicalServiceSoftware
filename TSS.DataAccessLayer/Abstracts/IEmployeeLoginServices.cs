﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSS.DataLayer.Abstracts
{
    public interface IEmployeeLoginServices : IEntityRepository<TSS.Entities.Concretes.Employees_Account>
    {
    }
}
