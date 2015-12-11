using Northwind.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.Core.Domain.Products;
using Northwind.Core;

namespace Northwind.Infrastructure.Repository
{
    public class ProductsRepository : IProductsRepository
    {
        private IUnitOfWork unitOfWork;
        
        public ProductsRepository(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public IList<Products> FindAll()
        {
            throw new NotImplementedException();
        }

        public Products FindByID(long id)
        {
            throw new NotImplementedException();
        }

        public void Remove(long id)
        {
            throw new NotImplementedException();
        }

        public Products Save(Products entity)
        {
            throw new NotImplementedException();
        }
    }
}
