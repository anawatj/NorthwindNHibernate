using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Core.Domain.Master
{
    public class City :SimpleMasterObject
    {
        public City()
        {

        }
        public virtual long CountryID { get; set; }

    }
}
