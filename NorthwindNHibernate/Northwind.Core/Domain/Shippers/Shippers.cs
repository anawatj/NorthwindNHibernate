using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Core.Domain.Shippers
{
    public class Shippers : AbstractDomain<long>
    {
        public Shippers()
        {

        }
        public virtual string CompanyName { get; set; }
        public virtual string Phone { get; set; }
    }
}
