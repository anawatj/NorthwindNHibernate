using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Infrastructure.Mapping.Purchases
{
    public class PurchasesMap : ClassMap<Core.Domain.Purchases.Purchases>
    {
        public PurchasesMap()
        {
            Table("Purchases");
            Id(t => t.ID).GeneratedBy.Native();
            Version(t => t.Version).Column("Version");
            Map(t => t.PurchaseCode).Length(20);
            References(t => t.Supplier).Column("SupplierID").LazyLoad();
            References(t => t.Employee).Column("EmployeeID").LazyLoad();
            Map(t => t.PurchaseDate);
            Map(t => t.RequireDate);
            Map(t => t.ShippedDate);
            References(t => t.Shipper).Column("ShipperID").LazyLoad();
            HasMany(t => t.Details).AsSet().KeyColumn("PurchaseID").Cascade.AllDeleteOrphan().LazyLoad();
            Map(t => t.Freight);
            Map(t => t.CreateBy).Length(20);
            Map(t => t.CreateDate);
            Map(t => t.UpdateBy).Length(20);
            Map(t => t.UpdateDate);
        }
    }
}
