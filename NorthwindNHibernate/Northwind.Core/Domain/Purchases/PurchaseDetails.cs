using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Core.Domain.Purchases
{
    public class PurchaseDetails : AbstractDomain<long>
    {
        public PurchaseDetails()
        {

        }
        public virtual long? PurchaseID { get; set; }
        public virtual Products.Products Product { get; set; }
        public virtual int? Quantity { get; set; }
        public virtual decimal? UnitPrice { get; set; }
        public virtual float? Discount { get; set; }

    }
}
