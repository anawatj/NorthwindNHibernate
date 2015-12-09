using Northwind.Core.Domain.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Core.Repository
{
    public interface ICategoriesRepository : Repository<Categories,long>
    {
        Dictionary<string, object> FindByQuery(CategoriesQuery query);

    }
}
