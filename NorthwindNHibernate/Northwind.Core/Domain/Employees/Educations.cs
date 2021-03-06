﻿using Northwind.Core.Domain.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Core.Domain.Employees
{
    public class Educations : AbstractDomain<long>
    {
        public Educations()
        {

        }
        public virtual long? EmployeeID { get; set; }
        public virtual EducationLevel EducationLevel { get; set; }
        public virtual string University { get; set; }
        public virtual string Major { get; set; }
        public virtual string Minor { get; set; }
        public virtual decimal? Gpa { get; set; }

       
    }
}
