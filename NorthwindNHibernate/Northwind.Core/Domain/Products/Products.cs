using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Core.Domain.Products
{
    public class Products : AbstractDomain<long>
    {
        public Products()
        {

        }
        public virtual string ProductCode { get; set; }
        public virtual string ProductName { get; set; }
        public virtual Categories.Categories Category { get; set; }
        public virtual Suppliers.Suppliers Supplier { get; set; }
        public virtual int? RecorderLevel { get; set; }
        public virtual decimal? UnitPrice { get; set; }
       
        public virtual int? UnitOnOrder { get; set; }
        public virtual int? UnitInStock { get; set; }
        public virtual bool? Discontinued { get; set; }


    }
}
