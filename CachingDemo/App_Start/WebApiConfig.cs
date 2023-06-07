using System.Web.Http;
using System.Web.Http.Cors;

namespace CachingDemo
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            ///This way we can enable cors globally
            ///it contains 3 perameter 
            ///1: origin,
            ///2: headers,
            ///3: methods
            EnableCorsAttribute  coresAttribute = new EnableCorsAttribute("*","*","*");
            config.EnableCors(coresAttribute);

            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
