using Northwind.Core;
using Northwind.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.Core.Domain.Suppliers;

namespace Northwind.Infrastructure.Repository
{
    public class SuppliersRepository : ISuppliersRepository
    {
        private IUnitOfWork unitOfWork;
        public SuppliersRepository(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public IList<Suppliers> FindAll()
        {
            throw new NotImplementedException();
        }

        public Suppliers FindByID(long id)
        {
            throw new NotImplementedException();
        }

        public void Remove(long id)
        {
            throw new NotImplementedException();
        }

        public Suppliers Save(Suppliers entity)
        {
            throw new NotImplementedException();
        }
    }
}
