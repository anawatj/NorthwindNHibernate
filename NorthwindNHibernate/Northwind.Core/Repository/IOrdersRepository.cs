using Northwind.Core.Domain.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Core.Repository
{
    public interface IOrdersRepository : Repository<Orders,long>
    {
    }
}
