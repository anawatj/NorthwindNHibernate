using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Core.Domain.Purchases
{
    public class Purchases :AbstractDomain<long>
    {
        public Purchases()
        {
            this.Details = new HashSet<PurchaseDetails>();
        }
        public virtual string PurchaseCode { get; set; }
        public virtual Suppliers.Suppliers Supplier { get; set; }
        public virtual Employees.Employees Employee { get; set; }
        public virtual DateTime? PurchaseDate { get; set; }
        public virtual DateTime? RequireDate { get; set; }
        public virtual DateTime? ShippedDate { get; set; }
        public virtual Shippers.Shippers Shipper { get; set; }
        public virtual decimal? Freight { get; set; }
        public virtual ISet<PurchaseDetails> Details { get; set; }
        
    }
}
