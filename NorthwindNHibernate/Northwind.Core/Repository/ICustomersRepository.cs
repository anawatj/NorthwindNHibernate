using Northwind.Core.Domain.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Core.Repository
{
    public interface ICustomersRepository : Repository<Customers,long>
    {
        Dictionary<string, object> FindByQuery(CustomersQuery query);
    }
}
