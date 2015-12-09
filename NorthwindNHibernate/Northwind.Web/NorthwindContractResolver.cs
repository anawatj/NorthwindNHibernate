using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using System.Reflection;
using Northwind.Core.Domain;
using System.Collections;
using NHibernate;

namespace Northwind.Web
{
    public class NorthwindContractResolver : DefaultContractResolver
    {
        protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
        {
            JsonProperty property = base.CreateProperty(member, memberSerialization);
            PropertyInfo pinfo = member as PropertyInfo;

            if((typeof(string) != property.PropertyType) && typeof(IEnumerable).IsAssignableFrom(property.PropertyType) && pinfo!=null)
            {
                property.ShouldSerialize =
                instance =>
                {
                    var value = pinfo.GetValue(instance);
                    var inited = NHibernateUtil.IsInitialized(value);
                    return inited;
                };
            }else if(typeof(Core.Domain.IBaseDomain).IsAssignableFrom(property.PropertyType) && pinfo!=null)
            {
                property.ShouldSerialize =
                instance =>
                {
                    var value = pinfo.GetValue(instance);
                    var inited = NHibernateUtil.IsInitialized(value);
                    return inited;
                };
            }

            return property;
        }
    }
}