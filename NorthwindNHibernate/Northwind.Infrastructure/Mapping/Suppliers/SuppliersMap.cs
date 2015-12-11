using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Infrastructure.Mapping.Suppliers
{
    public class SuppliersMap : ClassMap<Core.Domain.Suppliers.Suppliers>
    {
        public SuppliersMap()
        {
            Table("Suppliers");
            Id(t => t.ID).GeneratedBy.Native();
            Version(t => t.Version).Column("Version");
            Map(t => t.SupplierCode).Length(20);
            Map(t => t.CompanyName).Length(200);
            Map(t => t.ContactName).Length(200);
            Map(t => t.ContactTitle).Length(200);
            Map(t => t.Address).Length(1000);
            References(t => t.City).Column("CityID").LazyLoad();
            References(t => t.Region).Column("RegionID").LazyLoad();
            Map(t => t.PostalCode).Length(24);
            References(t => t.Country).Column("CountryID").LazyLoad();
            Map(t => t.Phone).Length(24);
            Map(t => t.Fax).Length(24);
            Map(t => t.HomePage).Length(1000);
            Map(t => t.CreateBy).Length(20);
            Map(t => t.CreateDate);
            Map(t => t.UpdateBy).Length(20);
            Map(t => t.UpdateDate);
        }
    }
}
