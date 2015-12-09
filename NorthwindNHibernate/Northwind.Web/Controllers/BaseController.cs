using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Northwind.Web.Controllers
{
    public class BaseController : Controller
    {
      
        protected override JsonResult Json(object data, string contentType, Encoding contentEncoding)
        {
            var result = new JsonNetResult(data);
            result.MaxJsonLength = int.MaxValue;
            result.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
           // result.ExecuteResult(this.ControllerContext);
            return result;
        }


    }
}