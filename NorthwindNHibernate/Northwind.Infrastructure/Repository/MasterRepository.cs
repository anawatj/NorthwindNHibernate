using NHibernate;
using NHibernate.Criterion;
using Northwind.Core;
using Northwind.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Infrastructure.Repository
{
    public class MasterRepository
    {
        private IUnitOfWork unitOfWork;
        public MasterRepository(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public IList<T> FindAll<T>() where T :SimpleMasterObject
        {
            ICriteria criteria = unitOfWork.CurrentSession.CreateCriteria<T>();
            var list = criteria.List<T>();
            return list;


        }
        public IList<T> FindAll<T>(string field,object value) where T : SimpleMasterObject
        {
            ICriteria criteria = unitOfWork.CurrentSession.CreateCriteria<T>();
            criteria.Add(Restrictions.Eq(field, value));
            var list = criteria.List<T>();
            return list;

        }
    }
}
