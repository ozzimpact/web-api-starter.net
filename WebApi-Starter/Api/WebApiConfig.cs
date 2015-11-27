using System.Net.Http.Formatting;
using System.Web.Http;
using System.Web.Http.Cors;
using Newtonsoft.Json;

namespace Api
{
    public class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //Web API routes
            config.MapHttpAttributeRoutes();
            config.Formatters.Clear();
            config.Formatters.Add(new JsonMediaTypeFormatter());
            config.Formatters.JsonFormatter.SerializerSettings.TypeNameHandling = TypeNameHandling.None;
            config.EnableCors(new EnableCorsAttribute(origins: "*", headers: "*", methods: "*"));
        }
    }
}
