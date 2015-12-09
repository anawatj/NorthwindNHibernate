using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Northwind.Web
{
    public class JsonNetResult : JsonResult
    {
        public JsonNetResult(object data)
        {
            this.Data = data;
        }
        public override void ExecuteResult(ControllerContext context)
        {
            if (context == null)
                throw new ArgumentNullException("context");

            var response = context.HttpContext.Response;

            response.ContentType = !String.IsNullOrEmpty(ContentType)
                ? ContentType
                : "application/json";

            if (ContentEncoding != null)
                response.ContentEncoding = ContentEncoding;

            // If you need special handling, you can call another form of SerializeObject below
            // var serializedObject = JsonConvert.SerializeObject(Data, Formatting.Indented);
            //response.Write(serializedObject);

            var serializer = new JsonSerializer()
            {
                ContractResolver = new NorthwindContractResolver(),
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                DateFormatString="dd/MM/yyyy"
            };
            StringWriter stringWriter = new StringWriter();
            JsonWriter jsonWriter = new Newtonsoft.Json.JsonTextWriter(stringWriter);
            serializer.Serialize(jsonWriter, this.Data);
            string serializedObject = stringWriter.ToString();
            response.Write(serializedObject);
        }
    }
}