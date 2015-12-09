using Northwind.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Northwind.Web.Controllers
{
    public class MasterController : BaseController
    {
        private MasterRepository repository;
        public MasterController(MasterRepository repository)
        {
            this.repository = repository;
        }
        // GET: Master
        public ActionResult Index()
        {
            return View();
        }
    }
}