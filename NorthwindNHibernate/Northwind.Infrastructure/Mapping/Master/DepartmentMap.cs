using FluentNHibernate.Mapping;
using Northwind.Core.Domain.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Infrastructure.Mapping.Master
{
    public class DepartmentMap : ClassMap<Department>
    {
        public DepartmentMap()
        {
            Table("Department");
            Id(t => t.ID).GeneratedBy.Native();
            Map(t => t.Code).Length(20);
            Map(t => t.Name).Length(200);
            Map(t => t.CreateBy).Length(20);
            Map(t => t.CreateDate);
            Map(t => t.UpdateBy).Length(20);
            Map(t => t.UpdateDate);
        }
    }
}
