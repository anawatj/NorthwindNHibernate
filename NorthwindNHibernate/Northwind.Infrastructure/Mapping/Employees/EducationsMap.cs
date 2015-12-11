using FluentNHibernate.Mapping;
using Northwind.Core.Domain.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Infrastructure.Mapping.Employees
{
    public class EducationsMap : ClassMap<Educations>
    {
        public EducationsMap()
        {
            Table("Educations");
            Id(t => t.ID).GeneratedBy.Native();
            Version(t => t.Version).Column("Version");
            Map(t => t.EmployeeID);
            References(t => t.EducationLevel).Column("EducationLevelID").LazyLoad();
            Map(t => t.University).Length(200);
            Map(t => t.Major).Length(200);
            Map(t => t.Minor).Length(200);
            Map(t => t.Gpa);
            Map(t => t.CreateBy).Length(20);
            Map(t => t.CreateDate);
            Map(t => t.UpdateBy).Length(20);
            Map(t => t.UpdateDate);
        }
    }
}
