﻿using Northwind.Core.Domain.Shippers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Core.Repository
{
    public interface IShippersRepository : Repository<Shippers,long>
    {
    }
}
