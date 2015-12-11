using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Infrastructure.Mapping.Products
{
    public class ProductsMap : ClassMap<Core.Domain.Products.Products>
    {
        public ProductsMap()
        {
            Table("Products");
            Id(t => t.ID).GeneratedBy.Native();
            Version(t => t.Version).Column("Version");
            Map(t => t.ProductCode).Length(20);
            Map(t => t.ProductName).Length(200);
            References(t => t.Supplier).Column("SupplierID").LazyLoad();
            References(t => t.Category).Column("CategoryID").LazyLoad();
            Map(t => t.RecorderLevel);
            Map(t => t.UnitInStock);
            Map(t => t.UnitOnOrder);
            Map(t => t.UnitPrice);
            Map(t => t.Discontinued);
            Map(t => t.CreateBy).Length(20);
            Map(t => t.CreateDate);
            Map(t => t.UpdateBy).Length(20);
            Map(t => t.UpdateDate);
        }
    }
}
