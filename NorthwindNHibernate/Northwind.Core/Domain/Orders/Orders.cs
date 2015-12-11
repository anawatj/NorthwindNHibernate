using Northwind.Core.Domain.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Core.Domain.Orders
{
    public class Orders : AbstractDomain<long>
    {
        public Orders()
        {
            this.Details = new HashSet<OrderDetails>();
        }
        public virtual string OrderCode { get; set; }
        public virtual Employees.Employees Employee { get; set; }
        public virtual Customers.Customers Customer { get; set; }
        
        public virtual DateTime? OrderDate { get; set; }
        public virtual DateTime? RequireDate { get; set; }
        public virtual DateTime? ShippedDate { get; set; }
        public virtual decimal? Freight { get; set; }
        public virtual Shippers.Shippers ShipVia { get; set; }
        public virtual string ShipName { get; set; }
        public virtual string ShipAddress { get; set; }
        public virtual City ShipCity { get; set; }
        public virtual Region ShipRegion { get; set; }
        public virtual string PostalCode { get; set; }
        public virtual Country ShipCountry { get; set; }

        public virtual ISet<OrderDetails> Details { get; set; }
        
    }
}
