using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Infrastructure.Mapping.Territories
{
    public class TerritoriesMap : ClassMap<Core.Domain.Territories.Territories>
    {
        public TerritoriesMap()
        {
            Table("Territories");
            Id(t => t.ID).GeneratedBy.Native();
            Map(t => t.TerritoryName).Length(200);
            References(t => t.Region).Column("RegionID").LazyLoad();
            Map(t => t.CreateBy).Length(20);
            Map(t => t.CreateDate);
            Map(t => t.UpdateBy).Length(20);
            Map(t => t.UpdateDate);
        }
    }
}
