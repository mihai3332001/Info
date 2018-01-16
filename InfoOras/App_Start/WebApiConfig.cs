using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web.Http;

namespace InfoOras
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
   // Web API configuration and services

   // Web API routes
   //config.MapHttpAttributeRoutes();
   config.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling
= Newtonsoft.Json.ReferenceLoopHandling.Ignore;

  
   config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
   config.MapHttpAttributeRoutes();
   config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

  }
    }
}
