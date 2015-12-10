using Northwind.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.Core.Domain.Categories;
using Northwind.Core;
using NHibernate.Criterion;

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
            var criteria = this.unitOfWork.CurrentSession.CreateCriteria<Categories>();
            criteria.Add(Restrictions.Eq("ID", id));
            Categories result = criteria.UniqueResult<Categories>();
            return result;
        }

        public Dictionary<string, object> FindByQuery(CategoriesQuery query)
        {
            var criteria = this.unitOfWork.CurrentSession.CreateCriteria<Categories>();
            if(!string.IsNullOrEmpty(query.CategoryCode))
            {
                if(query.CategoryCode.Contains("*") || query.CategoryCode.Contains("?"))
                {
                    criteria.Add(Restrictions.Like("CategoryCode", query.CategoryCode.Replace("*", "%").Replace("?", "_")));
                }
                else
                {
                    criteria.Add(Restrictions.Eq("CategoryCode", query.CategoryCode));
                }
            }
            if(!string.IsNullOrEmpty(query.CategoryName))
            {
                if(query.CategoryName.Contains("*") || query.CategoryName.Contains("?"))
                {
                    criteria.Add(Restrictions.Like("CategoryName", query.CategoryName.Replace("*", "%").Replace("?", "_")));
                }
                else
                {
                    criteria.Add(Restrictions.Eq("CategoryName", query.CategoryName));
                }
            }
            return null;
        }

        public void Remove(long id)
        {
            Categories data = FindByID(id);
            unitOfWork.CurrentSession.Delete(data);
        }

        public Categories Save(Categories entity)
        {
            Categories data = FindByID(entity.ID);
            Categories result = unitOfWork.CurrentSession.Merge(entity);
            return result;
        }
    }
}
