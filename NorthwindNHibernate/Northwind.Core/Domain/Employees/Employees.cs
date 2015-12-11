using Northwind.Core.Domain.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Core.Domain.Employees
{
    public class Employees : AbstractDomain<long>
    {
        public Employees()
        {
            this.Experiences = new HashSet<Experiences>();
            this.Educations = new HashSet<Educations>();
            this.Territories = new HashSet<Territories.Territories>();
        }
        public virtual string EmployeeCode { get; set; }
        public virtual Title Title { get; set; }

        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }

        public virtual DateTime? BirthDate { get; set; }
        public virtual DateTime? HireDate { get; set; }

        public virtual string Address { get; set; }
        public virtual City City { get; set; }
        public virtual Region Region { get; set; }
        public virtual string PostalCode { get; set; }
        public virtual Country Country { get; set; }
        public virtual string HomePhone { get; set; }
        public virtual string Extention { get; set; }

        public virtual Department Department { get; set; }
        public virtual Employees ReportTo { get; set; }

        public virtual ISet<Experiences> Experiences { get; set; }
        public virtual ISet<Educations> Educations { get; set; }

        public virtual ISet<Territories.Territories> Territories { get; set; }

    }
}
