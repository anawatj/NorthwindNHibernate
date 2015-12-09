using Northwind.Core.Domain.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Core.Domain.Customers
{
    public class Customers : AbstractDomain<long>
    {
        public Customers()
        {
            this.Demos = new HashSet<DemoGraphics>();
        }
        public virtual string CustomerCode { get; set; }
        public virtual string CompanyName { get; set; }
        public virtual string ContactName { get; set; }
        public virtual string ContactTitle { get; set; }
        public virtual string Address { get; set; }
        public virtual Country Country { get; set; }
        public virtual City City { get; set; }
        
        public virtual Region Region { get; set; }

        public virtual string PostalCode { get; set; }
        public virtual string Phone { get; set; }
        public virtual string Fax { get; set; }

        public virtual ISet<DemoGraphics> Demos { get; set; }


    }
}
