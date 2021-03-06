﻿using Northwind.Core.Domain.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Core.Domain.Suppliers
{
    public class Suppliers : AbstractDomain<long>
    {
        public Suppliers()
        {

        }
        public virtual string SupplierCode { get; set; }
        public virtual string CompanyName { get; set; }
        public virtual string ContactName { get; set; }
        public virtual string ContactTitle { get; set; }
        public virtual string Address { get; set; }
        public virtual City City { get; set; }
        public virtual Region Region { get; set; }
        public virtual Country Country { get; set; }
        public virtual string PostalCode { get; set; }
        public virtual string Phone { get; set; }
        public virtual string Fax { get; set; }
        public virtual string HomePage { get; set; }


    }
}
