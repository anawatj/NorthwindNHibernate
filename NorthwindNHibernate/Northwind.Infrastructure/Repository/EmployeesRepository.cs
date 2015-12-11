using Northwind.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.Core.Domain.Employees;
using Northwind.Core;

namespace Northwind.Infrastructure.Repository
{
    public class EmployeesRepository : IEmployeesRepository
    {
        private IUnitOfWork unitOfWork;
        public EmployeesRepository(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public IList<Employees> FindAll()
        {
            throw new NotImplementedException();
        }

        public Employees FindByID(long id)
        {
            throw new NotImplementedException();
        }

        public void Remove(long id)
        {
            throw new NotImplementedException();
        }

        public Employees Save(Employees entity)
        {
            throw new NotImplementedException();
        }
    }
}
