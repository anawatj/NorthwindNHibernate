using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Core.Domain.Customers
{
    public class CustomersQuery : AbstractQuery
    {
        public virtual string CustomerCode { get; set; }
        public virtual string CompanyName { get; set; }
        public virtual string ContactName { get; set; }
        public virtual string ContactTitle { get; set; }
        public virtual long? City { get; set; }
        public virtual long? Country { get; set; }
        public virtual long? Region { get; set; }

    }
}
