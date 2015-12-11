using Northwind.Core.Domain.Territories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Core.Repository
{
    public interface ITerritoriesRepository : Repository<Territories,long>
    {
    }
}
