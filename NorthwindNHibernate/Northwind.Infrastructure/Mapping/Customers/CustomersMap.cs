using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Infrastructure.Mapping.Customers
{
    public class CustomersMap : ClassMap<Northwind.Core.Domain.Customers.Customers>
    {
        public CustomersMap()
        {
            Table("Customers");
            Id(t => t.ID).GeneratedBy.Native();
            Version(t => t.Version).Column("Version");
            Map(t => t.CustomerCode).Length(20);
            Map(t => t.CompanyName).Length(200);
            Map(t => t.ContactName).Length(200);
            Map(t => t.ContactTitle).Length(200);
            Map(t => t.Address).Length(1000);
            References(t => t.Country).Column("CountryID").LazyLoad();
            References(t => t.City).Column("CityID").LazyLoad();
            References(t => t.Region).Column("RegionID").LazyLoad();
            Map(t => t.PostalCode).Length(20);
            Map(t => t.Phone).Length(20);
            Map(t => t.Fax).Length(20);
            HasManyToMany(t => t.Demos).Table("CustomersDemographics").ParentKeyColumn("CustomerID").ChildKeyColumn("DemographicID").Cascade.All().LazyLoad();

            Map(t => t.CreateBy).Length(20);
            Map(t => t.CreateDate);
            Map(t => t.UpdateBy).Length(20);
            Map(t => t.UpdateDate);
        }
    }
}
