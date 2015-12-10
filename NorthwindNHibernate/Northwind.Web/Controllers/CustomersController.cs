using Northwind.Core.Domain.Customers;
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
        public ActionResult Entry()
        {
            return View();
        }
        public ActionResult List()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            var list = repository.FindAll();
            return Json(list, "application/json", System.Text.Encoding.UTF8);
        }
        [HttpGet]
        public ActionResult GetByID(long id)
        {
            var result = repository.FindByID(id);
            return Json(result, "application/json", System.Text.Encoding.UTF8);
        }

        [HttpPost]
        public ActionResult Search(CustomersQuery query)
        {
            var result = repository.FindByQuery(query);
            return Json(result, "application/json", System.Text.Encoding.UTF8);
        }

        [HttpPost]
        public ActionResult Save(Customers entity)
        {
            var result = repository.Save(entity);
            return Json(result, "application/json", System.Text.Encoding.UTF8);
        }
        [HttpPost]
        public ActionResult Delete(Customers data)
        {
            repository.Remove(data.ID);
            return Json("Success", "application/json", System.Text.Encoding.UTF8);
        }
    }
}