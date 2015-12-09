using Northwind.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.Core.Domain.Categories;
using Northwind.Core;

namespace Northwind.Infrastructure.Repository
{
    public class CategoriesRepository : ICategoriesRepository
    {
        private IUnitOfWork unitOfWork;
        public CategoriesRepository(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public IList<Categories> FindAll()
        {
            var criteria =  this.unitOfWork.CurrentSession.CreateCriteria<Categories>();
            return criteria.List<Categories>();
        }

        public Categories FindByID(long id)
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, object> FindByQuery(CategoriesQuery query)
        {
            throw new NotImplementedException();
        }

        public void Remove(long id)
        {
            throw new NotImplementedException();
        }

        public Categories Save(Categories entity)
        {
            throw new NotImplementedException();
        }
    }
}
