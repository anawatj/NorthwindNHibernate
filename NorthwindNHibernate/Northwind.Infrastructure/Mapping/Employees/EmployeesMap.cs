using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Infrastructure.Mapping.Employees
{
    public class EmployeesMap : ClassMap<Core.Domain.Employees.Employees>
    {
        public EmployeesMap()
        {
            Table("Employees");
            Id(t => t.ID).GeneratedBy.Native();
            Version(t => t.Version).Column("Version");
            Map(t => t.EmployeeCode).Length(20);
            References(t => t.Title).Column("TitleID").LazyLoad();
            Map(t => t.FirstName).Length(200);
            Map(t => t.LastName).Length(200);
            Map(t => t.BirthDate);
            Map(t => t.HireDate);
            Map(t => t.Address).Length(1000);
            References(t => t.City).Column("CityID").LazyLoad();
            References(t => t.Region).Column("RegionID").LazyLoad();
            Map(t => t.PostalCode).Length(24);
            References(t => t.Country).Column("CountryID").LazyLoad();
            Map(t => t.HomePhone).Length(24);
            Map(t => t.Extention).Length(10);
            Map(t => t.Notes).Length(1000);
            References(t => t.Department).Column("DepartmentID").LazyLoad();
            References(t => t.ReportTo).Column("ReportTo").LazyLoad();
            HasMany(t => t.Educations).AsSet().KeyColumn("EmployeeID").Cascade.AllDeleteOrphan().LazyLoad();
            HasMany(t => t.Experiences).AsSet().KeyColumn("EmployeeID").Cascade.AllDeleteOrphan().LazyLoad();
            HasManyToMany(t => t.Territories).AsSet().Table("EmployeesTerritories").ParentKeyColumn("EmployeeID").ChildKeyColumn("TerritoryID").Cascade.All().LazyLoad();
            Map(t => t.CreateBy).Length(20);
            Map(t => t.CreateDate);
            Map(t => t.UpdateBy).Length(20);
            Map(t => t.UpdateDate);
        }
    }
}
