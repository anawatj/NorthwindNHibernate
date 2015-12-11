using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Infrastructure.Mapping.Purchases
{
    public class PurchaseDetailsMap : ClassMap<Core.Domain.Purchases.PurchaseDetails>
    {
        public PurchaseDetailsMap()
        {
            Table("PurchaseDetails");
            Id(t => t.ID).GeneratedBy.Native();
            Version(t => t.Version).Column("Version");
            Map(t => t.PurchaseID);
            References(t => t.Product).Column("ProductID").LazyLoad();
            Map(t => t.Quantity);
            Map(t => t.UnitPrice);
            Map(t => t.Discount);
            Map(t => t.CreateBy).Length(20);
            Map(t => t.CreateDate);
            Map(t => t.UpdateBy).Length(20);
            Map(t => t.UpdateDate);
        }
    }
}
