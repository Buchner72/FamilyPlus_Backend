using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Net.Http.Headers;
 using System.Web.Http.Cors;

namespace WebAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {

            // - Enable CORS (Wichtig!!  Damit Zugriff auch über localhost von Frontend aus funktioniert.)
             config.EnableCors(new EnableCorsAttribute("http://localhost:4200", headers: "*", methods: "*"));


            // Web-API-Konfiguration und -Dienste

            // Web-API-Konfiguration und -Dienste
            config.Formatters.JsonFormatter.SupportedMediaTypes
             .Add(new MediaTypeHeaderValue("text/html"));

            // Web-API-Routen
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
