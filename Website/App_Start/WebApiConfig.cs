using System.Configuration;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Website
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();
            var webUrl = ConfigurationManager.AppSettings["WebUrl"];
            var cors = new EnableCorsAttribute(webUrl, "*", "*");
            config.EnableCors(cors);

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
