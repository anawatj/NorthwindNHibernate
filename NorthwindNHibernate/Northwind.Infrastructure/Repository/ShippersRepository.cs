using Northwind.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.Core.Domain.Shippers;
using Northwind.Core;

namespace Northwind.Infrastructure.Repository
{
    public class ShippersRepository : IShippersRepository
    {
        private IUnitOfWork unitOfWork;
        
        public ShippersRepository(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public IList<Shippers> FindAll()
        {
            throw new NotImplementedException();
        }

        public Shippers FindByID(long id)
        {
            throw new NotImplementedException();
        }

        public void Remove(long id)
        {
            throw new NotImplementedException();
        }

        public Shippers Save(Shippers entity)
        {
            throw new NotImplementedException();
        }
    }
}
