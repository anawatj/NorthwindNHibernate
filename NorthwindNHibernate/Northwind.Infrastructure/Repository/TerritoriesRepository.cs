using Northwind.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.Core.Domain.Territories;
using Northwind.Core;

namespace Northwind.Infrastructure.Repository
{
    public class TerritoriesRepository : ITerritoriesRepository
    {
        private IUnitOfWork unitOfWork;
        public TerritoriesRepository(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;

        }
        public IList<Territories> FindAll()
        {
            throw new NotImplementedException();
        }

        public Territories FindByID(long id)
        {
            throw new NotImplementedException();
        }

        public void Remove(long id)
        {
            throw new NotImplementedException();
        }

        public Territories Save(Territories entity)
        {
            throw new NotImplementedException();
        }
    }
}
