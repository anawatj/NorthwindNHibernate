using Northwind.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.Core.Domain.Customers;
using NHibernate;
using Northwind.Core;
using NHibernate.Criterion;

namespace Northwind.Infrastructure.Repository
{
    public class CustomersRepository : ICustomersRepository
    {
        private IUnitOfWork unitOfWork;
        public CustomersRepository(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public IList<Customers> FindAll()
        {
            ICriteria criteria = this.unitOfWork.CurrentSession.CreateCriteria<Customers>();
            IList<Customers> list = criteria.List<Customers>();
            return list;
        }

        public Customers FindByID(long id)
        {
            ICriteria criteria = this.unitOfWork.CurrentSession.CreateCriteria<Customers>();
            criteria.Add(Restrictions.Eq("ID", id));
            criteria.SetFetchMode("Country", FetchMode.Join);
            criteria.SetFetchMode("City", FetchMode.Join);
            criteria.SetFetchMode("Region", FetchMode.Join);
            criteria.SetFetchMode("Demos", FetchMode.Join);
            Customers result = criteria.UniqueResult<Customers>();
            return result;
        }

        public Dictionary<string, object> FindByQuery(CustomersQuery query)
        {
            ICriteria criteria = this.unitOfWork.CurrentSession.CreateCriteria<Customers>();
            if(!string.IsNullOrEmpty(query.CustomerCode))
            {
                if(query.CustomerCode.Contains("*") || query.CustomerCode.Contains("?"))
                {
                    criteria.Add(Restrictions.Like("CustomerCode", query.CustomerCode.Replace("*", "%").Replace("?", "_")));
                }
                else
                {
                    criteria.Add(Restrictions.Eq("CustomerCode", query.CustomerCode));
                }
            }
            if(!string.IsNullOrEmpty(query.CompanyName))
            {
                if(query.CompanyName.Contains("*") || query.CompanyName.Contains("?"))
                {
                    criteria.Add(Restrictions.Like("CompanyName", query.CompanyName.Replace("*", "%").Replace("?", "_")));
                }
                else
                {
                    criteria.Add(Restrictions.Eq("CompanyName", query.CompanyName));
                }
            }
            if(!string.IsNullOrEmpty(query.ContactName))
            {
                if(query.ContactName.Contains("*") || query.ContactName.Contains("?"))
                {
                    criteria.Add(Restrictions.Like("ContactName", query.ContactName.Replace("*", "%").Replace("?", "_")));

                }
                else
                {
                    criteria.Add(Restrictions.Eq("ContactName", query.ContactName));
                }
            }

            criteria.SetFetchMode("Country", FetchMode.Join);
            criteria.SetFetchMode("City", FetchMode.Join);
            criteria.SetFetchMode("Region", FetchMode.Join);

            return null;
        }

        public void Remove(long id)
        {
            Customers data = FindByID(id);
            unitOfWork.CurrentSession.Delete(data);
        }

        public Customers Save(Customers entity)
        {
            Customers data = FindByID(entity.ID);
            Customers result = unitOfWork.CurrentSession.Merge(entity);
            return result;
        }
    }
}
