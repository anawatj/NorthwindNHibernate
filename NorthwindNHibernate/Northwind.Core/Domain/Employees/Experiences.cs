using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Core.Domain.Employees
{
    public class Experiences : AbstractDomain<long>
    {
        public Experiences()
        {

        }
        public virtual long? EmployeeID { get; set; }
        public virtual string Company { get; set; }
        public virtual DateTime? StartDate { get; set; }
        public virtual DateTime? EndDate { get; set; }
        public virtual decimal? Salary { get; set; }
        public virtual string ReasonOfResign { get; set; }

    }
}
