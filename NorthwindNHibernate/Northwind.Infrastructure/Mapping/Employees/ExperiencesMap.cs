using FluentNHibernate.Mapping;
using Northwind.Core.Domain.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Infrastructure.Mapping.Employees
{
    public class ExperiencesMap : ClassMap<Experiences>
    {
        public ExperiencesMap()
        {
            Table("Experiences");
            Id(t => t.ID).GeneratedBy.Native();
            Version(t => t.Version).Column("Version");
            Map(t => t.EmployeeID);
            Map(t => t.Company).Length(200);
            Map(t => t.StartDate);
            Map(t => t.EndDate);
            Map(t => t.Salary);
            Map(t => t.ReasonOfResign).Length(1000);
            Map(t => t.CreateBy).Length(20);
            Map(t => t.CreateDate);
            Map(t => t.UpdateBy).Length(20);
            Map(t => t.UpdateDate);
        }
    }
}
