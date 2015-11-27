using Autofac;

namespace Api
{
    public class ApiModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<JilSerializer>().As<IJsonSerializer>().SingleInstance();
        }
    }
}