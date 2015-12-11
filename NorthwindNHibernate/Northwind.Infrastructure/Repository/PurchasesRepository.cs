using Northwind.Core;
using Northwind.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.Core.Domain.Purchases;

namespace Northwind.Infrastructure.Repository
{
    public class PurchasesRepository : IPurchasesRepository
    {
        private IUnitOfWork unitOfWork;
        public PurchasesRepository(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public IList<Purchases> FindAll()
        {
            throw new NotImplementedException();
        }

        public Purchases FindByID(long id)
        {
            throw new NotImplementedException();
        }

        public void Remove(long id)
        {
            throw new NotImplementedException();
        }

        public Purchases Save(Purchases entity)
        {
            throw new NotImplementedException();
        }
    }
}
