using System.Web.Http;
using Api;
using Autofac;
using Autofac.Integration.WebApi;

namespace WebApiHost
{
    public class Bootstrapper
    {
        public static void Start()
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterModule<HostModule>();
            IContainer container = builder.Build();

            GlobalConfiguration.Configure(WebApiConfig.Register);
            HttpConfiguration config = GlobalConfiguration.Configuration;

            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}