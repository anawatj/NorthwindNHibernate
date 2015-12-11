using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Infrastructure.Mapping.Orders
{
    public class OrdersMap : ClassMap<Core.Domain.Orders.Orders>
    {
        public OrdersMap()
        {
            Table("Orders");
            Id(t => t.ID).GeneratedBy.Native();
            Version(t => t.Version).Column("Version");
            Map(t => t.OrderCode).Length(20);
            References(t => t.Customer).Column("CustomerID").LazyLoad();
            References(t => t.Employee).Column("EmployeeID").LazyLoad();
            Map(t => t.OrderDate);
            Map(t => t.RequireDate);
            Map(t => t.ShippedDate);
            References(t => t.ShipVia).Column("ShipVia").LazyLoad();
            Map(t => t.ShipName).Length(200);
            Map(t => t.ShipAddress).Length(1000);
            References(t => t.ShipCity).Column("ShipCityID").LazyLoad();
            References(t => t.ShipRegion).Column("ShipRegionID").LazyLoad();
            References(t => t.ShipCountry).Column("ShipCountryID").LazyLoad();
            HasMany(t => t.Details).AsSet().KeyColumn("OrderID").Cascade.AllDeleteOrphan().LazyLoad();
            Map(t => t.PostalCode).Length(24);
            Map(t => t.CreateBy).Length(20);
            Map(t => t.CreateDate);
            Map(t => t.UpdateBy).Length(20);
            Map(t => t.UpdateDate);

        }
    }
}
