using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Core.Repository
{
    public interface Repository<E,K>
    {
        IList<E> FindAll();

        E FindByID(K id);

        E Save(E entity);

        void Remove(K id);
    }
}
