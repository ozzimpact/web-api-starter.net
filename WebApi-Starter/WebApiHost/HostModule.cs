using System.Web.Http;
using Api;
using Api.Controllers;
using Autofac;
using Autofac.Integration.WebApi;

namespace WebApiHost
{
    public class HostModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterWebApiFilterProvider(GlobalConfiguration.Configuration);
            GlobalConfiguration.Configuration.Formatters.RemoveAt(0);
            GlobalConfiguration.Configuration.Formatters.Insert(0, new JilFormatter());
            builder.RegisterModule<ApiModule>();
            builder.RegisterApiControllers(typeof(HelpController).Assembly);
        }
    }
}