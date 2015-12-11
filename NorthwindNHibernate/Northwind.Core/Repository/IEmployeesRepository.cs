using Northwind.Core.Domain.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Core.Repository
{
    public interface IEmployeesRepository : Repository<Employees,long>
    {

    }
}
