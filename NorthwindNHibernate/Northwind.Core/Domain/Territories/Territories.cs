using Northwind.Core.Domain.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Core.Domain.Territories
{
    public class Territories : AbstractDomain<long>
    {
        public Territories ()
        {

        }
        public virtual string TerritoryName { get; set; }
        public virtual Region Region { get; set; }

    }
}
