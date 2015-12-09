using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Infrastructure.Mapping.Categories
{
    public class CategoriesMap : ClassMap<Core.Domain.Categories.Categories>
    {
        public CategoriesMap()
        {
            Table("Categories");
            Id(t => t.ID).GeneratedBy.Native();
            Version(t => t.Version).Column("Version");
            Map(t => t.CategoryCode).Length(20);
            Map(t => t.CategoryName).Length(200);
            Map(t => t.Description).Length(1000);

            Map(t => t.CreateBy).Length(20);
            Map(t => t.CreateDate);
            Map(t => t.UpdateBy).Length(20);
            Map(t => t.UpdateDate);
        }
    }
}
