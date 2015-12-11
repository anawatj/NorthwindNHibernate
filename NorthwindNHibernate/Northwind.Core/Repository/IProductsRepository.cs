using Northwind.Core.Domain.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Core.Repository
{
    public interface IProductsRepository : Repository<Products,long>
    {

    }
}
