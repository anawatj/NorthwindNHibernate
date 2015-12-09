using Northwind.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;

namespace Northwind.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ISessionFactory _sessionFactory;
        private ISession session;
        public UnitOfWork()
        {
            _sessionFactory = NHibernateUtils.GetFactory();
           // CurrentSession = _sessionFactory.OpenSession();

        }
        public ISession CurrentSession
        {
            get
            {
               // session = _sessionFactory.GetCurrentSession();
                if(session == null)
                {
                    session = _sessionFactory.OpenSession();
                }
                return session;
            }
            set
            {
                this.session = value;
            }
        }


        public void Dispose()
        {
            CurrentSession.Close();
            CurrentSession = null;
        }

    }
}
