using Northwind.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Northwind.Web.Controllers
{
    public class CustomersController : BaseController
    {
        private ICustomersRepository repository;
        public CustomersController(ICustomersRepository repository)
        {
            this.repository = repository;
        }
        // GET: Customers
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetAll()
        {
            var list = repository.FindAll();
            return Json(list, "application/json", System.Text.Encoding.UTF8);
        }
    }
}