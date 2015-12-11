using Northwind.Core;
using Northwind.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.Core.Domain.Orders;

namespace Northwind.Infrastructure.Repository
{
    public class OrdersRepository : IOrdersRepository
    {
        private IUnitOfWork unitOfWork;
        public OrdersRepository(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public IList<Orders> FindAll()
        {
            throw new NotImplementedException();
        }

        public Orders FindByID(long id)
        {
            throw new NotImplementedException();
        }

        public void Remove(long id)
        {
            throw new NotImplementedException();
        }

        public Orders Save(Orders entity)
        {
            throw new NotImplementedException();
        }
    }
}
